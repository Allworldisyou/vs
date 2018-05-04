using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    class text
    {
        public static void Main(string []args)
        {
            Program p = new Program();
            p.show();
            if (p.cun(0) == 0)
            {
                Console.WriteLine("取款成功！！");
            }
            else
            {
                Console.WriteLine("取款失败！！！");
            }
            Console.ReadLine();
        }
    }
}
