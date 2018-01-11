using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap7 {
    class Ex1 {
        public static void run() {
            Math math = new Math();
            Console.WriteLine(math.add(1, 2));
            Console.WriteLine(math.substract(1, 2));
            Console.WriteLine(math.multiply(1, 2));
            Console.WriteLine(math.divide(1, 2));
        }
    }

    class Math {
        public int add(int a, int b) {
            return a + b;
        }

        public int substract(int a, int b) {
            return a - b;
        }

        public int multiply(int a, int b) {
            return a * b;
        }

        public double divide(int a, int b) {
            return (double)a / b;
        }
    }
}
