using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank
{
    class Bank
    {
        User user = new User();


        public void show()
        {
            Bank bank = new Bank();
            bank.chushihua();

            Console.WriteLine("==================欢迎使用自动银行服务==================");
            Console.WriteLine("1：开户  2：存款  3：取款  4：转账  5：余额查询  6：修改密码  0：退出");
            Console.WriteLine("===============================================");
            Console.WriteLine("请选择你要进行的业务编号：");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    bank.NewUser();
                    break;
                case 2:
                    bank.cunKuan();
                    break;
                case 3:
                    bank.quKuan();
                    break;
                case 4:
                    bank.zhuanKuan();
                    break;
                case 5:
                    bank.find();
                    break;
                case 6:
                    bank.gai();
                    break;
                case 0:
                    Console.WriteLine("再见！！！");
                    break;
                default:
                    Console.WriteLine("输入错误，请重新输入！");
                    show();
                    break;
            }
        }

        public void chushihua()
        { 
            user.names[0]="安安";
            user.names[1]="Tom";
            user.names[2]="乐乐";
            user.nums[0] = "111";
            user.nums[1] = "222";
            user.nums[2] = "333";
            user.shenfens[0]="156";
            user.shenfens[1]="1172";
            user.shenfens[2]="9009";
            user.passwords[0]=182;
            user.passwords[1]=4788;
            user.passwords[2]=6078;
            user.moneys[0]=1234;
            user.moneys[1]=5678;
            user.moneys[2]=910;
        }
        public void NewUser()
        {
           
            for (int i = 0; i < user.names.Length;i++ )
            {
                if (user.names[i]==null)
                {
                    Console.Write("请输入您的名字：");
                    string newUserName = Console.ReadLine();
                    user.names[i] = newUserName;
                    Console.Write("请输入账户：");
                    string zhanghu = Console.ReadLine();
                    user.nums[i] = zhanghu;
                    Console.Write("请输入您的身份证号码：");
                    string number = Console.ReadLine();
                    user.shenfens[i] = number;
                    Console.Write("请输入密码：");
                    int password = int.Parse(Console.ReadLine());
                    user.passwords[i] = password;
                    //Console.WriteLine("开户成功，信息如下：\n姓名{0}\n账号：{1}\n身份证号：{2}\n密码：{3}",newUserName,zhanghu,number,password);
                    Console.WriteLine("===============================================");
                    
                    if (i == 3)
                    {
                        //Console.WriteLine("AAAAAAAA");
                        Console.WriteLine("开户成功，信息如下：\n姓名{0}\n账号：{1}\n身份证号：{2}\n密码：{3}", newUserName, zhanghu, number, password);
                        
                    }
                    else
                    {
                        Console.WriteLine("BBBBBBBB");
                    }
                    break;
                }
                
                if(i==4){
                    Console.WriteLine("账户已达上限，自动返回上一级！");
                    Console.WriteLine("===============================================");
                    break;
                }
            }
            show();
            
        }//开户
        public void cunKuan()
        {
            
            Console.Write("请输入存款账户:");
            string zhanghu = Console.ReadLine();
            for (int j = 0; j < user.nums.Length; j++)
            {
                if (zhanghu.Equals(user.nums[j]))
                {
                    Console.Write("请输入存款金额：");
                    int cunMoney = int.Parse(Console.ReadLine());
                    user.moneys[j] = user.moneys[j] + cunMoney; 
                    Console.WriteLine("存款成功！！");
                    break;
                }
                else
                {
                    Console.WriteLine("未查询到该账户，请确认后重新输入！！");
                    Console.Write("输入0重新输入，输入其他返回上一层：");
                    int xuan = int.Parse(Console.ReadLine());
                    if (xuan == 0)
                    {
                        cunKuan();
                    }
                }
            }
           show();
        }//存款

        public void quKuan()
        {
            Console.Write("请输入取款账户:");
            string zhangnumber = Console.ReadLine();
            for (int k = 0; k < user.names.Length;k++ )
            {
                if (zhangnumber == user.nums[k])
                {
                    Console.Write("请输入取款金额：");
                    int quMoney = int.Parse(Console.ReadLine());
                    if (quMoney <= user.moneys[k]&&quMoney>0)
                    {
                        user.moneys[k] = user.moneys[k] - quMoney;
                        Console.WriteLine("取款成功！！");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("取款金额不在指定范围内！！");
                    }
                }
                else
                {
                    Console.WriteLine("没找到该用户！！");
                }
            }
            show();
        }//取款
        public void zhuanKuan()
        {
           
            Console.Write("请输入转账账户:");
            string hunumber = Console.ReadLine();
            for (int z = 0; z < user.nums.Length;z++ )
            {
                if(hunumber==user.nums[z])
                {
                    Console.Write("请输入转账金额：");
                    int zhuanMoney = int.Parse(Console.ReadLine());
                    user.nums[z] = user.nums[z] + zhuanMoney;
                    Console.WriteLine("转账成功！！！");
                    break;
                }
            }
            show();
        }//转账
        public void find()
        {
           
            Console.Write("请输入想要查找余额的账户:");
            string findNumber = Console.ReadLine();
            for (int y = 0; y < user.nums.Length; y++)
            {
                if (findNumber == user.nums[y])
                {
                    Console.WriteLine("该账户信息如下：");
                    Console.WriteLine("姓名：{0}\n账号：{1}\n密码：{2}\n身份证号码：{3}\n余额：{4}",user.names[y],user.passwords[y],user.nums[y],user.shenfens[y],user.moneys[y]);
                    break;
                }
            }
                show();
        }//余额查询

        public void gai()
        {
           
            Console.Write("请输入需要修改的账户:");
            string hunumber = Console.ReadLine();
            for (int a = 0; a < user.names.Length;a++ )
            {
                if (hunumber == user.nums[a])
                {
                    Console.Write("请输入新密码：");
                    int newPassword = int.Parse(Console.ReadLine());
                    user.passwords[a] = newPassword;
                    Console.WriteLine("修改成功！！");
                    break;
                }
            }
           show();
        }//修改密码
    }
}
