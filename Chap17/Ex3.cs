using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap17 {
    class Ex3 {
        static public void Run() {
            CountdownClock clk = new CountdownClock("Time is up.", 2);
            ClockDisplay2 clkDisplay = new ClockDisplay2(clk);
            clk.Run();
        }
    }

    class ClockDisplay2 {

        public ClockDisplay2(CountdownClock clk) {
            clk.timeUpDelegate += delegate (CountdownClock clock, string msg) {
                Console.WriteLine(msg);
            };
        }
    }
}
