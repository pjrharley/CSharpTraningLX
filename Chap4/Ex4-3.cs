using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap4 {
    class Ex4_3 {
        static public void run() {
            const int MinWeight = 100, MaxWeight = 300;
            const int Abby = 135, Bob = 175, Charlie = 55, Dawn = 45;
            Console.WriteLine("Abby and Bob? {0}", (Abby + Bob > MinWeight && Abby + Bob <= MaxWeight));
            Console.WriteLine("Charlie and Bob? {0}", (Charlie + Bob > MinWeight && Charlie + Bob <= MaxWeight));
            Console.WriteLine("Charlie and Dawn? {0}", (Charlie + Dawn > MinWeight && Charlie + Dawn <= MaxWeight));
        }
    }
}
