using System;
using System.Collections.Generic;
using System.Text;

namespace MachineMonitoring.Models
{
    public class Alarm
    {
        public DateTime Timestamp { get; }
        public string Message { get; }
        public AlarmSeverity AlarmSeverity { get; }

        public Alarm(string message, AlarmSeverity severity)
        {
            Timestamp = DateTime.Now;
            Message = message;
            AlarmSeverity = severity;
        }
    }
}
