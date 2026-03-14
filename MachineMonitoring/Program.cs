using MachineMonitoring.Managers;
using MachineMonitoring.Models;
using MachineMonitoring.Services;
using System.ComponentModel;

public class Program
{
    private static void Main(string[] args)
    {
        MachineManager machineManager = new();
        INotificationService notificationService = new ConsoleNotificationService();

        machineManager.AddMachine(001, "Trommelmaschine");
        machineManager.AddMachine(002, "Heiztrockner");

        machineManager.StartMachine(001);
        machineManager.StopMachine(002);
        machineManager.DisplayMachines();

        machineManager.AddAlarmMachine(001, "Alarm - Hitze Obergrenze erreicht", AlarmSeverity.Warning);
        notificationService.Notify("Maschine 1 hat einen Warning-Alarm erhalten.");
        machineManager.SetMachineError(001);
        machineManager.DisplayMachines();
    }

}