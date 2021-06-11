/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace cygnet
{
    #region CvsState Class
#if (!OPCUA_EXCLUDE_CvsState)
    /// <summary>
    /// Stores an instance of the CvsType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CvsState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CvsState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(cygnet.ObjectTypes.CvsType, cygnet.Namespaces.cygnet, namespaceUris);
        }

#if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACIAAABodHRwczovL3dlYXRoZXJmb3JkLmNvbS9VQS9jeWduZXQv/////4RggAIBAAAAAQAPAAAA" +
           "Q3ZzVHlwZUluc3RhbmNlAQGZOgEBmTqZOgAAAf////8BAAAANWCJCgIAAAABAA4AAABDdnNEZXNjcmlw" +
           "dGlvbgEBmjoDAAAAAA8AAABDVlMgRGVzY3JpcHRpb24ALgBEmjoAAAAM/////wEB/////wAAAAA=";
        #endregion
#endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> CvsDescription
        {
            get
            {
                return m_cvsDescription;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cvsDescription, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cvsDescription = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_cvsDescription != null)
            {
                children.Add(m_cvsDescription);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case cygnet.BrowseNames.CvsDescription:
                    {
                        if (createOrReplace)
                        {
                            if (CvsDescription == null)
                            {
                                if (replacement == null)
                                {
                                    CvsDescription = new PropertyState<string>(this);
                                }
                                else
                                {
                                    CvsDescription = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = CvsDescription;
                        break;
                    }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_cvsDescription;
        #endregion
    }
#endif
    #endregion

    #region FacilityState Class
#if (!OPCUA_EXCLUDE_FacilityState)
    /// <summary>
    /// Stores an instance of the FacilityType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FacilityState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FacilityState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(cygnet.ObjectTypes.FacilityType, cygnet.Namespaces.cygnet, namespaceUris);
        }

#if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACIAAABodHRwczovL3dlYXRoZXJmb3JkLmNvbS9VQS9jeWduZXQv/////4RggAIBAAAAAQAUAAAA" +
           "RmFjaWxpdHlUeXBlSW5zdGFuY2UBAZs6AQGbOps6AAAB/////8AAAAA1YIkKAgAAAAEAEwAAAEZhY2ls" +
           "aXR5U2l0ZVNlcnZpY2UBAZw6AwAAAAASAAAAQ3lnTmV0IFNpdGVTZXJ2aWNlAC4ARJw6AAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAABAAoAAABGYWNpbGl0eUlkAQGdOgMAAAAAEwAAAEZhY2lsaXR5IGlkZW50" +
           "aWZpZXIALgBEnToAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEADAAAAEZhY2lsaXR5U2l0ZQEBnjoD" +
           "AAAAAAwAAABGYWNpbGl0eVNpdGUALgBEnjoAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEADwAAAEZh" +
           "Y2lsaXR5U2VydmljZQEBnzoDAAAAAA8AAABGYWNpbGl0eVNlcnZpY2UALgBEnzoAAAAM/////wEB////" +
           "/wAAAAA1YIkKAgAAAAEADAAAAEZhY2lsaXR5VHlwZQEBoDoDAAAAAAwAAABGYWNpbGl0eVR5cGUALgBE" +
           "oDoAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAEwAAAEZhY2lsaXR5RGVzY3JpcHRpb24BAaE6AwAA" +
           "AAATAAAARmFjaWxpdHlEZXNjcmlwdGlvbgAuAEShOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAW" +
           "AAAARmFjaWxpdHlJbmZvQXR0cmlidXRlMAEBojoDAAAAABYAAABGYWNpbGl0eUluZm9BdHRyaWJ1dGUw" +
           "AC4ARKI6AAAADP////8BAf////8AAAAANWCJCgIAAAABABYAAABGYWNpbGl0eUluZm9BdHRyaWJ1dGUx" +
           "AQGjOgMAAAAAFgAAAEZhY2lsaXR5SW5mb0F0dHJpYnV0ZTEALgBEozoAAAAM/////wEB/////wAAAAA1" +
           "YIkKAgAAAAEAEAAAAEZhY2lsaXR5Q2F0ZWdvcnkBAaQ6AwAAAAAQAAAARmFjaWxpdHlDYXRlZ29yeQAu" +
           "AESkOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAQAAAARmFjaWxpdHlJc0FjdGl2ZQEBpToDAAAA" +
           "ABAAAABGYWNpbGl0eUlzQWN0aXZlAC4ARKU6AAAAAf////8BAf////8AAAAANWCJCgIAAAABABsAAABG" +
           "YWNpbGl0eVNlY3VyaXR5QXBwbGljYXRpb24BAaY6AwAAAAAbAAAARmFjaWxpdHlTZWN1cml0eUFwcGxp" +
           "Y2F0aW9uAC4ARKY6AAAADP////8BAf////8AAAAANWCJCgIAAAABABcAAABGYWNpbGl0eVRleHRBdHRy" +
           "aWJ1dGUwMAEBpzoDAAAAABcAAABGYWNpbGl0eVRleHRBdHRyaWJ1dGUwMAAuAESnOgAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAQAXAAAARmFjaWxpdHlUZXh0QXR0cmlidXRlMDEBAag6AwAAAAAXAAAARmFj" +
           "aWxpdHlUZXh0QXR0cmlidXRlMDEALgBEqDoAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAFwAAAEZh" +
           "Y2lsaXR5VGV4dEF0dHJpYnV0ZTAyAQGpOgMAAAAAFwAAAEZhY2lsaXR5VGV4dEF0dHJpYnV0ZTAyAC4A" +
           "RKk6AAAADP////8BAf////8AAAAANWCJCgIAAAABABcAAABGYWNpbGl0eVRleHRBdHRyaWJ1dGUwMwEB" +
           "qjoDAAAAABcAAABGYWNpbGl0eVRleHRBdHRyaWJ1dGUwMwAuAESqOgAAAAz/////AQH/////AAAAADVg" +
           "iQoCAAAAAQAXAAAARmFjaWxpdHlUZXh0QXR0cmlidXRlMDQBAas6AwAAAAAXAAAARmFjaWxpdHlUZXh0" +
           "QXR0cmlidXRlMDQALgBEqzoAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAFwAAAEZhY2lsaXR5VGV4" +
           "dEF0dHJpYnV0ZTA1AQGsOgMAAAAAFwAAAEZhY2lsaXR5VGV4dEF0dHJpYnV0ZTA1AC4ARKw6AAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAABABcAAABGYWNpbGl0eVRleHRBdHRyaWJ1dGUwNgEBrToDAAAAABcA" +
           "AABGYWNpbGl0eVRleHRBdHRyaWJ1dGUwNgAuAEStOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAX" +
           "AAAARmFjaWxpdHlUZXh0QXR0cmlidXRlMDcBAa46AwAAAAAXAAAARmFjaWxpdHlUZXh0QXR0cmlidXRl" +
           "MDcALgBErjoAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAFwAAAEZhY2lsaXR5VGV4dEF0dHJpYnV0" +
           "ZTA4AQGvOgMAAAAAFwAAAEZhY2lsaXR5VGV4dEF0dHJpYnV0ZTA4AC4ARK86AAAADP////8BAf////8A" +
           "AAAANWCJCgIAAAABABcAAABGYWNpbGl0eVRleHRBdHRyaWJ1dGUwOQEBsDoDAAAAABcAAABGYWNpbGl0" +
           "eVRleHRBdHRyaWJ1dGUwOQAuAESwOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAXAAAARmFjaWxp" +
           "dHlUZXh0QXR0cmlidXRlMTABAbE6AwAAAAAXAAAARmFjaWxpdHlUZXh0QXR0cmlidXRlMTAALgBEsToA" +
           "AAAM/////wEB/////wAAAAA1YIkKAgAAAAEAFwAAAEZhY2lsaXR5VGV4dEF0dHJpYnV0ZTExAQGyOgMA" +
           "AAAAFwAAAEZhY2lsaXR5VGV4dEF0dHJpYnV0ZTExAC4ARLI6AAAADP////8BAf////8AAAAANWCJCgIA" +
           "AAABABcAAABGYWNpbGl0eVRleHRBdHRyaWJ1dGUxMgEBszoDAAAAABcAAABGYWNpbGl0eVRleHRBdHRy" +
           "aWJ1dGUxMgAuAESzOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAXAAAARmFjaWxpdHlUZXh0QXR0" +
           "cmlidXRlMTMBAbQ6AwAAAAAXAAAARmFjaWxpdHlUZXh0QXR0cmlidXRlMTMALgBEtDoAAAAM/////wEB" +
           "/////wAAAAA1YIkKAgAAAAEAFwAAAEZhY2lsaXR5VGV4dEF0dHJpYnV0ZTE0AQG1OgMAAAAAFwAAAEZh" +
           "Y2lsaXR5VGV4dEF0dHJpYnV0ZTE0AC4ARLU6AAAADP////8BAf////8AAAAANWCJCgIAAAABABcAAABG" +
           "YWNpbGl0eVRleHRBdHRyaWJ1dGUxNQEBtjoDAAAAABcAAABGYWNpbGl0eVRleHRBdHRyaWJ1dGUxNQAu" +
           "AES2OgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAXAAAARmFjaWxpdHlUZXh0QXR0cmlidXRlMTYB" +
           "Abc6AwAAAAAXAAAARmFjaWxpdHlUZXh0QXR0cmlidXRlMTYALgBEtzoAAAAM/////wEB/////wAAAAA1" +
           "YIkKAgAAAAEAFwAAAEZhY2lsaXR5VGV4dEF0dHJpYnV0ZTE3AQG4OgMAAAAAFwAAAEZhY2lsaXR5VGV4" +
           "dEF0dHJpYnV0ZTE3AC4ARLg6AAAADP////8BAf////8AAAAANWCJCgIAAAABABcAAABGYWNpbGl0eVRl" +
           "eHRBdHRyaWJ1dGUxOAEBuToDAAAAABcAAABGYWNpbGl0eVRleHRBdHRyaWJ1dGUxOAAuAES5OgAAAAz/" +
           "////AQH/////AAAAADVgiQoCAAAAAQAXAAAARmFjaWxpdHlUZXh0QXR0cmlidXRlMTkBAbo6AwAAAAAX" +
           "AAAARmFjaWxpdHlUZXh0QXR0cmlidXRlMTkALgBEujoAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEA" +
           "FwAAAEZhY2lsaXR5VGV4dEF0dHJpYnV0ZTIwAQG7OgMAAAAAFwAAAEZhY2lsaXR5VGV4dEF0dHJpYnV0" +
           "ZTIwAC4ARLs6AAAADP////8BAf////8AAAAANWCJCgIAAAABABcAAABGYWNpbGl0eVRleHRBdHRyaWJ1" +
           "dGUyMQEBvDoDAAAAABcAAABGYWNpbGl0eVRleHRBdHRyaWJ1dGUyMQAuAES8OgAAAAz/////AQH/////" +
           "AAAAADVgiQoCAAAAAQAXAAAARmFjaWxpdHlUZXh0QXR0cmlidXRlMjIBAb06AwAAAAAXAAAARmFjaWxp" +
           "dHlUZXh0QXR0cmlidXRlMjIALgBEvToAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAFwAAAEZhY2ls" +
           "aXR5VGV4dEF0dHJpYnV0ZTIzAQG+OgMAAAAAFwAAAEZhY2lsaXR5VGV4dEF0dHJpYnV0ZTIzAC4ARL46" +
           "AAAADP////8BAf////8AAAAANWCJCgIAAAABABcAAABGYWNpbGl0eVRleHRBdHRyaWJ1dGUyNAEBvzoD" +
           "AAAAABcAAABGYWNpbGl0eVRleHRBdHRyaWJ1dGUyNAAuAES/OgAAAAz/////AQH/////AAAAADVgiQoC" +
           "AAAAAQAXAAAARmFjaWxpdHlUZXh0QXR0cmlidXRlMjUBAcA6AwAAAAAXAAAARmFjaWxpdHlUZXh0QXR0" +
           "cmlidXRlMjUALgBEwDoAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAFwAAAEZhY2lsaXR5VGV4dEF0" +
           "dHJpYnV0ZTI2AQHBOgMAAAAAFwAAAEZhY2lsaXR5VGV4dEF0dHJpYnV0ZTI2AC4ARME6AAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAABABcAAABGYWNpbGl0eVRleHRBdHRyaWJ1dGUyNwEBwjoDAAAAABcAAABG" +
           "YWNpbGl0eVRleHRBdHRyaWJ1dGUyNwAuAETCOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAXAAAA" +
           "RmFjaWxpdHlUZXh0QXR0cmlidXRlMjgBAcM6AwAAAAAXAAAARmFjaWxpdHlUZXh0QXR0cmlidXRlMjgA" +
           "LgBEwzoAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAFwAAAEZhY2lsaXR5VGV4dEF0dHJpYnV0ZTI5" +
           "AQHEOgMAAAAAFwAAAEZhY2lsaXR5VGV4dEF0dHJpYnV0ZTI5AC4ARMQ6AAAADP////8BAf////8AAAAA" +
           "NWCJCgIAAAABABcAAABGYWNpbGl0eVRleHRBdHRyaWJ1dGUzMAEBxToDAAAAABcAAABGYWNpbGl0eVRl" +
           "eHRBdHRyaWJ1dGUzMAAuAETFOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAXAAAARmFjaWxpdHlU" +
           "ZXh0QXR0cmlidXRlMzEBAcY6AwAAAAAXAAAARmFjaWxpdHlUZXh0QXR0cmlidXRlMzEALgBExjoAAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAEAFwAAAEZhY2lsaXR5VGV4dEF0dHJpYnV0ZTMyAQHHOgMAAAAA" +
           "FwAAAEZhY2lsaXR5VGV4dEF0dHJpYnV0ZTMyAC4ARMc6AAAADP////8BAf////8AAAAANWCJCgIAAAAB" +
           "ABcAAABGYWNpbGl0eVRleHRBdHRyaWJ1dGUzMwEByDoDAAAAABcAAABGYWNpbGl0eVRleHRBdHRyaWJ1" +
           "dGUzMwAuAETIOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAXAAAARmFjaWxpdHlUZXh0QXR0cmli" +
           "dXRlMzQBAck6AwAAAAAXAAAARmFjaWxpdHlUZXh0QXR0cmlidXRlMzQALgBEyToAAAAM/////wEB////" +
           "/wAAAAA1YIkKAgAAAAEAFwAAAEZhY2lsaXR5VGV4dEF0dHJpYnV0ZTM1AQHKOgMAAAAAFwAAAEZhY2ls" +
           "aXR5VGV4dEF0dHJpYnV0ZTM1AC4ARMo6AAAADP////8BAf////8AAAAANWCJCgIAAAABABcAAABGYWNp" +
           "bGl0eVRleHRBdHRyaWJ1dGUzNgEByzoDAAAAABcAAABGYWNpbGl0eVRleHRBdHRyaWJ1dGUzNgAuAETL" +
           "OgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAXAAAARmFjaWxpdHlUZXh0QXR0cmlidXRlMzcBAcw6" +
           "AwAAAAAXAAAARmFjaWxpdHlUZXh0QXR0cmlidXRlMzcALgBEzDoAAAAM/////wEB/////wAAAAA1YIkK" +
           "AgAAAAEAFwAAAEZhY2lsaXR5VGV4dEF0dHJpYnV0ZTM4AQHNOgMAAAAAFwAAAEZhY2lsaXR5VGV4dEF0" +
           "dHJpYnV0ZTM4AC4ARM06AAAADP////8BAf////8AAAAANWCJCgIAAAABABcAAABGYWNpbGl0eVRleHRB" +
           "dHRyaWJ1dGUzOQEBzjoDAAAAABcAAABGYWNpbGl0eVRleHRBdHRyaWJ1dGUzOQAuAETOOgAAAAz/////" +
           "AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTAwAQHPOgMAAAAAGAAA" +
           "AEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUwMAAuAETPOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAY" +
           "AAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTAxAQHQOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1" +
           "dGUwMQAuAETQOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJp" +
           "YnV0ZTAyAQHROgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUwMgAuAETROgAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTAzAQHSOgMAAAAAGAAAAEZh" +
           "Y2lsaXR5VGFibGVBdHRyaWJ1dGUwMwAuAETSOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAA" +
           "RmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTA0AQHTOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUw" +
           "NAAuAETTOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0" +
           "ZTA1AQHUOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUwNQAuAETUOgAAAAz/////AQH/////" +
           "AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTA2AQHVOgMAAAAAGAAAAEZhY2ls" +
           "aXR5VGFibGVBdHRyaWJ1dGUwNgAuAETVOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFj" +
           "aWxpdHlUYWJsZUF0dHJpYnV0ZTA3AQHWOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUwNwAu" +
           "AETWOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTA4" +
           "AQHXOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUwOAAuAETXOgAAAAz/////AQH/////AAAA" +
           "ADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTA5AQHYOgMAAAAAGAAAAEZhY2lsaXR5" +
           "VGFibGVBdHRyaWJ1dGUwOQAuAETYOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxp" +
           "dHlUYWJsZUF0dHJpYnV0ZTEwAQHZOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUxMAAuAETZ" +
           "OgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTExAQHa" +
           "OgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUxMQAuAETaOgAAAAz/////AQH/////AAAAADVg" +
           "iQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTEyAQHbOgMAAAAAGAAAAEZhY2lsaXR5VGFi" +
           "bGVBdHRyaWJ1dGUxMgAuAETbOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlU" +
           "YWJsZUF0dHJpYnV0ZTEzAQHcOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUxMwAuAETcOgAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTE0AQHdOgMA" +
           "AAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUxNAAuAETdOgAAAAz/////AQH/////AAAAADVgiQoC" +
           "AAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTE1AQHeOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVB" +
           "dHRyaWJ1dGUxNQAuAETeOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJs" +
           "ZUF0dHJpYnV0ZTE2AQHfOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUxNgAuAETfOgAAAAz/" +
           "////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTE3AQHgOgMAAAAA" +
           "GAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUxNwAuAETgOgAAAAz/////AQH/////AAAAADVgiQoCAAAA" +
           "AQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTE4AQHhOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRy" +
           "aWJ1dGUxOAAuAEThOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0" +
           "dHJpYnV0ZTE5AQHiOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUxOQAuAETiOgAAAAz/////" +
           "AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTIwAQHjOgMAAAAAGAAA" +
           "AEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUyMAAuAETjOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAY" +
           "AAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTIxAQHkOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1" +
           "dGUyMQAuAETkOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJp" +
           "YnV0ZTIyAQHlOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUyMgAuAETlOgAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTIzAQHmOgMAAAAAGAAAAEZh" +
           "Y2lsaXR5VGFibGVBdHRyaWJ1dGUyMwAuAETmOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAA" +
           "RmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTI0AQHnOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUy" +
           "NAAuAETnOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0" +
           "ZTI1AQHoOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUyNQAuAEToOgAAAAz/////AQH/////" +
           "AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTI2AQHpOgMAAAAAGAAAAEZhY2ls" +
           "aXR5VGFibGVBdHRyaWJ1dGUyNgAuAETpOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFj" +
           "aWxpdHlUYWJsZUF0dHJpYnV0ZTI3AQHqOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUyNwAu" +
           "AETqOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTI4" +
           "AQHrOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUyOAAuAETrOgAAAAz/////AQH/////AAAA" +
           "ADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTI5AQHsOgMAAAAAGAAAAEZhY2lsaXR5" +
           "VGFibGVBdHRyaWJ1dGUyOQAuAETsOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxp" +
           "dHlUYWJsZUF0dHJpYnV0ZTMwAQHtOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUzMAAuAETt" +
           "OgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTMxAQHu" +
           "OgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUzMQAuAETuOgAAAAz/////AQH/////AAAAADVg" +
           "iQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTMyAQHvOgMAAAAAGAAAAEZhY2lsaXR5VGFi" +
           "bGVBdHRyaWJ1dGUzMgAuAETvOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlU" +
           "YWJsZUF0dHJpYnV0ZTMzAQHwOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUzMwAuAETwOgAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTM0AQHxOgMA" +
           "AAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUzNAAuAETxOgAAAAz/////AQH/////AAAAADVgiQoC" +
           "AAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTM1AQHyOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVB" +
           "dHRyaWJ1dGUzNQAuAETyOgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJs" +
           "ZUF0dHJpYnV0ZTM2AQHzOgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUzNgAuAETzOgAAAAz/" +
           "////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTM3AQH0OgMAAAAA" +
           "GAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUzNwAuAET0OgAAAAz/////AQH/////AAAAADVgiQoCAAAA" +
           "AQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTM4AQH1OgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRy" +
           "aWJ1dGUzOAAuAET1OgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0" +
           "dHJpYnV0ZTM5AQH2OgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUzOQAuAET2OgAAAAz/////" +
           "AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTQwAQH3OgMAAAAAGAAA" +
           "AEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU0MAAuAET3OgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAY" +
           "AAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTQxAQH4OgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1" +
           "dGU0MQAuAET4OgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJp" +
           "YnV0ZTQyAQH5OgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU0MgAuAET5OgAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTQzAQH6OgMAAAAAGAAAAEZh" +
           "Y2lsaXR5VGFibGVBdHRyaWJ1dGU0MwAuAET6OgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAA" +
           "RmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTQ0AQH7OgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU0" +
           "NAAuAET7OgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0" +
           "ZTQ1AQH8OgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU0NQAuAET8OgAAAAz/////AQH/////" +
           "AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTQ2AQH9OgMAAAAAGAAAAEZhY2ls" +
           "aXR5VGFibGVBdHRyaWJ1dGU0NgAuAET9OgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFj" +
           "aWxpdHlUYWJsZUF0dHJpYnV0ZTQ3AQH+OgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU0NwAu" +
           "AET+OgAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTQ4" +
           "AQH/OgMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU0OAAuAET/OgAAAAz/////AQH/////AAAA" +
           "ADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTQ5AQEAOwMAAAAAGAAAAEZhY2lsaXR5" +
           "VGFibGVBdHRyaWJ1dGU0OQAuAEQAOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxp" +
           "dHlUYWJsZUF0dHJpYnV0ZTUwAQEBOwMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU1MAAuAEQB" +
           "OwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTUxAQEC" +
           "OwMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU1MQAuAEQCOwAAAAz/////AQH/////AAAAADVg" +
           "iQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTUyAQEDOwMAAAAAGAAAAEZhY2lsaXR5VGFi" +
           "bGVBdHRyaWJ1dGU1MgAuAEQDOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlU" +
           "YWJsZUF0dHJpYnV0ZTUzAQEEOwMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU1MwAuAEQEOwAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTU0AQEFOwMA" +
           "AAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU1NAAuAEQFOwAAAAz/////AQH/////AAAAADVgiQoC" +
           "AAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTU1AQEGOwMAAAAAGAAAAEZhY2lsaXR5VGFibGVB" +
           "dHRyaWJ1dGU1NQAuAEQGOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJs" +
           "ZUF0dHJpYnV0ZTU2AQEHOwMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU1NgAuAEQHOwAAAAz/" +
           "////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTU3AQEIOwMAAAAA" +
           "GAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU1NwAuAEQIOwAAAAz/////AQH/////AAAAADVgiQoCAAAA" +
           "AQAYAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTU4AQEJOwMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRy" +
           "aWJ1dGU1OAAuAEQJOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlUYWJsZUF0" +
           "dHJpYnV0ZTU5AQEKOwMAAAAAGAAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU1OQAuAEQKOwAAAAz/////" +
           "AQH/////AAAAADVgiQoCAAAAAQAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTAwRGVzY3JpcHRpb24B" +
           "AQs7AwAAAAAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTAwRGVzY3JpcHRpb24ALgBECzsAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAEAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUwMURlc2NyaXB0aW9u" +
           "AQEMOwMAAAAAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUwMURlc2NyaXB0aW9uAC4ARAw7AAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAABACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlMDJEZXNjcmlwdGlv" +
           "bgEBDTsDAAAAACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlMDJEZXNjcmlwdGlvbgAuAEQNOwAAAAz/" +
           "////AQH/////AAAAADVgiQoCAAAAAQAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTAzRGVzY3JpcHRp" +
           "b24BAQ47AwAAAAAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTAzRGVzY3JpcHRpb24ALgBEDjsAAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAEAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUwNERlc2NyaXB0" +
           "aW9uAQEPOwMAAAAAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUwNERlc2NyaXB0aW9uAC4ARA87AAAA" +
           "DP////8BAf////8AAAAANWCJCgIAAAABACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlMDVEZXNjcmlw" +
           "dGlvbgEBEDsDAAAAACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlMDVEZXNjcmlwdGlvbgAuAEQQOwAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAQAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTA2RGVzY3Jp" +
           "cHRpb24BARE7AwAAAAAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTA2RGVzY3JpcHRpb24ALgBEETsA" +
           "AAAM/////wEB/////wAAAAA1YIkKAgAAAAEAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUwN0Rlc2Ny" +
           "aXB0aW9uAQESOwMAAAAAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUwN0Rlc2NyaXB0aW9uAC4ARBI7" +
           "AAAADP////8BAf////8AAAAANWCJCgIAAAABACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlMDhEZXNj" +
           "cmlwdGlvbgEBEzsDAAAAACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlMDhEZXNjcmlwdGlvbgAuAEQT" +
           "OwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTA5RGVz" +
           "Y3JpcHRpb24BARQ7AwAAAAAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTA5RGVzY3JpcHRpb24ALgBE" +
           "FDsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUxMERl" +
           "c2NyaXB0aW9uAQEVOwMAAAAAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUxMERlc2NyaXB0aW9uAC4A" +
           "RBU7AAAADP////8BAf////8AAAAANWCJCgIAAAABACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlMTFE" +
           "ZXNjcmlwdGlvbgEBFjsDAAAAACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlMTFEZXNjcmlwdGlvbgAu" +
           "AEQWOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTEy" +
           "RGVzY3JpcHRpb24BARc7AwAAAAAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTEyRGVzY3JpcHRpb24A" +
           "LgBEFzsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUx" +
           "M0Rlc2NyaXB0aW9uAQEYOwMAAAAAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUxM0Rlc2NyaXB0aW9u" +
           "AC4ARBg7AAAADP////8BAf////8AAAAANWCJCgIAAAABACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRl" +
           "MTREZXNjcmlwdGlvbgEBGTsDAAAAACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlMTREZXNjcmlwdGlv" +
           "bgAuAEQZOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0" +
           "ZTE1RGVzY3JpcHRpb24BARo7AwAAAAAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTE1RGVzY3JpcHRp" +
           "b24ALgBEGjsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1" +
           "dGUxNkRlc2NyaXB0aW9uAQEbOwMAAAAAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUxNkRlc2NyaXB0" +
           "aW9uAC4ARBs7AAAADP////8BAf////8AAAAANWCJCgIAAAABACMAAABGYWNpbGl0eVRhYmxlQXR0cmli" +
           "dXRlMTdEZXNjcmlwdGlvbgEBHDsDAAAAACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlMTdEZXNjcmlw" +
           "dGlvbgAuAEQcOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAjAAAARmFjaWxpdHlUYWJsZUF0dHJp" +
           "YnV0ZTE4RGVzY3JpcHRpb24BAR07AwAAAAAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTE4RGVzY3Jp" +
           "cHRpb24ALgBEHTsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAIwAAAEZhY2lsaXR5VGFibGVBdHRy" +
           "aWJ1dGUxOURlc2NyaXB0aW9uAQEeOwMAAAAAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUxOURlc2Ny" +
           "aXB0aW9uAC4ARB47AAAADP////8BAf////8AAAAANWCJCgIAAAABACMAAABGYWNpbGl0eVRhYmxlQXR0" +
           "cmlidXRlMjBEZXNjcmlwdGlvbgEBHzsDAAAAACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlMjBEZXNj" +
           "cmlwdGlvbgAuAEQfOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAjAAAARmFjaWxpdHlUYWJsZUF0" +
           "dHJpYnV0ZTIxRGVzY3JpcHRpb24BASA7AwAAAAAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTIxRGVz" +
           "Y3JpcHRpb24ALgBEIDsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAIwAAAEZhY2lsaXR5VGFibGVB" +
           "dHRyaWJ1dGUyMkRlc2NyaXB0aW9uAQEhOwMAAAAAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUyMkRl" +
           "c2NyaXB0aW9uAC4ARCE7AAAADP////8BAf////8AAAAANWCJCgIAAAABACMAAABGYWNpbGl0eVRhYmxl" +
           "QXR0cmlidXRlMjNEZXNjcmlwdGlvbgEBIjsDAAAAACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlMjNE" +
           "ZXNjcmlwdGlvbgAuAEQiOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAjAAAARmFjaWxpdHlUYWJs" +
           "ZUF0dHJpYnV0ZTI0RGVzY3JpcHRpb24BASM7AwAAAAAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTI0" +
           "RGVzY3JpcHRpb24ALgBEIzsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAIwAAAEZhY2lsaXR5VGFi" +
           "bGVBdHRyaWJ1dGUyNURlc2NyaXB0aW9uAQEkOwMAAAAAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUy" +
           "NURlc2NyaXB0aW9uAC4ARCQ7AAAADP////8BAf////8AAAAANWCJCgIAAAABACMAAABGYWNpbGl0eVRh" +
           "YmxlQXR0cmlidXRlMjZEZXNjcmlwdGlvbgEBJTsDAAAAACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRl" +
           "MjZEZXNjcmlwdGlvbgAuAEQlOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAjAAAARmFjaWxpdHlU" +
           "YWJsZUF0dHJpYnV0ZTI3RGVzY3JpcHRpb24BASY7AwAAAAAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0" +
           "ZTI3RGVzY3JpcHRpb24ALgBEJjsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAIwAAAEZhY2lsaXR5" +
           "VGFibGVBdHRyaWJ1dGUyOERlc2NyaXB0aW9uAQEnOwMAAAAAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1" +
           "dGUyOERlc2NyaXB0aW9uAC4ARCc7AAAADP////8BAf////8AAAAANWCJCgIAAAABACMAAABGYWNpbGl0" +
           "eVRhYmxlQXR0cmlidXRlMjlEZXNjcmlwdGlvbgEBKDsDAAAAACMAAABGYWNpbGl0eVRhYmxlQXR0cmli" +
           "dXRlMjlEZXNjcmlwdGlvbgAuAEQoOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAjAAAARmFjaWxp" +
           "dHlUYWJsZUF0dHJpYnV0ZTMwRGVzY3JpcHRpb24BASk7AwAAAAAjAAAARmFjaWxpdHlUYWJsZUF0dHJp" +
           "YnV0ZTMwRGVzY3JpcHRpb24ALgBEKTsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAIwAAAEZhY2ls" +
           "aXR5VGFibGVBdHRyaWJ1dGUzMURlc2NyaXB0aW9uAQEqOwMAAAAAIwAAAEZhY2lsaXR5VGFibGVBdHRy" +
           "aWJ1dGUzMURlc2NyaXB0aW9uAC4ARCo7AAAADP////8BAf////8AAAAANWCJCgIAAAABACMAAABGYWNp" +
           "bGl0eVRhYmxlQXR0cmlidXRlMzJEZXNjcmlwdGlvbgEBKzsDAAAAACMAAABGYWNpbGl0eVRhYmxlQXR0" +
           "cmlidXRlMzJEZXNjcmlwdGlvbgAuAEQrOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAjAAAARmFj" +
           "aWxpdHlUYWJsZUF0dHJpYnV0ZTMzRGVzY3JpcHRpb24BASw7AwAAAAAjAAAARmFjaWxpdHlUYWJsZUF0" +
           "dHJpYnV0ZTMzRGVzY3JpcHRpb24ALgBELDsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAIwAAAEZh" +
           "Y2lsaXR5VGFibGVBdHRyaWJ1dGUzNERlc2NyaXB0aW9uAQEtOwMAAAAAIwAAAEZhY2lsaXR5VGFibGVB" +
           "dHRyaWJ1dGUzNERlc2NyaXB0aW9uAC4ARC07AAAADP////8BAf////8AAAAANWCJCgIAAAABACMAAABG" +
           "YWNpbGl0eVRhYmxlQXR0cmlidXRlMzVEZXNjcmlwdGlvbgEBLjsDAAAAACMAAABGYWNpbGl0eVRhYmxl" +
           "QXR0cmlidXRlMzVEZXNjcmlwdGlvbgAuAEQuOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAjAAAA" +
           "RmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTM2RGVzY3JpcHRpb24BAS87AwAAAAAjAAAARmFjaWxpdHlUYWJs" +
           "ZUF0dHJpYnV0ZTM2RGVzY3JpcHRpb24ALgBELzsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAIwAA" +
           "AEZhY2lsaXR5VGFibGVBdHRyaWJ1dGUzN0Rlc2NyaXB0aW9uAQEwOwMAAAAAIwAAAEZhY2lsaXR5VGFi" +
           "bGVBdHRyaWJ1dGUzN0Rlc2NyaXB0aW9uAC4ARDA7AAAADP////8BAf////8AAAAANWCJCgIAAAABACMA" +
           "AABGYWNpbGl0eVRhYmxlQXR0cmlidXRlMzhEZXNjcmlwdGlvbgEBMTsDAAAAACMAAABGYWNpbGl0eVRh" +
           "YmxlQXR0cmlidXRlMzhEZXNjcmlwdGlvbgAuAEQxOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAj" +
           "AAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTM5RGVzY3JpcHRpb24BATI7AwAAAAAjAAAARmFjaWxpdHlU" +
           "YWJsZUF0dHJpYnV0ZTM5RGVzY3JpcHRpb24ALgBEMjsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEA" +
           "IwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU0MERlc2NyaXB0aW9uAQEzOwMAAAAAIwAAAEZhY2lsaXR5" +
           "VGFibGVBdHRyaWJ1dGU0MERlc2NyaXB0aW9uAC4ARDM7AAAADP////8BAf////8AAAAANWCJCgIAAAAB" +
           "ACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlNDFEZXNjcmlwdGlvbgEBNDsDAAAAACMAAABGYWNpbGl0" +
           "eVRhYmxlQXR0cmlidXRlNDFEZXNjcmlwdGlvbgAuAEQ0OwAAAAz/////AQH/////AAAAADVgiQoCAAAA" +
           "AQAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTQyRGVzY3JpcHRpb24BATU7AwAAAAAjAAAARmFjaWxp" +
           "dHlUYWJsZUF0dHJpYnV0ZTQyRGVzY3JpcHRpb24ALgBENTsAAAAM/////wEB/////wAAAAA1YIkKAgAA" +
           "AAEAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU0M0Rlc2NyaXB0aW9uAQE2OwMAAAAAIwAAAEZhY2ls" +
           "aXR5VGFibGVBdHRyaWJ1dGU0M0Rlc2NyaXB0aW9uAC4ARDY7AAAADP////8BAf////8AAAAANWCJCgIA" +
           "AAABACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlNDREZXNjcmlwdGlvbgEBNzsDAAAAACMAAABGYWNp" +
           "bGl0eVRhYmxlQXR0cmlidXRlNDREZXNjcmlwdGlvbgAuAEQ3OwAAAAz/////AQH/////AAAAADVgiQoC" +
           "AAAAAQAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTQ1RGVzY3JpcHRpb24BATg7AwAAAAAjAAAARmFj" +
           "aWxpdHlUYWJsZUF0dHJpYnV0ZTQ1RGVzY3JpcHRpb24ALgBEODsAAAAM/////wEB/////wAAAAA1YIkK" +
           "AgAAAAEAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU0NkRlc2NyaXB0aW9uAQE5OwMAAAAAIwAAAEZh" +
           "Y2lsaXR5VGFibGVBdHRyaWJ1dGU0NkRlc2NyaXB0aW9uAC4ARDk7AAAADP////8BAf////8AAAAANWCJ" +
           "CgIAAAABACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlNDdEZXNjcmlwdGlvbgEBOjsDAAAAACMAAABG" +
           "YWNpbGl0eVRhYmxlQXR0cmlidXRlNDdEZXNjcmlwdGlvbgAuAEQ6OwAAAAz/////AQH/////AAAAADVg" +
           "iQoCAAAAAQAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTQ4RGVzY3JpcHRpb24BATs7AwAAAAAjAAAA" +
           "RmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTQ4RGVzY3JpcHRpb24ALgBEOzsAAAAM/////wEB/////wAAAAA1" +
           "YIkKAgAAAAEAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU0OURlc2NyaXB0aW9uAQE8OwMAAAAAIwAA" +
           "AEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU0OURlc2NyaXB0aW9uAC4ARDw7AAAADP////8BAf////8AAAAA" +
           "NWCJCgIAAAABACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlNTBEZXNjcmlwdGlvbgEBPTsDAAAAACMA" +
           "AABGYWNpbGl0eVRhYmxlQXR0cmlidXRlNTBEZXNjcmlwdGlvbgAuAEQ9OwAAAAz/////AQH/////AAAA" +
           "ADVgiQoCAAAAAQAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTUxRGVzY3JpcHRpb24BAT47AwAAAAAj" +
           "AAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTUxRGVzY3JpcHRpb24ALgBEPjsAAAAM/////wEB/////wAA" +
           "AAA1YIkKAgAAAAEAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU1MkRlc2NyaXB0aW9uAQE/OwMAAAAA" +
           "IwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU1MkRlc2NyaXB0aW9uAC4ARD87AAAADP////8BAf////8A" +
           "AAAANWCJCgIAAAABACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlNTNEZXNjcmlwdGlvbgEBQDsDAAAA" +
           "ACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlNTNEZXNjcmlwdGlvbgAuAERAOwAAAAz/////AQH/////" +
           "AAAAADVgiQoCAAAAAQAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTU0RGVzY3JpcHRpb24BAUE7AwAA" +
           "AAAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTU0RGVzY3JpcHRpb24ALgBEQTsAAAAM/////wEB////" +
           "/wAAAAA1YIkKAgAAAAEAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU1NURlc2NyaXB0aW9uAQFCOwMA" +
           "AAAAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU1NURlc2NyaXB0aW9uAC4AREI7AAAADP////8BAf//" +
           "//8AAAAANWCJCgIAAAABACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlNTZEZXNjcmlwdGlvbgEBQzsD" +
           "AAAAACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlNTZEZXNjcmlwdGlvbgAuAERDOwAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAQAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTU3RGVzY3JpcHRpb24BAUQ7" +
           "AwAAAAAjAAAARmFjaWxpdHlUYWJsZUF0dHJpYnV0ZTU3RGVzY3JpcHRpb24ALgBERDsAAAAM/////wEB" +
           "/////wAAAAA1YIkKAgAAAAEAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU1OERlc2NyaXB0aW9uAQFF" +
           "OwMAAAAAIwAAAEZhY2lsaXR5VGFibGVBdHRyaWJ1dGU1OERlc2NyaXB0aW9uAC4AREU7AAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAABACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlNTlEZXNjcmlwdGlvbgEB" +
           "RjsDAAAAACMAAABGYWNpbGl0eVRhYmxlQXR0cmlidXRlNTlEZXNjcmlwdGlvbgAuAERGOwAAAAz/////" +
           "AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlZZXNOb0F0dHJpYnV0ZTAwAQFHOwMAAAAAGAAA" +
           "AEZhY2lsaXR5WWVzTm9BdHRyaWJ1dGUwMAAuAERHOwAAAAH/////AQH/////AAAAADVgiQoCAAAAAQAY" +
           "AAAARmFjaWxpdHlZZXNOb0F0dHJpYnV0ZTAxAQFIOwMAAAAAGAAAAEZhY2lsaXR5WWVzTm9BdHRyaWJ1" +
           "dGUwMQAuAERIOwAAAAH/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlZZXNOb0F0dHJp" +
           "YnV0ZTAyAQFJOwMAAAAAGAAAAEZhY2lsaXR5WWVzTm9BdHRyaWJ1dGUwMgAuAERJOwAAAAH/////AQH/" +
           "////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlZZXNOb0F0dHJpYnV0ZTAzAQFKOwMAAAAAGAAAAEZh" +
           "Y2lsaXR5WWVzTm9BdHRyaWJ1dGUwMwAuAERKOwAAAAH/////AQH/////AAAAADVgiQoCAAAAAQAYAAAA" +
           "RmFjaWxpdHlZZXNOb0F0dHJpYnV0ZTA0AQFLOwMAAAAAGAAAAEZhY2lsaXR5WWVzTm9BdHRyaWJ1dGUw" +
           "NAAuAERLOwAAAAH/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlZZXNOb0F0dHJpYnV0" +
           "ZTA1AQFMOwMAAAAAGAAAAEZhY2lsaXR5WWVzTm9BdHRyaWJ1dGUwNQAuAERMOwAAAAH/////AQH/////" +
           "AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlZZXNOb0F0dHJpYnV0ZTA2AQFNOwMAAAAAGAAAAEZhY2ls" +
           "aXR5WWVzTm9BdHRyaWJ1dGUwNgAuAERNOwAAAAH/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFj" +
           "aWxpdHlZZXNOb0F0dHJpYnV0ZTA3AQFOOwMAAAAAGAAAAEZhY2lsaXR5WWVzTm9BdHRyaWJ1dGUwNwAu" +
           "AEROOwAAAAH/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlZZXNOb0F0dHJpYnV0ZTA4" +
           "AQFPOwMAAAAAGAAAAEZhY2lsaXR5WWVzTm9BdHRyaWJ1dGUwOAAuAERPOwAAAAH/////AQH/////AAAA" +
           "ADVgiQoCAAAAAQAYAAAARmFjaWxpdHlZZXNOb0F0dHJpYnV0ZTA5AQFQOwMAAAAAGAAAAEZhY2lsaXR5" +
           "WWVzTm9BdHRyaWJ1dGUwOQAuAERQOwAAAAH/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxp" +
           "dHlZZXNOb0F0dHJpYnV0ZTEwAQFROwMAAAAAGAAAAEZhY2lsaXR5WWVzTm9BdHRyaWJ1dGUxMAAuAERR" +
           "OwAAAAH/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlZZXNOb0F0dHJpYnV0ZTExAQFS" +
           "OwMAAAAAGAAAAEZhY2lsaXR5WWVzTm9BdHRyaWJ1dGUxMQAuAERSOwAAAAH/////AQH/////AAAAADVg" +
           "iQoCAAAAAQAYAAAARmFjaWxpdHlZZXNOb0F0dHJpYnV0ZTEyAQFTOwMAAAAAGAAAAEZhY2lsaXR5WWVz" +
           "Tm9BdHRyaWJ1dGUxMgAuAERTOwAAAAH/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlZ" +
           "ZXNOb0F0dHJpYnV0ZTEzAQFUOwMAAAAAGAAAAEZhY2lsaXR5WWVzTm9BdHRyaWJ1dGUxMwAuAERUOwAA" +
           "AAH/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlZZXNOb0F0dHJpYnV0ZTE0AQFVOwMA" +
           "AAAAGAAAAEZhY2lsaXR5WWVzTm9BdHRyaWJ1dGUxNAAuAERVOwAAAAH/////AQH/////AAAAADVgiQoC" +
           "AAAAAQAYAAAARmFjaWxpdHlZZXNOb0F0dHJpYnV0ZTE1AQFWOwMAAAAAGAAAAEZhY2lsaXR5WWVzTm9B" +
           "dHRyaWJ1dGUxNQAuAERWOwAAAAH/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlZZXNO" +
           "b0F0dHJpYnV0ZTE2AQFXOwMAAAAAGAAAAEZhY2lsaXR5WWVzTm9BdHRyaWJ1dGUxNgAuAERXOwAAAAH/" +
           "////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlZZXNOb0F0dHJpYnV0ZTE3AQFYOwMAAAAA" +
           "GAAAAEZhY2lsaXR5WWVzTm9BdHRyaWJ1dGUxNwAuAERYOwAAAAH/////AQH/////AAAAADVgiQoCAAAA" +
           "AQAYAAAARmFjaWxpdHlZZXNOb0F0dHJpYnV0ZTE4AQFZOwMAAAAAGAAAAEZhY2lsaXR5WWVzTm9BdHRy" +
           "aWJ1dGUxOAAuAERZOwAAAAH/////AQH/////AAAAADVgiQoCAAAAAQAYAAAARmFjaWxpdHlZZXNOb0F0" +
           "dHJpYnV0ZTE5AQFaOwMAAAAAGAAAAEZhY2lsaXR5WWVzTm9BdHRyaWJ1dGUxOQAuAERaOwAAAAH/////" +
           "AQH/////AAAAADVgiQoCAAAAAQALAAAARmFjaWxpdHlUYWcBAVs7AwAAAAALAAAARmFjaWxpdHlUYWcA" +
           "LgBEWzsAAAAM/////wEB/////wAAAAA=";
        #endregion
#endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> FacilitySiteService
        {
            get
            {
                return m_facilitySiteService;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilitySiteService, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilitySiteService = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityId
        {
            get
            {
                return m_facilityId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityId = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilitySite
        {
            get
            {
                return m_facilitySite;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilitySite, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilitySite = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityService
        {
            get
            {
                return m_facilityService;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityService, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityService = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityType
        {
            get
            {
                return m_facilityType;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityType, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityType = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityDescription
        {
            get
            {
                return m_facilityDescription;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityDescription, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityDescription = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityInfoAttribute0
        {
            get
            {
                return m_facilityInfoAttribute0;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityInfoAttribute0, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityInfoAttribute0 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityInfoAttribute1
        {
            get
            {
                return m_facilityInfoAttribute1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityInfoAttribute1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityInfoAttribute1 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityCategory
        {
            get
            {
                return m_facilityCategory;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityCategory, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityCategory = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityIsActive
        {
            get
            {
                return m_facilityIsActive;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityIsActive, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityIsActive = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilitySecurityApplication
        {
            get
            {
                return m_facilitySecurityApplication;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilitySecurityApplication, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilitySecurityApplication = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute00
        {
            get
            {
                return m_facilityTextAttribute00;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute00, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute00 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute01
        {
            get
            {
                return m_facilityTextAttribute01;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute01, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute01 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute02
        {
            get
            {
                return m_facilityTextAttribute02;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute02, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute02 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute03
        {
            get
            {
                return m_facilityTextAttribute03;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute03, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute03 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute04
        {
            get
            {
                return m_facilityTextAttribute04;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute04, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute04 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute05
        {
            get
            {
                return m_facilityTextAttribute05;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute05, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute05 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute06
        {
            get
            {
                return m_facilityTextAttribute06;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute06, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute06 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute07
        {
            get
            {
                return m_facilityTextAttribute07;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute07, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute07 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute08
        {
            get
            {
                return m_facilityTextAttribute08;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute08, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute08 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute09
        {
            get
            {
                return m_facilityTextAttribute09;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute09, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute09 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute10
        {
            get
            {
                return m_facilityTextAttribute10;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute10, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute10 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute11
        {
            get
            {
                return m_facilityTextAttribute11;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute11, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute11 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute12
        {
            get
            {
                return m_facilityTextAttribute12;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute12, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute12 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute13
        {
            get
            {
                return m_facilityTextAttribute13;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute13, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute13 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute14
        {
            get
            {
                return m_facilityTextAttribute14;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute14, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute14 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute15
        {
            get
            {
                return m_facilityTextAttribute15;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute15, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute15 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute16
        {
            get
            {
                return m_facilityTextAttribute16;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute16, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute16 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute17
        {
            get
            {
                return m_facilityTextAttribute17;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute17, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute17 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute18
        {
            get
            {
                return m_facilityTextAttribute18;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute18, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute18 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute19
        {
            get
            {
                return m_facilityTextAttribute19;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute19, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute19 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute20
        {
            get
            {
                return m_facilityTextAttribute20;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute20, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute20 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute21
        {
            get
            {
                return m_facilityTextAttribute21;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute21, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute21 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute22
        {
            get
            {
                return m_facilityTextAttribute22;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute22, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute22 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute23
        {
            get
            {
                return m_facilityTextAttribute23;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute23, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute23 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute24
        {
            get
            {
                return m_facilityTextAttribute24;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute24, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute24 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute25
        {
            get
            {
                return m_facilityTextAttribute25;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute25, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute25 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute26
        {
            get
            {
                return m_facilityTextAttribute26;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute26, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute26 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute27
        {
            get
            {
                return m_facilityTextAttribute27;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute27, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute27 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute28
        {
            get
            {
                return m_facilityTextAttribute28;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute28, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute28 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute29
        {
            get
            {
                return m_facilityTextAttribute29;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute29, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute29 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute30
        {
            get
            {
                return m_facilityTextAttribute30;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute30, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute30 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute31
        {
            get
            {
                return m_facilityTextAttribute31;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute31, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute31 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute32
        {
            get
            {
                return m_facilityTextAttribute32;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute32, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute32 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute33
        {
            get
            {
                return m_facilityTextAttribute33;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute33, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute33 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute34
        {
            get
            {
                return m_facilityTextAttribute34;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute34, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute34 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute35
        {
            get
            {
                return m_facilityTextAttribute35;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute35, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute35 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute36
        {
            get
            {
                return m_facilityTextAttribute36;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute36, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute36 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute37
        {
            get
            {
                return m_facilityTextAttribute37;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute37, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute37 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute38
        {
            get
            {
                return m_facilityTextAttribute38;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute38, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute38 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTextAttribute39
        {
            get
            {
                return m_facilityTextAttribute39;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTextAttribute39, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTextAttribute39 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute00
        {
            get
            {
                return m_facilityTableAttribute00;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute00, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute00 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute01
        {
            get
            {
                return m_facilityTableAttribute01;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute01, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute01 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute02
        {
            get
            {
                return m_facilityTableAttribute02;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute02, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute02 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute03
        {
            get
            {
                return m_facilityTableAttribute03;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute03, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute03 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute04
        {
            get
            {
                return m_facilityTableAttribute04;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute04, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute04 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute05
        {
            get
            {
                return m_facilityTableAttribute05;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute05, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute05 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute06
        {
            get
            {
                return m_facilityTableAttribute06;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute06, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute06 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute07
        {
            get
            {
                return m_facilityTableAttribute07;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute07, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute07 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute08
        {
            get
            {
                return m_facilityTableAttribute08;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute08, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute08 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute09
        {
            get
            {
                return m_facilityTableAttribute09;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute09, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute09 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute10
        {
            get
            {
                return m_facilityTableAttribute10;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute10, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute10 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute11
        {
            get
            {
                return m_facilityTableAttribute11;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute11, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute11 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute12
        {
            get
            {
                return m_facilityTableAttribute12;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute12, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute12 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute13
        {
            get
            {
                return m_facilityTableAttribute13;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute13, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute13 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute14
        {
            get
            {
                return m_facilityTableAttribute14;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute14, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute14 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute15
        {
            get
            {
                return m_facilityTableAttribute15;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute15, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute15 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute16
        {
            get
            {
                return m_facilityTableAttribute16;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute16, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute16 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute17
        {
            get
            {
                return m_facilityTableAttribute17;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute17, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute17 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute18
        {
            get
            {
                return m_facilityTableAttribute18;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute18, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute18 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute19
        {
            get
            {
                return m_facilityTableAttribute19;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute19, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute19 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute20
        {
            get
            {
                return m_facilityTableAttribute20;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute20, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute20 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute21
        {
            get
            {
                return m_facilityTableAttribute21;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute21, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute21 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute22
        {
            get
            {
                return m_facilityTableAttribute22;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute22, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute22 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute23
        {
            get
            {
                return m_facilityTableAttribute23;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute23, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute23 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute24
        {
            get
            {
                return m_facilityTableAttribute24;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute24, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute24 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute25
        {
            get
            {
                return m_facilityTableAttribute25;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute25, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute25 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute26
        {
            get
            {
                return m_facilityTableAttribute26;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute26, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute26 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute27
        {
            get
            {
                return m_facilityTableAttribute27;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute27, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute27 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute28
        {
            get
            {
                return m_facilityTableAttribute28;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute28, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute28 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute29
        {
            get
            {
                return m_facilityTableAttribute29;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute29, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute29 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute30
        {
            get
            {
                return m_facilityTableAttribute30;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute30, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute30 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute31
        {
            get
            {
                return m_facilityTableAttribute31;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute31, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute31 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute32
        {
            get
            {
                return m_facilityTableAttribute32;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute32, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute32 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute33
        {
            get
            {
                return m_facilityTableAttribute33;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute33, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute33 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute34
        {
            get
            {
                return m_facilityTableAttribute34;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute34, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute34 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute35
        {
            get
            {
                return m_facilityTableAttribute35;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute35, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute35 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute36
        {
            get
            {
                return m_facilityTableAttribute36;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute36, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute36 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute37
        {
            get
            {
                return m_facilityTableAttribute37;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute37, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute37 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute38
        {
            get
            {
                return m_facilityTableAttribute38;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute38, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute38 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute39
        {
            get
            {
                return m_facilityTableAttribute39;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute39, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute39 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute40
        {
            get
            {
                return m_facilityTableAttribute40;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute40, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute40 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute41
        {
            get
            {
                return m_facilityTableAttribute41;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute41, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute41 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute42
        {
            get
            {
                return m_facilityTableAttribute42;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute42, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute42 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute43
        {
            get
            {
                return m_facilityTableAttribute43;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute43, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute43 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute44
        {
            get
            {
                return m_facilityTableAttribute44;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute44, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute44 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute45
        {
            get
            {
                return m_facilityTableAttribute45;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute45, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute45 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute46
        {
            get
            {
                return m_facilityTableAttribute46;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute46, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute46 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute47
        {
            get
            {
                return m_facilityTableAttribute47;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute47, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute47 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute48
        {
            get
            {
                return m_facilityTableAttribute48;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute48, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute48 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute49
        {
            get
            {
                return m_facilityTableAttribute49;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute49, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute49 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute50
        {
            get
            {
                return m_facilityTableAttribute50;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute50, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute50 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute51
        {
            get
            {
                return m_facilityTableAttribute51;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute51, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute51 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute52
        {
            get
            {
                return m_facilityTableAttribute52;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute52, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute52 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute53
        {
            get
            {
                return m_facilityTableAttribute53;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute53, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute53 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute54
        {
            get
            {
                return m_facilityTableAttribute54;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute54, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute54 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute55
        {
            get
            {
                return m_facilityTableAttribute55;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute55, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute55 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute56
        {
            get
            {
                return m_facilityTableAttribute56;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute56, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute56 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute57
        {
            get
            {
                return m_facilityTableAttribute57;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute57, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute57 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute58
        {
            get
            {
                return m_facilityTableAttribute58;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute58, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute58 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute59
        {
            get
            {
                return m_facilityTableAttribute59;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute59, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute59 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute00Description
        {
            get
            {
                return m_facilityTableAttribute00Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute00Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute00Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute01Description
        {
            get
            {
                return m_facilityTableAttribute01Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute01Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute01Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute02Description
        {
            get
            {
                return m_facilityTableAttribute02Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute02Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute02Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute03Description
        {
            get
            {
                return m_facilityTableAttribute03Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute03Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute03Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute04Description
        {
            get
            {
                return m_facilityTableAttribute04Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute04Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute04Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute05Description
        {
            get
            {
                return m_facilityTableAttribute05Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute05Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute05Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute06Description
        {
            get
            {
                return m_facilityTableAttribute06Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute06Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute06Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute07Description
        {
            get
            {
                return m_facilityTableAttribute07Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute07Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute07Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute08Description
        {
            get
            {
                return m_facilityTableAttribute08Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute08Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute08Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute09Description
        {
            get
            {
                return m_facilityTableAttribute09Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute09Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute09Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute10Description
        {
            get
            {
                return m_facilityTableAttribute10Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute10Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute10Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute11Description
        {
            get
            {
                return m_facilityTableAttribute11Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute11Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute11Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute12Description
        {
            get
            {
                return m_facilityTableAttribute12Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute12Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute12Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute13Description
        {
            get
            {
                return m_facilityTableAttribute13Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute13Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute13Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute14Description
        {
            get
            {
                return m_facilityTableAttribute14Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute14Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute14Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute15Description
        {
            get
            {
                return m_facilityTableAttribute15Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute15Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute15Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute16Description
        {
            get
            {
                return m_facilityTableAttribute16Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute16Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute16Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute17Description
        {
            get
            {
                return m_facilityTableAttribute17Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute17Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute17Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute18Description
        {
            get
            {
                return m_facilityTableAttribute18Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute18Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute18Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute19Description
        {
            get
            {
                return m_facilityTableAttribute19Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute19Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute19Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute20Description
        {
            get
            {
                return m_facilityTableAttribute20Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute20Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute20Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute21Description
        {
            get
            {
                return m_facilityTableAttribute21Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute21Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute21Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute22Description
        {
            get
            {
                return m_facilityTableAttribute22Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute22Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute22Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute23Description
        {
            get
            {
                return m_facilityTableAttribute23Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute23Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute23Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute24Description
        {
            get
            {
                return m_facilityTableAttribute24Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute24Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute24Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute25Description
        {
            get
            {
                return m_facilityTableAttribute25Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute25Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute25Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute26Description
        {
            get
            {
                return m_facilityTableAttribute26Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute26Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute26Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute27Description
        {
            get
            {
                return m_facilityTableAttribute27Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute27Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute27Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute28Description
        {
            get
            {
                return m_facilityTableAttribute28Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute28Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute28Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute29Description
        {
            get
            {
                return m_facilityTableAttribute29Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute29Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute29Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute30Description
        {
            get
            {
                return m_facilityTableAttribute30Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute30Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute30Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute31Description
        {
            get
            {
                return m_facilityTableAttribute31Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute31Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute31Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute32Description
        {
            get
            {
                return m_facilityTableAttribute32Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute32Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute32Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute33Description
        {
            get
            {
                return m_facilityTableAttribute33Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute33Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute33Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute34Description
        {
            get
            {
                return m_facilityTableAttribute34Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute34Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute34Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute35Description
        {
            get
            {
                return m_facilityTableAttribute35Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute35Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute35Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute36Description
        {
            get
            {
                return m_facilityTableAttribute36Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute36Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute36Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute37Description
        {
            get
            {
                return m_facilityTableAttribute37Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute37Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute37Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute38Description
        {
            get
            {
                return m_facilityTableAttribute38Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute38Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute38Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute39Description
        {
            get
            {
                return m_facilityTableAttribute39Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute39Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute39Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute40Description
        {
            get
            {
                return m_facilityTableAttribute40Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute40Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute40Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute41Description
        {
            get
            {
                return m_facilityTableAttribute41Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute41Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute41Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute42Description
        {
            get
            {
                return m_facilityTableAttribute42Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute42Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute42Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute43Description
        {
            get
            {
                return m_facilityTableAttribute43Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute43Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute43Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute44Description
        {
            get
            {
                return m_facilityTableAttribute44Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute44Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute44Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute45Description
        {
            get
            {
                return m_facilityTableAttribute45Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute45Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute45Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute46Description
        {
            get
            {
                return m_facilityTableAttribute46Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute46Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute46Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute47Description
        {
            get
            {
                return m_facilityTableAttribute47Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute47Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute47Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute48Description
        {
            get
            {
                return m_facilityTableAttribute48Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute48Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute48Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute49Description
        {
            get
            {
                return m_facilityTableAttribute49Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute49Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute49Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute50Description
        {
            get
            {
                return m_facilityTableAttribute50Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute50Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute50Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute51Description
        {
            get
            {
                return m_facilityTableAttribute51Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute51Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute51Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute52Description
        {
            get
            {
                return m_facilityTableAttribute52Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute52Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute52Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute53Description
        {
            get
            {
                return m_facilityTableAttribute53Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute53Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute53Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute54Description
        {
            get
            {
                return m_facilityTableAttribute54Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute54Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute54Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute55Description
        {
            get
            {
                return m_facilityTableAttribute55Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute55Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute55Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute56Description
        {
            get
            {
                return m_facilityTableAttribute56Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute56Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute56Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute57Description
        {
            get
            {
                return m_facilityTableAttribute57Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute57Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute57Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute58Description
        {
            get
            {
                return m_facilityTableAttribute58Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute58Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute58Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTableAttribute59Description
        {
            get
            {
                return m_facilityTableAttribute59Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTableAttribute59Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTableAttribute59Description = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityYesNoAttribute00
        {
            get
            {
                return m_facilityYesNoAttribute00;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityYesNoAttribute00, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityYesNoAttribute00 = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityYesNoAttribute01
        {
            get
            {
                return m_facilityYesNoAttribute01;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityYesNoAttribute01, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityYesNoAttribute01 = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityYesNoAttribute02
        {
            get
            {
                return m_facilityYesNoAttribute02;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityYesNoAttribute02, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityYesNoAttribute02 = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityYesNoAttribute03
        {
            get
            {
                return m_facilityYesNoAttribute03;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityYesNoAttribute03, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityYesNoAttribute03 = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityYesNoAttribute04
        {
            get
            {
                return m_facilityYesNoAttribute04;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityYesNoAttribute04, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityYesNoAttribute04 = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityYesNoAttribute05
        {
            get
            {
                return m_facilityYesNoAttribute05;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityYesNoAttribute05, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityYesNoAttribute05 = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityYesNoAttribute06
        {
            get
            {
                return m_facilityYesNoAttribute06;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityYesNoAttribute06, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityYesNoAttribute06 = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityYesNoAttribute07
        {
            get
            {
                return m_facilityYesNoAttribute07;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityYesNoAttribute07, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityYesNoAttribute07 = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityYesNoAttribute08
        {
            get
            {
                return m_facilityYesNoAttribute08;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityYesNoAttribute08, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityYesNoAttribute08 = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityYesNoAttribute09
        {
            get
            {
                return m_facilityYesNoAttribute09;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityYesNoAttribute09, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityYesNoAttribute09 = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityYesNoAttribute10
        {
            get
            {
                return m_facilityYesNoAttribute10;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityYesNoAttribute10, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityYesNoAttribute10 = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityYesNoAttribute11
        {
            get
            {
                return m_facilityYesNoAttribute11;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityYesNoAttribute11, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityYesNoAttribute11 = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityYesNoAttribute12
        {
            get
            {
                return m_facilityYesNoAttribute12;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityYesNoAttribute12, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityYesNoAttribute12 = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityYesNoAttribute13
        {
            get
            {
                return m_facilityYesNoAttribute13;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityYesNoAttribute13, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityYesNoAttribute13 = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityYesNoAttribute14
        {
            get
            {
                return m_facilityYesNoAttribute14;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityYesNoAttribute14, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityYesNoAttribute14 = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityYesNoAttribute15
        {
            get
            {
                return m_facilityYesNoAttribute15;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityYesNoAttribute15, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityYesNoAttribute15 = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityYesNoAttribute16
        {
            get
            {
                return m_facilityYesNoAttribute16;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityYesNoAttribute16, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityYesNoAttribute16 = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityYesNoAttribute17
        {
            get
            {
                return m_facilityYesNoAttribute17;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityYesNoAttribute17, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityYesNoAttribute17 = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityYesNoAttribute18
        {
            get
            {
                return m_facilityYesNoAttribute18;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityYesNoAttribute18, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityYesNoAttribute18 = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> FacilityYesNoAttribute19
        {
            get
            {
                return m_facilityYesNoAttribute19;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityYesNoAttribute19, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityYesNoAttribute19 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> FacilityTag
        {
            get
            {
                return m_facilityTag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facilityTag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facilityTag = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_facilitySiteService != null)
            {
                children.Add(m_facilitySiteService);
            }

            if (m_facilityId != null)
            {
                children.Add(m_facilityId);
            }

            if (m_facilitySite != null)
            {
                children.Add(m_facilitySite);
            }

            if (m_facilityService != null)
            {
                children.Add(m_facilityService);
            }

            if (m_facilityType != null)
            {
                children.Add(m_facilityType);
            }

            if (m_facilityDescription != null)
            {
                children.Add(m_facilityDescription);
            }

            if (m_facilityInfoAttribute0 != null)
            {
                children.Add(m_facilityInfoAttribute0);
            }

            if (m_facilityInfoAttribute1 != null)
            {
                children.Add(m_facilityInfoAttribute1);
            }

            if (m_facilityCategory != null)
            {
                children.Add(m_facilityCategory);
            }

            if (m_facilityIsActive != null)
            {
                children.Add(m_facilityIsActive);
            }

            if (m_facilitySecurityApplication != null)
            {
                children.Add(m_facilitySecurityApplication);
            }

            if (m_facilityTextAttribute00 != null)
            {
                children.Add(m_facilityTextAttribute00);
            }

            if (m_facilityTextAttribute01 != null)
            {
                children.Add(m_facilityTextAttribute01);
            }

            if (m_facilityTextAttribute02 != null)
            {
                children.Add(m_facilityTextAttribute02);
            }

            if (m_facilityTextAttribute03 != null)
            {
                children.Add(m_facilityTextAttribute03);
            }

            if (m_facilityTextAttribute04 != null)
            {
                children.Add(m_facilityTextAttribute04);
            }

            if (m_facilityTextAttribute05 != null)
            {
                children.Add(m_facilityTextAttribute05);
            }

            if (m_facilityTextAttribute06 != null)
            {
                children.Add(m_facilityTextAttribute06);
            }

            if (m_facilityTextAttribute07 != null)
            {
                children.Add(m_facilityTextAttribute07);
            }

            if (m_facilityTextAttribute08 != null)
            {
                children.Add(m_facilityTextAttribute08);
            }

            if (m_facilityTextAttribute09 != null)
            {
                children.Add(m_facilityTextAttribute09);
            }

            if (m_facilityTextAttribute10 != null)
            {
                children.Add(m_facilityTextAttribute10);
            }

            if (m_facilityTextAttribute11 != null)
            {
                children.Add(m_facilityTextAttribute11);
            }

            if (m_facilityTextAttribute12 != null)
            {
                children.Add(m_facilityTextAttribute12);
            }

            if (m_facilityTextAttribute13 != null)
            {
                children.Add(m_facilityTextAttribute13);
            }

            if (m_facilityTextAttribute14 != null)
            {
                children.Add(m_facilityTextAttribute14);
            }

            if (m_facilityTextAttribute15 != null)
            {
                children.Add(m_facilityTextAttribute15);
            }

            if (m_facilityTextAttribute16 != null)
            {
                children.Add(m_facilityTextAttribute16);
            }

            if (m_facilityTextAttribute17 != null)
            {
                children.Add(m_facilityTextAttribute17);
            }

            if (m_facilityTextAttribute18 != null)
            {
                children.Add(m_facilityTextAttribute18);
            }

            if (m_facilityTextAttribute19 != null)
            {
                children.Add(m_facilityTextAttribute19);
            }

            if (m_facilityTextAttribute20 != null)
            {
                children.Add(m_facilityTextAttribute20);
            }

            if (m_facilityTextAttribute21 != null)
            {
                children.Add(m_facilityTextAttribute21);
            }

            if (m_facilityTextAttribute22 != null)
            {
                children.Add(m_facilityTextAttribute22);
            }

            if (m_facilityTextAttribute23 != null)
            {
                children.Add(m_facilityTextAttribute23);
            }

            if (m_facilityTextAttribute24 != null)
            {
                children.Add(m_facilityTextAttribute24);
            }

            if (m_facilityTextAttribute25 != null)
            {
                children.Add(m_facilityTextAttribute25);
            }

            if (m_facilityTextAttribute26 != null)
            {
                children.Add(m_facilityTextAttribute26);
            }

            if (m_facilityTextAttribute27 != null)
            {
                children.Add(m_facilityTextAttribute27);
            }

            if (m_facilityTextAttribute28 != null)
            {
                children.Add(m_facilityTextAttribute28);
            }

            if (m_facilityTextAttribute29 != null)
            {
                children.Add(m_facilityTextAttribute29);
            }

            if (m_facilityTextAttribute30 != null)
            {
                children.Add(m_facilityTextAttribute30);
            }

            if (m_facilityTextAttribute31 != null)
            {
                children.Add(m_facilityTextAttribute31);
            }

            if (m_facilityTextAttribute32 != null)
            {
                children.Add(m_facilityTextAttribute32);
            }

            if (m_facilityTextAttribute33 != null)
            {
                children.Add(m_facilityTextAttribute33);
            }

            if (m_facilityTextAttribute34 != null)
            {
                children.Add(m_facilityTextAttribute34);
            }

            if (m_facilityTextAttribute35 != null)
            {
                children.Add(m_facilityTextAttribute35);
            }

            if (m_facilityTextAttribute36 != null)
            {
                children.Add(m_facilityTextAttribute36);
            }

            if (m_facilityTextAttribute37 != null)
            {
                children.Add(m_facilityTextAttribute37);
            }

            if (m_facilityTextAttribute38 != null)
            {
                children.Add(m_facilityTextAttribute38);
            }

            if (m_facilityTextAttribute39 != null)
            {
                children.Add(m_facilityTextAttribute39);
            }

            if (m_facilityTableAttribute00 != null)
            {
                children.Add(m_facilityTableAttribute00);
            }

            if (m_facilityTableAttribute01 != null)
            {
                children.Add(m_facilityTableAttribute01);
            }

            if (m_facilityTableAttribute02 != null)
            {
                children.Add(m_facilityTableAttribute02);
            }

            if (m_facilityTableAttribute03 != null)
            {
                children.Add(m_facilityTableAttribute03);
            }

            if (m_facilityTableAttribute04 != null)
            {
                children.Add(m_facilityTableAttribute04);
            }

            if (m_facilityTableAttribute05 != null)
            {
                children.Add(m_facilityTableAttribute05);
            }

            if (m_facilityTableAttribute06 != null)
            {
                children.Add(m_facilityTableAttribute06);
            }

            if (m_facilityTableAttribute07 != null)
            {
                children.Add(m_facilityTableAttribute07);
            }

            if (m_facilityTableAttribute08 != null)
            {
                children.Add(m_facilityTableAttribute08);
            }

            if (m_facilityTableAttribute09 != null)
            {
                children.Add(m_facilityTableAttribute09);
            }

            if (m_facilityTableAttribute10 != null)
            {
                children.Add(m_facilityTableAttribute10);
            }

            if (m_facilityTableAttribute11 != null)
            {
                children.Add(m_facilityTableAttribute11);
            }

            if (m_facilityTableAttribute12 != null)
            {
                children.Add(m_facilityTableAttribute12);
            }

            if (m_facilityTableAttribute13 != null)
            {
                children.Add(m_facilityTableAttribute13);
            }

            if (m_facilityTableAttribute14 != null)
            {
                children.Add(m_facilityTableAttribute14);
            }

            if (m_facilityTableAttribute15 != null)
            {
                children.Add(m_facilityTableAttribute15);
            }

            if (m_facilityTableAttribute16 != null)
            {
                children.Add(m_facilityTableAttribute16);
            }

            if (m_facilityTableAttribute17 != null)
            {
                children.Add(m_facilityTableAttribute17);
            }

            if (m_facilityTableAttribute18 != null)
            {
                children.Add(m_facilityTableAttribute18);
            }

            if (m_facilityTableAttribute19 != null)
            {
                children.Add(m_facilityTableAttribute19);
            }

            if (m_facilityTableAttribute20 != null)
            {
                children.Add(m_facilityTableAttribute20);
            }

            if (m_facilityTableAttribute21 != null)
            {
                children.Add(m_facilityTableAttribute21);
            }

            if (m_facilityTableAttribute22 != null)
            {
                children.Add(m_facilityTableAttribute22);
            }

            if (m_facilityTableAttribute23 != null)
            {
                children.Add(m_facilityTableAttribute23);
            }

            if (m_facilityTableAttribute24 != null)
            {
                children.Add(m_facilityTableAttribute24);
            }

            if (m_facilityTableAttribute25 != null)
            {
                children.Add(m_facilityTableAttribute25);
            }

            if (m_facilityTableAttribute26 != null)
            {
                children.Add(m_facilityTableAttribute26);
            }

            if (m_facilityTableAttribute27 != null)
            {
                children.Add(m_facilityTableAttribute27);
            }

            if (m_facilityTableAttribute28 != null)
            {
                children.Add(m_facilityTableAttribute28);
            }

            if (m_facilityTableAttribute29 != null)
            {
                children.Add(m_facilityTableAttribute29);
            }

            if (m_facilityTableAttribute30 != null)
            {
                children.Add(m_facilityTableAttribute30);
            }

            if (m_facilityTableAttribute31 != null)
            {
                children.Add(m_facilityTableAttribute31);
            }

            if (m_facilityTableAttribute32 != null)
            {
                children.Add(m_facilityTableAttribute32);
            }

            if (m_facilityTableAttribute33 != null)
            {
                children.Add(m_facilityTableAttribute33);
            }

            if (m_facilityTableAttribute34 != null)
            {
                children.Add(m_facilityTableAttribute34);
            }

            if (m_facilityTableAttribute35 != null)
            {
                children.Add(m_facilityTableAttribute35);
            }

            if (m_facilityTableAttribute36 != null)
            {
                children.Add(m_facilityTableAttribute36);
            }

            if (m_facilityTableAttribute37 != null)
            {
                children.Add(m_facilityTableAttribute37);
            }

            if (m_facilityTableAttribute38 != null)
            {
                children.Add(m_facilityTableAttribute38);
            }

            if (m_facilityTableAttribute39 != null)
            {
                children.Add(m_facilityTableAttribute39);
            }

            if (m_facilityTableAttribute40 != null)
            {
                children.Add(m_facilityTableAttribute40);
            }

            if (m_facilityTableAttribute41 != null)
            {
                children.Add(m_facilityTableAttribute41);
            }

            if (m_facilityTableAttribute42 != null)
            {
                children.Add(m_facilityTableAttribute42);
            }

            if (m_facilityTableAttribute43 != null)
            {
                children.Add(m_facilityTableAttribute43);
            }

            if (m_facilityTableAttribute44 != null)
            {
                children.Add(m_facilityTableAttribute44);
            }

            if (m_facilityTableAttribute45 != null)
            {
                children.Add(m_facilityTableAttribute45);
            }

            if (m_facilityTableAttribute46 != null)
            {
                children.Add(m_facilityTableAttribute46);
            }

            if (m_facilityTableAttribute47 != null)
            {
                children.Add(m_facilityTableAttribute47);
            }

            if (m_facilityTableAttribute48 != null)
            {
                children.Add(m_facilityTableAttribute48);
            }

            if (m_facilityTableAttribute49 != null)
            {
                children.Add(m_facilityTableAttribute49);
            }

            if (m_facilityTableAttribute50 != null)
            {
                children.Add(m_facilityTableAttribute50);
            }

            if (m_facilityTableAttribute51 != null)
            {
                children.Add(m_facilityTableAttribute51);
            }

            if (m_facilityTableAttribute52 != null)
            {
                children.Add(m_facilityTableAttribute52);
            }

            if (m_facilityTableAttribute53 != null)
            {
                children.Add(m_facilityTableAttribute53);
            }

            if (m_facilityTableAttribute54 != null)
            {
                children.Add(m_facilityTableAttribute54);
            }

            if (m_facilityTableAttribute55 != null)
            {
                children.Add(m_facilityTableAttribute55);
            }

            if (m_facilityTableAttribute56 != null)
            {
                children.Add(m_facilityTableAttribute56);
            }

            if (m_facilityTableAttribute57 != null)
            {
                children.Add(m_facilityTableAttribute57);
            }

            if (m_facilityTableAttribute58 != null)
            {
                children.Add(m_facilityTableAttribute58);
            }

            if (m_facilityTableAttribute59 != null)
            {
                children.Add(m_facilityTableAttribute59);
            }

            if (m_facilityTableAttribute00Description != null)
            {
                children.Add(m_facilityTableAttribute00Description);
            }

            if (m_facilityTableAttribute01Description != null)
            {
                children.Add(m_facilityTableAttribute01Description);
            }

            if (m_facilityTableAttribute02Description != null)
            {
                children.Add(m_facilityTableAttribute02Description);
            }

            if (m_facilityTableAttribute03Description != null)
            {
                children.Add(m_facilityTableAttribute03Description);
            }

            if (m_facilityTableAttribute04Description != null)
            {
                children.Add(m_facilityTableAttribute04Description);
            }

            if (m_facilityTableAttribute05Description != null)
            {
                children.Add(m_facilityTableAttribute05Description);
            }

            if (m_facilityTableAttribute06Description != null)
            {
                children.Add(m_facilityTableAttribute06Description);
            }

            if (m_facilityTableAttribute07Description != null)
            {
                children.Add(m_facilityTableAttribute07Description);
            }

            if (m_facilityTableAttribute08Description != null)
            {
                children.Add(m_facilityTableAttribute08Description);
            }

            if (m_facilityTableAttribute09Description != null)
            {
                children.Add(m_facilityTableAttribute09Description);
            }

            if (m_facilityTableAttribute10Description != null)
            {
                children.Add(m_facilityTableAttribute10Description);
            }

            if (m_facilityTableAttribute11Description != null)
            {
                children.Add(m_facilityTableAttribute11Description);
            }

            if (m_facilityTableAttribute12Description != null)
            {
                children.Add(m_facilityTableAttribute12Description);
            }

            if (m_facilityTableAttribute13Description != null)
            {
                children.Add(m_facilityTableAttribute13Description);
            }

            if (m_facilityTableAttribute14Description != null)
            {
                children.Add(m_facilityTableAttribute14Description);
            }

            if (m_facilityTableAttribute15Description != null)
            {
                children.Add(m_facilityTableAttribute15Description);
            }

            if (m_facilityTableAttribute16Description != null)
            {
                children.Add(m_facilityTableAttribute16Description);
            }

            if (m_facilityTableAttribute17Description != null)
            {
                children.Add(m_facilityTableAttribute17Description);
            }

            if (m_facilityTableAttribute18Description != null)
            {
                children.Add(m_facilityTableAttribute18Description);
            }

            if (m_facilityTableAttribute19Description != null)
            {
                children.Add(m_facilityTableAttribute19Description);
            }

            if (m_facilityTableAttribute20Description != null)
            {
                children.Add(m_facilityTableAttribute20Description);
            }

            if (m_facilityTableAttribute21Description != null)
            {
                children.Add(m_facilityTableAttribute21Description);
            }

            if (m_facilityTableAttribute22Description != null)
            {
                children.Add(m_facilityTableAttribute22Description);
            }

            if (m_facilityTableAttribute23Description != null)
            {
                children.Add(m_facilityTableAttribute23Description);
            }

            if (m_facilityTableAttribute24Description != null)
            {
                children.Add(m_facilityTableAttribute24Description);
            }

            if (m_facilityTableAttribute25Description != null)
            {
                children.Add(m_facilityTableAttribute25Description);
            }

            if (m_facilityTableAttribute26Description != null)
            {
                children.Add(m_facilityTableAttribute26Description);
            }

            if (m_facilityTableAttribute27Description != null)
            {
                children.Add(m_facilityTableAttribute27Description);
            }

            if (m_facilityTableAttribute28Description != null)
            {
                children.Add(m_facilityTableAttribute28Description);
            }

            if (m_facilityTableAttribute29Description != null)
            {
                children.Add(m_facilityTableAttribute29Description);
            }

            if (m_facilityTableAttribute30Description != null)
            {
                children.Add(m_facilityTableAttribute30Description);
            }

            if (m_facilityTableAttribute31Description != null)
            {
                children.Add(m_facilityTableAttribute31Description);
            }

            if (m_facilityTableAttribute32Description != null)
            {
                children.Add(m_facilityTableAttribute32Description);
            }

            if (m_facilityTableAttribute33Description != null)
            {
                children.Add(m_facilityTableAttribute33Description);
            }

            if (m_facilityTableAttribute34Description != null)
            {
                children.Add(m_facilityTableAttribute34Description);
            }

            if (m_facilityTableAttribute35Description != null)
            {
                children.Add(m_facilityTableAttribute35Description);
            }

            if (m_facilityTableAttribute36Description != null)
            {
                children.Add(m_facilityTableAttribute36Description);
            }

            if (m_facilityTableAttribute37Description != null)
            {
                children.Add(m_facilityTableAttribute37Description);
            }

            if (m_facilityTableAttribute38Description != null)
            {
                children.Add(m_facilityTableAttribute38Description);
            }

            if (m_facilityTableAttribute39Description != null)
            {
                children.Add(m_facilityTableAttribute39Description);
            }

            if (m_facilityTableAttribute40Description != null)
            {
                children.Add(m_facilityTableAttribute40Description);
            }

            if (m_facilityTableAttribute41Description != null)
            {
                children.Add(m_facilityTableAttribute41Description);
            }

            if (m_facilityTableAttribute42Description != null)
            {
                children.Add(m_facilityTableAttribute42Description);
            }

            if (m_facilityTableAttribute43Description != null)
            {
                children.Add(m_facilityTableAttribute43Description);
            }

            if (m_facilityTableAttribute44Description != null)
            {
                children.Add(m_facilityTableAttribute44Description);
            }

            if (m_facilityTableAttribute45Description != null)
            {
                children.Add(m_facilityTableAttribute45Description);
            }

            if (m_facilityTableAttribute46Description != null)
            {
                children.Add(m_facilityTableAttribute46Description);
            }

            if (m_facilityTableAttribute47Description != null)
            {
                children.Add(m_facilityTableAttribute47Description);
            }

            if (m_facilityTableAttribute48Description != null)
            {
                children.Add(m_facilityTableAttribute48Description);
            }

            if (m_facilityTableAttribute49Description != null)
            {
                children.Add(m_facilityTableAttribute49Description);
            }

            if (m_facilityTableAttribute50Description != null)
            {
                children.Add(m_facilityTableAttribute50Description);
            }

            if (m_facilityTableAttribute51Description != null)
            {
                children.Add(m_facilityTableAttribute51Description);
            }

            if (m_facilityTableAttribute52Description != null)
            {
                children.Add(m_facilityTableAttribute52Description);
            }

            if (m_facilityTableAttribute53Description != null)
            {
                children.Add(m_facilityTableAttribute53Description);
            }

            if (m_facilityTableAttribute54Description != null)
            {
                children.Add(m_facilityTableAttribute54Description);
            }

            if (m_facilityTableAttribute55Description != null)
            {
                children.Add(m_facilityTableAttribute55Description);
            }

            if (m_facilityTableAttribute56Description != null)
            {
                children.Add(m_facilityTableAttribute56Description);
            }

            if (m_facilityTableAttribute57Description != null)
            {
                children.Add(m_facilityTableAttribute57Description);
            }

            if (m_facilityTableAttribute58Description != null)
            {
                children.Add(m_facilityTableAttribute58Description);
            }

            if (m_facilityTableAttribute59Description != null)
            {
                children.Add(m_facilityTableAttribute59Description);
            }

            if (m_facilityYesNoAttribute00 != null)
            {
                children.Add(m_facilityYesNoAttribute00);
            }

            if (m_facilityYesNoAttribute01 != null)
            {
                children.Add(m_facilityYesNoAttribute01);
            }

            if (m_facilityYesNoAttribute02 != null)
            {
                children.Add(m_facilityYesNoAttribute02);
            }

            if (m_facilityYesNoAttribute03 != null)
            {
                children.Add(m_facilityYesNoAttribute03);
            }

            if (m_facilityYesNoAttribute04 != null)
            {
                children.Add(m_facilityYesNoAttribute04);
            }

            if (m_facilityYesNoAttribute05 != null)
            {
                children.Add(m_facilityYesNoAttribute05);
            }

            if (m_facilityYesNoAttribute06 != null)
            {
                children.Add(m_facilityYesNoAttribute06);
            }

            if (m_facilityYesNoAttribute07 != null)
            {
                children.Add(m_facilityYesNoAttribute07);
            }

            if (m_facilityYesNoAttribute08 != null)
            {
                children.Add(m_facilityYesNoAttribute08);
            }

            if (m_facilityYesNoAttribute09 != null)
            {
                children.Add(m_facilityYesNoAttribute09);
            }

            if (m_facilityYesNoAttribute10 != null)
            {
                children.Add(m_facilityYesNoAttribute10);
            }

            if (m_facilityYesNoAttribute11 != null)
            {
                children.Add(m_facilityYesNoAttribute11);
            }

            if (m_facilityYesNoAttribute12 != null)
            {
                children.Add(m_facilityYesNoAttribute12);
            }

            if (m_facilityYesNoAttribute13 != null)
            {
                children.Add(m_facilityYesNoAttribute13);
            }

            if (m_facilityYesNoAttribute14 != null)
            {
                children.Add(m_facilityYesNoAttribute14);
            }

            if (m_facilityYesNoAttribute15 != null)
            {
                children.Add(m_facilityYesNoAttribute15);
            }

            if (m_facilityYesNoAttribute16 != null)
            {
                children.Add(m_facilityYesNoAttribute16);
            }

            if (m_facilityYesNoAttribute17 != null)
            {
                children.Add(m_facilityYesNoAttribute17);
            }

            if (m_facilityYesNoAttribute18 != null)
            {
                children.Add(m_facilityYesNoAttribute18);
            }

            if (m_facilityYesNoAttribute19 != null)
            {
                children.Add(m_facilityYesNoAttribute19);
            }

            if (m_facilityTag != null)
            {
                children.Add(m_facilityTag);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case cygnet.BrowseNames.FacilitySiteService:
                    {
                        if (createOrReplace)
                        {
                            if (FacilitySiteService == null)
                            {
                                if (replacement == null)
                                {
                                    FacilitySiteService = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilitySiteService = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilitySiteService;
                        break;
                    }

                case cygnet.BrowseNames.FacilityId:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityId == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityId = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityId = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityId;
                        break;
                    }

                case cygnet.BrowseNames.FacilitySite:
                    {
                        if (createOrReplace)
                        {
                            if (FacilitySite == null)
                            {
                                if (replacement == null)
                                {
                                    FacilitySite = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilitySite = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilitySite;
                        break;
                    }

                case cygnet.BrowseNames.FacilityService:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityService == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityService = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityService = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityService;
                        break;
                    }

                case cygnet.BrowseNames.FacilityType:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityType == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityType = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityType = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityType;
                        break;
                    }

                case cygnet.BrowseNames.FacilityDescription:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityDescription == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityDescription = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityDescription = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityDescription;
                        break;
                    }

                case cygnet.BrowseNames.FacilityInfoAttribute0:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityInfoAttribute0 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityInfoAttribute0 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityInfoAttribute0 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityInfoAttribute0;
                        break;
                    }

                case cygnet.BrowseNames.FacilityInfoAttribute1:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityInfoAttribute1 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityInfoAttribute1 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityInfoAttribute1 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityInfoAttribute1;
                        break;
                    }

                case cygnet.BrowseNames.FacilityCategory:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityCategory == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityCategory = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityCategory = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityCategory;
                        break;
                    }

                case cygnet.BrowseNames.FacilityIsActive:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityIsActive == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityIsActive = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityIsActive = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityIsActive;
                        break;
                    }

                case cygnet.BrowseNames.FacilitySecurityApplication:
                    {
                        if (createOrReplace)
                        {
                            if (FacilitySecurityApplication == null)
                            {
                                if (replacement == null)
                                {
                                    FacilitySecurityApplication = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilitySecurityApplication = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilitySecurityApplication;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute00:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute00 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute00 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute00 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute00;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute01:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute01 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute01 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute01 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute01;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute02:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute02 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute02 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute02 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute02;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute03:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute03 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute03 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute03 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute03;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute04:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute04 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute04 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute04 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute04;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute05:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute05 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute05 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute05 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute05;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute06:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute06 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute06 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute06 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute06;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute07:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute07 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute07 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute07 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute07;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute08:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute08 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute08 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute08 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute08;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute09:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute09 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute09 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute09 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute09;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute10:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute10 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute10 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute10 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute10;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute11:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute11 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute11 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute11 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute11;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute12:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute12 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute12 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute12 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute12;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute13:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute13 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute13 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute13 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute13;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute14:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute14 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute14 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute14 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute14;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute15:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute15 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute15 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute15 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute15;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute16:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute16 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute16 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute16 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute16;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute17:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute17 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute17 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute17 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute17;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute18:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute18 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute18 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute18 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute18;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute19:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute19 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute19 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute19 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute19;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute20:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute20 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute20 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute20 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute20;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute21:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute21 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute21 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute21 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute21;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute22:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute22 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute22 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute22 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute22;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute23:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute23 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute23 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute23 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute23;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute24:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute24 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute24 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute24 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute24;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute25:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute25 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute25 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute25 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute25;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute26:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute26 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute26 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute26 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute26;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute27:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute27 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute27 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute27 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute27;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute28:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute28 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute28 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute28 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute28;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute29:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute29 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute29 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute29 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute29;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute30:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute30 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute30 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute30 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute30;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute31:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute31 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute31 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute31 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute31;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute32:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute32 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute32 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute32 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute32;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute33:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute33 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute33 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute33 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute33;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute34:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute34 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute34 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute34 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute34;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute35:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute35 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute35 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute35 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute35;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute36:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute36 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute36 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute36 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute36;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute37:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute37 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute37 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute37 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute37;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute38:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute38 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute38 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute38 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute38;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTextAttribute39:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTextAttribute39 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTextAttribute39 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTextAttribute39 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTextAttribute39;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute00:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute00 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute00 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute00 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute00;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute01:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute01 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute01 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute01 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute01;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute02:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute02 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute02 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute02 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute02;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute03:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute03 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute03 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute03 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute03;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute04:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute04 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute04 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute04 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute04;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute05:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute05 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute05 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute05 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute05;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute06:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute06 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute06 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute06 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute06;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute07:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute07 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute07 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute07 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute07;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute08:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute08 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute08 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute08 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute08;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute09:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute09 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute09 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute09 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute09;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute10:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute10 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute10 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute10 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute10;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute11:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute11 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute11 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute11 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute11;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute12:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute12 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute12 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute12 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute12;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute13:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute13 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute13 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute13 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute13;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute14:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute14 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute14 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute14 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute14;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute15:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute15 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute15 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute15 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute15;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute16:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute16 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute16 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute16 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute16;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute17:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute17 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute17 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute17 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute17;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute18:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute18 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute18 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute18 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute18;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute19:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute19 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute19 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute19 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute19;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute20:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute20 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute20 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute20 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute20;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute21:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute21 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute21 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute21 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute21;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute22:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute22 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute22 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute22 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute22;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute23:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute23 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute23 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute23 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute23;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute24:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute24 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute24 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute24 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute24;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute25:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute25 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute25 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute25 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute25;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute26:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute26 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute26 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute26 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute26;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute27:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute27 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute27 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute27 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute27;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute28:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute28 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute28 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute28 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute28;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute29:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute29 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute29 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute29 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute29;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute30:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute30 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute30 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute30 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute30;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute31:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute31 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute31 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute31 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute31;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute32:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute32 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute32 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute32 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute32;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute33:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute33 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute33 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute33 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute33;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute34:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute34 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute34 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute34 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute34;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute35:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute35 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute35 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute35 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute35;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute36:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute36 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute36 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute36 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute36;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute37:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute37 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute37 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute37 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute37;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute38:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute38 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute38 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute38 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute38;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute39:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute39 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute39 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute39 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute39;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute40:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute40 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute40 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute40 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute40;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute41:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute41 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute41 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute41 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute41;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute42:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute42 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute42 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute42 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute42;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute43:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute43 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute43 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute43 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute43;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute44:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute44 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute44 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute44 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute44;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute45:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute45 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute45 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute45 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute45;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute46:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute46 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute46 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute46 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute46;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute47:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute47 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute47 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute47 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute47;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute48:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute48 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute48 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute48 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute48;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute49:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute49 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute49 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute49 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute49;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute50:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute50 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute50 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute50 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute50;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute51:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute51 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute51 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute51 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute51;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute52:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute52 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute52 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute52 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute52;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute53:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute53 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute53 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute53 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute53;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute54:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute54 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute54 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute54 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute54;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute55:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute55 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute55 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute55 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute55;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute56:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute56 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute56 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute56 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute56;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute57:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute57 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute57 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute57 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute57;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute58:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute58 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute58 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute58 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute58;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute59:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute59 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute59 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute59 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute59;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute00Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute00Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute00Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute00Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute00Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute01Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute01Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute01Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute01Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute01Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute02Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute02Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute02Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute02Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute02Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute03Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute03Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute03Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute03Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute03Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute04Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute04Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute04Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute04Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute04Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute05Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute05Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute05Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute05Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute05Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute06Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute06Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute06Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute06Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute06Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute07Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute07Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute07Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute07Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute07Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute08Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute08Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute08Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute08Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute08Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute09Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute09Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute09Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute09Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute09Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute10Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute10Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute10Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute10Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute10Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute11Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute11Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute11Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute11Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute11Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute12Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute12Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute12Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute12Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute12Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute13Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute13Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute13Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute13Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute13Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute14Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute14Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute14Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute14Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute14Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute15Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute15Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute15Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute15Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute15Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute16Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute16Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute16Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute16Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute16Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute17Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute17Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute17Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute17Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute17Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute18Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute18Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute18Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute18Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute18Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute19Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute19Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute19Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute19Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute19Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute20Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute20Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute20Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute20Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute20Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute21Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute21Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute21Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute21Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute21Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute22Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute22Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute22Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute22Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute22Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute23Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute23Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute23Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute23Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute23Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute24Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute24Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute24Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute24Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute24Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute25Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute25Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute25Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute25Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute25Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute26Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute26Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute26Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute26Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute26Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute27Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute27Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute27Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute27Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute27Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute28Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute28Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute28Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute28Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute28Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute29Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute29Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute29Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute29Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute29Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute30Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute30Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute30Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute30Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute30Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute31Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute31Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute31Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute31Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute31Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute32Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute32Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute32Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute32Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute32Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute33Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute33Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute33Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute33Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute33Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute34Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute34Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute34Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute34Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute34Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute35Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute35Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute35Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute35Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute35Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute36Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute36Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute36Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute36Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute36Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute37Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute37Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute37Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute37Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute37Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute38Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute38Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute38Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute38Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute38Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute39Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute39Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute39Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute39Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute39Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute40Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute40Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute40Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute40Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute40Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute41Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute41Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute41Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute41Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute41Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute42Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute42Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute42Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute42Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute42Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute43Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute43Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute43Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute43Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute43Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute44Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute44Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute44Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute44Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute44Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute45Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute45Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute45Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute45Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute45Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute46Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute46Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute46Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute46Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute46Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute47Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute47Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute47Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute47Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute47Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute48Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute48Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute48Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute48Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute48Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute49Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute49Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute49Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute49Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute49Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute50Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute50Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute50Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute50Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute50Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute51Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute51Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute51Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute51Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute51Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute52Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute52Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute52Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute52Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute52Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute53Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute53Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute53Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute53Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute53Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute54Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute54Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute54Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute54Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute54Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute55Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute55Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute55Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute55Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute55Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute56Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute56Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute56Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute56Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute56Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute57Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute57Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute57Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute57Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute57Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute58Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute58Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute58Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute58Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute58Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTableAttribute59Description:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTableAttribute59Description == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTableAttribute59Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTableAttribute59Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTableAttribute59Description;
                        break;
                    }

                case cygnet.BrowseNames.FacilityYesNoAttribute00:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityYesNoAttribute00 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityYesNoAttribute00 = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityYesNoAttribute00 = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityYesNoAttribute00;
                        break;
                    }

                case cygnet.BrowseNames.FacilityYesNoAttribute01:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityYesNoAttribute01 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityYesNoAttribute01 = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityYesNoAttribute01 = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityYesNoAttribute01;
                        break;
                    }

                case cygnet.BrowseNames.FacilityYesNoAttribute02:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityYesNoAttribute02 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityYesNoAttribute02 = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityYesNoAttribute02 = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityYesNoAttribute02;
                        break;
                    }

                case cygnet.BrowseNames.FacilityYesNoAttribute03:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityYesNoAttribute03 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityYesNoAttribute03 = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityYesNoAttribute03 = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityYesNoAttribute03;
                        break;
                    }

                case cygnet.BrowseNames.FacilityYesNoAttribute04:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityYesNoAttribute04 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityYesNoAttribute04 = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityYesNoAttribute04 = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityYesNoAttribute04;
                        break;
                    }

                case cygnet.BrowseNames.FacilityYesNoAttribute05:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityYesNoAttribute05 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityYesNoAttribute05 = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityYesNoAttribute05 = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityYesNoAttribute05;
                        break;
                    }

                case cygnet.BrowseNames.FacilityYesNoAttribute06:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityYesNoAttribute06 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityYesNoAttribute06 = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityYesNoAttribute06 = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityYesNoAttribute06;
                        break;
                    }

                case cygnet.BrowseNames.FacilityYesNoAttribute07:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityYesNoAttribute07 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityYesNoAttribute07 = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityYesNoAttribute07 = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityYesNoAttribute07;
                        break;
                    }

                case cygnet.BrowseNames.FacilityYesNoAttribute08:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityYesNoAttribute08 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityYesNoAttribute08 = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityYesNoAttribute08 = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityYesNoAttribute08;
                        break;
                    }

                case cygnet.BrowseNames.FacilityYesNoAttribute09:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityYesNoAttribute09 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityYesNoAttribute09 = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityYesNoAttribute09 = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityYesNoAttribute09;
                        break;
                    }

                case cygnet.BrowseNames.FacilityYesNoAttribute10:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityYesNoAttribute10 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityYesNoAttribute10 = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityYesNoAttribute10 = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityYesNoAttribute10;
                        break;
                    }

                case cygnet.BrowseNames.FacilityYesNoAttribute11:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityYesNoAttribute11 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityYesNoAttribute11 = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityYesNoAttribute11 = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityYesNoAttribute11;
                        break;
                    }

                case cygnet.BrowseNames.FacilityYesNoAttribute12:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityYesNoAttribute12 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityYesNoAttribute12 = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityYesNoAttribute12 = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityYesNoAttribute12;
                        break;
                    }

                case cygnet.BrowseNames.FacilityYesNoAttribute13:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityYesNoAttribute13 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityYesNoAttribute13 = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityYesNoAttribute13 = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityYesNoAttribute13;
                        break;
                    }

                case cygnet.BrowseNames.FacilityYesNoAttribute14:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityYesNoAttribute14 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityYesNoAttribute14 = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityYesNoAttribute14 = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityYesNoAttribute14;
                        break;
                    }

                case cygnet.BrowseNames.FacilityYesNoAttribute15:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityYesNoAttribute15 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityYesNoAttribute15 = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityYesNoAttribute15 = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityYesNoAttribute15;
                        break;
                    }

                case cygnet.BrowseNames.FacilityYesNoAttribute16:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityYesNoAttribute16 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityYesNoAttribute16 = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityYesNoAttribute16 = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityYesNoAttribute16;
                        break;
                    }

                case cygnet.BrowseNames.FacilityYesNoAttribute17:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityYesNoAttribute17 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityYesNoAttribute17 = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityYesNoAttribute17 = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityYesNoAttribute17;
                        break;
                    }

                case cygnet.BrowseNames.FacilityYesNoAttribute18:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityYesNoAttribute18 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityYesNoAttribute18 = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityYesNoAttribute18 = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityYesNoAttribute18;
                        break;
                    }

                case cygnet.BrowseNames.FacilityYesNoAttribute19:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityYesNoAttribute19 == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityYesNoAttribute19 = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    FacilityYesNoAttribute19 = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = FacilityYesNoAttribute19;
                        break;
                    }

                case cygnet.BrowseNames.FacilityTag:
                    {
                        if (createOrReplace)
                        {
                            if (FacilityTag == null)
                            {
                                if (replacement == null)
                                {
                                    FacilityTag = new PropertyState<string>(this);
                                }
                                else
                                {
                                    FacilityTag = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = FacilityTag;
                        break;
                    }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_facilitySiteService;
        private PropertyState<string> m_facilityId;
        private PropertyState<string> m_facilitySite;
        private PropertyState<string> m_facilityService;
        private PropertyState<string> m_facilityType;
        private PropertyState<string> m_facilityDescription;
        private PropertyState<string> m_facilityInfoAttribute0;
        private PropertyState<string> m_facilityInfoAttribute1;
        private PropertyState<string> m_facilityCategory;
        private PropertyState<bool> m_facilityIsActive;
        private PropertyState<string> m_facilitySecurityApplication;
        private PropertyState<string> m_facilityTextAttribute00;
        private PropertyState<string> m_facilityTextAttribute01;
        private PropertyState<string> m_facilityTextAttribute02;
        private PropertyState<string> m_facilityTextAttribute03;
        private PropertyState<string> m_facilityTextAttribute04;
        private PropertyState<string> m_facilityTextAttribute05;
        private PropertyState<string> m_facilityTextAttribute06;
        private PropertyState<string> m_facilityTextAttribute07;
        private PropertyState<string> m_facilityTextAttribute08;
        private PropertyState<string> m_facilityTextAttribute09;
        private PropertyState<string> m_facilityTextAttribute10;
        private PropertyState<string> m_facilityTextAttribute11;
        private PropertyState<string> m_facilityTextAttribute12;
        private PropertyState<string> m_facilityTextAttribute13;
        private PropertyState<string> m_facilityTextAttribute14;
        private PropertyState<string> m_facilityTextAttribute15;
        private PropertyState<string> m_facilityTextAttribute16;
        private PropertyState<string> m_facilityTextAttribute17;
        private PropertyState<string> m_facilityTextAttribute18;
        private PropertyState<string> m_facilityTextAttribute19;
        private PropertyState<string> m_facilityTextAttribute20;
        private PropertyState<string> m_facilityTextAttribute21;
        private PropertyState<string> m_facilityTextAttribute22;
        private PropertyState<string> m_facilityTextAttribute23;
        private PropertyState<string> m_facilityTextAttribute24;
        private PropertyState<string> m_facilityTextAttribute25;
        private PropertyState<string> m_facilityTextAttribute26;
        private PropertyState<string> m_facilityTextAttribute27;
        private PropertyState<string> m_facilityTextAttribute28;
        private PropertyState<string> m_facilityTextAttribute29;
        private PropertyState<string> m_facilityTextAttribute30;
        private PropertyState<string> m_facilityTextAttribute31;
        private PropertyState<string> m_facilityTextAttribute32;
        private PropertyState<string> m_facilityTextAttribute33;
        private PropertyState<string> m_facilityTextAttribute34;
        private PropertyState<string> m_facilityTextAttribute35;
        private PropertyState<string> m_facilityTextAttribute36;
        private PropertyState<string> m_facilityTextAttribute37;
        private PropertyState<string> m_facilityTextAttribute38;
        private PropertyState<string> m_facilityTextAttribute39;
        private PropertyState<string> m_facilityTableAttribute00;
        private PropertyState<string> m_facilityTableAttribute01;
        private PropertyState<string> m_facilityTableAttribute02;
        private PropertyState<string> m_facilityTableAttribute03;
        private PropertyState<string> m_facilityTableAttribute04;
        private PropertyState<string> m_facilityTableAttribute05;
        private PropertyState<string> m_facilityTableAttribute06;
        private PropertyState<string> m_facilityTableAttribute07;
        private PropertyState<string> m_facilityTableAttribute08;
        private PropertyState<string> m_facilityTableAttribute09;
        private PropertyState<string> m_facilityTableAttribute10;
        private PropertyState<string> m_facilityTableAttribute11;
        private PropertyState<string> m_facilityTableAttribute12;
        private PropertyState<string> m_facilityTableAttribute13;
        private PropertyState<string> m_facilityTableAttribute14;
        private PropertyState<string> m_facilityTableAttribute15;
        private PropertyState<string> m_facilityTableAttribute16;
        private PropertyState<string> m_facilityTableAttribute17;
        private PropertyState<string> m_facilityTableAttribute18;
        private PropertyState<string> m_facilityTableAttribute19;
        private PropertyState<string> m_facilityTableAttribute20;
        private PropertyState<string> m_facilityTableAttribute21;
        private PropertyState<string> m_facilityTableAttribute22;
        private PropertyState<string> m_facilityTableAttribute23;
        private PropertyState<string> m_facilityTableAttribute24;
        private PropertyState<string> m_facilityTableAttribute25;
        private PropertyState<string> m_facilityTableAttribute26;
        private PropertyState<string> m_facilityTableAttribute27;
        private PropertyState<string> m_facilityTableAttribute28;
        private PropertyState<string> m_facilityTableAttribute29;
        private PropertyState<string> m_facilityTableAttribute30;
        private PropertyState<string> m_facilityTableAttribute31;
        private PropertyState<string> m_facilityTableAttribute32;
        private PropertyState<string> m_facilityTableAttribute33;
        private PropertyState<string> m_facilityTableAttribute34;
        private PropertyState<string> m_facilityTableAttribute35;
        private PropertyState<string> m_facilityTableAttribute36;
        private PropertyState<string> m_facilityTableAttribute37;
        private PropertyState<string> m_facilityTableAttribute38;
        private PropertyState<string> m_facilityTableAttribute39;
        private PropertyState<string> m_facilityTableAttribute40;
        private PropertyState<string> m_facilityTableAttribute41;
        private PropertyState<string> m_facilityTableAttribute42;
        private PropertyState<string> m_facilityTableAttribute43;
        private PropertyState<string> m_facilityTableAttribute44;
        private PropertyState<string> m_facilityTableAttribute45;
        private PropertyState<string> m_facilityTableAttribute46;
        private PropertyState<string> m_facilityTableAttribute47;
        private PropertyState<string> m_facilityTableAttribute48;
        private PropertyState<string> m_facilityTableAttribute49;
        private PropertyState<string> m_facilityTableAttribute50;
        private PropertyState<string> m_facilityTableAttribute51;
        private PropertyState<string> m_facilityTableAttribute52;
        private PropertyState<string> m_facilityTableAttribute53;
        private PropertyState<string> m_facilityTableAttribute54;
        private PropertyState<string> m_facilityTableAttribute55;
        private PropertyState<string> m_facilityTableAttribute56;
        private PropertyState<string> m_facilityTableAttribute57;
        private PropertyState<string> m_facilityTableAttribute58;
        private PropertyState<string> m_facilityTableAttribute59;
        private PropertyState<string> m_facilityTableAttribute00Description;
        private PropertyState<string> m_facilityTableAttribute01Description;
        private PropertyState<string> m_facilityTableAttribute02Description;
        private PropertyState<string> m_facilityTableAttribute03Description;
        private PropertyState<string> m_facilityTableAttribute04Description;
        private PropertyState<string> m_facilityTableAttribute05Description;
        private PropertyState<string> m_facilityTableAttribute06Description;
        private PropertyState<string> m_facilityTableAttribute07Description;
        private PropertyState<string> m_facilityTableAttribute08Description;
        private PropertyState<string> m_facilityTableAttribute09Description;
        private PropertyState<string> m_facilityTableAttribute10Description;
        private PropertyState<string> m_facilityTableAttribute11Description;
        private PropertyState<string> m_facilityTableAttribute12Description;
        private PropertyState<string> m_facilityTableAttribute13Description;
        private PropertyState<string> m_facilityTableAttribute14Description;
        private PropertyState<string> m_facilityTableAttribute15Description;
        private PropertyState<string> m_facilityTableAttribute16Description;
        private PropertyState<string> m_facilityTableAttribute17Description;
        private PropertyState<string> m_facilityTableAttribute18Description;
        private PropertyState<string> m_facilityTableAttribute19Description;
        private PropertyState<string> m_facilityTableAttribute20Description;
        private PropertyState<string> m_facilityTableAttribute21Description;
        private PropertyState<string> m_facilityTableAttribute22Description;
        private PropertyState<string> m_facilityTableAttribute23Description;
        private PropertyState<string> m_facilityTableAttribute24Description;
        private PropertyState<string> m_facilityTableAttribute25Description;
        private PropertyState<string> m_facilityTableAttribute26Description;
        private PropertyState<string> m_facilityTableAttribute27Description;
        private PropertyState<string> m_facilityTableAttribute28Description;
        private PropertyState<string> m_facilityTableAttribute29Description;
        private PropertyState<string> m_facilityTableAttribute30Description;
        private PropertyState<string> m_facilityTableAttribute31Description;
        private PropertyState<string> m_facilityTableAttribute32Description;
        private PropertyState<string> m_facilityTableAttribute33Description;
        private PropertyState<string> m_facilityTableAttribute34Description;
        private PropertyState<string> m_facilityTableAttribute35Description;
        private PropertyState<string> m_facilityTableAttribute36Description;
        private PropertyState<string> m_facilityTableAttribute37Description;
        private PropertyState<string> m_facilityTableAttribute38Description;
        private PropertyState<string> m_facilityTableAttribute39Description;
        private PropertyState<string> m_facilityTableAttribute40Description;
        private PropertyState<string> m_facilityTableAttribute41Description;
        private PropertyState<string> m_facilityTableAttribute42Description;
        private PropertyState<string> m_facilityTableAttribute43Description;
        private PropertyState<string> m_facilityTableAttribute44Description;
        private PropertyState<string> m_facilityTableAttribute45Description;
        private PropertyState<string> m_facilityTableAttribute46Description;
        private PropertyState<string> m_facilityTableAttribute47Description;
        private PropertyState<string> m_facilityTableAttribute48Description;
        private PropertyState<string> m_facilityTableAttribute49Description;
        private PropertyState<string> m_facilityTableAttribute50Description;
        private PropertyState<string> m_facilityTableAttribute51Description;
        private PropertyState<string> m_facilityTableAttribute52Description;
        private PropertyState<string> m_facilityTableAttribute53Description;
        private PropertyState<string> m_facilityTableAttribute54Description;
        private PropertyState<string> m_facilityTableAttribute55Description;
        private PropertyState<string> m_facilityTableAttribute56Description;
        private PropertyState<string> m_facilityTableAttribute57Description;
        private PropertyState<string> m_facilityTableAttribute58Description;
        private PropertyState<string> m_facilityTableAttribute59Description;
        private PropertyState<bool> m_facilityYesNoAttribute00;
        private PropertyState<bool> m_facilityYesNoAttribute01;
        private PropertyState<bool> m_facilityYesNoAttribute02;
        private PropertyState<bool> m_facilityYesNoAttribute03;
        private PropertyState<bool> m_facilityYesNoAttribute04;
        private PropertyState<bool> m_facilityYesNoAttribute05;
        private PropertyState<bool> m_facilityYesNoAttribute06;
        private PropertyState<bool> m_facilityYesNoAttribute07;
        private PropertyState<bool> m_facilityYesNoAttribute08;
        private PropertyState<bool> m_facilityYesNoAttribute09;
        private PropertyState<bool> m_facilityYesNoAttribute10;
        private PropertyState<bool> m_facilityYesNoAttribute11;
        private PropertyState<bool> m_facilityYesNoAttribute12;
        private PropertyState<bool> m_facilityYesNoAttribute13;
        private PropertyState<bool> m_facilityYesNoAttribute14;
        private PropertyState<bool> m_facilityYesNoAttribute15;
        private PropertyState<bool> m_facilityYesNoAttribute16;
        private PropertyState<bool> m_facilityYesNoAttribute17;
        private PropertyState<bool> m_facilityYesNoAttribute18;
        private PropertyState<bool> m_facilityYesNoAttribute19;
        private PropertyState<string> m_facilityTag;
        #endregion
    }
#endif
    #endregion

    #region PointConfigurationState Class
#if (!OPCUA_EXCLUDE_PointConfigurationState)
    /// <summary>
    /// Stores an instance of the PointConfigurationType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PointConfigurationState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PointConfigurationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(cygnet.ObjectTypes.PointConfigurationType, cygnet.Namespaces.cygnet, namespaceUris);
        }

#if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACIAAABodHRwczovL3dlYXRoZXJmb3JkLmNvbS9VQS9jeWduZXQv/////4RggAIBAAAAAQAeAAAA" +
           "UG9pbnRDb25maWd1cmF0aW9uVHlwZUluc3RhbmNlAQFcOwEBXDtcOwAAAf////82AAAANWCJCgIAAAAB" +
           "ABAAAABQb2ludERlc2NyaXB0aW9uAQFdOwMAAAAAEAAAAFBvaW50RGVzY3JpcHRpb24ALgBEXTsAAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAEABQAAAFVuaXRzAQFeOwMAAAAABQAAAFVuaXRzAC4ARF47AAAA" +
           "DP////8BAf////8AAAAANWCJCgIAAAABAA4AAABBbHRlcm5hdGVVbml0cwEBXzsDAAAAAA4AAABBbHRl" +
           "cm5hdGVVbml0cwAuAERfOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQADAAAAVGFnAQFgOwMAAAAA" +
           "AwAAAFRhZwAuAERgOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAHAAAAVGFnTG9uZwEBYTsDAAAA" +
           "AAcAAABUYWdMb25nAC4ARGE7AAAADP////8BAf////8AAAAANWCJCgIAAAABAAcAAABUYWdGdWxsAQFi" +
           "OwMAAAAABwAAAFRhZ0Z1bGwALgBEYjsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEABwAAAFBvaW50" +
           "SWQBAWM7AwAAAAAHAAAAUG9pbnRJZAAuAERjOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQALAAAA" +
           "UG9pbnRJZExvbmcBAWQ7AwAAAAALAAAAUG9pbnRJZExvbmcALgBEZDsAAAAM/////wEB/////wAAAAA1" +
           "YIkKAgAAAAEACwAAAFNpdGVTZXJ2aWNlAQFlOwMAAAAACwAAAFNpdGVTZXJ2aWNlAC4ARGU7AAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAABAAQAAABTaXRlAQFmOwMAAAAABAAAAFNpdGUALgBEZjsAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAEABwAAAFNlcnZpY2UBAWc7AwAAAAAHAAAAU2VydmljZQAuAERnOwAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAQAIAAAARmFjaWxpdHkBAWg7AwAAAAAIAAAARmFjaWxpdHkA" +
           "LgBEaDsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAAwAAAFVEQwEBaTsDAAAAAAMAAABVREMALgBE" +
           "aTsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEADgAAAFVEQ0Rlc2NyaXB0aW9uAQFqOwMAAAAADgAA" +
           "AFVEQ0Rlc2NyaXB0aW9uAC4ARGo7AAAADP////8BAf////8AAAAANWCJCgIAAAABAAYAAABTeXN0ZW0B" +
           "AWs7AwAAAAAGAAAAU3lzdGVtAC4ARGs7AAAADP////8BAf////8AAAAANWCJCgIAAAABABEAAABTeXN0" +
           "ZW1EZXNjcmlwdGlvbgEBbDsDAAAAABEAAABTeXN0ZW1EZXNjcmlwdGlvbgAuAERsOwAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAQANAAAAUG9pbnREYXRhVHlwZQEBbTsDAAAAAA0AAABQb2ludERhdGFUeXBl" +
           "AC4ARG07AAAADP////8BAf////8AAAAANWCJCgIAAAABABgAAABQb2ludERhdGFUeXBlRGVzY3JpcHRp" +
           "b24BAW47AwAAAAAYAAAAUG9pbnREYXRhVHlwZURlc2NyaXB0aW9uAC4ARG47AAAADP////8BAf////8A" +
           "AAAANWCJCgIAAAABAAcAAABDb21tZW50AQFvOwMAAAAABwAAAENvbW1lbnQALgBEbzsAAAAM/////wEB" +
           "/////wAAAAA1YIkKAgAAAAEADQAAAEFsYXJtQ2F0ZWdvcnkBAXA7AwAAAAANAAAAQWxhcm1DYXRlZ29y" +
           "eQAuAERwOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAYAAAAQWxhcm1DYXRlZ29yeURlc2NyaXB0" +
           "aW9uAQFxOwMAAAAAGAAAAEFsYXJtQ2F0ZWdvcnlEZXNjcmlwdGlvbgAuAERxOwAAAAz/////AQH/////" +
           "AAAAADVgiQoCAAAAAQAPAAAAQW55VmVyaWZpZWRGbGFnAQFyOwMAAAAADwAAAEFueVZlcmlmaWVkRmxh" +
           "ZwAuAERyOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQANAAAAVmVyaWZpZWRGbGFnMQEBczsDAAAA" +
           "AA0AAABWZXJpZmllZEZsYWcxAC4ARHM7AAAADP////8BAf////8AAAAANWCJCgIAAAABAA0AAABWZXJp" +
           "ZmllZEZsYWcyAQF0OwMAAAAADQAAAFZlcmlmaWVkRmxhZzIALgBEdDsAAAAM/////wEB/////wAAAAA1" +
           "YIkKAgAAAAEADQAAAFZlcmlmaWVkRmxhZzMBAXU7AwAAAAANAAAAVmVyaWZpZWRGbGFnMwAuAER1OwAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAQANAAAAVmVyaWZpZWRGbGFnNAEBdjsDAAAAAA0AAABWZXJp" +
           "ZmllZEZsYWc0AC4ARHY7AAAADP////8BAf////8AAAAANWCJCgIAAAABABEAAABWZXJpZmllZFRpbWVz" +
           "dGFtcAEBdzsDAAAAABEAAABWZXJpZmllZFRpbWVzdGFtcAAuAER3OwAAAAz/////AQH/////AAAAADVg" +
           "iQoCAAAAAQAQAAAAUXVlc3Rpb25hYmxlRmxhZwEBeDsDAAAAABAAAABRdWVzdGlvbmFibGVGbGFnAC4A" +
           "RHg7AAAADP////8BAf////8AAAAANWCJCgIAAAABABUAAABRdWVzdGlvbmFibGVUaW1lc3RhbXABAXk7" +
           "AwAAAAAVAAAAUXVlc3Rpb25hYmxlVGltZXN0YW1wAC4ARHk7AAAADP////8BAf////8AAAAANWCJCgIA" +
           "AAABAAsAAABBbnlVc2VyRmxhZwEBejsDAAAAAAsAAABBbnlVc2VyRmxhZwAuAER6OwAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAQAJAAAAVXNlckZsYWcxAQF7OwMAAAAACQAAAFVzZXJGbGFnMQAuAER7OwAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAQAJAAAAVXNlckZsYWcyAQF8OwMAAAAACQAAAFVzZXJGbGFn" +
           "MgAuAER8OwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAJAAAAVXNlckZsYWczAQF9OwMAAAAACQAA" +
           "AFVzZXJGbGFnMwAuAER9OwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAJAAAAVXNlckZsYWc0AQF+" +
           "OwMAAAAACQAAAFVzZXJGbGFnNAAuAER+OwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAJAAAAVXNl" +
           "ckZsYWc1AQF/OwMAAAAACQAAAFVzZXJGbGFnNQAuAER/OwAAAAz/////AQH/////AAAAADVgiQoCAAAA" +
           "AQAJAAAAVXNlckZsYWc2AQGAOwMAAAAACQAAAFVzZXJGbGFnNgAuAESAOwAAAAz/////AQH/////AAAA" +
           "ADVgiQoCAAAAAQAJAAAAVXNlckZsYWc3AQGBOwMAAAAACQAAAFVzZXJGbGFnNwAuAESBOwAAAAz/////" +
           "AQH/////AAAAADVgiQoCAAAAAQAJAAAAVXNlckZsYWc4AQGCOwMAAAAACQAAAFVzZXJGbGFnOAAuAESC" +
           "OwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAIAAAASW5kZXhlZDEBAYM7AwAAAAAIAAAASW5kZXhl" +
           "ZDEALgBEgzsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEACAAAAEluZGV4ZWQyAQGEOwMAAAAACAAA" +
           "AEluZGV4ZWQyAC4ARIQ7AAAADP////8BAf////8AAAAANWCJCgIAAAABAAgAAABJbmRleGVkMwEBhTsD" +
           "AAAAAAgAAABJbmRleGVkMwAuAESFOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAMAAAAVGFibGVE" +
           "cml2ZW4xAQGGOwMAAAAADAAAAFRhYmxlRHJpdmVuMQAuAESGOwAAAAz/////AQH/////AAAAADVgiQoC" +
           "AAAAAQAMAAAAVGFibGVEcml2ZW4yAQGHOwMAAAAADAAAAFRhYmxlRHJpdmVuMgAuAESHOwAAAAz/////" +
           "AQH/////AAAAADVgiQoCAAAAAQAMAAAAVGFibGVEcml2ZW4zAQGIOwMAAAAADAAAAFRhYmxlRHJpdmVu" +
           "MwAuAESIOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAMAAAAR2VuZXJhbERhdGExAQGJOwMAAAAA" +
           "DAAAAEdlbmVyYWxEYXRhMQAuAESJOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAMAAAAR2VuZXJh" +
           "bERhdGEyAQGKOwMAAAAADAAAAEdlbmVyYWxEYXRhMgAuAESKOwAAAAz/////AQH/////AAAAADVgiQoC" +
           "AAAAAQAMAAAAR2VuZXJhbERhdGEzAQGLOwMAAAAADAAAAEdlbmVyYWxEYXRhMwAuAESLOwAAAAz/////" +
           "AQH/////AAAAADVgiQoCAAAAAQAXAAAAVGFibGVEcml2ZW4xRGVzY3JpcHRpb24BAYw7AwAAAAAXAAAA" +
           "VGFibGVEcml2ZW4xRGVzY3JpcHRpb24ALgBEjDsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAFwAA" +
           "AFRhYmxlRHJpdmVuMkRlc2NyaXB0aW9uAQGNOwMAAAAAFwAAAFRhYmxlRHJpdmVuMkRlc2NyaXB0aW9u" +
           "AC4ARI07AAAADP////8BAf////8AAAAANWCJCgIAAAABABcAAABUYWJsZURyaXZlbjNEZXNjcmlwdGlv" +
           "bgEBjjsDAAAAABcAAABUYWJsZURyaXZlbjNEZXNjcmlwdGlvbgAuAESOOwAAAAz/////AQH/////AAAA" +
           "ADVgiQoCAAAAAQAPAAAATG9uZ0Rlc2NyaXB0aW9uAQGPOwMAAAAADwAAAExvbmdEZXNjcmlwdGlvbgAu" +
           "AESPOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQALAAAAUG9pbnRTY2hlbWUBAZA7AwAAAAALAAAA" +
           "UG9pbnRTY2hlbWUALgBEkDsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAFgAAAFBvaW50U2NoZW1l" +
           "RGVzY3JpcHRpb24BAZE7AwAAAAAWAAAAUG9pbnRTY2hlbWVEZXNjcmlwdGlvbgAuAESROwAAAAz/////" +
           "AQH/////AAAAADVgiQoCAAAAAQAKAAAARXh0ZXJuYWxJZAEBkjsDAAAAAAoAAABFeHRlcm5hbElkAC4A" +
           "RJI7AAAADP////8BAf////8AAAAA";
        #endregion
#endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> PointDescription
        {
            get
            {
                return m_pointDescription;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pointDescription, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pointDescription = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Units
        {
            get
            {
                return m_units;
            }

            set
            {
                if (!Object.ReferenceEquals(m_units, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_units = value;
            }
        }

        /// <remarks />
        public PropertyState<string> AlternateUnits
        {
            get
            {
                return m_alternateUnits;
            }

            set
            {
                if (!Object.ReferenceEquals(m_alternateUnits, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_alternateUnits = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Tag
        {
            get
            {
                return m_tag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tag = value;
            }
        }

        /// <remarks />
        public PropertyState<string> TagLong
        {
            get
            {
                return m_tagLong;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tagLong, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tagLong = value;
            }
        }

        /// <remarks />
        public PropertyState<string> TagFull
        {
            get
            {
                return m_tagFull;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tagFull, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tagFull = value;
            }
        }

        /// <remarks />
        public PropertyState<string> PointId
        {
            get
            {
                return m_pointId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pointId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pointId = value;
            }
        }

        /// <remarks />
        public PropertyState<string> PointIdLong
        {
            get
            {
                return m_pointIdLong;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pointIdLong, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pointIdLong = value;
            }
        }

        /// <remarks />
        public PropertyState<string> SiteService
        {
            get
            {
                return m_siteService;
            }

            set
            {
                if (!Object.ReferenceEquals(m_siteService, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_siteService = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Site
        {
            get
            {
                return m_site;
            }

            set
            {
                if (!Object.ReferenceEquals(m_site, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_site = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Service
        {
            get
            {
                return m_service;
            }

            set
            {
                if (!Object.ReferenceEquals(m_service, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_service = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Facility
        {
            get
            {
                return m_facility;
            }

            set
            {
                if (!Object.ReferenceEquals(m_facility, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_facility = value;
            }
        }

        /// <remarks />
        public PropertyState<string> UDC
        {
            get
            {
                return m_uDC;
            }

            set
            {
                if (!Object.ReferenceEquals(m_uDC, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_uDC = value;
            }
        }

        /// <remarks />
        public PropertyState<string> UDCDescription
        {
            get
            {
                return m_uDCDescription;
            }

            set
            {
                if (!Object.ReferenceEquals(m_uDCDescription, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_uDCDescription = value;
            }
        }

        /// <remarks />
        public PropertyState<string> System
        {
            get
            {
                return m_system;
            }

            set
            {
                if (!Object.ReferenceEquals(m_system, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_system = value;
            }
        }

        /// <remarks />
        public PropertyState<string> SystemDescription
        {
            get
            {
                return m_systemDescription;
            }

            set
            {
                if (!Object.ReferenceEquals(m_systemDescription, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_systemDescription = value;
            }
        }

        /// <remarks />
        public PropertyState<string> PointDataType
        {
            get
            {
                return m_pointDataType;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pointDataType, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pointDataType = value;
            }
        }

        /// <remarks />
        public PropertyState<string> PointDataTypeDescription
        {
            get
            {
                return m_pointDataTypeDescription;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pointDataTypeDescription, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pointDataTypeDescription = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Comment
        {
            get
            {
                return m_comment;
            }

            set
            {
                if (!Object.ReferenceEquals(m_comment, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_comment = value;
            }
        }

        /// <remarks />
        public PropertyState<string> AlarmCategory
        {
            get
            {
                return m_alarmCategory;
            }

            set
            {
                if (!Object.ReferenceEquals(m_alarmCategory, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_alarmCategory = value;
            }
        }

        /// <remarks />
        public PropertyState<string> AlarmCategoryDescription
        {
            get
            {
                return m_alarmCategoryDescription;
            }

            set
            {
                if (!Object.ReferenceEquals(m_alarmCategoryDescription, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_alarmCategoryDescription = value;
            }
        }

        /// <remarks />
        public PropertyState<string> AnyVerifiedFlag
        {
            get
            {
                return m_anyVerifiedFlag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_anyVerifiedFlag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_anyVerifiedFlag = value;
            }
        }

        /// <remarks />
        public PropertyState<string> VerifiedFlag1
        {
            get
            {
                return m_verifiedFlag1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_verifiedFlag1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_verifiedFlag1 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> VerifiedFlag2
        {
            get
            {
                return m_verifiedFlag2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_verifiedFlag2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_verifiedFlag2 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> VerifiedFlag3
        {
            get
            {
                return m_verifiedFlag3;
            }

            set
            {
                if (!Object.ReferenceEquals(m_verifiedFlag3, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_verifiedFlag3 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> VerifiedFlag4
        {
            get
            {
                return m_verifiedFlag4;
            }

            set
            {
                if (!Object.ReferenceEquals(m_verifiedFlag4, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_verifiedFlag4 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> VerifiedTimestamp
        {
            get
            {
                return m_verifiedTimestamp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_verifiedTimestamp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_verifiedTimestamp = value;
            }
        }

        /// <remarks />
        public PropertyState<string> QuestionableFlag
        {
            get
            {
                return m_questionableFlag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_questionableFlag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_questionableFlag = value;
            }
        }

        /// <remarks />
        public PropertyState<string> QuestionableTimestamp
        {
            get
            {
                return m_questionableTimestamp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_questionableTimestamp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_questionableTimestamp = value;
            }
        }

        /// <remarks />
        public PropertyState<string> AnyUserFlag
        {
            get
            {
                return m_anyUserFlag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_anyUserFlag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_anyUserFlag = value;
            }
        }

        /// <remarks />
        public PropertyState<string> UserFlag1
        {
            get
            {
                return m_userFlag1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_userFlag1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_userFlag1 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> UserFlag2
        {
            get
            {
                return m_userFlag2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_userFlag2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_userFlag2 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> UserFlag3
        {
            get
            {
                return m_userFlag3;
            }

            set
            {
                if (!Object.ReferenceEquals(m_userFlag3, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_userFlag3 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> UserFlag4
        {
            get
            {
                return m_userFlag4;
            }

            set
            {
                if (!Object.ReferenceEquals(m_userFlag4, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_userFlag4 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> UserFlag5
        {
            get
            {
                return m_userFlag5;
            }

            set
            {
                if (!Object.ReferenceEquals(m_userFlag5, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_userFlag5 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> UserFlag6
        {
            get
            {
                return m_userFlag6;
            }

            set
            {
                if (!Object.ReferenceEquals(m_userFlag6, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_userFlag6 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> UserFlag7
        {
            get
            {
                return m_userFlag7;
            }

            set
            {
                if (!Object.ReferenceEquals(m_userFlag7, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_userFlag7 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> UserFlag8
        {
            get
            {
                return m_userFlag8;
            }

            set
            {
                if (!Object.ReferenceEquals(m_userFlag8, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_userFlag8 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Indexed1
        {
            get
            {
                return m_indexed1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_indexed1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_indexed1 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Indexed2
        {
            get
            {
                return m_indexed2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_indexed2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_indexed2 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Indexed3
        {
            get
            {
                return m_indexed3;
            }

            set
            {
                if (!Object.ReferenceEquals(m_indexed3, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_indexed3 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> TableDriven1
        {
            get
            {
                return m_tableDriven1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tableDriven1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tableDriven1 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> TableDriven2
        {
            get
            {
                return m_tableDriven2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tableDriven2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tableDriven2 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> TableDriven3
        {
            get
            {
                return m_tableDriven3;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tableDriven3, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tableDriven3 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> GeneralData1
        {
            get
            {
                return m_generalData1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_generalData1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_generalData1 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> GeneralData2
        {
            get
            {
                return m_generalData2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_generalData2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_generalData2 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> GeneralData3
        {
            get
            {
                return m_generalData3;
            }

            set
            {
                if (!Object.ReferenceEquals(m_generalData3, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_generalData3 = value;
            }
        }

        /// <remarks />
        public PropertyState<string> TableDriven1Description
        {
            get
            {
                return m_tableDriven1Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tableDriven1Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tableDriven1Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> TableDriven2Description
        {
            get
            {
                return m_tableDriven2Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tableDriven2Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tableDriven2Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> TableDriven3Description
        {
            get
            {
                return m_tableDriven3Description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tableDriven3Description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tableDriven3Description = value;
            }
        }

        /// <remarks />
        public PropertyState<string> LongDescription
        {
            get
            {
                return m_longDescription;
            }

            set
            {
                if (!Object.ReferenceEquals(m_longDescription, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_longDescription = value;
            }
        }

        /// <remarks />
        public PropertyState<string> PointScheme
        {
            get
            {
                return m_pointScheme;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pointScheme, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pointScheme = value;
            }
        }

        /// <remarks />
        public PropertyState<string> PointSchemeDescription
        {
            get
            {
                return m_pointSchemeDescription;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pointSchemeDescription, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pointSchemeDescription = value;
            }
        }

        /// <remarks />
        public PropertyState<string> ExternalId
        {
            get
            {
                return m_externalId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_externalId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_externalId = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_pointDescription != null)
            {
                children.Add(m_pointDescription);
            }

            if (m_units != null)
            {
                children.Add(m_units);
            }

            if (m_alternateUnits != null)
            {
                children.Add(m_alternateUnits);
            }

            if (m_tag != null)
            {
                children.Add(m_tag);
            }

            if (m_tagLong != null)
            {
                children.Add(m_tagLong);
            }

            if (m_tagFull != null)
            {
                children.Add(m_tagFull);
            }

            if (m_pointId != null)
            {
                children.Add(m_pointId);
            }

            if (m_pointIdLong != null)
            {
                children.Add(m_pointIdLong);
            }

            if (m_siteService != null)
            {
                children.Add(m_siteService);
            }

            if (m_site != null)
            {
                children.Add(m_site);
            }

            if (m_service != null)
            {
                children.Add(m_service);
            }

            if (m_facility != null)
            {
                children.Add(m_facility);
            }

            if (m_uDC != null)
            {
                children.Add(m_uDC);
            }

            if (m_uDCDescription != null)
            {
                children.Add(m_uDCDescription);
            }

            if (m_system != null)
            {
                children.Add(m_system);
            }

            if (m_systemDescription != null)
            {
                children.Add(m_systemDescription);
            }

            if (m_pointDataType != null)
            {
                children.Add(m_pointDataType);
            }

            if (m_pointDataTypeDescription != null)
            {
                children.Add(m_pointDataTypeDescription);
            }

            if (m_comment != null)
            {
                children.Add(m_comment);
            }

            if (m_alarmCategory != null)
            {
                children.Add(m_alarmCategory);
            }

            if (m_alarmCategoryDescription != null)
            {
                children.Add(m_alarmCategoryDescription);
            }

            if (m_anyVerifiedFlag != null)
            {
                children.Add(m_anyVerifiedFlag);
            }

            if (m_verifiedFlag1 != null)
            {
                children.Add(m_verifiedFlag1);
            }

            if (m_verifiedFlag2 != null)
            {
                children.Add(m_verifiedFlag2);
            }

            if (m_verifiedFlag3 != null)
            {
                children.Add(m_verifiedFlag3);
            }

            if (m_verifiedFlag4 != null)
            {
                children.Add(m_verifiedFlag4);
            }

            if (m_verifiedTimestamp != null)
            {
                children.Add(m_verifiedTimestamp);
            }

            if (m_questionableFlag != null)
            {
                children.Add(m_questionableFlag);
            }

            if (m_questionableTimestamp != null)
            {
                children.Add(m_questionableTimestamp);
            }

            if (m_anyUserFlag != null)
            {
                children.Add(m_anyUserFlag);
            }

            if (m_userFlag1 != null)
            {
                children.Add(m_userFlag1);
            }

            if (m_userFlag2 != null)
            {
                children.Add(m_userFlag2);
            }

            if (m_userFlag3 != null)
            {
                children.Add(m_userFlag3);
            }

            if (m_userFlag4 != null)
            {
                children.Add(m_userFlag4);
            }

            if (m_userFlag5 != null)
            {
                children.Add(m_userFlag5);
            }

            if (m_userFlag6 != null)
            {
                children.Add(m_userFlag6);
            }

            if (m_userFlag7 != null)
            {
                children.Add(m_userFlag7);
            }

            if (m_userFlag8 != null)
            {
                children.Add(m_userFlag8);
            }

            if (m_indexed1 != null)
            {
                children.Add(m_indexed1);
            }

            if (m_indexed2 != null)
            {
                children.Add(m_indexed2);
            }

            if (m_indexed3 != null)
            {
                children.Add(m_indexed3);
            }

            if (m_tableDriven1 != null)
            {
                children.Add(m_tableDriven1);
            }

            if (m_tableDriven2 != null)
            {
                children.Add(m_tableDriven2);
            }

            if (m_tableDriven3 != null)
            {
                children.Add(m_tableDriven3);
            }

            if (m_generalData1 != null)
            {
                children.Add(m_generalData1);
            }

            if (m_generalData2 != null)
            {
                children.Add(m_generalData2);
            }

            if (m_generalData3 != null)
            {
                children.Add(m_generalData3);
            }

            if (m_tableDriven1Description != null)
            {
                children.Add(m_tableDriven1Description);
            }

            if (m_tableDriven2Description != null)
            {
                children.Add(m_tableDriven2Description);
            }

            if (m_tableDriven3Description != null)
            {
                children.Add(m_tableDriven3Description);
            }

            if (m_longDescription != null)
            {
                children.Add(m_longDescription);
            }

            if (m_pointScheme != null)
            {
                children.Add(m_pointScheme);
            }

            if (m_pointSchemeDescription != null)
            {
                children.Add(m_pointSchemeDescription);
            }

            if (m_externalId != null)
            {
                children.Add(m_externalId);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case cygnet.BrowseNames.PointDescription:
                    {
                        if (createOrReplace)
                        {
                            if (PointDescription == null)
                            {
                                if (replacement == null)
                                {
                                    PointDescription = new PropertyState<string>(this);
                                }
                                else
                                {
                                    PointDescription = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = PointDescription;
                        break;
                    }

                case cygnet.BrowseNames.Units:
                    {
                        if (createOrReplace)
                        {
                            if (Units == null)
                            {
                                if (replacement == null)
                                {
                                    Units = new PropertyState<string>(this);
                                }
                                else
                                {
                                    Units = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = Units;
                        break;
                    }

                case cygnet.BrowseNames.AlternateUnits:
                    {
                        if (createOrReplace)
                        {
                            if (AlternateUnits == null)
                            {
                                if (replacement == null)
                                {
                                    AlternateUnits = new PropertyState<string>(this);
                                }
                                else
                                {
                                    AlternateUnits = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = AlternateUnits;
                        break;
                    }

                case cygnet.BrowseNames.Tag:
                    {
                        if (createOrReplace)
                        {
                            if (Tag == null)
                            {
                                if (replacement == null)
                                {
                                    Tag = new PropertyState<string>(this);
                                }
                                else
                                {
                                    Tag = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = Tag;
                        break;
                    }

                case cygnet.BrowseNames.TagLong:
                    {
                        if (createOrReplace)
                        {
                            if (TagLong == null)
                            {
                                if (replacement == null)
                                {
                                    TagLong = new PropertyState<string>(this);
                                }
                                else
                                {
                                    TagLong = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = TagLong;
                        break;
                    }

                case cygnet.BrowseNames.TagFull:
                    {
                        if (createOrReplace)
                        {
                            if (TagFull == null)
                            {
                                if (replacement == null)
                                {
                                    TagFull = new PropertyState<string>(this);
                                }
                                else
                                {
                                    TagFull = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = TagFull;
                        break;
                    }

                case cygnet.BrowseNames.PointId:
                    {
                        if (createOrReplace)
                        {
                            if (PointId == null)
                            {
                                if (replacement == null)
                                {
                                    PointId = new PropertyState<string>(this);
                                }
                                else
                                {
                                    PointId = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = PointId;
                        break;
                    }

                case cygnet.BrowseNames.PointIdLong:
                    {
                        if (createOrReplace)
                        {
                            if (PointIdLong == null)
                            {
                                if (replacement == null)
                                {
                                    PointIdLong = new PropertyState<string>(this);
                                }
                                else
                                {
                                    PointIdLong = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = PointIdLong;
                        break;
                    }

                case cygnet.BrowseNames.SiteService:
                    {
                        if (createOrReplace)
                        {
                            if (SiteService == null)
                            {
                                if (replacement == null)
                                {
                                    SiteService = new PropertyState<string>(this);
                                }
                                else
                                {
                                    SiteService = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = SiteService;
                        break;
                    }

                case cygnet.BrowseNames.Site:
                    {
                        if (createOrReplace)
                        {
                            if (Site == null)
                            {
                                if (replacement == null)
                                {
                                    Site = new PropertyState<string>(this);
                                }
                                else
                                {
                                    Site = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = Site;
                        break;
                    }

                case cygnet.BrowseNames.Service:
                    {
                        if (createOrReplace)
                        {
                            if (Service == null)
                            {
                                if (replacement == null)
                                {
                                    Service = new PropertyState<string>(this);
                                }
                                else
                                {
                                    Service = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = Service;
                        break;
                    }

                case cygnet.BrowseNames.Facility:
                    {
                        if (createOrReplace)
                        {
                            if (Facility == null)
                            {
                                if (replacement == null)
                                {
                                    Facility = new PropertyState<string>(this);
                                }
                                else
                                {
                                    Facility = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = Facility;
                        break;
                    }

                case cygnet.BrowseNames.UDC:
                    {
                        if (createOrReplace)
                        {
                            if (UDC == null)
                            {
                                if (replacement == null)
                                {
                                    UDC = new PropertyState<string>(this);
                                }
                                else
                                {
                                    UDC = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = UDC;
                        break;
                    }

                case cygnet.BrowseNames.UDCDescription:
                    {
                        if (createOrReplace)
                        {
                            if (UDCDescription == null)
                            {
                                if (replacement == null)
                                {
                                    UDCDescription = new PropertyState<string>(this);
                                }
                                else
                                {
                                    UDCDescription = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = UDCDescription;
                        break;
                    }

                case cygnet.BrowseNames.System:
                    {
                        if (createOrReplace)
                        {
                            if (System == null)
                            {
                                if (replacement == null)
                                {
                                    System = new PropertyState<string>(this);
                                }
                                else
                                {
                                    System = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = System;
                        break;
                    }

                case cygnet.BrowseNames.SystemDescription:
                    {
                        if (createOrReplace)
                        {
                            if (SystemDescription == null)
                            {
                                if (replacement == null)
                                {
                                    SystemDescription = new PropertyState<string>(this);
                                }
                                else
                                {
                                    SystemDescription = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = SystemDescription;
                        break;
                    }

                case cygnet.BrowseNames.PointDataType:
                    {
                        if (createOrReplace)
                        {
                            if (PointDataType == null)
                            {
                                if (replacement == null)
                                {
                                    PointDataType = new PropertyState<string>(this);
                                }
                                else
                                {
                                    PointDataType = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = PointDataType;
                        break;
                    }

                case cygnet.BrowseNames.PointDataTypeDescription:
                    {
                        if (createOrReplace)
                        {
                            if (PointDataTypeDescription == null)
                            {
                                if (replacement == null)
                                {
                                    PointDataTypeDescription = new PropertyState<string>(this);
                                }
                                else
                                {
                                    PointDataTypeDescription = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = PointDataTypeDescription;
                        break;
                    }

                case cygnet.BrowseNames.Comment:
                    {
                        if (createOrReplace)
                        {
                            if (Comment == null)
                            {
                                if (replacement == null)
                                {
                                    Comment = new PropertyState<string>(this);
                                }
                                else
                                {
                                    Comment = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = Comment;
                        break;
                    }

                case cygnet.BrowseNames.AlarmCategory:
                    {
                        if (createOrReplace)
                        {
                            if (AlarmCategory == null)
                            {
                                if (replacement == null)
                                {
                                    AlarmCategory = new PropertyState<string>(this);
                                }
                                else
                                {
                                    AlarmCategory = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = AlarmCategory;
                        break;
                    }

                case cygnet.BrowseNames.AlarmCategoryDescription:
                    {
                        if (createOrReplace)
                        {
                            if (AlarmCategoryDescription == null)
                            {
                                if (replacement == null)
                                {
                                    AlarmCategoryDescription = new PropertyState<string>(this);
                                }
                                else
                                {
                                    AlarmCategoryDescription = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = AlarmCategoryDescription;
                        break;
                    }

                case cygnet.BrowseNames.AnyVerifiedFlag:
                    {
                        if (createOrReplace)
                        {
                            if (AnyVerifiedFlag == null)
                            {
                                if (replacement == null)
                                {
                                    AnyVerifiedFlag = new PropertyState<string>(this);
                                }
                                else
                                {
                                    AnyVerifiedFlag = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = AnyVerifiedFlag;
                        break;
                    }

                case cygnet.BrowseNames.VerifiedFlag1:
                    {
                        if (createOrReplace)
                        {
                            if (VerifiedFlag1 == null)
                            {
                                if (replacement == null)
                                {
                                    VerifiedFlag1 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    VerifiedFlag1 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = VerifiedFlag1;
                        break;
                    }

                case cygnet.BrowseNames.VerifiedFlag2:
                    {
                        if (createOrReplace)
                        {
                            if (VerifiedFlag2 == null)
                            {
                                if (replacement == null)
                                {
                                    VerifiedFlag2 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    VerifiedFlag2 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = VerifiedFlag2;
                        break;
                    }

                case cygnet.BrowseNames.VerifiedFlag3:
                    {
                        if (createOrReplace)
                        {
                            if (VerifiedFlag3 == null)
                            {
                                if (replacement == null)
                                {
                                    VerifiedFlag3 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    VerifiedFlag3 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = VerifiedFlag3;
                        break;
                    }

                case cygnet.BrowseNames.VerifiedFlag4:
                    {
                        if (createOrReplace)
                        {
                            if (VerifiedFlag4 == null)
                            {
                                if (replacement == null)
                                {
                                    VerifiedFlag4 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    VerifiedFlag4 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = VerifiedFlag4;
                        break;
                    }

                case cygnet.BrowseNames.VerifiedTimestamp:
                    {
                        if (createOrReplace)
                        {
                            if (VerifiedTimestamp == null)
                            {
                                if (replacement == null)
                                {
                                    VerifiedTimestamp = new PropertyState<string>(this);
                                }
                                else
                                {
                                    VerifiedTimestamp = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = VerifiedTimestamp;
                        break;
                    }

                case cygnet.BrowseNames.QuestionableFlag:
                    {
                        if (createOrReplace)
                        {
                            if (QuestionableFlag == null)
                            {
                                if (replacement == null)
                                {
                                    QuestionableFlag = new PropertyState<string>(this);
                                }
                                else
                                {
                                    QuestionableFlag = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = QuestionableFlag;
                        break;
                    }

                case cygnet.BrowseNames.QuestionableTimestamp:
                    {
                        if (createOrReplace)
                        {
                            if (QuestionableTimestamp == null)
                            {
                                if (replacement == null)
                                {
                                    QuestionableTimestamp = new PropertyState<string>(this);
                                }
                                else
                                {
                                    QuestionableTimestamp = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = QuestionableTimestamp;
                        break;
                    }

                case cygnet.BrowseNames.AnyUserFlag:
                    {
                        if (createOrReplace)
                        {
                            if (AnyUserFlag == null)
                            {
                                if (replacement == null)
                                {
                                    AnyUserFlag = new PropertyState<string>(this);
                                }
                                else
                                {
                                    AnyUserFlag = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = AnyUserFlag;
                        break;
                    }

                case cygnet.BrowseNames.UserFlag1:
                    {
                        if (createOrReplace)
                        {
                            if (UserFlag1 == null)
                            {
                                if (replacement == null)
                                {
                                    UserFlag1 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    UserFlag1 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = UserFlag1;
                        break;
                    }

                case cygnet.BrowseNames.UserFlag2:
                    {
                        if (createOrReplace)
                        {
                            if (UserFlag2 == null)
                            {
                                if (replacement == null)
                                {
                                    UserFlag2 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    UserFlag2 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = UserFlag2;
                        break;
                    }

                case cygnet.BrowseNames.UserFlag3:
                    {
                        if (createOrReplace)
                        {
                            if (UserFlag3 == null)
                            {
                                if (replacement == null)
                                {
                                    UserFlag3 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    UserFlag3 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = UserFlag3;
                        break;
                    }

                case cygnet.BrowseNames.UserFlag4:
                    {
                        if (createOrReplace)
                        {
                            if (UserFlag4 == null)
                            {
                                if (replacement == null)
                                {
                                    UserFlag4 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    UserFlag4 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = UserFlag4;
                        break;
                    }

                case cygnet.BrowseNames.UserFlag5:
                    {
                        if (createOrReplace)
                        {
                            if (UserFlag5 == null)
                            {
                                if (replacement == null)
                                {
                                    UserFlag5 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    UserFlag5 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = UserFlag5;
                        break;
                    }

                case cygnet.BrowseNames.UserFlag6:
                    {
                        if (createOrReplace)
                        {
                            if (UserFlag6 == null)
                            {
                                if (replacement == null)
                                {
                                    UserFlag6 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    UserFlag6 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = UserFlag6;
                        break;
                    }

                case cygnet.BrowseNames.UserFlag7:
                    {
                        if (createOrReplace)
                        {
                            if (UserFlag7 == null)
                            {
                                if (replacement == null)
                                {
                                    UserFlag7 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    UserFlag7 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = UserFlag7;
                        break;
                    }

                case cygnet.BrowseNames.UserFlag8:
                    {
                        if (createOrReplace)
                        {
                            if (UserFlag8 == null)
                            {
                                if (replacement == null)
                                {
                                    UserFlag8 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    UserFlag8 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = UserFlag8;
                        break;
                    }

                case cygnet.BrowseNames.Indexed1:
                    {
                        if (createOrReplace)
                        {
                            if (Indexed1 == null)
                            {
                                if (replacement == null)
                                {
                                    Indexed1 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    Indexed1 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = Indexed1;
                        break;
                    }

                case cygnet.BrowseNames.Indexed2:
                    {
                        if (createOrReplace)
                        {
                            if (Indexed2 == null)
                            {
                                if (replacement == null)
                                {
                                    Indexed2 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    Indexed2 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = Indexed2;
                        break;
                    }

                case cygnet.BrowseNames.Indexed3:
                    {
                        if (createOrReplace)
                        {
                            if (Indexed3 == null)
                            {
                                if (replacement == null)
                                {
                                    Indexed3 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    Indexed3 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = Indexed3;
                        break;
                    }

                case cygnet.BrowseNames.TableDriven1:
                    {
                        if (createOrReplace)
                        {
                            if (TableDriven1 == null)
                            {
                                if (replacement == null)
                                {
                                    TableDriven1 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    TableDriven1 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = TableDriven1;
                        break;
                    }

                case cygnet.BrowseNames.TableDriven2:
                    {
                        if (createOrReplace)
                        {
                            if (TableDriven2 == null)
                            {
                                if (replacement == null)
                                {
                                    TableDriven2 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    TableDriven2 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = TableDriven2;
                        break;
                    }

                case cygnet.BrowseNames.TableDriven3:
                    {
                        if (createOrReplace)
                        {
                            if (TableDriven3 == null)
                            {
                                if (replacement == null)
                                {
                                    TableDriven3 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    TableDriven3 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = TableDriven3;
                        break;
                    }

                case cygnet.BrowseNames.GeneralData1:
                    {
                        if (createOrReplace)
                        {
                            if (GeneralData1 == null)
                            {
                                if (replacement == null)
                                {
                                    GeneralData1 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    GeneralData1 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = GeneralData1;
                        break;
                    }

                case cygnet.BrowseNames.GeneralData2:
                    {
                        if (createOrReplace)
                        {
                            if (GeneralData2 == null)
                            {
                                if (replacement == null)
                                {
                                    GeneralData2 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    GeneralData2 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = GeneralData2;
                        break;
                    }

                case cygnet.BrowseNames.GeneralData3:
                    {
                        if (createOrReplace)
                        {
                            if (GeneralData3 == null)
                            {
                                if (replacement == null)
                                {
                                    GeneralData3 = new PropertyState<string>(this);
                                }
                                else
                                {
                                    GeneralData3 = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = GeneralData3;
                        break;
                    }

                case cygnet.BrowseNames.TableDriven1Description:
                    {
                        if (createOrReplace)
                        {
                            if (TableDriven1Description == null)
                            {
                                if (replacement == null)
                                {
                                    TableDriven1Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    TableDriven1Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = TableDriven1Description;
                        break;
                    }

                case cygnet.BrowseNames.TableDriven2Description:
                    {
                        if (createOrReplace)
                        {
                            if (TableDriven2Description == null)
                            {
                                if (replacement == null)
                                {
                                    TableDriven2Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    TableDriven2Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = TableDriven2Description;
                        break;
                    }

                case cygnet.BrowseNames.TableDriven3Description:
                    {
                        if (createOrReplace)
                        {
                            if (TableDriven3Description == null)
                            {
                                if (replacement == null)
                                {
                                    TableDriven3Description = new PropertyState<string>(this);
                                }
                                else
                                {
                                    TableDriven3Description = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = TableDriven3Description;
                        break;
                    }

                case cygnet.BrowseNames.LongDescription:
                    {
                        if (createOrReplace)
                        {
                            if (LongDescription == null)
                            {
                                if (replacement == null)
                                {
                                    LongDescription = new PropertyState<string>(this);
                                }
                                else
                                {
                                    LongDescription = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = LongDescription;
                        break;
                    }

                case cygnet.BrowseNames.PointScheme:
                    {
                        if (createOrReplace)
                        {
                            if (PointScheme == null)
                            {
                                if (replacement == null)
                                {
                                    PointScheme = new PropertyState<string>(this);
                                }
                                else
                                {
                                    PointScheme = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = PointScheme;
                        break;
                    }

                case cygnet.BrowseNames.PointSchemeDescription:
                    {
                        if (createOrReplace)
                        {
                            if (PointSchemeDescription == null)
                            {
                                if (replacement == null)
                                {
                                    PointSchemeDescription = new PropertyState<string>(this);
                                }
                                else
                                {
                                    PointSchemeDescription = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = PointSchemeDescription;
                        break;
                    }

                case cygnet.BrowseNames.ExternalId:
                    {
                        if (createOrReplace)
                        {
                            if (ExternalId == null)
                            {
                                if (replacement == null)
                                {
                                    ExternalId = new PropertyState<string>(this);
                                }
                                else
                                {
                                    ExternalId = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = ExternalId;
                        break;
                    }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_pointDescription;
        private PropertyState<string> m_units;
        private PropertyState<string> m_alternateUnits;
        private PropertyState<string> m_tag;
        private PropertyState<string> m_tagLong;
        private PropertyState<string> m_tagFull;
        private PropertyState<string> m_pointId;
        private PropertyState<string> m_pointIdLong;
        private PropertyState<string> m_siteService;
        private PropertyState<string> m_site;
        private PropertyState<string> m_service;
        private PropertyState<string> m_facility;
        private PropertyState<string> m_uDC;
        private PropertyState<string> m_uDCDescription;
        private PropertyState<string> m_system;
        private PropertyState<string> m_systemDescription;
        private PropertyState<string> m_pointDataType;
        private PropertyState<string> m_pointDataTypeDescription;
        private PropertyState<string> m_comment;
        private PropertyState<string> m_alarmCategory;
        private PropertyState<string> m_alarmCategoryDescription;
        private PropertyState<string> m_anyVerifiedFlag;
        private PropertyState<string> m_verifiedFlag1;
        private PropertyState<string> m_verifiedFlag2;
        private PropertyState<string> m_verifiedFlag3;
        private PropertyState<string> m_verifiedFlag4;
        private PropertyState<string> m_verifiedTimestamp;
        private PropertyState<string> m_questionableFlag;
        private PropertyState<string> m_questionableTimestamp;
        private PropertyState<string> m_anyUserFlag;
        private PropertyState<string> m_userFlag1;
        private PropertyState<string> m_userFlag2;
        private PropertyState<string> m_userFlag3;
        private PropertyState<string> m_userFlag4;
        private PropertyState<string> m_userFlag5;
        private PropertyState<string> m_userFlag6;
        private PropertyState<string> m_userFlag7;
        private PropertyState<string> m_userFlag8;
        private PropertyState<string> m_indexed1;
        private PropertyState<string> m_indexed2;
        private PropertyState<string> m_indexed3;
        private PropertyState<string> m_tableDriven1;
        private PropertyState<string> m_tableDriven2;
        private PropertyState<string> m_tableDriven3;
        private PropertyState<string> m_generalData1;
        private PropertyState<string> m_generalData2;
        private PropertyState<string> m_generalData3;
        private PropertyState<string> m_tableDriven1Description;
        private PropertyState<string> m_tableDriven2Description;
        private PropertyState<string> m_tableDriven3Description;
        private PropertyState<string> m_longDescription;
        private PropertyState<string> m_pointScheme;
        private PropertyState<string> m_pointSchemeDescription;
        private PropertyState<string> m_externalId;
        #endregion
    }
#endif
    #endregion

    #region RealtimeRecordState Class
#if (!OPCUA_EXCLUDE_RealtimeRecordState)
    /// <summary>
    /// Stores an instance of the RealtimeRecordType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RealtimeRecordState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public RealtimeRecordState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(cygnet.ObjectTypes.RealtimeRecordType, cygnet.Namespaces.cygnet, namespaceUris);
        }

#if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACIAAABodHRwczovL3dlYXRoZXJmb3JkLmNvbS9VQS9jeWduZXQv/////4RggAIBAAAAAQAaAAAA" +
           "UmVhbHRpbWVSZWNvcmRUeXBlSW5zdGFuY2UBAZM7AQGTO5M7AAAB/////wgAAAA1YIkKAgAAAAEABQAA" +
           "AFZhbHVlAQGUOwMAAAAADgAAAFJlYWx0aW1lIHZhbHVlAC4ARJQ7AAAADP////8BAf////8AAAAANWCJ" +
           "CgIAAAABAA4AAABBbHRlcm5hdGVWYWx1ZQEBlTsDAAAAAA8AAABBbHRlcm5hdGUgdmFsdWUALgBElTsA" +
           "AAAM/////wEB/////wAAAAA1YIkKAgAAAAEACQAAAFRpbWVzdGFtcAEBljsDAAAAABUAAABQb2ludCB2" +
           "YWx1ZSB0aW1lc3RhbXAALgBEljsAAAAN/////wEB/////wAAAAA1YIkKAgAAAAEABgAAAFN0YXR1cwEB" +
           "lzsDAAAAAAYAAABTdGF0dXMALgBElzsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEACgAAAFVzZXJT" +
           "dGF0dXMBAZg7AwAAAAAKAAAAVXNlclN0YXR1cwAuAESYOwAAAAz/////AQH/////AAAAADVgiQoCAAAA" +
           "AQAVAAAAUG9pbnRTdGF0ZURlc2NyaXB0aW9uAQGZOwMAAAAAFQAAAFBvaW50U3RhdGVEZXNjcmlwdGlv" +
           "bgAuAESZOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAgAAAAQWxhcm1Qcmlvcml0eUNhdGVnb3J5" +
           "RGVzY3JpcHRpb24BAZo7AwAAAAAgAAAAQWxhcm1Qcmlvcml0eUNhdGVnb3J5RGVzY3JpcHRpb24ALgBE" +
           "mjsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAGQAAAEFsYXJtQ29uZGl0aW9uRGVzY3JpcHRpb24B" +
           "AZs7AwAAAAAZAAAAQWxhcm1Db25kaXRpb25EZXNjcmlwdGlvbgAuAESbOwAAAAz/////AQH/////AAAA" +
           "AA==";
        #endregion
#endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> Value
        {
            get
            {
                return m_value;
            }

            set
            {
                if (!Object.ReferenceEquals(m_value, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_value = value;
            }
        }

        /// <remarks />
        public PropertyState<string> AlternateValue
        {
            get
            {
                return m_alternateValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_alternateValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_alternateValue = value;
            }
        }

        /// <remarks />
        public PropertyState<DateTime> Timestamp
        {
            get
            {
                return m_timestamp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_timestamp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_timestamp = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Status
        {
            get
            {
                return m_status;
            }

            set
            {
                if (!Object.ReferenceEquals(m_status, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_status = value;
            }
        }

        /// <remarks />
        public PropertyState<string> UserStatus
        {
            get
            {
                return m_userStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_userStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_userStatus = value;
            }
        }

        /// <remarks />
        public PropertyState<string> PointStateDescription
        {
            get
            {
                return m_pointStateDescription;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pointStateDescription, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pointStateDescription = value;
            }
        }

        /// <remarks />
        public PropertyState<string> AlarmPriorityCategoryDescription
        {
            get
            {
                return m_alarmPriorityCategoryDescription;
            }

            set
            {
                if (!Object.ReferenceEquals(m_alarmPriorityCategoryDescription, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_alarmPriorityCategoryDescription = value;
            }
        }

        /// <remarks />
        public PropertyState<string> AlarmConditionDescription
        {
            get
            {
                return m_alarmConditionDescription;
            }

            set
            {
                if (!Object.ReferenceEquals(m_alarmConditionDescription, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_alarmConditionDescription = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_value != null)
            {
                children.Add(m_value);
            }

            if (m_alternateValue != null)
            {
                children.Add(m_alternateValue);
            }

            if (m_timestamp != null)
            {
                children.Add(m_timestamp);
            }

            if (m_status != null)
            {
                children.Add(m_status);
            }

            if (m_userStatus != null)
            {
                children.Add(m_userStatus);
            }

            if (m_pointStateDescription != null)
            {
                children.Add(m_pointStateDescription);
            }

            if (m_alarmPriorityCategoryDescription != null)
            {
                children.Add(m_alarmPriorityCategoryDescription);
            }

            if (m_alarmConditionDescription != null)
            {
                children.Add(m_alarmConditionDescription);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case cygnet.BrowseNames.Value:
                    {
                        if (createOrReplace)
                        {
                            if (Value == null)
                            {
                                if (replacement == null)
                                {
                                    Value = new PropertyState<string>(this);
                                }
                                else
                                {
                                    Value = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = Value;
                        break;
                    }

                case cygnet.BrowseNames.AlternateValue:
                    {
                        if (createOrReplace)
                        {
                            if (AlternateValue == null)
                            {
                                if (replacement == null)
                                {
                                    AlternateValue = new PropertyState<string>(this);
                                }
                                else
                                {
                                    AlternateValue = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = AlternateValue;
                        break;
                    }

                case cygnet.BrowseNames.Timestamp:
                    {
                        if (createOrReplace)
                        {
                            if (Timestamp == null)
                            {
                                if (replacement == null)
                                {
                                    Timestamp = new PropertyState<DateTime>(this);
                                }
                                else
                                {
                                    Timestamp = (PropertyState<DateTime>)replacement;
                                }
                            }
                        }

                        instance = Timestamp;
                        break;
                    }

                case cygnet.BrowseNames.Status:
                    {
                        if (createOrReplace)
                        {
                            if (Status == null)
                            {
                                if (replacement == null)
                                {
                                    Status = new PropertyState<string>(this);
                                }
                                else
                                {
                                    Status = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = Status;
                        break;
                    }

                case cygnet.BrowseNames.UserStatus:
                    {
                        if (createOrReplace)
                        {
                            if (UserStatus == null)
                            {
                                if (replacement == null)
                                {
                                    UserStatus = new PropertyState<string>(this);
                                }
                                else
                                {
                                    UserStatus = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = UserStatus;
                        break;
                    }

                case cygnet.BrowseNames.PointStateDescription:
                    {
                        if (createOrReplace)
                        {
                            if (PointStateDescription == null)
                            {
                                if (replacement == null)
                                {
                                    PointStateDescription = new PropertyState<string>(this);
                                }
                                else
                                {
                                    PointStateDescription = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = PointStateDescription;
                        break;
                    }

                case cygnet.BrowseNames.AlarmPriorityCategoryDescription:
                    {
                        if (createOrReplace)
                        {
                            if (AlarmPriorityCategoryDescription == null)
                            {
                                if (replacement == null)
                                {
                                    AlarmPriorityCategoryDescription = new PropertyState<string>(this);
                                }
                                else
                                {
                                    AlarmPriorityCategoryDescription = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = AlarmPriorityCategoryDescription;
                        break;
                    }

                case cygnet.BrowseNames.AlarmConditionDescription:
                    {
                        if (createOrReplace)
                        {
                            if (AlarmConditionDescription == null)
                            {
                                if (replacement == null)
                                {
                                    AlarmConditionDescription = new PropertyState<string>(this);
                                }
                                else
                                {
                                    AlarmConditionDescription = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = AlarmConditionDescription;
                        break;
                    }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_value;
        private PropertyState<string> m_alternateValue;
        private PropertyState<DateTime> m_timestamp;
        private PropertyState<string> m_status;
        private PropertyState<string> m_userStatus;
        private PropertyState<string> m_pointStateDescription;
        private PropertyState<string> m_alarmPriorityCategoryDescription;
        private PropertyState<string> m_alarmConditionDescription;
        #endregion
    }
#endif
    #endregion

    #region CygNetAlarmState Class
#if (!OPCUA_EXCLUDE_CygNetAlarmState)
    /// <summary>
    /// Stores an instance of the CygNetAlarmType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CygNetAlarmState : AlarmConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CygNetAlarmState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(cygnet.ObjectTypes.CygNetAlarmType, cygnet.Namespaces.cygnet, namespaceUris);
        }

#if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACIAAABodHRwczovL3dlYXRoZXJmb3JkLmNvbS9VQS9jeWduZXQv/////4RggAIBAAAAAQAXAAAA" +
           "Q3lnTmV0QWxhcm1UeXBlSW5zdGFuY2UBAZw7AQGcO5w7AAAB/////yYAAAAVYIkKAgAAAAAABwAAAEV2" +
           "ZW50SWQBAZ07AC4ARJ07AAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAZ47" +
           "AC4ARJ47AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQGfOwAuAESfOwAA" +
           "ABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBoDsALgBEoDsAAAAM/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAaE7AC4ARKE7AAABACYB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAACwAAAFJlY2VpdmVUaW1lAQGiOwAuAESiOwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAcAAABNZXNzYWdlAQGkOwAuAESkOwAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAU2V2ZXJp" +
           "dHkBAaU7AC4ARKU7AAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25DbGFzc0lk" +
           "AQGmOwAuAESmOwAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xhc3NOYW1l" +
           "AQGnOwAuAESnOwAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFtZQEBqjsA" +
           "LgBEqjsAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQGrOwAuAESrOwAAABH/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQGsOwAuAESsOwAAAAH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQGtOwAvAQAjI607AAAAFf////8BAQUAAAABACwjAAEB" +
           "xTsBACwjAAEBzjsBACwjAAEB2zsBACwjAAEB5TsBACwjAAEB9zsBAAAAFWCJCgIAAAAAAAIAAABJZAEB" +
           "rjsALgBErjsAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAFF1YWxpdHkBAbY7AC8BACojtjsA" +
           "AAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBtzsALgBEtzsAAAEA" +
           "JgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVyaXR5AQG4OwAvAQAqI7g7AAAABf//" +
           "//8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAbk7AC4ARLk7AAABACYB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAbo7AC8BACojujsAAAAV/////wEB/////wEA" +
           "AAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBuzsALgBEuzsAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQG8OwAuAES8OwAAAAz/////AQH/////AAAAAARhggoE" +
           "AAAAAAAHAAAARGlzYWJsZQEBvTsALwEARCO9OwAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAG" +
           "AAAARW5hYmxlAQG+OwAvAQBDI747AAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRD" +
           "b21tZW50AQG/OwAvAQBFI787AAABAQEAAAABAPkLAAEADQsBAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFy" +
           "Z3VtZW50cwEBwDsALgBEwDsAAJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAo" +
           "AAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21t" +
           "ZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEA" +
           "KAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAAAAAoAAABBY2tlZFN0YXRlAQHFOwAvAQAjI8U7" +
           "AAAAFf////8BAQEAAAABACwjAQEBrTsBAAAAFWCJCgIAAAAAAAIAAABJZAEBxjsALgBExjsAAAAB////" +
           "/wEB/////wAAAAAEYYIKBAAAAAAACwAAAEFja25vd2xlZGdlAQHXOwAvAQCXI9c7AAABAQEAAAABAPkL" +
           "AAEA8CIBAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB2DsALgBE2DsAAJYCAAAAAQAqAQFG" +
           "AAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVu" +
           "dCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21t" +
           "ZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIA" +
           "AAAAAAsAAABBY3RpdmVTdGF0ZQEB2zsALwEAIyPbOwAAABX/////AQEBAAAAAQAsIwEBAa07AQAAABVg" +
           "iQoCAAAAAAACAAAASWQBAdw7AC4ARNw7AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABJbnB1" +
           "dE5vZGUBAeQ7AC4AROQ7AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABMAAABTdXBwcmVzc2VkT3JT" +
           "aGVsdmVkAQEKPAAuAEQKPAAAAAH/////AQH/////AAAAADVgiQoCAAAAAQAFAAAASXNTZXQBATA8AwAA" +
           "AAAGAAAASXMgc2V0AC4ARDA8AAAAAf////8BAf////8AAAAANWCJCgIAAAABAAgAAABJc0hpZGRlbgEB" +
           "MTwDAAAAAAkAAABJcyBoaWRkZW4ALgBEMTwAAAAB/////wEB/////wAAAAA1YIkKAgAAAAEAIAAAAEFs" +
           "YXJtUHJpb3JpdHlDYXRlZ29yeURlc2NyaXB0aW9uAQEyPAMAAAAAIwAAAEFsYXJtIHByaW9yaXR5IGNh" +
           "dGVnb3J5IGRlc2NyaXB0aW9uAC4ARDI8AAAADP////8BAf////8AAAAANWCJCgIAAAABAA4AAABBbGFy" +
           "bUNvbmRpdGlvbgEBMzwDAAAAAA8AAABBbGFybSBjb25kaXRpb24ALgBEMzwAAAAM/////wEB/////wAA" +
           "AAA1YIkKAgAAAAEACgAAAFBvaW50U3RhdGUBATQ8AwAAAAALAAAAUG9pbnQgc3RhdGUALgBENDwAAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAEADQAAAEFsYXJtQ2F0ZWdvcnkBATU8AwAAAAAOAAAAQWxhcm0g" +
           "Y2F0ZWdvcnkALgBENTwAAAAM/////wEB/////wAAAAA1YIkKAgAAAAEAFQAAAEFsYXJtUHJpb3JpdHlD" +
           "YXRlZ29yeQEBNjwDAAAAABcAAABBbGFybSBwcmlvcml0eSBjYXRlZ29yeQAuAEQ2PAAAAAf/////AQH/" +
           "////AAAAADVgiQoCAAAAAQAUAAAASGlnaGVzdEFsYXJtUHJpb3JpdHkBATc8AwAAAAAWAAAASGlnaGVz" +
           "dCBhbGFybSBwcmlvcml0eQAuAEQ3PAAAAAf/////AQH/////AAAAADVgiQoCAAAAAQAcAAAASGlnaGVz" +
           "dEFsYXJtUHJpb3JpdHlTaW5jZUFjawEBODwDAAAAACwAAABIaWdoZXN0IGFsYXJtIHByaW9yaXR5IHNp" +
           "bmNlIGFja25vd2xlZGdlbWVudAAuAEQ4PAAAAAf/////AQH/////AAAAADVgiQoCAAAAAQASAAAAQWxh" +
           "cm1SZWNvcmRWZXJzaW9uAQE5PAMAAAAAFAAAAEFsYXJtIHJlY29yZCB2ZXJzaW9uAC4ARDk8AAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAABAA0AAABBbGFybVByaW9yaXR5AQE6PAMAAAAADgAAAEFsYXJtIHBy" +
           "aW9yaXR5AC4ARDo8AAAAB/////8BAf////8AAAAANWCJCgIAAAABAAoAAABQb2ludFZhbHVlAQE7PAMA" +
           "AAAACwAAAFBvaW50IHZhbHVlAC4ARDs8AAAADP////8BAf////8AAAAA";
        #endregion
#endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<bool> IsSet
        {
            get
            {
                return m_isSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isSet = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> IsHidden
        {
            get
            {
                return m_isHidden;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isHidden, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isHidden = value;
            }
        }

        /// <remarks />
        public PropertyState<string> AlarmPriorityCategoryDescription
        {
            get
            {
                return m_alarmPriorityCategoryDescription;
            }

            set
            {
                if (!Object.ReferenceEquals(m_alarmPriorityCategoryDescription, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_alarmPriorityCategoryDescription = value;
            }
        }

        /// <remarks />
        public PropertyState<string> AlarmCondition
        {
            get
            {
                return m_alarmCondition;
            }

            set
            {
                if (!Object.ReferenceEquals(m_alarmCondition, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_alarmCondition = value;
            }
        }

        /// <remarks />
        public PropertyState<string> PointState
        {
            get
            {
                return m_pointState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pointState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pointState = value;
            }
        }

        /// <remarks />
        public PropertyState<string> AlarmCategory
        {
            get
            {
                return m_alarmCategory;
            }

            set
            {
                if (!Object.ReferenceEquals(m_alarmCategory, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_alarmCategory = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> AlarmPriorityCategory
        {
            get
            {
                return m_alarmPriorityCategory;
            }

            set
            {
                if (!Object.ReferenceEquals(m_alarmPriorityCategory, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_alarmPriorityCategory = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> HighestAlarmPriority
        {
            get
            {
                return m_highestAlarmPriority;
            }

            set
            {
                if (!Object.ReferenceEquals(m_highestAlarmPriority, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_highestAlarmPriority = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> HighestAlarmPrioritySinceAck
        {
            get
            {
                return m_highestAlarmPrioritySinceAck;
            }

            set
            {
                if (!Object.ReferenceEquals(m_highestAlarmPrioritySinceAck, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_highestAlarmPrioritySinceAck = value;
            }
        }

        /// <remarks />
        public PropertyState<string> AlarmRecordVersion
        {
            get
            {
                return m_alarmRecordVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_alarmRecordVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_alarmRecordVersion = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> AlarmPriority
        {
            get
            {
                return m_alarmPriority;
            }

            set
            {
                if (!Object.ReferenceEquals(m_alarmPriority, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_alarmPriority = value;
            }
        }

        /// <remarks />
        public PropertyState<string> PointValue
        {
            get
            {
                return m_pointValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pointValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pointValue = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_isSet != null)
            {
                children.Add(m_isSet);
            }

            if (m_isHidden != null)
            {
                children.Add(m_isHidden);
            }

            if (m_alarmPriorityCategoryDescription != null)
            {
                children.Add(m_alarmPriorityCategoryDescription);
            }

            if (m_alarmCondition != null)
            {
                children.Add(m_alarmCondition);
            }

            if (m_pointState != null)
            {
                children.Add(m_pointState);
            }

            if (m_alarmCategory != null)
            {
                children.Add(m_alarmCategory);
            }

            if (m_alarmPriorityCategory != null)
            {
                children.Add(m_alarmPriorityCategory);
            }

            if (m_highestAlarmPriority != null)
            {
                children.Add(m_highestAlarmPriority);
            }

            if (m_highestAlarmPrioritySinceAck != null)
            {
                children.Add(m_highestAlarmPrioritySinceAck);
            }

            if (m_alarmRecordVersion != null)
            {
                children.Add(m_alarmRecordVersion);
            }

            if (m_alarmPriority != null)
            {
                children.Add(m_alarmPriority);
            }

            if (m_pointValue != null)
            {
                children.Add(m_pointValue);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case cygnet.BrowseNames.IsSet:
                    {
                        if (createOrReplace)
                        {
                            if (IsSet == null)
                            {
                                if (replacement == null)
                                {
                                    IsSet = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    IsSet = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = IsSet;
                        break;
                    }

                case cygnet.BrowseNames.IsHidden:
                    {
                        if (createOrReplace)
                        {
                            if (IsHidden == null)
                            {
                                if (replacement == null)
                                {
                                    IsHidden = new PropertyState<bool>(this);
                                }
                                else
                                {
                                    IsHidden = (PropertyState<bool>)replacement;
                                }
                            }
                        }

                        instance = IsHidden;
                        break;
                    }

                case cygnet.BrowseNames.AlarmPriorityCategoryDescription:
                    {
                        if (createOrReplace)
                        {
                            if (AlarmPriorityCategoryDescription == null)
                            {
                                if (replacement == null)
                                {
                                    AlarmPriorityCategoryDescription = new PropertyState<string>(this);
                                }
                                else
                                {
                                    AlarmPriorityCategoryDescription = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = AlarmPriorityCategoryDescription;
                        break;
                    }

                case cygnet.BrowseNames.AlarmCondition:
                    {
                        if (createOrReplace)
                        {
                            if (AlarmCondition == null)
                            {
                                if (replacement == null)
                                {
                                    AlarmCondition = new PropertyState<string>(this);
                                }
                                else
                                {
                                    AlarmCondition = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = AlarmCondition;
                        break;
                    }

                case cygnet.BrowseNames.PointState:
                    {
                        if (createOrReplace)
                        {
                            if (PointState == null)
                            {
                                if (replacement == null)
                                {
                                    PointState = new PropertyState<string>(this);
                                }
                                else
                                {
                                    PointState = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = PointState;
                        break;
                    }

                case cygnet.BrowseNames.AlarmCategory:
                    {
                        if (createOrReplace)
                        {
                            if (AlarmCategory == null)
                            {
                                if (replacement == null)
                                {
                                    AlarmCategory = new PropertyState<string>(this);
                                }
                                else
                                {
                                    AlarmCategory = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = AlarmCategory;
                        break;
                    }

                case cygnet.BrowseNames.AlarmPriorityCategory:
                    {
                        if (createOrReplace)
                        {
                            if (AlarmPriorityCategory == null)
                            {
                                if (replacement == null)
                                {
                                    AlarmPriorityCategory = new PropertyState<uint>(this);
                                }
                                else
                                {
                                    AlarmPriorityCategory = (PropertyState<uint>)replacement;
                                }
                            }
                        }

                        instance = AlarmPriorityCategory;
                        break;
                    }

                case cygnet.BrowseNames.HighestAlarmPriority:
                    {
                        if (createOrReplace)
                        {
                            if (HighestAlarmPriority == null)
                            {
                                if (replacement == null)
                                {
                                    HighestAlarmPriority = new PropertyState<uint>(this);
                                }
                                else
                                {
                                    HighestAlarmPriority = (PropertyState<uint>)replacement;
                                }
                            }
                        }

                        instance = HighestAlarmPriority;
                        break;
                    }

                case cygnet.BrowseNames.HighestAlarmPrioritySinceAck:
                    {
                        if (createOrReplace)
                        {
                            if (HighestAlarmPrioritySinceAck == null)
                            {
                                if (replacement == null)
                                {
                                    HighestAlarmPrioritySinceAck = new PropertyState<uint>(this);
                                }
                                else
                                {
                                    HighestAlarmPrioritySinceAck = (PropertyState<uint>)replacement;
                                }
                            }
                        }

                        instance = HighestAlarmPrioritySinceAck;
                        break;
                    }

                case cygnet.BrowseNames.AlarmRecordVersion:
                    {
                        if (createOrReplace)
                        {
                            if (AlarmRecordVersion == null)
                            {
                                if (replacement == null)
                                {
                                    AlarmRecordVersion = new PropertyState<string>(this);
                                }
                                else
                                {
                                    AlarmRecordVersion = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = AlarmRecordVersion;
                        break;
                    }

                case cygnet.BrowseNames.AlarmPriority:
                    {
                        if (createOrReplace)
                        {
                            if (AlarmPriority == null)
                            {
                                if (replacement == null)
                                {
                                    AlarmPriority = new PropertyState<uint>(this);
                                }
                                else
                                {
                                    AlarmPriority = (PropertyState<uint>)replacement;
                                }
                            }
                        }

                        instance = AlarmPriority;
                        break;
                    }

                case cygnet.BrowseNames.PointValue:
                    {
                        if (createOrReplace)
                        {
                            if (PointValue == null)
                            {
                                if (replacement == null)
                                {
                                    PointValue = new PropertyState<string>(this);
                                }
                                else
                                {
                                    PointValue = (PropertyState<string>)replacement;
                                }
                            }
                        }

                        instance = PointValue;
                        break;
                    }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<bool> m_isSet;
        private PropertyState<bool> m_isHidden;
        private PropertyState<string> m_alarmPriorityCategoryDescription;
        private PropertyState<string> m_alarmCondition;
        private PropertyState<string> m_pointState;
        private PropertyState<string> m_alarmCategory;
        private PropertyState<uint> m_alarmPriorityCategory;
        private PropertyState<uint> m_highestAlarmPriority;
        private PropertyState<uint> m_highestAlarmPrioritySinceAck;
        private PropertyState<string> m_alarmRecordVersion;
        private PropertyState<uint> m_alarmPriority;
        private PropertyState<string> m_pointValue;
        #endregion
    }
#endif
    #endregion
}
