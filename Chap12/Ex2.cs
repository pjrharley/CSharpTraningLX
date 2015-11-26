using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap12 {
    class Ex2 {
        static public void run() {
            Invoice a = new Invoice("hello", 1);
            Invoice b = new Invoice("hello", 2);
            Invoice c = new Invoice("hello", 2);
            Console.WriteLine(a == b);
            Console.WriteLine(b == c);
        }
    }


}
