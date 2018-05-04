using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day08_0400
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //点击添加父节点
        private void btnFather_Click(object sender, EventArgs e)
        {
            string textValue = txtName.Text;
            TreeNode tn = new TreeNode();
            tn.Text = textValue;
          
            
            tvShwo.Nodes.Add(tn);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //点击添加子节点
        private void btnChild_Click(object sender, EventArgs e)
        {
            string textValue = txtName.Text;
            TreeNode tn = new TreeNode();
            tn.Text = textValue;

            TreeNode selectNode = tvShwo.SelectedNode;
            foreach (TreeNode item in selectNode.Nodes)
            {
                if (item.Text == textValue)
                {
                    MessageBox.Show("已存在");

                    
                }

                 selectNode.Nodes.Add(tn);
            }

          


        }

        private void tvShwo_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(tvShwo.SelectedNode.Text);
        }
    }
}
