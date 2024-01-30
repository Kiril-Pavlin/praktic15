using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум___15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"x\ty");
            Console.WriteLine();
            for (double x = 0; x <= 5.2; x += 0.2)
            {
                double y = Math.Sin(x);
                Console.Write(x);
                Console.WriteLine($"\t{y:f2}");

            }
            Console.ReadKey();
        }
    }
}
