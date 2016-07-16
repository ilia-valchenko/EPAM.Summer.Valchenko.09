using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            Listener listener = new Listener(timer);
            timer.SimulateTimer("Hello Ilia!", 3000);

            Console.WriteLine("\n\nTap to contine...");
            Console.ReadKey(true);
        }
    }
}
