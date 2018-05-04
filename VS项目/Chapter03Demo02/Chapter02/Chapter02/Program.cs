using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    class Program
    {
       public void  show()
        {
            Console.Write("账号：");
            int number = int.Parse(Console.ReadLine());
            Console.Write("密码：");
            int password = int.Parse(Console.ReadLine());
            if (number == 123456789 && password == 111)
            {
                Console.WriteLine("登录成功！！");
                //cun(1);
            }
            else {
                Console.WriteLine("账号或密码错误，请重新输入！！！");
                show();
            }
        }
       public int cun(int victory)
       {
           
           Console.Write("请输入取款金额：");
           int qu = int.Parse(Console.ReadLine());
           if (qu > 0 && qu < 8000)
           {
               return victory = 0;
           }
           else 
           {
               return victory = 1;
           }

        }


    }
}
