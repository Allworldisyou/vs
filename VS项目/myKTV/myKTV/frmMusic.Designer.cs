namespace myKTV
{
    partial class frmMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusic));
            this.wmpMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpMusic
            // 
            this.wmpMusic.Enabled = true;
            this.wmpMusic.Location = new System.Drawing.Point(-2, 0);
            this.wmpMusic.Name = "wmpMusic";
            this.wmpMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpMusic.OcxState")));
            this.wmpMusic.Size = new System.Drawing.Size(440, 308);
            this.wmpMusic.TabIndex = 0;
            this.wmpMusic.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 386);
            this.Controls.Add(this.wmpMusic);
            this.Name = "frmMusic";
            this.Text = "播放音乐";
            this.Load += new System.EventHandler(this.frmMusic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpMusic;
        private System.Windows.Forms.Timer timer1;
    }
}