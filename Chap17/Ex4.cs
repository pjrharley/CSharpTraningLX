using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap17 {
    class Ex4 {
        static public void Run() {
            CountdownClock clk = new CountdownClock("Time is up.", 2);
            ClockDisplay3 clkDisplay = new ClockDisplay3(clk);
            clk.Run();
        }
    }

    class ClockDisplay3 {

        public ClockDisplay3(CountdownClock clk) {
            clk.timeUpDelegate += (clock, msg) => {
                Console.WriteLine(msg);
            };
        }
    }
}
