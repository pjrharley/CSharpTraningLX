using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5 {
    class Ex5_4 {
        static public void run() {
            for (int i = 0, j = 25; i <= j; i++, j--) {
                Console.WriteLine("i: {0}, j: {1}", i, j);
            }
            Console.WriteLine("Cross over");
        }
    }
}
