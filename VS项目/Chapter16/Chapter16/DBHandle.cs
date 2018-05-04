using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter16
{
    class DBHandle
    {
        private string strConn = "Data Source=.;Initial Catalog=QQDB;User ID=sa;Password=zhang";

        SqlConnection conn = null;

        SqlCommand cmd = null;

        #region 检查管理员信息
        /// <summary>
        /// 检查管理员信息
        /// </summary>
        /// <returns></returns>
        public bool CheckAdmin(string admin,string pwd)
        {
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                string sql = "select count(*) from admin where LoginId ='" + admin + "'and LoginPwd = '" + pwd + "'";
                cmd = new SqlCommand(sql,conn);
                int count = (int)cmd.ExecuteScalar();
                if (count != 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
               

            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        #endregion

        #region 获取学生信息列表
        /// <summary>
        /// 获取学生信息列表
        /// </summary>
        /// <returns></returns>
        public SqlDataReader GetUser()
        {
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                string sql = "select [UserId],[UserName],[levelId],[Email],[OnlineDay] from UserInfo ";
                cmd = new SqlCommand(sql,conn);
                return cmd.ExecuteReader();

            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region 更新天数
        /// <summary>
        /// 更新天数
        /// </summary>
        /// <returns></returns>
        public int UpdateOnlineDay(int userId,double newOnlineDay)
        {
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                string sql = "update UserInfo set [OnLineDay] = '"+newOnlineDay+"' where [UserId] = '"+userId+"'";
                cmd = new SqlCommand(sql, conn);
                return cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return -1;
            }
        }
        #endregion

        #region 用户等级更新
        /// <summary>
        /// 用户等级更新
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="iLive"></param>
        /// <returns></returns>
        public int UpdateUserLeve(int userId, int iLive)
        {
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                 string sql = "update ";
                cmd = new SqlCommand(sql, conn);
                return cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return -1;
            }
        }
        #endregion

        #region 添加用户
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPwd"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public object InsertUser(string userName,string userPwd,string email)
        {
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                string sql = "insert ";
                cmd = new SqlCommand(sql, conn);
                return cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return -1;
            }
        }
        #endregion

        #region 按用户编号查询
        /// <summary>
        /// 按用户编号查询
        /// </summary>
        /// <returns></returns>
        public SqlDataReader GetUserByID(int UserId)
        {
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                string sql = "select    where    ---- ";
                cmd = new SqlCommand(sql, conn);
                return cmd.ExecuteReader();

            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region 删除用户信息
        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <returns></returns>
        public int DeleteUserInfo()
        {
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                string sql = "delete ";
                cmd = new SqlCommand(sql, conn);
                return cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return -1;
            }
        }
        #endregion

    }
    
}
