using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap8 {
    class Ex1 {
        static public void run() {
            Console.WriteLine(Tester.Triple(1));
            Console.WriteLine(Tester.Triple(1.2));
        }
    }

    class Tester {
        static public int Triple(int a) {
            return a * 3;
        }

        static public double Triple(double a) {
            return a * 3;
        }
    }
}
