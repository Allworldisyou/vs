using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2230
{
    class Program
    {
        static void Main(string[] args)
        {
            int heightMing = 170;
            int heightHao = heightMing;
            Console.WriteLine("小明身高：{0},张浩身高{1}", heightMing, heightHao);
            heightHao = 180;
            Console.WriteLine("小明身高：{0},张浩身高{1}", heightMing, heightHao);
            Console.ReadLine();
        }
    }
}
