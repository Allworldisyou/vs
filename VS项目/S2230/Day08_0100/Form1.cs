using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day08_0100
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            int numbeLeft = Convert.ToInt32(txtLeft.Text);
            int numberRight = Convert.ToInt32(txtRight.Text);
            string fu = cboFu.Text;

            All all = SimpleFactory.getInstance(fu);

            all.NumberLeft = numbeLeft;
            all.NumberRight = numberRight;

            try
            {
                int result = all.Cale();
                txtFinally.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtFinally.Text = "";

            }


        }
    }
}
