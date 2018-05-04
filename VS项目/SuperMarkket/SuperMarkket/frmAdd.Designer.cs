namespace SuperMarkket
{
    partial class frmAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.udPrice = new System.Windows.Forms.NumericUpDown();
            this.udCountPrice = new System.Windows.Forms.NumericUpDown();
            this.tboName = new System.Windows.Forms.TextBox();
            this.cboSort = new System.Windows.Forms.ComboBox();
            this.cbDisCount = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCountPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSort);
            this.groupBox1.Controls.Add(this.tboName);
            this.groupBox1.Controls.Add(this.udPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDisCount);
            this.groupBox2.Controls.Add(this.udCountPrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "其他信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品类别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "预售价格：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "特价价格：";
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(193, 328);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(79, 34);
            this.btnReserve.TabIndex = 2;
            this.btnReserve.Text = "保存&S";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.butReserve_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(339, 328);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 34);
            this.btnCancle.TabIndex = 3;
            this.btnCancle.Text = "取消&C";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // udPrice
            // 
            this.udPrice.DecimalPlaces = 2;
            this.udPrice.Location = new System.Drawing.Point(139, 107);
            this.udPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udPrice.Name = "udPrice";
            this.udPrice.Size = new System.Drawing.Size(162, 25);
            this.udPrice.TabIndex = 3;
            // 
            // udCountPrice
            // 
            this.udCountPrice.DecimalPlaces = 2;
            this.udCountPrice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udCountPrice.Location = new System.Drawing.Point(140, 78);
            this.udCountPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udCountPrice.Name = "udCountPrice";
            this.udCountPrice.Size = new System.Drawing.Size(162, 25);
            this.udCountPrice.TabIndex = 4;
            // 
            // tboName
            // 
            this.tboName.Location = new System.Drawing.Point(139, 22);
            this.tboName.Name = "tboName";
            this.tboName.Size = new System.Drawing.Size(162, 25);
            this.tboName.TabIndex = 4;
            // 
            // cboSort
            // 
            this.cboSort.FormattingEnabled = true;
            this.cboSort.Location = new System.Drawing.Point(138, 64);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(163, 23);
            this.cboSort.TabIndex = 5;
            // 
            // cbDisCount
            // 
            this.cbDisCount.AutoSize = true;
            this.cbDisCount.Location = new System.Drawing.Point(139, 34);
            this.cbDisCount.Name = "cbDisCount";
            this.cbDisCount.Size = new System.Drawing.Size(136, 19);
            this.cbDisCount.TabIndex = 5;
            this.cbDisCount.Text = "    是否为特价";
            this.cbDisCount.UseVisualStyleBackColor = true;
            this.cbDisCount.CheckedChanged += new System.EventHandler(this.cbDisCount_CheckedChanged);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 370);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdd";
            this.Text = "编辑商品信息";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCountPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboSort;
        private System.Windows.Forms.TextBox tboName;
        private System.Windows.Forms.NumericUpDown udPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbDisCount;
        private System.Windows.Forms.NumericUpDown udCountPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnCancle;
    }
}