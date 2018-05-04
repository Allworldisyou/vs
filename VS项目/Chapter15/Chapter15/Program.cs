using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15
{
    class Program
    {
        static void Main(string[] args)
        {
            shixian shi = new shixian();
            shi.show();
        }
    }
    class shixian
    {
        public void show()
        {
            String choose;
            string[] name = new string[] { "一度电", "一升水", "一度天然气" };
            double[] en = new double[] { 0.638, 0.194, 2.1 };
            double[] liang = new double[en.Length];
            do
            {
                double sum = 0;
                Console.WriteLine("=============低碳生活计算公式=============");
                for (int j = 0; j < name.Length; j++)
                {
                    Console.WriteLine("省{0}，就减少{1}千克的碳排放", name[j], en[j]);
                }
                Console.WriteLine("==========================================");
                Console.WriteLine("请输入每天的用电量：");
                liang[0] = double.Parse(Console.ReadLine());
                Console.WriteLine("请输入每天的用水量：");
                liang[1] = double.Parse(Console.ReadLine());
                Console.WriteLine("请输入每天的用天然气量：");
                liang[2] = double.Parse(Console.ReadLine());
                for (int i = 0; i < en.Length; i++)
                {
                    sum = sum + en[i] * liang[i];
                }
                Console.WriteLine("你每天生活将会产生碳排放量是：{0}千克", Math.Round(sum, 2));
                Console.WriteLine("希望你继续努力，降低碳排量！");
                Console.WriteLine("");
                Console.WriteLine("继续输入吗？(Y/N)");
                choose = Console.ReadLine();
            } while (choose.Equals("Y"));

            Console.ReadKey();
        }
    }
}
