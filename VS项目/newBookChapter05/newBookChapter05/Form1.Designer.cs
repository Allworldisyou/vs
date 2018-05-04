namespace newBookChapter05
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("男", 3, 3);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("女", 2, 2);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("1", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("男", 3, 3);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("女", 2, 2);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("2", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("男", 3, 3);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("女", 2, 2);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("3", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("全部", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode16,
            treeNode19});
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(387, 43);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(148, 23);
            this.cboClass.TabIndex = 0;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "年级";
            // 
            // dgvMain
            // 
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvMain.Location = new System.Drawing.Point(202, 101);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 27;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(816, 395);
            this.dgvMain.TabIndex = 2;
            this.dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StudentNo";
            this.Column1.HeaderText = "学号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LoginPwd";
            this.Column2.HeaderText = "密码";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "StudentName";
            this.Column3.HeaderText = "姓名";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Sex";
            this.Column4.HeaderText = "性别";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GradeId";
            this.Column5.HeaderText = "年级";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Phone";
            this.Column6.HeaderText = "电话";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Address";
            this.Column7.HeaderText = "地址";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "BornDate";
            this.Column8.HeaderText = "生日";
            this.Column8.Name = "Column8";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "01.gif");
            this.imageList1.Images.SetKeyName(1, "02.gif");
            this.imageList1.Images.SetKeyName(2, "03.gif");
            this.imageList1.Images.SetKeyName(3, "04.gif");
            // 
            // tvMenu
            // 
            this.tvMenu.ImageIndex = 0;
            this.tvMenu.ImageList = this.imageList1;
            this.tvMenu.Location = new System.Drawing.Point(-2, -1);
            this.tvMenu.Name = "tvMenu";
            treeNode11.ImageIndex = 3;
            treeNode11.Name = "节点4";
            treeNode11.SelectedImageIndex = 3;
            treeNode11.Text = "男";
            treeNode12.ImageIndex = 2;
            treeNode12.Name = "节点5";
            treeNode12.SelectedImageIndex = 2;
            treeNode12.Text = "女";
            treeNode13.ImageIndex = 0;
            treeNode13.Name = "节点1";
            treeNode13.SelectedImageIndex = 1;
            treeNode13.Text = "1";
            treeNode14.ImageIndex = 3;
            treeNode14.Name = "节点6";
            treeNode14.SelectedImageIndex = 3;
            treeNode14.Text = "男";
            treeNode15.ImageIndex = 2;
            treeNode15.Name = "节点7";
            treeNode15.SelectedImageIndex = 2;
            treeNode15.Text = "女";
            treeNode16.ImageIndex = 0;
            treeNode16.Name = "节点2";
            treeNode16.SelectedImageIndex = 1;
            treeNode16.Text = "2";
            treeNode17.ImageIndex = 3;
            treeNode17.Name = "节点8";
            treeNode17.SelectedImageIndex = 3;
            treeNode17.Text = "男";
            treeNode18.ImageIndex = 2;
            treeNode18.Name = "节点9";
            treeNode18.SelectedImageIndex = 2;
            treeNode18.Text = "女";
            treeNode19.ImageIndex = 0;
            treeNode19.Name = "节点3";
            treeNode19.SelectedImageIndex = 1;
            treeNode19.Text = "3";
            treeNode20.ImageIndex = 0;
            treeNode20.Name = "节点0";
            treeNode20.SelectedImageIndex = 1;
            treeNode20.Text = "全部";
            this.tvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20});
            this.tvMenu.SelectedImageIndex = 0;
            this.tvMenu.Size = new System.Drawing.Size(176, 567);
            this.tvMenu.TabIndex = 3;
            this.tvMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.修改ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 74);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.修改ToolStripMenuItem.Text = "修改";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 566);
            this.Controls.Add(this.tvMenu);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboClass);
            this.Name = "Form1";
            this.Text = "年级下拉框";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
    }
}

