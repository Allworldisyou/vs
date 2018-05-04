namespace SuperMarkket
{
    partial class frmChangePwd
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
            this.lblOldPwd = new System.Windows.Forms.Label();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.lblNewPwdTure = new System.Windows.Forms.Label();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwdTure = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOldPwd
            // 
            this.lblOldPwd.AutoSize = true;
            this.lblOldPwd.Location = new System.Drawing.Point(59, 74);
            this.lblOldPwd.Name = "lblOldPwd";
            this.lblOldPwd.Size = new System.Drawing.Size(67, 15);
            this.lblOldPwd.TabIndex = 0;
            this.lblOldPwd.Text = "原密码：";
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.Location = new System.Drawing.Point(62, 175);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(67, 15);
            this.lblNewPwd.TabIndex = 1;
            this.lblNewPwd.Text = "新密码：";
            // 
            // lblNewPwdTure
            // 
            this.lblNewPwdTure.AutoSize = true;
            this.lblNewPwdTure.Location = new System.Drawing.Point(29, 272);
            this.lblNewPwdTure.Name = "lblNewPwdTure";
            this.lblNewPwdTure.Size = new System.Drawing.Size(97, 15);
            this.lblNewPwdTure.TabIndex = 2;
            this.lblNewPwdTure.Text = "确认新密码：";
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(214, 71);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.Size = new System.Drawing.Size(172, 25);
            this.txtOldPwd.TabIndex = 3;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(214, 172);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(172, 25);
            this.txtNewPwd.TabIndex = 4;
            // 
            // txtNewPwdTure
            // 
            this.txtNewPwdTure.Location = new System.Drawing.Point(214, 269);
            this.txtNewPwdTure.Name = "txtNewPwdTure";
            this.txtNewPwdTure.Size = new System.Drawing.Size(172, 25);
            this.txtNewPwdTure.TabIndex = 5;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(85, 338);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(95, 36);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(331, 337);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(87, 37);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 394);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtNewPwdTure);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtOldPwd);
            this.Controls.Add(this.lblNewPwdTure);
            this.Controls.Add(this.lblNewPwd);
            this.Controls.Add(this.lblOldPwd);
            this.Name = "frmChangePwd";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldPwd;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.Label lblNewPwdTure;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtNewPwdTure;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnReturn;
    }
}