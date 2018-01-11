using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap11 {
    class Ex3 {
        static public void run() {
            Telephone phone = new DigitalPhone();
            Telephone phone2 = new TalkingPhone();
            phone.Ring();
            phone2.Ring();
        }
    }

    class DigitalPhone: Telephone {
        public DigitalPhone() {
            this.phoneType = "Digital";
        }

        public override void Ring() {
            Console.WriteLine("Digital phone");
        }

        public virtual void VoiceMail() {
            Console.WriteLine("You have a message. Press to play");
        }
    }

    class TalkingPhone : Telephone {
        public TalkingPhone() {
            this.phoneType = "Talking";
        }

        public override void Ring() {
            Console.WriteLine("Talking phone");
        }
    }
}
