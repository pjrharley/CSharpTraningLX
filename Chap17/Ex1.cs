using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chap17 {
    class Ex1 {
        static public void Run() {
            CountdownClock clk = new CountdownClock("Time is up.", 2);
            ClockDisplay clkDisplay = new ClockDisplay(clk);
            clk.Run();
        }
    }

    class CountdownClock {
        private string message;
        private int seconds;

        public CountdownClock(string message, int seconds) {
            this.message = message;
            this.seconds = seconds;
        }

        public delegate void TimeUpHandler(CountdownClock clk, string msg);
        public event TimeUpHandler timeUpDelegate;

        public void Run() {
            Thread.Sleep(seconds * 1000);
            if(timeUpDelegate != null) {
                timeUpDelegate(this, message);
            }
        }
    }

    class ClockDisplay {

        public ClockDisplay(CountdownClock clk) {
            clk.timeUpDelegate += new CountdownClock.TimeUpHandler(TimeIsUp);
        }

        public void TimeIsUp(CountdownClock clk, string msg) {
            Console.WriteLine(msg);
        }
    }
}
