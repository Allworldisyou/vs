namespace Day08_0100
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
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.cboFu = new System.Windows.Forms.ComboBox();
            this.btnReady = new System.Windows.Forms.Button();
            this.txtFinally = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(46, 52);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(100, 25);
            this.txtLeft.TabIndex = 0;
            // 
            // txtRight
            // 
            this.txtRight.Location = new System.Drawing.Point(348, 51);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(100, 25);
            this.txtRight.TabIndex = 1;
            // 
            // cboFu
            // 
            this.cboFu.FormattingEnabled = true;
            this.cboFu.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cboFu.Location = new System.Drawing.Point(181, 53);
            this.cboFu.Name = "cboFu";
            this.cboFu.Size = new System.Drawing.Size(121, 23);
            this.cboFu.TabIndex = 2;
            // 
            // btnReady
            // 
            this.btnReady.Location = new System.Drawing.Point(522, 46);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(75, 34);
            this.btnReady.TabIndex = 3;
            this.btnReady.Text = "计算";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // txtFinally
            // 
            this.txtFinally.Location = new System.Drawing.Point(273, 206);
            this.txtFinally.Name = "txtFinally";
            this.txtFinally.Size = new System.Drawing.Size(100, 25);
            this.txtFinally.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "结果是";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFinally);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.cboFu);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.txtLeft);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "简单工厂——多态计算机";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.ComboBox cboFu;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.TextBox txtFinally;
        private System.Windows.Forms.Label label1;
    }
}

