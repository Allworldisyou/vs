using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loveHeart
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double y = 1.5; y > -1.5; y -= 0.1)
            {
                for (double x = -1.5; x < 1.5; x += 0.05)
                {
                    double a = x * x + y * y - 1;                 //0.0
                    Console.Write(a * a * a - x * x * y * y * y <= 0.001 ? '*' : ' ');
                }
                Console.WriteLine();
            }


        
            Console.ReadKey();
        }
    }
}
