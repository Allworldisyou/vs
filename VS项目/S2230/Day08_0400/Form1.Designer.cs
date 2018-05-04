namespace Day08_0400
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
            this.tvShwo = new System.Windows.Forms.TreeView();
            this.btnFather = new System.Windows.Forms.Button();
            this.btnChild = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tvShwo
            // 
            this.tvShwo.Location = new System.Drawing.Point(13, 13);
            this.tvShwo.Name = "tvShwo";
            this.tvShwo.Size = new System.Drawing.Size(241, 344);
            this.tvShwo.TabIndex = 0;
            this.tvShwo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvShwo_AfterSelect);
            // 
            // btnFather
            // 
            this.btnFather.Location = new System.Drawing.Point(289, 380);
            this.btnFather.Name = "btnFather";
            this.btnFather.Size = new System.Drawing.Size(75, 48);
            this.btnFather.TabIndex = 1;
            this.btnFather.Text = "添加父节点";
            this.btnFather.UseVisualStyleBackColor = true;
            this.btnFather.Click += new System.EventHandler(this.btnFather_Click);
            // 
            // btnChild
            // 
            this.btnChild.Location = new System.Drawing.Point(426, 380);
            this.btnChild.Name = "btnChild";
            this.btnChild.Size = new System.Drawing.Size(75, 48);
            this.btnChild.TabIndex = 2;
            this.btnChild.Text = "添加子节点";
            this.btnChild.UseVisualStyleBackColor = true;
            this.btnChild.Click += new System.EventHandler(this.btnChild_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(289, 317);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 25);
            this.txtName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 462);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnChild);
            this.Controls.Add(this.btnFather);
            this.Controls.Add(this.tvShwo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvShwo;
        private System.Windows.Forms.Button btnFather;
        private System.Windows.Forms.Button btnChild;
        private System.Windows.Forms.TextBox txtName;
    }
}

