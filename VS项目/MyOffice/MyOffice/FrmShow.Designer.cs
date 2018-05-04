namespace MyOffice
{
    partial class FrmShow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tboName = new System.Windows.Forms.TextBox();
            this.rtbShow = new System.Windows.Forms.RichTextBox();
            this.tboScoer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "填写评价";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "年度评分";
            // 
            // tboOk
            // 
            this.tboOk.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboOk.Location = new System.Drawing.Point(140, 324);
            this.tboOk.Name = "tboOk";
            this.tboOk.Size = new System.Drawing.Size(75, 31);
            this.tboOk.TabIndex = 3;
            this.tboOk.Text = "评分";
            this.tboOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(286, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tboName
            // 
            this.tboName.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboName.Location = new System.Drawing.Point(128, 30);
            this.tboName.Name = "tboName";
            this.tboName.ReadOnly = true;
            this.tboName.Size = new System.Drawing.Size(281, 34);
            this.tboName.TabIndex = 5;
            // 
            // rtbShow
            // 
            this.rtbShow.Location = new System.Drawing.Point(128, 115);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.Size = new System.Drawing.Size(281, 96);
            this.rtbShow.TabIndex = 6;
            this.rtbShow.Text = "";
            // 
            // tboScoer
            // 
            this.tboScoer.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboScoer.Location = new System.Drawing.Point(128, 235);
            this.tboScoer.Name = "tboScoer";
            this.tboScoer.Size = new System.Drawing.Size(281, 34);
            this.tboScoer.TabIndex = 7;
            // 
            // FrmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 389);
            this.Controls.Add(this.tboScoer);
            this.Controls.Add(this.rtbShow);
            this.Controls.Add(this.tboName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tboOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmShow";
            this.Text = "评分";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tboOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tboName;
        private System.Windows.Forms.RichTextBox rtbShow;
        private System.Windows.Forms.TextBox tboScoer;
    }
}