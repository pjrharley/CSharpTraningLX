using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap11 {
    class Ex2 {
        static public void run() {
            Telephone phone = new ElectricPhone2();
            phone.Ring();
        }
    }

    class ElectricPhone2: Telephone {
        public override void Ring() {
            Console.WriteLine("Different message");
        }
    }
}
