using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarkket
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePwd changePwd = new frmChangePwd();
            changePwd.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmShow show = new frmShow();
            show.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("是否退出？","温馨提示",MessageBoxButtons.YesNo);
            DialogResult result = DialogResult.Yes;
            if (result == DialogResult.Yes)
            {
                 Application.Exit(); 
            }
        }
    }
}
