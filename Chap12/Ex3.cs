using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap12 {
    class Ex3 {
        static public void run() {
            Invoice a = new Invoice("1", 1.2);
            Invoice b = new Invoice("1", 1.3);
            Console.WriteLine(a > b);
            Console.WriteLine(b > a);
        }
    }
}
