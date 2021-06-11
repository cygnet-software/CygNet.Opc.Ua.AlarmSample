using Opc.Ua;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CygNet.Opc.Ua.AlarmSample
{
    public class Alarm : INotifyPropertyChanged
    {
        private string _pointTag;
        public string PointTag
        {
            get { return _pointTag; }
            set
            {
                if (_pointTag != value)
                {
                    _pointTag = value;
                    NotifyPropertyChanged(nameof(PointTag));
                }
            }
        }

        private DateTime _reportedTimestamp;
        public DateTime ReportedTimestamp
        {
            get { return _reportedTimestamp; }
            set
            {
                if (_reportedTimestamp != value)
                {
                    _reportedTimestamp = value;
                    NotifyPropertyChanged(nameof(ReportedTimestamp));
                }
            }
        }

        private DateTime _receivedTimestamp;
        public DateTime ReceivedTimestamp
        {
            get { return _receivedTimestamp; }
            set
            {
                if (_receivedTimestamp != value)
                {
                    _receivedTimestamp = value;
                    NotifyPropertyChanged(nameof(ReceivedTimestamp));
                }
            }
        }

        private bool _isAcknowledged;
        public bool IsAcknowledged
        {
            get { return _isAcknowledged; }
            set
            {
                if (_isAcknowledged != value)
                {
                    _isAcknowledged = value;
                    NotifyPropertyChanged(nameof(IsAcknowledged));
                }
            }
        }

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                if (_isActive != value)
                {
                    _isActive = value;
                    NotifyPropertyChanged(nameof(IsActive));
                }
            }
        }

        private bool _isSet;
        public bool IsSet
        {
            get { return _isSet; }
            set
            {
                if (_isSet != value)
                {
                    _isSet = value;
                    NotifyPropertyChanged(nameof(IsSet));
                }
            }
        }

        private bool _isHidden;
        public bool IsHidden
        {
            get { return _isHidden; }
            set
            {
                if (_isHidden != value)
                {
                    _isHidden = value;
                    NotifyPropertyChanged(nameof(IsHidden));
                }
            }
        }

        private bool _isSuppressed;
        public bool IsSuppressed
        {
            get { return _isSuppressed; }
            set
            {
                if (_isSuppressed != value)
                {
                    _isSuppressed = value;
                    NotifyPropertyChanged(nameof(IsSuppressed));
                }
            }
        }

        private string _alarmPriorityCategoryDescription;
        public string AlarmPriorityCategoryDescription
        {
            get { return _alarmPriorityCategoryDescription; }
            set
            {
                if (_alarmPriorityCategoryDescription != value)
                {
                    _alarmPriorityCategoryDescription = value;
                    NotifyPropertyChanged(nameof(AlarmPriorityCategoryDescription));
                }
            }
        }

        private string _alarmCondition;
        public string AlarmCondition
        {
            get { return _alarmCondition; }
            set
            {
                if (_alarmCondition != value)
                {
                    _alarmCondition = value;
                    NotifyPropertyChanged(nameof(AlarmCondition));
                }
            }
        }

        private string _pointState;
        public string PointState
        {
            get { return _pointState; }
            set
            {
                if (_pointState != value)
                {
                    _pointState = value;
                    NotifyPropertyChanged(nameof(PointState));
                }
            }
        }

        private string _alarmCategory;
        public string AlarmCategory
        {
            get { return _alarmCategory; }
            set
            {
                if (_alarmCategory != value)
                {
                    _alarmCategory = value;
                    NotifyPropertyChanged(nameof(AlarmCategory));
                }
            }
        }

        private uint _alarmPriorityCategory;
        public uint AlarmPriorityCategory
        {
            get { return _alarmPriorityCategory; }
            set
            {
                if (_alarmPriorityCategory != value)
                {
                    _alarmPriorityCategory = value;
                    NotifyPropertyChanged(nameof(AlarmPriorityCategory));
                }
            }
        }

        private uint _highestAlarmPriority;
        public uint HighestAlarmPriority
        {
            get { return _highestAlarmPriority; }
            set
            {
                if (_highestAlarmPriority != value)
                {
                    _highestAlarmPriority = value;
                    NotifyPropertyChanged(nameof(HighestAlarmPriority));
                }
            }
        }

        private uint _highestAlarmPrioritySinceAck;
        public uint HighestAlarmPrioritySinceAck
        {
            get { return _highestAlarmPrioritySinceAck; }
            set
            {
                if (_highestAlarmPrioritySinceAck != value)
                {
                    _highestAlarmPrioritySinceAck = value;
                    NotifyPropertyChanged(nameof(HighestAlarmPrioritySinceAck));
                }
            }
        }

        private string _alarmRecordVersion;
        public string AlarmRecordVersion
        {
            get { return _alarmRecordVersion; }
            set
            {
                if (_alarmRecordVersion != value)
                {
                    _alarmRecordVersion = value;
                    NotifyPropertyChanged(nameof(AlarmRecordVersion));
                }
            }
        }

        private uint _alarmPriority;
        public uint AlarmPriority
        {
            get { return _alarmPriority; }
            set
            {
                if (_alarmPriority != value)
                {
                    _alarmPriority = value;
                    NotifyPropertyChanged(nameof(AlarmPriority));
                }
            }
        }

        private string _pointValue;
        public string PointValue
        {
            get { return _pointValue; }
            set
            {
                if (_pointValue != value)
                {
                    _pointValue = value;
                    NotifyPropertyChanged(nameof(PointValue));
                }
            }
        }

        private NodeId _nodeId;
        public NodeId NodeId
        {
            get { return _nodeId; }
            set
            {
                if (_nodeId != value)
                {
                    _nodeId = value;
                    NotifyPropertyChanged(nameof(NodeId));
                }
            }
        }

        public byte[] EventId { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
