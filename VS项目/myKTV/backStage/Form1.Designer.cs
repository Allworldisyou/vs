namespace backStage
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassWord3 = new System.Windows.Forms.Label();
            this.tboUserName = new System.Windows.Forms.TextBox();
            this.tboPassWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Snow;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.Location = new System.Drawing.Point(68, 269);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 33);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登 录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.Snow;
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancle.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancle.ForeColor = System.Drawing.Color.Black;
            this.btnCancle.Location = new System.Drawing.Point(314, 269);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(95, 33);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Text = "取 消";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserName.Location = new System.Drawing.Point(64, 69);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(110, 24);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "用户名：";
            // 
            // lblPassWord3
            // 
            this.lblPassWord3.AutoSize = true;
            this.lblPassWord3.BackColor = System.Drawing.Color.Transparent;
            this.lblPassWord3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPassWord3.Location = new System.Drawing.Point(64, 165);
            this.lblPassWord3.Name = "lblPassWord3";
            this.lblPassWord3.Size = new System.Drawing.Size(98, 24);
            this.lblPassWord3.TabIndex = 3;
            this.lblPassWord3.Text = "密 码：";
            // 
            // tboUserName
            // 
            this.tboUserName.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboUserName.Location = new System.Drawing.Point(238, 66);
            this.tboUserName.Name = "tboUserName";
            this.tboUserName.Size = new System.Drawing.Size(152, 34);
            this.tboUserName.TabIndex = 4;
            // 
            // tboPassWord
            // 
            this.tboPassWord.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboPassWord.Location = new System.Drawing.Point(238, 162);
            this.tboPassWord.Name = "tboPassWord";
            this.tboPassWord.Size = new System.Drawing.Size(152, 34);
            this.tboPassWord.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::backStage.Properties.Resources.t014568576f82526a66;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 353);
            this.Controls.Add(this.tboPassWord);
            this.Controls.Add(this.tboUserName);
            this.Controls.Add(this.lblPassWord3);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassWord3;
        private System.Windows.Forms.TextBox tboUserName;
        private System.Windows.Forms.TextBox tboPassWord;
    }
}

