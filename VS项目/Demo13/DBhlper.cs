using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo13
{
    /// <summary>
    /// 工具类
    /// </summary>
    class DBhlper
    {
        
        // 定义连接数据库字符串
        // string connString = "server = .;database = 数据库名;uid = 登录名;pwd = 密码";
        // 创建数据库连接对象（Connection）
        // SqlConnection conn1 = null;
        // 创建执行命令对象（Command）
        // 创建执行查询对象（DataReader）

        //  获取学生名单方法
        // 连接数据库
        // 创建sql语句（string sql / StringBuilder拼接sql）

        // 创建查询对象（new   参数（sql语句，连接数据库））

        // 在执行命令时，如果关闭关联的DataReader对象，则关联的Connection对象也将关闭







        // 连接字符串
        string strString = "Data Source=.;Initial Catalog=MySchool;User ID=sa;Password=zhang";
        SqlDataReader rader = null;
        // SqlConnection对象
        SqlConnection conn = null;

        /// <summary>
        /// 用户验证
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="pwd">密码</param>
        /// <param name="strMsg">需要返回处理的信息</param>
        /// <returns>返回结果（成功&失败）</returns>
        public bool ChenkUserInfo(string username, string pwd,ref string strMsg)
        {
            // 创建SqlCconnection对象
            conn = new SqlConnection(strString);
            try
            {
                // 创建sql语句
                string sql = "select count(*) from Admin where LoginId = '" + username + "' and LoginPwd = '" + pwd + "'";
                // 打开数据库
                conn.Open();

                // 创建SqlCommand对象
                SqlCommand comm = new SqlCommand(sql, conn);
                int Reat = (int)comm.ExecuteScalar();
                if (Reat != 1)
                {
                    strMsg = "用户名密码错误！！！";
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                strMsg = "发生异常！！！";
                return false;
            }
            finally
            {
                // 关闭数据库
                conn.Close();
            }
        }



        public void GetStudentLinst() 
        {
            // 创建SqlConnection连接对象
            conn = new SqlConnection(strString);
            try
            {
                // 打开数据库
                conn.Open();

                // 创建StringBuilder对象
                StringBuilder str = new StringBuilder();
                str.AppendLine("select");
                str.AppendLine("   [StudentNo]    ");
                str.AppendLine(",[StudentName] ");
                str.AppendLine("from ");
                str.AppendLine("    Student");

                // 创建SqlCommand对象
                SqlCommand comm = new SqlCommand(str.ToString(), conn);
               
                rader = comm.ExecuteReader();
                Console.WriteLine("---------------------------");
                Console.WriteLine(" 学号\t 姓名");
                Console.WriteLine("---------------------------");

                StringBuilder sb1 = new StringBuilder();
                //循环读取DataReader
                while (rader.Read())
                {
                    sb1.AppendFormat("{0}\t{1}",rader["StudentNo"],rader["StudentName"]);
                    Console.WriteLine(sb1);
                    sb1.Length = 0;
                }
                Console.WriteLine("---------------------------");

            }
            catch (Exception ex)
            {

                Console.WriteLine("数据操作异常！" + ex);
            }
            finally
            {
                conn.Close();
            }
        }






        #region 打开数据库连接
        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void OopenConnection()
        {
            // 创建SqlConnection连接对象
            conn = new SqlConnection(strString);

            try
            {
                conn.Open();
                Console.WriteLine("打开数据库连接成功！");
            }
            catch (Exception ex)
            {
                Console.WriteLine("异常：" + ex.Message);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("关闭成功！！！");
                Console.ReadLine();
            }

        #endregion
        }

    }
}
