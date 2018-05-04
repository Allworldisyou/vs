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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public string name;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("是否退出？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (s==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            tboUserName.Text += name;
        }
    }
}
