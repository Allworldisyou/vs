namespace Flowers
{
    partial class frmUpDate
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
            this.lblNO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboCount = new System.Windows.Forms.TextBox();
            this.tboPrice = new System.Windows.Forms.TextBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNO
            // 
            this.lblNO.AutoSize = true;
            this.lblNO.Location = new System.Drawing.Point(39, 74);
            this.lblNO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNO.Name = "lblNO";
            this.lblNO.Size = new System.Drawing.Size(109, 19);
            this.lblNO.TabIndex = 0;
            this.lblNO.Text = "销售编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "销售数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "单价：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "备注：";
            // 
            // tboCount
            // 
            this.tboCount.Location = new System.Drawing.Point(357, 71);
            this.tboCount.Name = "tboCount";
            this.tboCount.Size = new System.Drawing.Size(100, 28);
            this.tboCount.TabIndex = 4;
            // 
            // tboPrice
            // 
            this.tboPrice.Location = new System.Drawing.Point(564, 71);
            this.tboPrice.Name = "tboPrice";
            this.tboPrice.Size = new System.Drawing.Size(100, 28);
            this.tboPrice.TabIndex = 5;
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(115, 153);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(549, 103);
            this.rtbMessage.TabIndex = 6;
            this.rtbMessage.Text = "";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(286, 285);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(89, 32);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "保 存";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(518, 284);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(94, 33);
            this.btnNo.TabIndex = 8;
            this.btnNo.Text = "取消";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // frmUpDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 329);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.tboPrice);
            this.Controls.Add(this.tboCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNO);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUpDate";
            this.Text = "修改鲜花销售信息";
            this.Load += new System.EventHandler(this.frmUpDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboCount;
        private System.Windows.Forms.TextBox tboPrice;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnNo;
    }
}