using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap13 {
    class Ex2 {
        static public void run() {
            ProgramHelper converter = new ProgramHelper();
            string code = "hello world";
            Console.WriteLine(converter.ConvertToCSharp(code));
            Console.WriteLine(converter.ConvertToVB(code));
        }
    }

    class ProgramHelper : ProgramConverter, ICodeChecker {
        public bool CodeCheckSyntax(string code, string lan) {
            return true;
        }
    }
}
