using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //可租车集合
        Dictionary<string, Vehicle> canUse;
        //已租车集合
        Dictionary<string, Vehicle> Used;

        #region 点击退出按钮

        private void tbnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出本系统？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        } 
        #endregion
    }
}
