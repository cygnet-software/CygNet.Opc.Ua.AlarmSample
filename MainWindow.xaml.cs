using Opc.Ua;
using Opc.Ua.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CygNet.Opc.Ua.AlarmSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Alarm> _items = new ObservableCollection<Alarm>();
        private Subscription _subscription = null;
        private object _lockObj = new object();

        public MainWindow()
        {
            InitializeComponent();
            lvAlarms.ItemsSource = _items;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvAlarms.ItemsSource);
            view.SortDescriptions.Add(new SortDescription("PointTag", ListSortDirection.Ascending));

            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _subscription = OpcUaClientUtils.SubscribeToCygNetAlarms(App.Instance.Session, AlarmsChangedEventHandler);
        }

        private void AckAlarmButtonClicked(object sender, RoutedEventArgs e)
        {
            if (lvAlarms.SelectedItem is Alarm alarm)
            {
                if (!OpcUaClientUtils.CallAcknowledgeAlarm(App.Instance.Session, alarm.NodeId, alarm.EventId))
                {
                    MessageBox.Show($"Failed to acknowledge alarm for point '{alarm.PointTag}'");
                }
            }
        }

        private void RefreshAlarmsButtonClicked(object sender, RoutedEventArgs e)
        {
            OpcUaClientUtils.CallConditionRefresh(App.Instance.Session, _subscription.Id);
        }

        private void ClearButtonClicked(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Wait;
            _items.Clear();
            Mouse.OverrideCursor = null;
        }

        private void AlarmsChangedEventHandler(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                EventFieldList notification = e.NotificationValue as EventFieldList;
                EventFilter filter = monitoredItem.Status.Filter as EventFilter;

                UpdateAlarms(notification, filter);
            });
        }

        private void UpdateAlarms(EventFieldList notification, EventFilter filter)
        {
            try
            {
                Mouse.OverrideCursor = Cursors.Wait;

                lock (_lockObj)
                {
                    cygnet.CygNetAlarmState cygAlarm = OpcUaClientUtils.ExtractCygNetAlarmState(App.Instance.Session, filter, notification);

                    if (cygAlarm == null)
                    {
                        return;
                    }

                    Alarm alarm = _items.FirstOrDefault(i => i.PointTag == cygAlarm.SourceName.Value);

                    if (!cygAlarm.Retain.Value)
                    {
                        if (alarm != null)
                        {
                            _items.Remove(alarm);
                        }
                    }
                    else
                    {
                        if (alarm == null)
                        {
                            AddNewAlarm(cygAlarm);
                        }
                        else
                        {
                            UpdateAlarm(alarm, cygAlarm);
                        }
                    }
                }
            }
            finally
            {
                Mouse.OverrideCursor = null;
            }
        }

        private void AddNewAlarm(cygnet.CygNetAlarmState cygAlarm)
        {
            var alarm = new Alarm();
            UpdateAlarm(alarm, cygAlarm);

            _items.Add(alarm);
        }

        private void UpdateAlarm(Alarm alarm, cygnet.CygNetAlarmState cygAlarm)
        {
            alarm.IsSet = cygAlarm.IsSet.Value;
            alarm.IsActive = cygAlarm.ActiveState.Id.Value;
            alarm.IsAcknowledged = cygAlarm.AckedState.Id.Value;
            alarm.IsHidden = cygAlarm.IsHidden.Value;
            alarm.IsSuppressed = cygAlarm.SuppressedOrShelved.Value;
            alarm.AlarmCondition = cygAlarm.AlarmCondition.Value;
            alarm.ReportedTimestamp = cygAlarm.Time.Value.ToLocalTime();
            alarm.ReceivedTimestamp = cygAlarm.ReceiveTime.Value.ToLocalTime();
            alarm.AlarmCategory = cygAlarm.AlarmCategory.Value;
            alarm.AlarmPriority = cygAlarm.AlarmPriority.Value;
            alarm.AlarmPriorityCategory = cygAlarm.AlarmPriorityCategory.Value;
            alarm.AlarmPriorityCategoryDescription = cygAlarm.AlarmPriorityCategoryDescription.Value;
            alarm.HighestAlarmPriority = cygAlarm.HighestAlarmPriority.Value;
            alarm.HighestAlarmPrioritySinceAck = cygAlarm.HighestAlarmPrioritySinceAck.Value;
            alarm.AlarmRecordVersion = cygAlarm.AlarmRecordVersion.Value;
            alarm.PointTag = cygAlarm.SourceName.Value;
            alarm.PointValue = cygAlarm.PointValue.Value;
            alarm.PointState = cygAlarm.PointState.Value;
            alarm.NodeId = cygAlarm.NodeId;
            alarm.EventId = cygAlarm.EventId.Value;
        }
    }
}
