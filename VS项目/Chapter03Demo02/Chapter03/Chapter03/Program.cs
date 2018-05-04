using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("初始化成功！！");
            Bank bk = new Bank() {Name="王丽丽",Num=18247,Yue=10000,Key=10086,Pn=1111};
            Console.WriteLine("账户姓名：{0}，账号：{1}，存款余额：{2},密码：{3}，身份证号：{4}",bk.Name,bk.Num,bk.Yue,bk.Key,bk.Pn);
            Bank bk1 = new Bank() { Name = "张颖影", Num = 88607,Yue = 30000, Key = 10086, Pn = 2222 };
            Console.WriteLine("账户姓名：{0}，账号：{1}，存款余额：{2},密码：{3}，身份证号：{4}", bk1.Name, bk1.Num, bk1.Yue, bk1.Key, bk1.Pn);
            Bank bk2 = new Bank() { Name = "刘  华", Num = 8888, Yue = 20000, Key = 10086, Pn = 3333 };
            Console.WriteLine("账户姓名：{0}，账号：{1}，存款余额：{2},密码：{3}，身份证号：{4}", bk2.Name, bk2.Num, bk2.Yue, bk2.Key, bk2.Pn);
            Console.ReadKey();
            Console.WriteLine("=========================欢迎使用自动银行服务=========================");
            Console.WriteLine("1.开户  2.存款  3.取款  4.转账  5.余额查询  6.修改密码  0.退出");
            int choose = int.Parse(Console.ReadLine());
            switch(choose)
            {
            case 1:
                    Console.Write("请输入姓名：");
                    break;
            }
        }
    }
}
