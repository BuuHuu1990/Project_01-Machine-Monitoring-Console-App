using System;
using System.Collections.Generic;
using System.Text;

namespace MachineMonitoring.Models
{
    public class Machine
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public MachineStatus Status { get; set; }
        public List<Alarm> Alarms { get; set; }

        public void MachineStart()
        {

        }

        public void MachineStop() { }
        public void MachineError(string message) { }
        public void AddAlarm(Alarm alarm) { }

    }
}
