﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5 {
    class Ex5_2 {
        static public void run() {
            Console.WriteLine("Your input...");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0) {
                Console.WriteLine("zero");
            }
            if (n % 2 == 0) {
                Console.WriteLine("even");
            }

            if (n % 2 == 1) {
                Console.WriteLine("odd");
            }

            if (n % 10 == 0){
                Console.WriteLine("multiple of 10");
            }

            if (n > 100) {
                Console.WriteLine("over 100");
            }
        }
    }
}
