using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileManager
{
    public partial class frmManin : Form
    {
        public frmManin()
        {
            InitializeComponent();
        }

        private void 增加信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.Show();
        }
    }
}
