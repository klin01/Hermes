using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Hermes.Core.Factories;
using Hermes.Core.Interfaces;

namespace Hermes.Core
{
    public class Agent
    {
        private readonly NotificationBuilderFactory _builderFactory;
        private readonly NotificationContextFactory _contextFactory;

        public Agent()
        {
            _builderFactory = new NotificationBuilderFactory();
            _contextFactory = new NotificationContextFactory();
        }

        public void LoadNotification()
        {
            //by explicit types or by namespace if possible or by attribute reflection
        }

        public void Run(INotificationTrigger trigger)
        {
            trigger.OnTrigger += new NotificationTriggerEventHandler(Notify);
            Task.Run((Action) trigger.Start);
        }

        private void Notify(object data)
        {
            //cast data to some dto
            //use dto to get builder and context
            //build notification
            //send notification

            Console.WriteLine("Notified user!");
        }
    }
}
