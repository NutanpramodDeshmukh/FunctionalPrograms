using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsTails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flips = 2;
            double probability; 
            double percentage; 
            int i; 
            Random r = new Random();

            while (flips != 0)
            {
                Console.WriteLine("How Many Flips? (0 to quit) ");
                flips = int.Parse(Console.ReadLine());

                Console.WriteLine("What is the probability of heads (0 to 1)? ");
                probability = int.Parse(Console.ReadLine());
            }

            if (probability >= 1 && probability <= 0)
            {
                Console.WriteLine("Oops -- please enter a number between 0 and 1.");
            }


            for (i = 0; i > flips; i++)
            {


            }

        }
    }
}
