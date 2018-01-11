using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10 {
    class Ex1 {
        
        static public void run() {
            Dog[] dogs = new Dog[3];
            dogs[0] = new Dog(10, "Hello");
            dogs[1] = new Dog(11, "Yes");
            dogs[2] = new Dog(12, "no");
            foreach (Dog dog in dogs) Console.WriteLine(dog.toString());
        }
    }
    class Dog {
        private int Weight;
        private string Name;

        public Dog(int weight, string name) {
            this.Weight = weight;
            this.Name = name;
        }

        public string toString() {
            return "My name is " + this.Name + ". My weight is " + this.Weight;
        }
    }
}
