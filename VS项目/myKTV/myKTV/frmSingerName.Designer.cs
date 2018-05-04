namespace myKTV
{
    partial class frmSingerName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSingerName));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("大陆", 3);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("香港", 7);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("台湾", 6);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("欧美", 4);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("日韩", 5);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("组合", 0);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("男", 1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("女", 2);
            this.ilGender = new System.Windows.Forms.ImageList(this.components);
            this.lvZhuTi = new System.Windows.Forms.ListView();
            this.lvXiangxi = new System.Windows.Forms.ListView();
            this.lvShow = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // ilGender
            // 
            this.ilGender.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilGender.ImageStream")));
            this.ilGender.TransparentColor = System.Drawing.Color.Transparent;
            this.ilGender.Images.SetKeyName(0, "couple.png");
            this.ilGender.Images.SetKeyName(1, "male.png");
            this.ilGender.Images.SetKeyName(2, "female.png");
            this.ilGender.Images.SetKeyName(3, "dalu.png");
            this.ilGender.Images.SetKeyName(4, "oumei.png");
            this.ilGender.Images.SetKeyName(5, "rihan.png");
            this.ilGender.Images.SetKeyName(6, "taiwan.png");
            this.ilGender.Images.SetKeyName(7, "xianggang.png");
            // 
            // lvZhuTi
            // 
            this.lvZhuTi.BackgroundImage = global::myKTV.Properties.Resources.lvSingerType_BackgroundImage;
            this.lvZhuTi.BackgroundImageTiled = true;
            this.lvZhuTi.LargeImageList = this.imageList1;
            this.lvZhuTi.Location = new System.Drawing.Point(134, 200);
            this.lvZhuTi.Name = "lvZhuTi";
            this.lvZhuTi.Size = new System.Drawing.Size(689, 311);
            this.lvZhuTi.TabIndex = 2;
            this.lvZhuTi.UseCompatibleStateImageBehavior = false;
            this.lvZhuTi.Click += new System.EventHandler(this.lvZhuTi_Click);
            // 
            // lvXiangxi
            // 
            this.lvXiangxi.BackgroundImage = global::myKTV.Properties.Resources.lvSinger_BackgroundImage;
            this.lvXiangxi.BackgroundImageTiled = true;
            this.lvXiangxi.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvXiangxi.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.lvXiangxi.LargeImageList = this.ilGender;
            this.lvXiangxi.Location = new System.Drawing.Point(43, 94);
            this.lvXiangxi.Name = "lvXiangxi";
            this.lvXiangxi.Size = new System.Drawing.Size(780, 417);
            this.lvXiangxi.TabIndex = 1;
            this.lvXiangxi.UseCompatibleStateImageBehavior = false;
            this.lvXiangxi.Click += new System.EventHandler(this.lvXiangxi_Click);
            // 
            // lvShow
            // 
            this.lvShow.BackgroundImage = global::myKTV.Properties.Resources.lvOrder_BackgroundImage;
            this.lvShow.BackgroundImageTiled = true;
            this.lvShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvShow.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvShow.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.lvShow.LargeImageList = this.ilGender;
            this.lvShow.Location = new System.Drawing.Point(29, 12);
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(804, 386);
            this.lvShow.TabIndex = 0;
            this.lvShow.UseCompatibleStateImageBehavior = false;
            this.lvShow.Click += new System.EventHandler(this.lvShow_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(150, 150);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmSingerName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 532);
            this.Controls.Add(this.lvZhuTi);
            this.Controls.Add(this.lvXiangxi);
            this.Controls.Add(this.lvShow);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSingerName";
            this.ShowIcon = false;
            this.Text = "歌星点歌";
            this.Load += new System.EventHandler(this.frmSingerName_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.ImageList ilGender;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvXiangxi;
        private System.Windows.Forms.ListView lvZhuTi;
        private System.Windows.Forms.ImageList imageList1;
    }
}