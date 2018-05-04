using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13
{
    class Program
    {
        static void Main(string[] args)
        {

            // 数据库连接字符串
            string coonString = "Data Source=.;Initial Catalog=MySchool;User ID=sa;Password=zhang";
            // 创建sqlConnection连接对象
            SqlConnection coon = new SqlConnection(coonString);
            // 打开数据库连接
            coon.Open();
            Console.WriteLine("开启成功！！");
            // 关闭数据库连接
            coon.Close();
            Console.WriteLine("关闭成功！！");
            Console.ReadLine();
        }
    }
}
