namespace myKTV
{
    partial class frmPinYin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPinYin = new System.Windows.Forms.TextBox();
            this.gvShow = new System.Windows.Forms.DataGridView();
            this.songName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(576, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "(支持模糊查询)";
            // 
            // txtPinYin
            // 
            this.txtPinYin.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPinYin.Location = new System.Drawing.Point(88, 33);
            this.txtPinYin.Name = "txtPinYin";
            this.txtPinYin.Size = new System.Drawing.Size(201, 34);
            this.txtPinYin.TabIndex = 1;
            this.txtPinYin.TextChanged += new System.EventHandler(this.txtPinYin_TextChanged);
            // 
            // gvShow
            // 
            this.gvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvShow.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songName,
            this.singerName,
            this.Column1});
            this.gvShow.EnableHeadersVisualStyles = false;
            this.gvShow.GridColor = System.Drawing.SystemColors.ControlText;
            this.gvShow.Location = new System.Drawing.Point(1, 95);
            this.gvShow.Name = "gvShow";
            this.gvShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvShow.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gvShow.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvShow.RowTemplate.Height = 27;
            this.gvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvShow.Size = new System.Drawing.Size(809, 428);
            this.gvShow.TabIndex = 2;
            this.gvShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvShow_CellClick);
            // 
            // songName
            // 
            this.songName.DataPropertyName = "song_name";
            this.songName.HeaderText = "歌曲名称";
            this.songName.Name = "songName";
            // 
            // singerName
            // 
            this.singerName.DataPropertyName = "singer_name";
            this.singerName.HeaderText = "演唱者";
            this.singerName.Name = "singerName";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "song_url";
            this.Column1.HeaderText = "歌曲路径";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // frmPinYin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 525);
            this.Controls.Add(this.gvShow);
            this.Controls.Add(this.txtPinYin);
            this.Controls.Add(this.label1);
            this.Name = "frmPinYin";
            this.Text = "拼音点歌";
            this.Load += new System.EventHandler(this.frmPinYin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPinYin;
        private System.Windows.Forms.DataGridView gvShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn songName;
        private System.Windows.Forms.DataGridViewTextBoxColumn singerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}