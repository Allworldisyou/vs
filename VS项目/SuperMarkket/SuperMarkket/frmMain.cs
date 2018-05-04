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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        #region 退出
        private void btnCanle_Click(object sender, EventArgs e)  
        {
            DialogResult result =  MessageBox.Show("是否要退出？", "提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.OK)  //确认是否退出
            {
                 Application.Exit();  // 退出
            }
           
        }
        #endregion

        
        private void btnOk_Click(object sender, EventArgs e)
        {
            show();

        }
        
        #region 登录验证
        public void show()
        {
            string con = "Data Source=.;Initial Catalog=SuperMarket;Integrated Security=True";
            SqlConnection conn = new SqlConnection(con);
            string userName =txtUserName .Text;
            string pwd = txtPassWord.Text;

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
                    string sql = @"select * from [User]  where UserName = '" + userName + "' and PassWord = '" + pwd + "'";
                    //用sqlcomman执行命令
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //处理返回
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                      
                        //创建登陆页面的对象
                        Form2 sb = new Form2();
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
        #endregion

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

    }
}
