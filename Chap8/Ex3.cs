using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap8 {
    class Ex3 {
        static public void run() {
            var input = Convert.ToInt32(Console.ReadLine());
            int dou, triple;
            DoubleTriple(input, out dou, out triple);
            Console.WriteLine("dou: " + dou + " tri: " + triple);
        }

        static private void DoubleTriple(int input, out int dou, out int triple) {
            dou = input * 2;
            triple = input * 3;
        }
    }
}
