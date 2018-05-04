using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarkket
{
    public partial class frmChangePwd : Form
    {
        public frmChangePwd()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Change();
        }






        public string pwd1;

        #region 修改密码
        public void Change()
        {
            SqlConnection conn = new SqlConnection(connStr.str);
            string oldPwd = txtOldPwd.Text;
            string newPwd = txtNewPwd.Text;
            string newPwdTure = txtNewPwdTure.Text;
               string sql = "select * from [User]";
           
           
            conn.Open();
            //创建Command
          
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader count = cmd.ExecuteReader();
                while (count.Read())
                {
                      pwd1 = count["PassWord"].ToString();
                }
                count.Close();
                conn.Close();

                if (oldPwd == pwd1)
                {
                    if (newPwd.Equals(newPwdTure))
                    {
                        if (newPwd != oldPwd)
                        {
                            try
                            {
                                conn.Open();
                                string sql1 = "  update [User] set [PassWord] = '" + newPwd + "' where [PassWord] = '" + oldPwd + "'";
                                SqlCommand cmd1 = new SqlCommand(sql, conn);

                                int count1 = cmd1.ExecuteNonQuery();
                                if (count1 > 0)
                                {
                                    MessageBox.Show("修改成功！密码为：" + newPwd);
                                }
                                else
                                {
                                    MessageBox.Show("修改失败");
                                }


                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("出错啦！！" + ex);
                            }
                            finally
                            {
                                conn.Close();
                            }

                        }
                        else
                        {
                            MessageBox.Show("新旧密码不可以相同", "提示", MessageBoxButtons.OKCancel);
                        }
                    }
                    else
                    {
                        MessageBox.Show("两次密码不一致！", "提示", MessageBoxButtons.OKCancel);
                    }

                }
                else
                {
                    MessageBox.Show("旧密码错误！", "提示", MessageBoxButtons.OKCancel);
                }
        }
        #endregion
    }
}
