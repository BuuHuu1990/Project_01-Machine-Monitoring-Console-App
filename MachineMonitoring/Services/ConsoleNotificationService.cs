using System;
using System.Collections.Generic;
using System.Text;

namespace MachineMonitoring.Services
{
    public class ConsoleNotificationService : INotificationService
    {
        public void Notify(string message)
        {
            Console.WriteLine($"[NOTIFICATION] {message}");
        }
    }
}
