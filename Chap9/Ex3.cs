using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap9 {
    class Ex3 {
        static private int Factorial(int n) {
            int res = 1;
            for (int i = 1; i <= n; i++) res *= i;
            return res;
        }

        static public void run() {
            int input = 5;
            Console.WriteLine(Factorial(input));
        }
    }
}
