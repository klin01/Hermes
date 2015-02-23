using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Core.Interfaces
{
    public delegate void NotificationTriggerEventHandler(object data);

    public interface INotificationTrigger
    {
        event NotificationTriggerEventHandler OnTrigger;
        void Start();
    }
}
