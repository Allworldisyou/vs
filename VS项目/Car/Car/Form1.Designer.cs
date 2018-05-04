namespace Car
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbnExit = new System.Windows.Forms.Button();
            this.btnAgain = new System.Windows.Forms.Button();
            this.tbnOk = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCanUse = new System.Windows.Forms.Label();
            this.lblUseDay = new System.Windows.Forms.Label();
            this.txtUseDay = new System.Windows.Forms.TextBox();
            this.btnNewPrice = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbtnCar = new System.Windows.Forms.RadioButton();
            this.rbtnLorry = new System.Windows.Forms.RadioButton();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtOneDayPrice = new System.Windows.Forms.TextBox();
            this.txtUseTime = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblOneDayPrice = new System.Windows.Forms.Label();
            this.lblUseTime = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.lvShow1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvShow2 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "汽车租赁系统";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 95);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(873, 609);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvShow1);
            this.tabPage1.Controls.Add(this.lblCanUse);
            this.tabPage1.Controls.Add(this.txtUserName);
            this.tabPage1.Controls.Add(this.lblUserName);
            this.tabPage1.Controls.Add(this.tbnOk);
            this.tabPage1.Controls.Add(this.btnAgain);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(865, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "租车";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvShow2);
            this.tabPage2.Controls.Add(this.btnNewPrice);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.txtUseDay);
            this.tabPage2.Controls.Add(this.lblUseDay);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(865, 580);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "还车";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnInput);
            this.tabPage3.Controls.Add(this.cboColor);
            this.tabPage3.Controls.Add(this.txtWeight);
            this.tabPage3.Controls.Add(this.txtOneDayPrice);
            this.tabPage3.Controls.Add(this.txtUseTime);
            this.tabPage3.Controls.Add(this.txtSize);
            this.tabPage3.Controls.Add(this.txtNo);
            this.tabPage3.Controls.Add(this.lblWeight);
            this.tabPage3.Controls.Add(this.lblOneDayPrice);
            this.tabPage3.Controls.Add(this.lblUseTime);
            this.tabPage3.Controls.Add(this.lblColor);
            this.tabPage3.Controls.Add(this.lblSize);
            this.tabPage3.Controls.Add(this.lblNo);
            this.tabPage3.Controls.Add(this.rbtnLorry);
            this.tabPage3.Controls.Add(this.rbtnCar);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(865, 580);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "新车入库";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbnExit
            // 
            this.tbnExit.Location = new System.Drawing.Point(778, 723);
            this.tbnExit.Name = "tbnExit";
            this.tbnExit.Size = new System.Drawing.Size(75, 30);
            this.tbnExit.TabIndex = 0;
            this.tbnExit.Text = "退出";
            this.tbnExit.UseVisualStyleBackColor = true;
            this.tbnExit.Click += new System.EventHandler(this.tbnExit_Click);
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(328, 531);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(53, 32);
            this.btnAgain.TabIndex = 0;
            this.btnAgain.Text = "刷新";
            this.btnAgain.UseVisualStyleBackColor = true;
            // 
            // tbnOk
            // 
            this.tbnOk.Location = new System.Drawing.Point(443, 531);
            this.tbnOk.Name = "tbnOk";
            this.tbnOk.Size = new System.Drawing.Size(53, 32);
            this.tbnOk.TabIndex = 1;
            this.tbnOk.Text = "租车";
            this.tbnOk.UseVisualStyleBackColor = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(309, 473);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(52, 15);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "租用者";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(420, 470);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(132, 25);
            this.txtUserName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(362, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "结算";
            // 
            // lblCanUse
            // 
            this.lblCanUse.AutoSize = true;
            this.lblCanUse.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCanUse.Location = new System.Drawing.Point(354, 3);
            this.lblCanUse.Name = "lblCanUse";
            this.lblCanUse.Size = new System.Drawing.Size(106, 24);
            this.lblCanUse.TabIndex = 4;
            this.lblCanUse.Text = "可租车辆";
            // 
            // lblUseDay
            // 
            this.lblUseDay.AutoSize = true;
            this.lblUseDay.Location = new System.Drawing.Point(309, 469);
            this.lblUseDay.Name = "lblUseDay";
            this.lblUseDay.Size = new System.Drawing.Size(67, 15);
            this.lblUseDay.TabIndex = 1;
            this.lblUseDay.Text = "租用天数";
            // 
            // txtUseDay
            // 
            this.txtUseDay.Location = new System.Drawing.Point(408, 466);
            this.txtUseDay.Name = "txtUseDay";
            this.txtUseDay.Size = new System.Drawing.Size(135, 25);
            this.txtUseDay.TabIndex = 2;
            // 
            // btnNewPrice
            // 
            this.btnNewPrice.Location = new System.Drawing.Point(435, 524);
            this.btnNewPrice.Name = "btnNewPrice";
            this.btnNewPrice.Size = new System.Drawing.Size(81, 32);
            this.btnNewPrice.TabIndex = 4;
            this.btnNewPrice.Text = "重新结算";
            this.btnNewPrice.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 524);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "刷新";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rbtnCar
            // 
            this.rbtnCar.AutoSize = true;
            this.rbtnCar.Location = new System.Drawing.Point(247, 32);
            this.rbtnCar.Name = "rbtnCar";
            this.rbtnCar.Size = new System.Drawing.Size(58, 19);
            this.rbtnCar.TabIndex = 0;
            this.rbtnCar.TabStop = true;
            this.rbtnCar.Text = "轿车";
            this.rbtnCar.UseVisualStyleBackColor = true;
            // 
            // rbtnLorry
            // 
            this.rbtnLorry.AutoSize = true;
            this.rbtnLorry.Location = new System.Drawing.Point(370, 32);
            this.rbtnLorry.Name = "rbtnLorry";
            this.rbtnLorry.Size = new System.Drawing.Size(58, 19);
            this.rbtnLorry.TabIndex = 1;
            this.rbtnLorry.TabStop = true;
            this.rbtnLorry.Text = "卡车";
            this.rbtnLorry.UseVisualStyleBackColor = true;
            // 
            // cboColor
            // 
            this.cboColor.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(355, 232);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(205, 31);
            this.cboColor.TabIndex = 28;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWeight.Location = new System.Drawing.Point(355, 426);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(205, 34);
            this.txtWeight.TabIndex = 27;
            // 
            // txtOneDayPrice
            // 
            this.txtOneDayPrice.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOneDayPrice.Location = new System.Drawing.Point(355, 357);
            this.txtOneDayPrice.Name = "txtOneDayPrice";
            this.txtOneDayPrice.Size = new System.Drawing.Size(205, 34);
            this.txtOneDayPrice.TabIndex = 26;
            // 
            // txtUseTime
            // 
            this.txtUseTime.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUseTime.Location = new System.Drawing.Point(355, 291);
            this.txtUseTime.Name = "txtUseTime";
            this.txtUseTime.Size = new System.Drawing.Size(205, 34);
            this.txtUseTime.TabIndex = 25;
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSize.Location = new System.Drawing.Point(355, 172);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(205, 34);
            this.txtSize.TabIndex = 24;
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNo.Location = new System.Drawing.Point(355, 104);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(205, 34);
            this.txtNo.TabIndex = 23;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWeight.Location = new System.Drawing.Point(143, 429);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(106, 24);
            this.lblWeight.TabIndex = 22;
            this.lblWeight.Text = "卡车载重";
            // 
            // lblOneDayPrice
            // 
            this.lblOneDayPrice.AutoSize = true;
            this.lblOneDayPrice.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOneDayPrice.Location = new System.Drawing.Point(143, 360);
            this.lblOneDayPrice.Name = "lblOneDayPrice";
            this.lblOneDayPrice.Size = new System.Drawing.Size(106, 24);
            this.lblOneDayPrice.TabIndex = 21;
            this.lblOneDayPrice.Text = "每日租金";
            // 
            // lblUseTime
            // 
            this.lblUseTime.AutoSize = true;
            this.lblUseTime.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUseTime.Location = new System.Drawing.Point(143, 294);
            this.lblUseTime.Name = "lblUseTime";
            this.lblUseTime.Size = new System.Drawing.Size(106, 24);
            this.lblUseTime.TabIndex = 20;
            this.lblUseTime.Text = "使用时间";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblColor.Location = new System.Drawing.Point(191, 232);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(58, 24);
            this.lblColor.TabIndex = 19;
            this.lblColor.Text = "颜色";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSize.Location = new System.Drawing.Point(191, 172);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(58, 24);
            this.lblSize.TabIndex = 18;
            this.lblSize.Text = "车型";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNo.Location = new System.Drawing.Point(167, 104);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(82, 24);
            this.lblNo.TabIndex = 17;
            this.lblNo.Text = "车牌号";
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInput.Location = new System.Drawing.Point(311, 510);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(94, 41);
            this.btnInput.TabIndex = 29;
            this.btnInput.Text = "入库";
            this.btnInput.UseVisualStyleBackColor = true;
            // 
            // lvShow1
            // 
            this.lvShow1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvShow1.Location = new System.Drawing.Point(3, 49);
            this.lvShow1.Name = "lvShow1";
            this.lvShow1.Size = new System.Drawing.Size(862, 399);
            this.lvShow1.TabIndex = 5;
            this.lvShow1.UseCompatibleStateImageBehavior = false;
            this.lvShow1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "车牌号";
            this.columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "车名";
            this.columnHeader2.Width = 157;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "颜色";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "使用时间";
            this.columnHeader4.Width = 147;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "日租金";
            this.columnHeader5.Width = 129;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "卡车载重";
            this.columnHeader6.Width = 115;
            // 
            // lvShow2
            // 
            this.lvShow2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvShow2.Location = new System.Drawing.Point(-2, 47);
            this.lvShow2.Name = "lvShow2";
            this.lvShow2.Size = new System.Drawing.Size(862, 399);
            this.lvShow2.TabIndex = 6;
            this.lvShow2.UseCompatibleStateImageBehavior = false;
            this.lvShow2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "车牌号";
            this.columnHeader7.Width = 151;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "车名";
            this.columnHeader8.Width = 157;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "颜色";
            this.columnHeader9.Width = 102;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "使用时间";
            this.columnHeader10.Width = 147;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "日租金";
            this.columnHeader11.Width = 129;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "卡车载重";
            this.columnHeader12.Width = 115;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 765);
            this.Controls.Add(this.tbnExit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "汽车租赁系统";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button tbnExit;
        private System.Windows.Forms.Label lblCanUse;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button tbnOk;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Button btnNewPrice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtUseDay;
        private System.Windows.Forms.Label lblUseDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnLorry;
        private System.Windows.Forms.RadioButton rbtnCar;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtOneDayPrice;
        private System.Windows.Forms.TextBox txtUseTime;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblOneDayPrice;
        private System.Windows.Forms.Label lblUseTime;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.ListView lvShow1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lvShow2;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}

