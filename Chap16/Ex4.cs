using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap16 {
    class Ex4 {
        static public void Run() {
            List<Cat> cats = new List<Cat>();
            Random rnd = new Random();
            int numOfCats = 50;
            while (numOfCats-- > 0) {
                try {
                    CatManager.CheckCatAge(new Cat(rnd.Next(-20, 150)));
                } catch (CustomCatError e) {
                    Console.WriteLine(e.Message);
                } catch (ArgumentOutOfRangeException) {
                    Console.WriteLine("Invalid age");
                } catch {
                    Console.WriteLine("Unknown errors");
                } 
            }
        }
    }

    class CustomCatError : System.ApplicationException {
        public CustomCatError(string message) : base(message) {
        }
    }

    class CatManager {
        static public void CheckCatAge(Cat cat) {
            if (cat.Age <= 0) {
                throw new CustomCatError("Age <= 0, invalid age");
            }
        }
    }
}
