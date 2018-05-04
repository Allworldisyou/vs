using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.book.util
{
    public class DBHLper
    {
        private string  strString="server=. ;database = Book; uid =sa;pwd = zhang";
        private SqlConnection conn;
        private  SqlCommand cmd;
        #region 打开数据库方法
        //打开数据库方法
        public void openConnection()
        {
            //判断是否为空
            if (conn == null)
            {
                //创建对象
                conn = new SqlConnection(strString);
                //打开数据库
                conn.Open();
            }
                //判断数据库是否为关闭状态
            else if (conn.State == ConnectionState.Broken)
            {
                //关闭数据库
                conn.Close();
                //打开数据库
                conn.Open();
            }
            else
            {
                //打开数据库
                conn.Open();
            }
        }
        #endregion

        #region 关闭数据库方法
        public void closeConnection()
        {
            //判断状态不为空 并且 状态不为关闭状态
            if(conn != null && conn.State != ConnectionState.Closed)
            {
                //关闭
                conn.Close();
            }
        }
        #endregion

        #region 查询方法
        /// <summary>
        /// 查询方法
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>返回值</returns>
        public SqlDataReader Read(string sql)
        {
            try
            {
                //创建命令对象
                using (cmd = new SqlCommand(sql, conn))
                {
                    //执行SQL语句，并返回结果
                    return cmd.ExecuteReader();
                }
            }
            catch (Exception)
            {
                //异常返回空
                return null;
            }
        }
        #endregion

        #region 执行增删改
        /// <summary>
        /// 执行增删改
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>返回值，异常返回-1</returns>
        public int NonQuery(string sql)
        {
            try
            {
                //创建命令对象
                using (cmd = new SqlCommand(sql, conn))
                {
                    //执行SQL语句，并返回结果
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                //异常返回空
                return -1;
            }
        }
        #endregion





    }
    
}
