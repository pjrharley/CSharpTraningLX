using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chap15 {
    class Ex4 {
        static public void Run() {
            string s = "we hold these truths. hello\nsdds";
            Regex rgx = new Regex(" |，|\n");
            StringBuilder sb = new StringBuilder();
            string[] words = rgx.Split(s);
            for (int i = 0; i < words.Length; i++) {
                sb.AppendLine("line " + (i + 1) + ": " + words[i]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
