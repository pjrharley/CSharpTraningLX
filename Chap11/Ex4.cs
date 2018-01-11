using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap11 {
    class Ex4 {
        static public void run() {
            DigitalPhone digitalPhone = new DigitalPhone();
            digitalPhone.VoiceMail();
            DigitalPhone digitalPhone2 = new DigitalCellPhone();
            digitalPhone2.VoiceMail();
        }
    }

    class DigitalCellPhone: DigitalPhone {
        public override void VoiceMail() {
            Console.WriteLine("You have a message. Call to play");
        }
    }
}
