using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap13 {
    class Ex4 {
        static public void Run() {
            ProgramConverter[] converters = new ProgramConverter[3];
            converters[0] = new ProgramConverter();
            converters[1] = new ProgramHelper();
            converters[2] = new ProgramConverter();

            foreach(ProgramConverter converter in converters) {
                ICodeChecker codeChecker = converter as ICodeChecker;
                if (codeChecker != null) {
                    Console.WriteLine(codeChecker.CodeCheckSyntax("hello", "c#"));
                }
            }
        }
    }

    class ProgramConverter : IConvertible {
        public string ConvertToCSharp(string s) {
            return "CSharp code";
        }

        public string ConvertToVB(string s) {
            return "VB code";
        }
    }
}
