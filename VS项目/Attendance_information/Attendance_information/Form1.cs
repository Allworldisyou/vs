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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdd a = new FrmAdd();
            a.f1 = this;
            a.Show();
            
        }
         public Dictionary<string, info> dic = new Dictionary<string, info>();

         public void NewAddress(Dictionary<string, info> a)
         {
             BindingSource bs = new BindingSource();
             bs.DataSource = a.Values;
             this.dgvShow.DataSource = bs;
         }


        private void Form1_Load(object sender, EventArgs e)
        { 
            info i = new info();
            i.Id = 111;
            i.Name = "员工一";
            i.Age = 22;
            i.Sex = "男";
            dic.Add(i.Name,i);
            BindingSource bs = new BindingSource();
            bs.DataSource = dic.Values;
            this.dgvShow.DataSource = bs;
            
        }

       
      

    }
}
