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

namespace backStage
{
    public partial class frmUpdatePassWord : Form
    {
        public frmUpdatePassWord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Change();
        }


        public string pwd1;
        public string name;
        #region 修改密码
        public void Change()
        {
            SqlConnection conn = new SqlConnection(conStr.str);
            string oldPwd = txtOldPwd.Text;
            string newPwd = txtNewPwd.Text;
            string newPwdTure = txtNewPwdTure.Text;
            
            string UserName = txtUserName.Text;
            string sql = "select * from dbo.admin_info";
            conn.Open();
            //创建Command

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader count = cmd.ExecuteReader();
            while (count.Read())
            {
                if (count["admin_pwd"].ToString().Equals(oldPwd))
                {
                     pwd1 = count["admin_pwd"].ToString();
                name = count["admin_name"].ToString();
                }
               
            }
            count.Close();
            conn.Close();

            if (UserName.Equals(name))
            {
                if (oldPwd == pwd1)
                {
                    if (newPwd.Equals(newPwdTure))
                    {
                        if (newPwd != oldPwd)
                        {
                            try
                            {
                                conn.Open();
                                string sql1 = "  update [admin_info] set [admin_pwd] = '"+newPwd+"' where [admin_name] = '"+UserName+"'";
                                SqlCommand cmd1 = new SqlCommand(sql1, conn);

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
            else
            {
                MessageBox.Show("用户名不存在！", "提示", MessageBoxButtons.OKCancel);
            }
        }
        #endregion

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txtNewPwdTure_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否取消修改密码？","操作提示",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }



    }
}
