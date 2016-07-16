using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EventsConsoleApplication
{
    public class Listener
    {
        public Listener(Timer timer)
        {
            timer.Countdown += Message;
        }

        public void Register(Timer timer)
        {
            timer.Countdown += Message;
        }

        public void Unregister(Timer timer)
        {
            timer.Countdown -= Message;
        }

        private void Message(object sender, TimerEventArgs eventArgs)
        {
            Console.WriteLine("New message.");
            Console.WriteLine("Topic: '{0}' for time {1}", eventArgs.Message, eventArgs.Time);
        }
    }
}
