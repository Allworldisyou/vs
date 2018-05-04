namespace Attendance_information
{
    partial class FrmAdd
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
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.btnConserve = new System.Windows.Forms.Button();
            this.tboName = new System.Windows.Forms.TextBox();
            this.tboAge = new System.Windows.Forms.TextBox();
            this.tboId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboGender);
            this.groupBox1.Controls.Add(this.btnConserve);
            this.groupBox1.Controls.Add(this.tboName);
            this.groupBox1.Controls.Add(this.tboAge);
            this.groupBox1.Controls.Add(this.tboId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息维护";
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "女",
            "男"});
            this.cboGender.Location = new System.Drawing.Point(169, 218);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(162, 23);
            this.cboGender.TabIndex = 9;
            // 
            // btnConserve
            // 
            this.btnConserve.Location = new System.Drawing.Point(120, 310);
            this.btnConserve.Name = "btnConserve";
            this.btnConserve.Size = new System.Drawing.Size(87, 31);
            this.btnConserve.TabIndex = 8;
            this.btnConserve.Text = "保存";
            this.btnConserve.UseVisualStyleBackColor = true;
            this.btnConserve.Click += new System.EventHandler(this.button1_Click);
            // 
            // tboName
            // 
            this.tboName.Location = new System.Drawing.Point(169, 101);
            this.tboName.Name = "tboName";
            this.tboName.Size = new System.Drawing.Size(162, 25);
            this.tboName.TabIndex = 6;
            // 
            // tboAge
            // 
            this.tboAge.Location = new System.Drawing.Point(169, 159);
            this.tboAge.Name = "tboAge";
            this.tboAge.Size = new System.Drawing.Size(162, 25);
            this.tboAge.TabIndex = 5;
            // 
            // tboId
            // 
            this.tboId.Location = new System.Drawing.Point(169, 48);
            this.tboId.Name = "tboId";
            this.tboId.Size = new System.Drawing.Size(162, 25);
            this.tboId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "年龄";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "工号";
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 431);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAdd";
            this.Text = "员工信息维护";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConserve;
        private System.Windows.Forms.TextBox tboName;
        private System.Windows.Forms.TextBox tboAge;
        private System.Windows.Forms.TextBox tboId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGender;
    }
}