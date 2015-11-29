using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15 {
    class Ex1 {
        static public void Run() {
            string[] strings = new string[6];
            strings[0] = "Hello";
            strings[1] = "World";
            strings[2] = @"http://www.google.com/";
            strings[3] = strings[0] + strings[1];
            strings[4] = "world";
            strings[5] = string.Copy(strings[2]);

            foreach(string s in strings) {
                Console.WriteLine(s.Length);
                Console.WriteLine(s[2]);
                Console.WriteLine(s.IndexOf("H"));

                if (s.Equals(strings[1])) {
                    Console.WriteLine(s + " equals to string 2");
                }

                if (s.Equals(strings[1], StringComparison.InvariantCultureIgnoreCase)) {
                    Console.WriteLine(s + " equals to string 2 ignoring case");
                }
            }
        }
    }
}
