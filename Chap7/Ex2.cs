using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap7 {
    class Ex2 {
        public static void run() {
            Math math = new Math();
            Console.WriteLine(Math2.add(1, 2));
            Console.WriteLine(Math2.substract(1, 2));
            Console.WriteLine(Math2.multiply(1, 2));
            Console.WriteLine(Math2.divide(1, 2));
        }
    }

    class Math2 {
        static public int add(int a, int b) {
            return a + b;
        }

        static public int substract(int a, int b) {
            return a - b;
        }

        static public int multiply(int a, int b) {
            return a * b;
        }

        static public int divide(int a, int b) {
            return a / b;
        }
    }
}
