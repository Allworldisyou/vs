using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Small
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRootNode();
        }

        #region 加载驱动器

        private void LoadRootNode()
        {
            TreeNode tn = new TreeNode();
            tn.Text = "C:\\";
            tn.Tag = "C:\\";
            this.tvDirectory.Nodes.Add(tn);


            TreeNode tn1 = new TreeNode();
            tn1.Text = "D:\\";
            tn1.Tag = "D:\\";
            this.tvDirectory.Nodes.Add(tn1);

            TreeNode tn2 = new TreeNode();
            tn2.Text = "F:\\";
            tn2.Tag = "F:\\";
            this.tvDirectory.Nodes.Add(tn2);

            TreeNode tn3 = new TreeNode();
            tn3.Text = "G:\\";
            tn3.Tag = "G:\\";
            this.tvDirectory.Nodes.Add(tn3);

            TreeNode tn4 = new TreeNode();
            tn4.Text = "H:\\";
            tn4.Tag = "H:\\";
            this.tvDirectory.Nodes.Add(tn4);
        }
        #endregion

        #region 绑定
        private void BingInfo(TreeNode node)
        {
            #region 绑定子目录

            DirectoryInfo directoryInfo = new DirectoryInfo(node.Tag.ToString());
            DirectoryInfo[] dirs = directoryInfo.GetDirectories();
            foreach (DirectoryInfo di in dirs)
            {
                TreeNode temp = new TreeNode();
                temp.Text = di.Name;
                temp.Tag = di.FullName;
                node.Nodes.Add(temp);
            } 
            #endregion

            #region 绑定本目录中的文件

            FileInfo[] fileInfo = directoryInfo.GetFiles();
            List<MyFile> files = new List<MyFile>();
            foreach (FileInfo myFile in fileInfo)
            {
                MyFile file = new MyFile();
                file.FileName = myFile.Name;
                file.FileLength = myFile.Length;
                file.FileType = myFile.Extension;
                file.FilePath = myFile.FullName;
                files.Add(file);
            } 
            #endregion

            #region 绑定listView

            ListViewItem item = null;
            this.lvDirectory.Items.Clear();
            foreach (MyFile file in files)
            {
                item = new ListViewItem();
                item.Text = file.FileName;
                item.SubItems.Add(file.FileLength.ToString());
                item.SubItems.Add(file.FileType);
                item.SubItems.Add(file.FilePath);
                this.lvDirectory.Items.Add(item);
            } 
            #endregion

        }
        #endregion

        #region 选择后

        private void tvDirectory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = this.tvDirectory.SelectedNode;
            this.BingInfo(node);

        } 
        #endregion

        #region 复制

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lvDirectory.SelectedItems.Count == 0)
            {
                return;
            }
            //提示用户选择文件夹
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            //源文件路径
            string sourcePath = lvDirectory.SelectedItems[0].SubItems[3].Text;
            //目标文件路径
            string desPath = null;
            //如果正确选择目标位置，执行复制操作

            if (result == DialogResult.OK)
            {
                desPath = fbd.SelectedPath;
                desPath += "\\" + lvDirectory.SelectedItems[0].SubItems[0].Text;
                //复制文件
                File.Copy(sourcePath, desPath);
                MessageBox.Show("复制成功！");
            }
        } 
        #endregion

        #region 删除
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lvDirectory.SelectedItems.Count == 0)
            {
                return;
            }
            //要删除的文件
            string sourcePath = lvDirectory.SelectedItems[0].SubItems[3].Text;
            DialogResult result = MessageBox.Show(this, "确定要删除吗?", "警告!",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
             if (result == DialogResult.OK)
             {
                 File.Delete(sourcePath);
                 MessageBox.Show("删除成功!");
             }
             //移除
             this.lvDirectory.SelectedItems[0].Remove();

        }
        
        #endregion

    }
}
