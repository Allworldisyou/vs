using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13Demo0
{
    class ayy
    {
        string Strstring = "Data Source=.;Initial Catalog=MySchool;User ID=sa;Password=zhang";
        SqlConnection conn = null;

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="userName">姓名</param>
        /// <param name="pwd">密码</param>
        /// <param name="strMsg">返回语句</param>
        /// <returns>返回值</returns>
        public bool checkUserBaseInfo(string userName, string pwd, string strMsg)
        {
            conn = new SqlConnection(Strstring);
            try
            {
                //创建SQL语句
                string sql = "select * from Admin where LoginId='"+userName+"' and LoginPwd='"+pwd+"' ";
                conn.Open();
                //创建command对象
                SqlCommand comm = new SqlCommand(sql,conn);
                int reat = (int)comm.ExecuteScalar();
                if (reat != 1)
                {
                    strMsg = "用户密码错误！！";
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("有异常："+ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
                Console.WriteLine("数据库关闭成功！！");

                Console.ReadKey();
            }

          
        }
       

    }
}
