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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmRegist regist = new FrmRegist();
            regist.ShowDialog();
        }

     private void btnLogin_Click(object sender, EventArgs e)
    {


        foreach (LoginInfo item in array)
        {
            if (item!=null)
            {
                if (tboEmail.Text.Equals(item._email)&&tboPwd.Text.Equals(item._password))
                {
                    FrmMain main = new FrmMain();
                    main.name = item._name;
                    main.Show();
                   
                }
     
            }
        }
    }
        public static LoginInfo[] array= new LoginInfo[10];
        private void FrmLogin_Load(object sender, EventArgs e)
        {
        
            LoginInfo infol = new LoginInfo();
            infol.Name = "孙丽丽";
            infol.Id = "120123456789203216";
            infol.Email = "lili@123.com";
            infol.Password = "lili1998";
            array[0] = infol;
            //Visible = false;
        }
        public static bool Add(LoginInfo yn)
        {
            bool rs = false;


            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = yn;
                    rs = true;
                    break;
                }
            }


            return rs ;
        }
    }
}
