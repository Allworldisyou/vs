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
    public partial class frmFlowerShow : Form
    {
        public frmFlowerShow()
        {
            InitializeComponent();
        }

        private void frmFlowerShow_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(DBhelper.conStr);
            string sql = @"select SaleId,a.FlowerId,Flowername,Salecount,Saledate,Saleprice,Saleclerk,Remark 
                           from Flower as a,Flowersale as b 
                           where a.FlowerId=b.FlowerId";
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DBhelper.conStr);
            string sql = @"select SaleId,a.FlowerId,Flowername,Salecount,Saledate,Saleprice,Saleclerk,Remark 
                           from Flower as a,Flowersale as b 
                           where a.FlowerId=b.FlowerId and Flowername like '%" + tboFlowerName.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpDate upf = new frmUpDate();//创建修改窗口对象
            upf.id = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//分别获取信息赋值
            upf.num = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            upf.danjia = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            upf.beizhu = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            upf.ShowDialog();//模式化窗口

        }
    }
}
