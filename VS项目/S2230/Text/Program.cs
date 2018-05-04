using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass x = new MyClass();
            MyClass y = new MyClass();
            x.MyInt = 20;
            y = x;
            y.MyInt = 30;
            Console.WriteLine("x={0},y={1}",x.MyInt,y.MyInt);
            Console.ReadLine();
        }
    }
}
