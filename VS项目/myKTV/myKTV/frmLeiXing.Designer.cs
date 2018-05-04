namespace myKTV
{
    partial class frmLeiXing
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("热门流行", 3);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("经典老歌", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("影视金曲", 5);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("游戏动漫", 2);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("京剧戏曲", 4);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("儿童歌曲", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeiXing));
            this.lvType = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lvType
            // 
            this.lvType.BackColor = System.Drawing.Color.LightCyan;
            this.lvType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            listViewItem1.Tag = "1";
            listViewItem2.Tag = "2";
            listViewItem3.Tag = "3";
            listViewItem4.Tag = "4";
            listViewItem5.Tag = "5";
            listViewItem6.Tag = "6";
            this.lvType.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lvType.LargeImageList = this.imageList1;
            this.lvType.Location = new System.Drawing.Point(3, 3);
            this.lvType.Name = "lvType";
            this.lvType.Size = new System.Drawing.Size(639, 409);
            this.lvType.TabIndex = 0;
            this.lvType.UseCompatibleStateImageBehavior = false;
            this.lvType.Click += new System.EventHandler(this.listView1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "erge.png");
            this.imageList1.Images.SetKeyName(1, "jingdianlaoge.png");
            this.imageList1.Images.SetKeyName(2, "katongdongman.png");
            this.imageList1.Images.SetKeyName(3, "remenliuxing.png");
            this.imageList1.Images.SetKeyName(4, "xiqu.png");
            this.imageList1.Images.SetKeyName(5, "yingshijinqu.png");
            // 
            // frmLeiXing
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(642, 413);
            this.Controls.Add(this.lvType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLeiXing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "类型点歌";
            this.Load += new System.EventHandler(this.frmLeiXing_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvType;
        private System.Windows.Forms.ImageList imageList1;
    }
}