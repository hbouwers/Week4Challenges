using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4Challenges;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog lab = new Dog("Labradodle","Dog", 4,true);
            Cat willow = new Cat(false, "Cat", 4, true);
            Snake cobra = new Snake(true, "Cobra", 0, false);

            cobra.Run();
            lab.Run();
            willow.Sneeze();
            Console.ReadLine();
        }
    }
}
