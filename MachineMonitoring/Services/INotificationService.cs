using System;
using System.Collections.Generic;
using System.Text;

namespace MachineMonitoring.Services
{
    public interface INotificationService
    {
        void Notify(string message);
    }
}
