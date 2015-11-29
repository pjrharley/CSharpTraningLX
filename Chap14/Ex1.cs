using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap14 {
    class Ex1 {
        static public void Run() {
            Animal[] animals = new Animal[3];
            animals[0] = new Dog(5.2, "Tom");
            animals[1] = new Cat(1.2, "Shelly");
            animals[2] = new Dog(2.3, "Tommy");

            foreach(Animal animal in animals) {
                animal.Move();
                animal.Speak();
                Console.WriteLine(animal);
            }
        }
    }

    abstract class Animal : IComparable<Animal> {
        protected double weight;
        protected string name;

        public abstract void Speak();
        public abstract void Move();
        public override abstract string ToString();

        public int CompareTo(Animal obj) {
            return weight.CompareTo(obj.weight);
        }

        public int CompareTo(Animal obj, Animal.AnimalComparer.ComparisonType comparisonType) {
            switch(comparisonType) {
                case Animal.AnimalComparer.ComparisonType.weight:
                    return this.weight.CompareTo(obj.weight);
                case AnimalComparer.ComparisonType.name:
                    return this.name.CompareTo(obj.name);
                default:
                    return 0;
            }
        }

        public class AnimalComparer : IComparer<Animal> {
            public enum ComparisonType {
                weight,
                name
            };

            private ComparisonType whichComparison;
            public ComparisonType WhichComparison {
                get { return whichComparison; }
                set { this.whichComparison = value; }
            }

            int IComparer<Animal>.Compare(Animal x, Animal y) {
                return x.CompareTo(y, WhichComparison);
                throw new NotImplementedException();
            }
        }
    }

    class Cat : Animal {
        public Cat(double weight, string name) {
            this.weight = weight;
            this.name = name;
        }

        public override void Speak() {
            Console.WriteLine("Cat speaks");
        }

        public override void Move() {
            Console.WriteLine("Cat moves");
        }

        public override string ToString() {
            return "I am " + name;
        }
    }

    class Dog : Animal {
        public Dog(double weight, string name) {
            this.weight = weight;
            this.name = name;
        }

        public override void Speak() {
            Console.WriteLine("Dog speaks");
        }

        public override void Move() {
            Console.WriteLine("Dog moves");
        }

        public override string ToString() {
            return "I am " + name;
        }
    }
}
