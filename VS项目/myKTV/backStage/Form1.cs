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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = tboUserName.Text.ToString();
            string pwd = tboPassWord.Text.ToString();
            SqlConnection conn = new SqlConnection(conStr.str);
            
            try
            {
                conn.Open();
                string sql = "select count(*) from admin_info where admin_name ='"+name+"' and admin_pwd = '"+pwd+"'";
                SqlCommand cmd = new SqlCommand(sql,conn);
                int num = Convert.ToInt32(cmd.ExecuteScalar());
                if (num >0)
                {
                    frmMainMenu mainMenu = new frmMainMenu();
                    this.Hide();
                    mainMenu.Show();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！","温馨提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Hand);
                }

            }
            catch (Exception ex) 
            {

                MessageBox.Show(ex.ToString());
            }
            conn.Close();

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否取消登录？", "操作提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
