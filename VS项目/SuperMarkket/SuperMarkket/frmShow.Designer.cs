namespace SuperMarkket
{
    partial class frmShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("正价商品");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("特价商品");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("所有商品", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvShow = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvShow = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsShow = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbChange = new System.Windows.Forms.ToolStripButton();
            this.tsbDelet = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvShow)).BeginInit();
            this.tsShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvShow);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 547);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商品分类";
            // 
            // tvShow
            // 
            this.tvShow.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tvShow.Location = new System.Drawing.Point(0, 20);
            this.tvShow.Name = "tvShow";
            treeNode1.Name = "节点1";
            treeNode1.Tag = "true";
            treeNode1.Text = "正价商品";
            treeNode2.Name = "节点2";
            treeNode2.Tag = "false";
            treeNode2.Text = "特价商品";
            treeNode3.Name = "节点0";
            treeNode3.Text = "所有商品";
            this.tvShow.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tvShow.Size = new System.Drawing.Size(211, 527);
            this.tvShow.TabIndex = 0;
            this.tvShow.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvShow_AfterSelect);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvShow);
            this.groupBox2.Controls.Add(this.tsShow);
            this.groupBox2.Location = new System.Drawing.Point(231, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(802, 547);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "商品显示";
            // 
            // gvShow
            // 
            this.gvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvShow.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvShow.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvShow.GridColor = System.Drawing.Color.White;
            this.gvShow.Location = new System.Drawing.Point(0, 110);
            this.gvShow.Name = "gvShow";
            this.gvShow.RowTemplate.Height = 27;
            this.gvShow.Size = new System.Drawing.Size(802, 431);
            this.gvShow.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CommodityID";
            this.Column1.HeaderText = "商品编号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CommodityName";
            this.Column2.HeaderText = "商品名称";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SortName";
            this.Column3.HeaderText = "类别名称";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CommodityPrice";
            this.Column4.HeaderText = "商品价格";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "IsDiscount";
            this.Column5.HeaderText = "是否特价";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ReducedPrice";
            this.Column6.HeaderText = "打折价格";
            this.Column6.Name = "Column6";
            // 
            // tsShow
            // 
            this.tsShow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbChange,
            this.tsbDelet,
            this.tsbExit});
            this.tsShow.Location = new System.Drawing.Point(3, 21);
            this.tsShow.Name = "tsShow";
            this.tsShow.Size = new System.Drawing.Size(796, 67);
            this.tsShow.TabIndex = 0;
            this.tsShow.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(75, 64);
            this.tsbAdd.Text = "    增加    ";
            this.tsbAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbChange
            // 
            this.tsbChange.Image = ((System.Drawing.Image)(resources.GetObject("tsbChange.Image")));
            this.tsbChange.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChange.Name = "tsbChange";
            this.tsbChange.Size = new System.Drawing.Size(75, 64);
            this.tsbChange.Text = "    修改    ";
            this.tsbChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbChange.Click += new System.EventHandler(this.tsbChange_Click);
            // 
            // tsbDelet
            // 
            this.tsbDelet.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelet.Image")));
            this.tsbDelet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDelet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelet.Name = "tsbDelet";
            this.tsbDelet.Size = new System.Drawing.Size(79, 64);
            this.tsbDelet.Text = "    删除     ";
            this.tsbDelet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDelet.Click += new System.EventHandler(this.tsbDelet_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(75, 64);
            this.tsbExit.Text = "    退出    ";
            this.tsbExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // frmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmShow";
            this.Text = "frmShow";
            this.Load += new System.EventHandler(this.frmShow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvShow)).EndInit();
            this.tsShow.ResumeLayout(false);
            this.tsShow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvShow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip tsShow;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbChange;
        private System.Windows.Forms.ToolStripButton tsbDelet;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.DataGridView gvShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}