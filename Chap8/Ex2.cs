using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap8 {
    class Ex2 {
        static public void run() {
            Dog dog = new Dog();
            Console.WriteLine("give a weight");
            dog.Weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("the colour of your dog is: " + dog.Colour);
            Console.WriteLine("the weight of your dog is: " + dog.Weight);
        }
    }
    
    class Dog {
        private double weight;
        private string colour = "blue";

        public string Colour {
            get {
                return colour;
            }
        }

        public double Weight {
            set {
                this.weight = value;
            }
            get {
                return weight;
            }
        }
    }
}
