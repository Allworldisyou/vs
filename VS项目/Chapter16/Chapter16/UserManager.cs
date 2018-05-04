using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter16
{
    class UserManager
    {
        DBHandle db = new DBHandle();

        #region 登陆
        public void deng()
        {
            int count = 0;
            do
            {
            Console.WriteLine("请输入用户名：");
            string Admin = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string Pwd = Console.ReadLine();
            bool abc = db.CheckAdmin(Admin,Pwd);
           if (abc)
           {
               Console.WriteLine("登陆成功！");
               show();
               break;
           }
           else
           {
               Console.WriteLine("账户名或密码错误，请重新输入！");
           }
           count++;
                if (count == 3)
                {
                    Console.WriteLine("连续三次登陆失败，退出本系统！！！");
                    break;
                }
            } while (true);
        }
        #endregion

        #region 菜单及选择
        public void show()
        {
            int choose;
            do
            {
            Console.WriteLine("===欢迎登陆用户信息管理系统===");
            Console.WriteLine("--------请选择菜单项--------");
            Console.WriteLine("1.显示用户清单");
            Console.WriteLine("2.更新在线天数");
            Console.WriteLine("3.添加用户新记录");
            Console.WriteLine("4.更新用户等级");
            Console.WriteLine("5.删除用户记录");
            Console.WriteLine("0.退出");
            Console.WriteLine("===============================");
            Console.Write("请选择：");
            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1 :
                    first();
                    break;
                case 2:
                    Console.WriteLine("请输入要更新的ID：");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("请输入新的在线天数：");
                    double newDay = double.Parse(Console.ReadLine());
                    db.UpdateOnlineDay(id,newDay);
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 0: 
                    Console.WriteLine("感谢使用，再见！");
                    break;
                default:
                   
                    break;
            }
            } while (choose !=0);

            Console.ReadKey();
        }
        #endregion

        #region 情况一
        public void first()
        {
            SqlDataReader reader = db.GetUser();
            if (reader == null)
            {
                Console.WriteLine("出现异常！！");
                return;
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("编号   昵称      等级     邮箱           在线天数");
            Console.WriteLine("------------------------------------------------------");
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                //循环遍历
                sb.AppendFormat("{0} {1}      {2}  {3}      {4}", reader["UserId"], reader["UserName"], reader["levelId"], reader["Email"], reader["OnlineDay"]);
                Console.WriteLine(sb);
                sb.Length = 0;
            }
        }
        #endregion

        #region 情况二
        public void second()
        {
        }
        #endregion
    }

}
