using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01Demo1
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入昵称：");  
            string name = (Console.ReadLine());
            Console.WriteLine("请输入QQ等级：");
            int deng = int.Parse(Console.ReadLine());
            Console.WriteLine(name + "您好！您的QQ等级是：" + deng);
            Console.WriteLine("{0}您好！您的QQ等级是：{1}", name, deng);
            Console.ReadLine();
        }
    }
}
