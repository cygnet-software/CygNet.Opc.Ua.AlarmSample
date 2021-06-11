using Opc.Ua;
using Opc.Ua.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CygNet.Opc.Ua.AlarmSample
{
    public class OpcUaClientUtils
    {
        public static Subscription SubscribeToCygNetAlarms(Session session, MonitoredItemNotificationEventHandler handler)
        {
            Subscription subscription = MakeSubscription(session);
            MonitoredItem monitoredItem = MakeMonitoredItem(session, ObjectIds.Server);

            // set up callback for notifications.
            monitoredItem.Notification += handler;

            session.AddSubscription(subscription);
            subscription.Create();

            subscription.AddItem(monitoredItem);
            subscription.ApplyChanges();

            return subscription;
        }

        public static bool CallAcknowledgeAlarm(Session session, NodeId alarmNodeId, byte[] eventId)
        {
            CallMethodRequestCollection methodsToCall = new CallMethodRequestCollection();

            CallMethodRequest request = new CallMethodRequest();
            request.ObjectId = alarmNodeId;
            request.MethodId = MethodIds.AcknowledgeableConditionType_Acknowledge;
            request.Handle = alarmNodeId;
            request.InputArguments.Add(new Variant(eventId));
            request.InputArguments.Add(new Variant((LocalizedText)""));

            methodsToCall.Add(request);

            CallMethodResultCollection results = null;
            DiagnosticInfoCollection diagnosticInfos = null;

            try
            {
                // call the method
                session.Call(
                    null,
                    methodsToCall,
                    out results,
                    out diagnosticInfos);

                ClientBase.ValidateResponse(results, methodsToCall);
                ClientBase.ValidateDiagnosticInfos(diagnosticInfos, methodsToCall);

                return !results.Any(r => StatusCode.IsBad(r.StatusCode));
            }
            catch
            {
                return false;
            }
        }

        public static bool CallConditionRefresh(Session session, uint subscriptionId)
        {
            CallMethodRequest request = new CallMethodRequest();

            request.ObjectId = ObjectTypeIds.ConditionType;
            request.MethodId = MethodIds.ConditionType_ConditionRefresh;
            request.InputArguments.Add(new Variant(subscriptionId));

            CallMethodRequestCollection methodsToCall = new CallMethodRequestCollection();
            methodsToCall.Add(request);

            try
            {
                session.Call(
                    null,
                    methodsToCall,
                    out CallMethodResultCollection results,
                    out DiagnosticInfoCollection diagnosticInfos);

                ClientBase.ValidateResponse(results, methodsToCall);
                ClientBase.ValidateDiagnosticInfos(diagnosticInfos, methodsToCall);

                return !results.Any(r => StatusCode.IsBad(r.StatusCode));
            }
            catch
            {
                return false;
            }
        }

        public static cygnet.CygNetAlarmState ExtractCygNetAlarmState(Session session, EventFilter eventFilter, EventFieldList notification)
        {
            if (notification == null)
            {
                return null;
            }

            // construct the CygNetAlarmState object.
            return ConstructCygNetAlarmState(
                session,
                eventFilter,
                notification);
        }

        public static ContentFilterElement AddEventTypeClause(ContentFilter whereClause, ExpandedNodeId nodeTypeId)
        {
            // for this example uses the 'OfType' operator to limit events to thoses with specified event type.
            LiteralOperand litOperand = new LiteralOperand();
            litOperand.Value = new Variant(nodeTypeId);
            return whereClause.Push(FilterOperator.OfType, litOperand);
        }

        public static ContentFilterElement AddSeverityClause(ContentFilter whereClause, EventSeverity minSeverity)
        {
            // select the Severity property of the event.
            SimpleAttributeOperand operand1 = new SimpleAttributeOperand();
            operand1.TypeDefinitionId = ObjectTypeIds.BaseEventType;
            operand1.BrowsePath.Add(BrowseNames.Severity);
            operand1.AttributeId = Attributes.Value;

            // specify the value to compare the Severity property with.
            LiteralOperand operand2 = new LiteralOperand();
            operand2.Value = new Variant((ushort)minSeverity);

            // specify that the Severity property must be GreaterThanOrEqual the value specified.
            return whereClause.Push(FilterOperator.GreaterThanOrEqual, operand1, operand2);
        }

        /// <summary>
        /// Finds the type of the event for the notification.
        /// </summary>
        /// <param name="monitoredItem">The monitored item.</param>
        /// <param name="notification">The notification.</param>
        /// <returns>The NodeId of the EventType.</returns>
        public static NodeId FindEventType(EventFilter filter, EventFieldList notification)
        {
            if (filter != null)
            {
                for (int ii = 0; ii < filter.SelectClauses.Count; ii++)
                {
                    SimpleAttributeOperand clause = filter.SelectClauses[ii];

                    if (clause.BrowsePath.Count == 1 && clause.BrowsePath[0] == BrowseNames.EventType)
                    {
                        return notification.EventFields[ii].Value as NodeId;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Constructs an event object from a notification.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="monitoredItem">The monitored item that produced the notification.</param>
        /// <param name="notification">The notification.</param>
        /// <param name="eventTypeMappings">Mapping between event types and known event types.</param>
        /// <returns>
        /// The event object. Null if the notification is not a valid event type.
        /// </returns>
        public static cygnet.CygNetAlarmState ConstructCygNetAlarmState(
            Session session,
            EventFilter filter,
            EventFieldList notification)
        {
            // find the event type.
            NodeId eventTypeId = FindEventType(filter, notification);

            if (eventTypeId != ExpandedNodeId.ToNodeId(cygnet.ObjectTypeIds.CygNetAlarmType, session.NamespaceUris))
            {
                return null;
            }

            // construct the event based on the known event type.
            var e = new cygnet.CygNetAlarmState(null);

            // initialize the event with the values in the notification.
            e.Update(session.SystemContext, filter.SelectClauses, notification);

            // save the orginal notification.
            e.Handle = notification;

            return e;
        }

        /// <summary>
        /// Browses the address space and returns all of the supertypes of the specified type node.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="typeId">The NodeId for a type node in the address space.</param>
        /// <param name="throwOnError">if set to <c>true</c> a exception will be thrown on an error.</param>
        /// <returns>
        /// The references found. Null if an error occurred.
        /// </returns>
        public static ReferenceDescriptionCollection BrowseSuperTypes(Session session, NodeId typeId, bool throwOnError)
        {
            ReferenceDescriptionCollection supertypes = new ReferenceDescriptionCollection();

            try
            {
                // find all of the children of the field.
                BrowseDescription nodeToBrowse = new BrowseDescription();

                nodeToBrowse.NodeId = typeId;
                nodeToBrowse.BrowseDirection = BrowseDirection.Inverse;
                nodeToBrowse.ReferenceTypeId = ReferenceTypeIds.HasSubtype;
                nodeToBrowse.IncludeSubtypes = false; // more efficient to use IncludeSubtypes=False when possible.
                nodeToBrowse.NodeClassMask = 0; // the HasSubtype reference already restricts the targets to Types.
                nodeToBrowse.ResultMask = (uint)BrowseResultMask.All;

                ReferenceDescriptionCollection references = Browse(session, nodeToBrowse, throwOnError);

                while (references != null && references.Count > 0)
                {
                    // should never be more than one supertype.
                    supertypes.Add(references[0]);

                    // only follow references within this server.
                    if (references[0].NodeId.IsAbsolute)
                    {
                        break;
                    }

                    // get the references for the next level up.
                    nodeToBrowse.NodeId = (NodeId)references[0].NodeId;
                    references = Browse(session, nodeToBrowse, throwOnError);
                }

                // return complete list.
                return supertypes;
            }
            catch (Exception exception)
            {
                if (throwOnError)
                {
                    throw new ServiceResultException(exception, StatusCodes.BadUnexpectedError);
                }

                return null;
            }
        }

        /// <summary>
        /// Browses the address space and returns the references found.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="nodeToBrowse">The NodeId for the starting node.</param>
        /// <param name="throwOnError">if set to <c>true</c> a exception will be thrown on an error.</param>
        /// <returns>
        /// The references found. Null if an error occurred.
        /// </returns>
        public static ReferenceDescriptionCollection Browse(Session session, BrowseDescription nodeToBrowse, bool throwOnError)
        {
            try
            {
                ReferenceDescriptionCollection references = new ReferenceDescriptionCollection();

                // construct browse request.
                BrowseDescriptionCollection nodesToBrowse = new BrowseDescriptionCollection();
                nodesToBrowse.Add(nodeToBrowse);

                // start the browse operation.
                BrowseResultCollection results = null;
                DiagnosticInfoCollection diagnosticInfos = null;

                session.Browse(
                    null,
                    null,
                    0,
                    nodesToBrowse,
                    out results,
                    out diagnosticInfos);

                ClientBase.ValidateResponse(results, nodesToBrowse);
                ClientBase.ValidateDiagnosticInfos(diagnosticInfos, nodesToBrowse);

                do
                {
                    // check for error.
                    if (StatusCode.IsBad(results[0].StatusCode))
                    {
                        throw new ServiceResultException(results[0].StatusCode);
                    }

                    // process results.
                    for (int ii = 0; ii < results[0].References.Count; ii++)
                    {
                        references.Add(results[0].References[ii]);
                    }

                    // check if all references have been fetched.
                    if (results[0].References.Count == 0 || results[0].ContinuationPoint == null)
                    {
                        break;
                    }

                    // continue browse operation.
                    ByteStringCollection continuationPoints = new ByteStringCollection();
                    continuationPoints.Add(results[0].ContinuationPoint);

                    session.BrowseNext(
                        null,
                        false,
                        continuationPoints,
                        out results,
                        out diagnosticInfos);

                    ClientBase.ValidateResponse(results, continuationPoints);
                    ClientBase.ValidateDiagnosticInfos(diagnosticInfos, continuationPoints);
                }
                while (true);

                //return complete list.
                return references;
            }
            catch (Exception exception)
            {
                if (throwOnError)
                {
                    throw new ServiceResultException(exception, StatusCodes.BadUnexpectedError);
                }

                return null;
            }
        }

        /// <summary>
        /// Constructs the select clauses for a set of event types.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="eventTypeIds">The event type ids.</param>
        /// <returns>The select clauses for all fields discovered.</returns>
        /// <remarks>
        /// Each event type is an ObjectType in the address space. The fields supported by the
        /// server are defined as children of the ObjectType. Many of the fields are manadatory
        /// and are defined by the UA information model, however, indiviudual servers many not
        /// support all of the optional fields.
        /// </remarks>
        public static SimpleAttributeOperandCollection ConstructSelectClauses(
            Session session,
            params NodeId[] eventTypeIds)
        {
            // browse the type model in the server address space to find the fields available for the event type.
            SimpleAttributeOperandCollection selectClauses = new SimpleAttributeOperandCollection();

            // must always request the NodeId for the condition instances.
            // this can be done by specifying an operand with an empty browse path.
            SimpleAttributeOperand operand = new SimpleAttributeOperand();

            operand.TypeDefinitionId = ObjectTypeIds.BaseEventType;
            operand.AttributeId = Attributes.NodeId;
            operand.BrowsePath = new QualifiedNameCollection();

            selectClauses.Add(operand);

            // add the fields for the selected EventTypes.
            if (eventTypeIds != null)
            {
                for (int ii = 0; ii < eventTypeIds.Length; ii++)
                {
                    CollectFields(session, eventTypeIds[ii], selectClauses);
                }
            }

            // use BaseEventType as the default if no EventTypes specified.
            else
            {
                CollectFields(session, ObjectTypeIds.BaseEventType, selectClauses);
            }

            return selectClauses;
        }

        /// <summary>
        /// Collects the fields for the event type.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="eventTypeId">The event type id.</param>
        /// <param name="eventFields">The event fields.</param>
        public static void CollectFields(Session session, NodeId eventTypeId, SimpleAttributeOperandCollection eventFields)
        {
            // get the supertypes.
            ReferenceDescriptionCollection supertypes = BrowseSuperTypes(session, eventTypeId, false);

            if (supertypes == null)
            {
                return;
            }

            // process the types starting from the top of the tree.
            Dictionary<NodeId, QualifiedNameCollection> foundNodes = new Dictionary<NodeId, QualifiedNameCollection>();
            QualifiedNameCollection parentPath = new QualifiedNameCollection();

            for (int ii = supertypes.Count - 1; ii >= 0; ii--)
            {
                CollectFields(session, (NodeId)supertypes[ii].NodeId, parentPath, eventFields, foundNodes);
            }

            // collect the fields for the selected type.
            CollectFields(session, eventTypeId, parentPath, eventFields, foundNodes);
        }

        /// <summary>
        /// Collects the fields for the instance node.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="nodeId">The node id.</param>
        /// <param name="parentPath">The parent path.</param>
        /// <param name="eventFields">The event fields.</param>
        /// <param name="foundNodes">The table of found nodes.</param>
        public static void CollectFields(
            Session session,
            NodeId nodeId,
            QualifiedNameCollection parentPath,
            SimpleAttributeOperandCollection eventFields,
            Dictionary<NodeId, QualifiedNameCollection> foundNodes)
        {
            // find all of the children of the field.
            BrowseDescription nodeToBrowse = new BrowseDescription();

            nodeToBrowse.NodeId = nodeId;
            nodeToBrowse.BrowseDirection = BrowseDirection.Forward;
            nodeToBrowse.ReferenceTypeId = ReferenceTypeIds.Aggregates;
            nodeToBrowse.IncludeSubtypes = true;
            nodeToBrowse.NodeClassMask = (uint)(NodeClass.Object | NodeClass.Variable);
            nodeToBrowse.ResultMask = (uint)BrowseResultMask.All;

            ReferenceDescriptionCollection children = Browse(session, nodeToBrowse, false);

            if (children == null)
            {
                return;
            }

            // process the children.
            for (int ii = 0; ii < children.Count; ii++)
            {
                ReferenceDescription child = children[ii];

                if (child.NodeId.IsAbsolute)
                {
                    continue;
                }

                // construct browse path.
                QualifiedNameCollection browsePath = new QualifiedNameCollection(parentPath);
                browsePath.Add(child.BrowseName);

                // check if the browse path is already in the list.
                if (!ContainsPath(eventFields, browsePath))
                {
                    SimpleAttributeOperand field = new SimpleAttributeOperand();

                    field.TypeDefinitionId = ObjectTypeIds.BaseEventType;
                    field.BrowsePath = browsePath;
                    field.AttributeId = (child.NodeClass == NodeClass.Variable) ? Attributes.Value : Attributes.NodeId;

                    eventFields.Add(field);
                }

                // recusively find all of the children.
                NodeId targetId = (NodeId)child.NodeId;

                // need to guard against loops.
                if (!foundNodes.ContainsKey(targetId))
                {
                    foundNodes.Add(targetId, browsePath);
                    CollectFields(session, (NodeId)child.NodeId, browsePath, eventFields, foundNodes);
                }
            }
        }

        /// <summary>
        /// Determines whether the specified select clause contains the browse path.
        /// </summary>
        /// <param name="selectClause">The select clause.</param>
        /// <param name="browsePath">The browse path.</param>
        /// <returns>
        /// 	<c>true</c> if the specified select clause contains path; otherwise, <c>false</c>.
        /// </returns>
        public static bool ContainsPath(SimpleAttributeOperandCollection selectClause, QualifiedNameCollection browsePath)
        {
            for (int ii = 0; ii < selectClause.Count; ii++)
            {
                SimpleAttributeOperand field = selectClause[ii];

                if (field.BrowsePath.Count != browsePath.Count)
                {
                    continue;
                }

                bool match = true;

                for (int jj = 0; jj < field.BrowsePath.Count; jj++)
                {
                    if (field.BrowsePath[jj] != browsePath[jj])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    return true;
                }
            }

            return false;
        }

        public static Subscription MakeSubscription(Session session)
        {
            var subscription = new Subscription(session.DefaultSubscription) { PublishingInterval = 1000 };
            subscription.DisplayName = null;
            subscription.PublishingInterval = 1000;
            subscription.KeepAliveCount = 10;
            subscription.LifetimeCount = 100;
            subscription.MaxNotificationsPerPublish = 1000;
            subscription.PublishingEnabled = true;
            subscription.TimestampsToReturn = TimestampsToReturn.Both;

            return subscription;
        }

        public static MonitoredItem MakeMonitoredItem(Session session, NodeId startNode)
        {
            MonitoredItem monitoredItem = new MonitoredItem();
            monitoredItem.DisplayName = null;
            monitoredItem.StartNodeId = startNode;
            monitoredItem.RelativePath = null;
            monitoredItem.NodeClass = NodeClass.Object;
            monitoredItem.AttributeId = Attributes.EventNotifier;
            monitoredItem.IndexRange = null;
            monitoredItem.Encoding = null;
            monitoredItem.MonitoringMode = MonitoringMode.Reporting;
            monitoredItem.SamplingInterval = 0;
            monitoredItem.QueueSize = UInt32.MaxValue;
            monitoredItem.DiscardOldest = true;
            monitoredItem.Filter = new EventFilter
            {
                SelectClauses = ConstructSelectClauses(session, ExpandedNodeId.ToNodeId(cygnet.ObjectTypeIds.CygNetAlarmType, session.NamespaceUris))
            };

            return monitoredItem;
        }
    }
}
