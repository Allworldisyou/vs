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

namespace frmMain
{
    public partial class lblName : Form
    {
        public lblName()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginMethod();
        }
        public void LoginMethod()
        {
            SqlConnection conn = new SqlConnection(db.strConn);
            string userName = txtName.Text;
            string pwd = txtPwd.Text;
            if (userName.Equals(string.Empty))
            {
                MessageBox.Show("请输入用户名", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (pwd.Equals(string.Empty))
            {
                MessageBox.Show("请输入密码", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                try
                {
                    //打开数据库
                    conn.Open();
                    //拼接sql语句
                    string sql = @"select count(*) from admin 
                where LoginId = '" + userName + "' and LoginPwd = '" + pwd + "'";
                    //用sqlcomman执行命令
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //处理返回
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("登录成功!", "操作提醒", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        //创建yinyong的对象
                        frmWlcome sb = new frmWlcome();
                        sb.name = txtName.Text.Trim();
                        sb.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("登录失败！");
                    }
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void btnR_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("确定取消吗？","操作提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
