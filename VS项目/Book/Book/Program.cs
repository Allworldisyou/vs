using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
     static void Main(string[] args)
        {
            show();
        }
         public static void show()
        {
        bool isR = true;


        do
	       {
	         Console.WriteLine("欢迎登陆图书管理系统");
             Console.WriteLine("1.查看\n2.增加\n3.修改\n4.删除\n5.退出");
             int choose = int.Parse(Console.ReadLine());
             switch (choose)
             {
                 case 1:
                     break;
                 case 2:
                     break;
                 case 3:
                     break;
                 case 4:
                     break;
                 case 5:
                     break;
                 default:
                     break;
             }

           } while (isR);


        }   
       
    }
}
