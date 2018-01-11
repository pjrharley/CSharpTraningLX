using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap13 {
    class Ex3 {
    }

    interface ICodeChecker : IConvertible {
        bool CodeCheckSyntax(string code, string lanuage);
    }
}
