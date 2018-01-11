using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15 {
    class Ex3 {
        static public void Run() {
            string s = "We choose to go the moon. the";
            Console.WriteLine(count("the", s));
        }
        
        static private int count(string searchString, string s) {
            int cnt = 0;
            while(s.IndexOf(searchString) >= 0) {
                cnt++;
                s = s.Substring(s.IndexOf(searchString) + 1);
            }
            return cnt;
        }
    }
}
