using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flowers
{
    public partial class frmUpDate : Form
    {
        public frmUpDate()
        {
            InitializeComponent();
        }

        public string id;//商品编号
        public string num;//销售数量
        public string danjia;//单价
        public string beizhu;//备注

        private void frmUpDate_Load(object sender, EventArgs e)
        {
           
            lblNO.Text = "销售编号" + id;//分别将获取的值赋到控件中
            tboCount.Text = num;
            tboPrice.Text = danjia;
            rtbMessage.Text = beizhu;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DBhelper.conStr);

            try
            {
                conn.Open();//打开数据库
                //根据商品ID修改的sql语句
                string sql = @"update flowersale set salecount='" + tboCount.Text + "',saleprice='" + tboPrice.Text + "',remark='" + rtbMessage.Text + "' where saleId='" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int num = cmd.ExecuteNonQuery();//返回行数方法
                if (num > 0)
                {
                    MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK);
                }
                else
                {

                    MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "提示");
            }
            finally
            {

                conn.Close();
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否取消？","提示",MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                frmFlowerShow flower = new frmFlowerShow();
                flower.Show();
            }
        }
    }
}
