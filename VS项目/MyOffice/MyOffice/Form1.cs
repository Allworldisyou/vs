using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOffice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            FrmShow show = new FrmShow();
        }


        public SE[] engineers= new SE[3]; 
        public void All()
        {
          

            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SE s = new SE();
            s.Id = 111;
            s.Name = "王小毛";
            s.Age = 26;
            s.Show = "未评价";
            s.Scoer = 0;
            engineers[0] = s;

            SE s1 = new SE();
            s1.Id = 222;
            s1.Name = "周新宇";
            s1.Age = 22;
            s1.Show = "未评价";
            s1.Scoer = 0;
            engineers[1] = s1;

            SE s2 = new SE();
            s2.Id = 333;
            s2.Name = "张晔";
            s2.Age = 30;
            s2.Show = "未评价";
            s2.Scoer = 0;
            engineers[2] = s2;

            for (int i = 0; i < engineers.Length; i++)
            {
                ListViewItem item = new ListViewItem(engineers[i].Id.ToString());
                item.SubItems.Add(engineers[i].Name);
                item.SubItems.Add(engineers[i].Age.ToString());
                item.SubItems.Add(engineers[i].Show);
                item.SubItems.Add(engineers[i].Scoer.ToString());
                listView1.Items.Add(item);

            }
        }
    }
}
