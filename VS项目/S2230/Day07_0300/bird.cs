using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_0300
{
    class bird:IFly,IEat
    {
        public void fly()
        {
            Console.WriteLine("我要飞啦！");
        }

        public void eat()
        {
            Console.WriteLine("飞的累了，吃东西！！");
        }
    }
}
