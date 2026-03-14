using System;
using System.Collections.Generic;
using System.Text;

namespace MachineMonitoring.Models
{
    public class Machine
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public MachineStatus Status { get; private set; } = MachineStatus.Offline;
        public List<Alarm> Alarms { get; private set; } = new();

        public void Start()
        {
            Status = MachineStatus.Running;
        }

        public void Stop()
        {
            Status = MachineStatus.Stopped;
        }

        public void Error()
        {
            Status = MachineStatus.Error;
        }

        public void AddAlarm(string message, AlarmSeverity severity)
        {
            Alarm alarm = new(message, severity);
            Alarms.Add(alarm);
        }

        public Machine(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
