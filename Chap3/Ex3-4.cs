using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3 {
    class Ex3_4 {
        enum Year {
            Jan = 1,
            Feb,
            Mar,
            Apr,
            May,
            Jun,
        }

        static public void run() {
            Console.WriteLine("June is the {0}th month of a year", (ushort)Year.Jun);
        }
    }
}
