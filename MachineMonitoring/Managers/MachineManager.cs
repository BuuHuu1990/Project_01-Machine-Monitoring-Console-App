using MachineMonitoring.Models;


namespace MachineMonitoring.Managers
{
    public class MachineManager
    {
        public List<Machine> Machines { get; set; } = new();

        public void AddMachine(int id, string name)
        {
            Machine machine = new Machine(id, name);
            Machines.Add(machine);
        }

        public void DisplayMachines()
        {
            foreach (var machine in Machines)
            {
                Console.WriteLine($"Machine ID: {machine.Id}, Machine name: {machine.Name}, Status: {machine.Status}");
            }
        }

        public void StartMachine(int id)
        {
            var machine = GetMachinesById(id);
            if (machine != null)
            {
                machine.Start();
            }
        }

        public void StopMachine(int id)
        {
            var machine = GetMachinesById(id);
            if (machine != null)
            {
                machine.Stop();
            }
        }

        public void SetMachineError(int id)
        {
            var machine = GetMachinesById(id);
            if (machine != null)
            {
                machine.Error();
            }
        }

        public void AddAlarmMachine(int id, string message, AlarmSeverity severity)
        {
            foreach (var machine in Machines)
            {
                if (machine.Id == id)
                    machine.AddAlarm(message, severity);
            }
        }

        public Machine? GetMachinesById(int id)
        {
            return Machines.FirstOrDefault(m => m.Id == id);
        }

    }
}
