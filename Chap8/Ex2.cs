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

        public string Colour { get; } = "blue";

        public double Weight { get; set; }
    }
}
