using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            double s = 0.0;

            Console.WriteLine("\n\n");
            Console.WriteLine("Calculate the harmonic series and their sum:\n");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("\n\n");

            Console.WriteLine("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n");
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.WriteLine("\nSum of Series upto {0} terms : {1} \n", n, s);

        }
    }
}
