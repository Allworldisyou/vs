using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETmoshou
{
    public partial class FrmRegist : Form
    {
        public FrmRegist()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否取消注册？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tboName.Text;
            string No = tboPersonNo.Text;
            string email = tboE.Text;
            string emaila = tboEAgin.Text;
            string pwd = tboPassWord.Text;
            string pwda = tboPassWordAgin.Text;
            if (name.Equals(string.Empty)||No.Equals(string.Empty)||email.Equals(string.Empty)||emaila.Equals(string.Empty)||pwd.Equals(string.Empty)||pwda.Equals(string.Empty))
            {
                MessageBox.Show("输入不能为空！！","错误提示",MessageBoxButtons.OK);
            }
            else if (!email.Equals(emaila) || !pwd.Equals(pwda))
            {
                MessageBox.Show("两次输入不一致！！", "错误提示", MessageBoxButtons.OK);
            }
            else
            {
                LoginInfo info = new LoginInfo();
                info._name = name;
                info._id = No;
                info._email = email;
                info._password = pwd;
                FrmLogin.Add(info);
               DialogResult result = MessageBox.Show("添加成功！","",MessageBoxButtons.OK);
               if (result ==DialogResult.OK)
               {
                   this.Close();
               }
            }
        }
    }
}
