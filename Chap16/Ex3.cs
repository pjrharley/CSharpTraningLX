using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap16 {
    class Ex3 {
        static public void Run() {
            List<Cat> cats = new List<Cat>();
            Random rnd = new Random();
            int numOfCats = 50;
            while (numOfCats-- > 0) {
                try {
                    cats.Add(new Cat(rnd.Next(-5, 110)));
                } catch (ArgumentOutOfRangeException) {
                    Console.WriteLine("Invalid age");
                } catch {
                    Console.WriteLine("Unknown errors");
                } finally {
                    Console.WriteLine("Deallocating objects");
                }
            }
            
        }
    }

    class Cat {
        private int age;
        public int Age {
            set {
                age = value;
            }
            get {
                return age;
            }
        }

        public Cat(int age) {
            if (age > 100) {
                throw new ArgumentOutOfRangeException();
            }
            this.age = age;
        }
    }
}
