using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap12 {
    class Ex4 {
        static public void run() {
            Foot foot = new Foot(1.2);
            Meter meter = new Meter(2.1);

            Console.WriteLine((Foot)meter);
            Console.WriteLine((Meter)foot);
        }
    }

    class Foot {
        double length;
        private static double footToMeterRatio = 2.1;

        public Foot(double length) {
            this.length = length;
        }

        public override string ToString() {
            return length + " foot long";
        }

        public static explicit operator Meter(Foot foot) {
            return new Meter(foot.length * footToMeterRatio);
        }
    }

    class Meter {
        double length;
        private static double meterToFootRatio = 1 / 2.1;

        public Meter(double length) {
            this.length = length;
        }

        public override string ToString() {
            return length + " meter long";
        }

        public static explicit operator Foot(Meter meter) {
            return new Foot(meter.length * meterToFootRatio);
        }
    }
}
