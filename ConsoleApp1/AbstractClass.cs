using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Challenges
{
    abstract public class Animal
    {
        public string Name { get; set; }
        public int Legs { get; set; }
        public bool Mammal { get; set; }
        public Animal() { }
        public Animal(string name, int legs, bool mammal)
        {
            Name = name;
            Legs = legs;
            Mammal = mammal;
        }

        public void Run()
        {
            if (Legs > 0)
            {
                Console.WriteLine($"You got to close! The {Name} ran away");
            }
            else
            {
                Console.WriteLine($"You got to close! The {Name} slithered away");
            }
        }
    }

    class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog() { }
        public Dog(string breed, string name, int legs, bool mammal) : base(name, legs, mammal)
        {
            Breed = breed;
        }
        public void dogBreed()
        {
            Console.WriteLine($"This dog is a {Breed}");
        }
    }

    class Cat : Animal
    {
        public bool IsHypoAllergenic { get; set; }
        public Cat() { }
        public Cat(bool isHypoAllergenic, string name, int legs, bool mammal) : base(name, legs, mammal)
        {
            IsHypoAllergenic = isHypoAllergenic;
        }
        public void Sneeze()
        {
            if (IsHypoAllergenic)
            {
                Console.WriteLine("phew, I thought I was goint to sneeze");
            }
            else
            {
                Console.WriteLine("achooooooooooo");
            }
        }
    }

    class Snake : Animal
    {
        public bool IsPosionous { get; set; }
        public Snake() { }
        public Snake(bool isPosionous, string name, int legs, bool mammal) : base(name, legs, mammal)
        {
            IsPosionous = isPosionous;
        }
        public void Strike()
        {
            if (IsPosionous)
            {
                Console.WriteLine("You should go to the hospital");
            }
            else
            {
                Console.WriteLine("Ouch!");
            }
        }
    }

}
