using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetTv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTreeView();
        }
        public void UpdateTreeView()
        {
            this.treeView1.Nodes.Clear();
            TreeNode nodeFirstLevel = new TreeNode("我的电视台");
            nodeFirstLevel.ImageIndex = 0;
            this.treeView1.Nodes.Add(nodeFirstLevel);
            nodeFirstLevel = new TreeNode("所有电视台");
            this.treeView1.Nodes.Add(nodeFirstLevel);

            foreach (ChannelBase item in )
            {
                
            }


        }

    }
}
