using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10 {
    class Ex3 {
        static public void run() {
            string[][] awards = new string[][] { new string[]{ "1st", "2nd"}, new string[]{ "2nd", "3rd" } };
            for (int dogIndex = 0; dogIndex < awards.Length; dogIndex++) {
                for (int awardIndex = 0; awardIndex < awards[dogIndex].Length; awardIndex++) {
                    Console.Write(awards[dogIndex][awardIndex] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
