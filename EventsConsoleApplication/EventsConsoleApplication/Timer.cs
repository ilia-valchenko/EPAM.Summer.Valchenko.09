using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsConsoleApplication
{
    public class Timer
    {
        public delegate void TimerEventHandler(object sender, TimerEventArgs e);

        public event TimerEventHandler Countdown;

        public virtual void OnCountdown(object sender, TimerEventArgs e)
        {
            if (Countdown != null)
            {
                Thread.Sleep(e.Time);
                Countdown(sender, e);
            } 
        }

        public void SimulateTimer(string message, int time)
        {
            OnCountdown(this, new TimerEventArgs(time, message));
        }
    }
}
