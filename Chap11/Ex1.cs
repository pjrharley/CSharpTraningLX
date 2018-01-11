using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap11 {
    class Ex1 {
        static public void run() {
            Telephone phone = new ElectricPhone();
            phone.Ring();
        }
    }

    class Telephone {
        protected string phoneType;

        public virtual void Ring() {
            Console.WriteLine("Ringing the {0}", phoneType);
        }
    }

    class ElectricPhone: Telephone {
        public ElectricPhone() {
            this.phoneType = "Digital";
        }
    }
}
