namespace Flight07
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
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.gbReserve = new System.Windows.Forms.GroupBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.cboLeaveCity = new System.Windows.Forms.ComboBox();
            this.cboArriveCity = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.gvShow = new System.Windows.Forms.DataGridView();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblFlightFrom = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.udNumber = new System.Windows.Forms.NumericUpDown();
            this.lblFirm = new System.Windows.Forms.Label();
            this.lblToWhere = new System.Windows.Forms.Label();
            this.lblToTime = new System.Windows.Forms.Label();
            this.lblGoTime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtWhere = new System.Windows.Forms.TextBox();
            this.txtArriveTime = new System.Windows.Forms.TextBox();
            this.dtpGoTime = new System.Windows.Forms.DateTimePicker();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbMessage.SuspendLayout();
            this.gbReserve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMessage
            // 
            this.gbMessage.Controls.Add(this.gvShow);
            this.gbMessage.Controls.Add(this.btnSelect);
            this.gbMessage.Controls.Add(this.cboArriveCity);
            this.gbMessage.Controls.Add(this.cboLeaveCity);
            this.gbMessage.Controls.Add(this.lblTo);
            this.gbMessage.Controls.Add(this.lblFrom);
            this.gbMessage.Location = new System.Drawing.Point(60, 34);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Size = new System.Drawing.Size(792, 232);
            this.gbMessage.TabIndex = 0;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "航班信息";
            // 
            // gbReserve
            // 
            this.gbReserve.BackColor = System.Drawing.Color.Transparent;
            this.gbReserve.Controls.Add(this.dtpGoTime);
            this.gbReserve.Controls.Add(this.txtArriveTime);
            this.gbReserve.Controls.Add(this.txtWhere);
            this.gbReserve.Controls.Add(this.textBox1);
            this.gbReserve.Controls.Add(this.lblGoTime);
            this.gbReserve.Controls.Add(this.lblToTime);
            this.gbReserve.Controls.Add(this.lblToWhere);
            this.gbReserve.Controls.Add(this.lblFirm);
            this.gbReserve.Controls.Add(this.udNumber);
            this.gbReserve.Controls.Add(this.txtMoney);
            this.gbReserve.Controls.Add(this.txtTime);
            this.gbReserve.Controls.Add(this.txtFrom);
            this.gbReserve.Controls.Add(this.txtNo);
            this.gbReserve.Controls.Add(this.lblNumber);
            this.gbReserve.Controls.Add(this.lblMoney);
            this.gbReserve.Controls.Add(this.lblTime);
            this.gbReserve.Controls.Add(this.lblFlightFrom);
            this.gbReserve.Controls.Add(this.lblNo);
            this.gbReserve.Location = new System.Drawing.Point(60, 314);
            this.gbReserve.Name = "gbReserve";
            this.gbReserve.Size = new System.Drawing.Size(792, 258);
            this.gbReserve.TabIndex = 1;
            this.gbReserve.TabStop = false;
            this.gbReserve.Text = "航班预定";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(27, 34);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(67, 15);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "出发地：";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(310, 34);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(52, 15);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "目的地";
            // 
            // cboLeaveCity
            // 
            this.cboLeaveCity.FormattingEnabled = true;
            this.cboLeaveCity.Location = new System.Drawing.Point(125, 31);
            this.cboLeaveCity.Name = "cboLeaveCity";
            this.cboLeaveCity.Size = new System.Drawing.Size(121, 23);
            this.cboLeaveCity.TabIndex = 2;
            // 
            // cboArriveCity
            // 
            this.cboArriveCity.FormattingEnabled = true;
            this.cboArriveCity.Location = new System.Drawing.Point(406, 31);
            this.cboArriveCity.Name = "cboArriveCity";
            this.cboArriveCity.Size = new System.Drawing.Size(121, 23);
            this.cboArriveCity.TabIndex = 3;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(618, 30);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(80, 37);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // gvShow
            // 
            this.gvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvShow.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gvShow.Location = new System.Drawing.Point(6, 73);
            this.gvShow.Name = "gvShow";
            this.gvShow.RowTemplate.Height = 27;
            this.gvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvShow.Size = new System.Drawing.Size(780, 153);
            this.gvShow.TabIndex = 5;
            this.gvShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvShow_CellClick);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(27, 25);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(60, 15);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "航班号:";
            // 
            // lblFlightFrom
            // 
            this.lblFlightFrom.AutoSize = true;
            this.lblFlightFrom.Location = new System.Drawing.Point(27, 68);
            this.lblFlightFrom.Name = "lblFlightFrom";
            this.lblFlightFrom.Size = new System.Drawing.Size(60, 15);
            this.lblFlightFrom.TabIndex = 1;
            this.lblFlightFrom.Text = "出发地:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 116);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(75, 15);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "出发时间:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(12, 168);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(75, 15);
            this.lblMoney.TabIndex = 3;
            this.lblMoney.Text = "成人票价:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(12, 215);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(82, 15);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "预定数量：";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(105, 22);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 25);
            this.txtNo.TabIndex = 5;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(105, 65);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 25);
            this.txtFrom.TabIndex = 6;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(105, 113);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 25);
            this.txtTime.TabIndex = 7;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(105, 165);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(100, 25);
            this.txtMoney.TabIndex = 8;
            // 
            // udNumber
            // 
            this.udNumber.Location = new System.Drawing.Point(105, 213);
            this.udNumber.Name = "udNumber";
            this.udNumber.Size = new System.Drawing.Size(120, 25);
            this.udNumber.TabIndex = 9;
            this.udNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblFirm
            // 
            this.lblFirm.AutoSize = true;
            this.lblFirm.Location = new System.Drawing.Point(406, 31);
            this.lblFirm.Name = "lblFirm";
            this.lblFirm.Size = new System.Drawing.Size(82, 15);
            this.lblFirm.TabIndex = 10;
            this.lblFirm.Text = "航班公司：";
            // 
            // lblToWhere
            // 
            this.lblToWhere.AutoSize = true;
            this.lblToWhere.Location = new System.Drawing.Point(421, 86);
            this.lblToWhere.Name = "lblToWhere";
            this.lblToWhere.Size = new System.Drawing.Size(67, 15);
            this.lblToWhere.TabIndex = 11;
            this.lblToWhere.Text = "目的地：";
            // 
            // lblToTime
            // 
            this.lblToTime.AutoSize = true;
            this.lblToTime.Location = new System.Drawing.Point(406, 138);
            this.lblToTime.Name = "lblToTime";
            this.lblToTime.Size = new System.Drawing.Size(82, 15);
            this.lblToTime.TabIndex = 12;
            this.lblToTime.Text = "到达时间：";
            // 
            // lblGoTime
            // 
            this.lblGoTime.AutoSize = true;
            this.lblGoTime.Location = new System.Drawing.Point(403, 215);
            this.lblGoTime.Name = "lblGoTime";
            this.lblGoTime.Size = new System.Drawing.Size(82, 15);
            this.lblGoTime.TabIndex = 13;
            this.lblGoTime.Text = "出发日期：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(523, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 14;
            // 
            // txtWhere
            // 
            this.txtWhere.Location = new System.Drawing.Point(523, 83);
            this.txtWhere.Name = "txtWhere";
            this.txtWhere.Size = new System.Drawing.Size(100, 25);
            this.txtWhere.TabIndex = 15;
            // 
            // txtArriveTime
            // 
            this.txtArriveTime.Location = new System.Drawing.Point(523, 135);
            this.txtArriveTime.Name = "txtArriveTime";
            this.txtArriveTime.Size = new System.Drawing.Size(100, 25);
            this.txtArriveTime.TabIndex = 16;
            // 
            // dtpGoTime
            // 
            this.dtpGoTime.Location = new System.Drawing.Point(523, 208);
            this.dtpGoTime.MinDate = new System.DateTime(2018, 3, 7, 0, 0, 0, 0);
            this.dtpGoTime.Name = "dtpGoTime";
            this.dtpGoTime.Size = new System.Drawing.Size(200, 25);
            this.dtpGoTime.TabIndex = 17;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(622, 578);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(82, 33);
            this.btnReserve.TabIndex = 2;
            this.btnReserve.Text = "预订";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(770, 578);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FlightNO";
            this.Column1.HeaderText = "航班号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Airways";
            this.Column2.HeaderText = "航班公司";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LeaveTime";
            this.Column3.HeaderText = "出发时间";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LandTime";
            this.Column4.HeaderText = "到达时间";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Price";
            this.Column5.HeaderText = "成人票价";
            this.Column5.Name = "Column5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 613);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.gbReserve);
            this.Controls.Add(this.gbMessage);
            this.Name = "Form1";
            this.Text = "航班查询及预订";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
            this.gbReserve.ResumeLayout(false);
            this.gbReserve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.DataGridView gvShow;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cboArriveCity;
        private System.Windows.Forms.ComboBox cboLeaveCity;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.GroupBox gbReserve;
        private System.Windows.Forms.DateTimePicker dtpGoTime;
        private System.Windows.Forms.TextBox txtArriveTime;
        private System.Windows.Forms.TextBox txtWhere;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblGoTime;
        private System.Windows.Forms.Label lblToTime;
        private System.Windows.Forms.Label lblToWhere;
        private System.Windows.Forms.Label lblFirm;
        private System.Windows.Forms.NumericUpDown udNumber;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblFlightFrom;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

