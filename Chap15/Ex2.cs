using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15 {
    class Ex2 {
        static public void Run() {
            string s = "To be or not to be";
            foreach(char c in s.Reverse()) {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}
