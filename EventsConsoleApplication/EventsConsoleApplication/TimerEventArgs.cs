using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsConsoleApplication
{
    public sealed class TimerEventArgs : EventArgs
    {
        public int Time
        {
            get
            {
                return time;
            }
            set
            {
                if(value <= 0)
                    throw new ArgumentException("Time value can't be less or equals to zero.");

                time = value;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
        
        public TimerEventArgs(int time, string message)
        {
            Time = time;
            Message = message;
        }

        private int time;
        private string message;
    }
}
