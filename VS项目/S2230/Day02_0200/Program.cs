using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_0200
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] xminfo = { 176,60};
            int[] xlinfo = xminfo;
            Console.WriteLine("小明去年身高{0}，体重{1};小李身高{2}，体重{3}", xminfo[0], xminfo[1], xlinfo[0], xlinfo[1]);
            xlinfo[0] = 180;
            xlinfo[1] = 65;
            Console.WriteLine("小明今年身高{0}，体重{1};小李身高{2}，体重{3}", xminfo[0], xminfo[1], xlinfo[0], xlinfo[1]);
            Console.ReadKey();
        }
    }
}
