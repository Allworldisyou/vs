using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMain
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void frmLogin_Click(object sender, EventArgs e)
        {
            if(this.BackColor == Color.Pink)
            {
                this.BackColor=Color.Peru;
            }else if(this.BackColor ==Color.Peru)
            {
                this.BackColor = Color.BlueViolet;
            }
            else if(this.BackColor == Color.BlueViolet)
            {
                this.BackColor = Color.Purple;
            }
            else if(this.BackColor == Color.Purple)
            {
                this.BackColor = Color.YellowGreen;
            }
            else {
                this.BackColor = Color.Pink;
            }
        }
    }
}
