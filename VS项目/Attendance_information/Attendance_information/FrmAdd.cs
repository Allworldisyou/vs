using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_information
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

        public Form1 f1 { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 f1 = new Form1();
            info fo = new info();
            fo.Id = Convert.ToInt32(tboId.Text);
            fo.Name = tboName.Text;
            fo.Age = Convert.ToInt32(tboAge.Text);
            fo.Sex = cboGender.Text;


            f1.dic.Add(fo.Name,fo);
            this.Close();
            f1.NewAddress(f1.dic);
        }
    }
}
