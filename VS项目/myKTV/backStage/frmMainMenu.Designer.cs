namespace backStage
{
    partial class frmMainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.歌曲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.歌手ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询歌手ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询歌曲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加ToolStripMenuItem,
            this.查询ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 增加ToolStripMenuItem
            // 
            this.增加ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.歌曲ToolStripMenuItem,
            this.歌手ToolStripMenuItem});
            this.增加ToolStripMenuItem.Name = "增加ToolStripMenuItem";
            this.增加ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.增加ToolStripMenuItem.Text = "增加";
            // 
            // 歌曲ToolStripMenuItem
            // 
            this.歌曲ToolStripMenuItem.Name = "歌曲ToolStripMenuItem";
            this.歌曲ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.歌曲ToolStripMenuItem.Text = "歌曲";
            this.歌曲ToolStripMenuItem.Click += new System.EventHandler(this.歌曲ToolStripMenuItem_Click);
            // 
            // 歌手ToolStripMenuItem
            // 
            this.歌手ToolStripMenuItem.Name = "歌手ToolStripMenuItem";
            this.歌手ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.歌手ToolStripMenuItem.Text = "歌手";
            this.歌手ToolStripMenuItem.Click += new System.EventHandler(this.歌手ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登录密码ToolStripMenuItem});
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.修改ToolStripMenuItem.Text = "修改";
            // 
            // 登录密码ToolStripMenuItem
            // 
            this.登录密码ToolStripMenuItem.Name = "登录密码ToolStripMenuItem";
            this.登录密码ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.登录密码ToolStripMenuItem.Text = "登录密码";
            this.登录密码ToolStripMenuItem.Click += new System.EventHandler(this.登录密码ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询歌手ToolStripMenuItem,
            this.查询歌曲ToolStripMenuItem});
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.查询ToolStripMenuItem.Text = "查询";
            // 
            // 查询歌手ToolStripMenuItem
            // 
            this.查询歌手ToolStripMenuItem.Name = "查询歌手ToolStripMenuItem";
            this.查询歌手ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.查询歌手ToolStripMenuItem.Text = "查询歌手";
            this.查询歌手ToolStripMenuItem.Click += new System.EventHandler(this.查询歌手ToolStripMenuItem_Click);
            // 
            // 查询歌曲ToolStripMenuItem
            // 
            this.查询歌曲ToolStripMenuItem.Name = "查询歌曲ToolStripMenuItem";
            this.查询歌曲ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.查询歌曲ToolStripMenuItem.Text = "查询歌曲";
            this.查询歌曲ToolStripMenuItem.Click += new System.EventHandler(this.查询歌曲ToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(551, 341);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "菜单";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 歌曲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 歌手ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登录密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询歌手ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询歌曲ToolStripMenuItem;

    }
}