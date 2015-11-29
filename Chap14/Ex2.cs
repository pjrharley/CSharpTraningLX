using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap14 {
    class Ex2 {
        static public void Run() {
            int numOfAnimals = 10;
            List<Animal> animals = new List<Animal>();
            Random random = new Random();
            while (numOfAnimals-- > 0) {
                Animal animal;
                if (random.Next(10) > 5) {
                    animal = new Dog(random.Next(1000), "dog" + animals.Count);
                } else {
                    animal = new Cat(random.Next(100), "cat" + animals.Count);
                }
                animals.Add(animal);
            }
            foreach (Animal animal in animals) {
                Console.WriteLine(animal);
            }

            animals.Sort();

            foreach (Animal animal in animals) {
                Console.WriteLine(animal);
            }
        }
    }
}
