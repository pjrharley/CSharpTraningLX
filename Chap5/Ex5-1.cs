using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5 {
    class Ex5_1 {
        static public void run() {
            int cnt = 0;
            while (cnt++ < 3) {
                for (int i = 1; i <= 10; i++) {
                    Console.WriteLine(i);
                }
            }

            cnt = 0;
            do {
                for (int i = 1; i <= 10; i++) {
                    Console.WriteLine(i);
                }
            } while (++cnt < 3);

            for (cnt = 0; cnt < 3; cnt++) {
                for (int i = 1; i <= 10; i++) {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
