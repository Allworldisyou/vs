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

namespace SuperMarkket
{
    public partial class frmShow : Form
    {
        public frmShow()
        {
            InitializeComponent();
        }

        private void tsbExit_Click(object sender, EventArgs e)//判断是否退出
        {
            DialogResult result = MessageBox.Show("是否退出？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result ==DialogResult.Yes)
            {
                this.Close();
            }

        }

        
        private void tvShow_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int high = this.tvShow.SelectedNode.Level;
            try
            {
                if (tvShow.SelectedNode != null)
                {
                    // 通过连接进行查询
                    string sql = "SELECT A.CommodityID,A.CommodityName,B.SortName" +
                       ",A.CommodityPrice,A.IsDiscount,A.ReducedPrice  FROM [Commodity] AS A " +
                       " JOIN [CommoditySort]  AS B ON A.SortID=B.SortID";

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    SqlConnection conn = new SqlConnection(connStr.str);
                    da.SelectCommand = new SqlCommand(sql,conn);
                    da.Fill(ds, "zhazha");
                    this.gvShow.DataSource = ds.Tables["zhazha"];
                    DataView dv = new DataView(ds.Tables[0]);
                    gvShow.DataSource =ds.Tables[0];
                    if (high == 1)
                    {
                        bool isDiscount = Convert.ToBoolean(tvShow.SelectedNode.Tag);
                        if (isDiscount == true)
                        {
                            dv.RowFilter = "isDiscount='false'";
                        }
                        else
                        {
                            dv.RowFilter = "isDiscount ='true'";
                        }
                        
                    }
                    //重新绑定数据源
                        gvShow.DataSource = dv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
       
        #region 显示所有
        public void All()
        {

            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(connStr.str);
            string sql = "SELECT A.CommodityID,A.CommodityName,B.SortName" +
                   ",A.CommodityPrice,A.IsDiscount,A.ReducedPrice  FROM [Commodity] AS A " +
                   " JOIN [CommoditySort]  AS B ON A.SortID=B.SortID";

            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            
            da.Fill(ds,"s");
            gvShow.DataSource = ds.Tables["s"];
            
        }
        #endregion

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.commodityID = 0;
            add.ShowDialog();
            All();         
        }



        private void FillCommodityInfo()
        {
            SqlConnection conn = new SqlConnection(connStr.str);
            
            try
            {
                // 通过连接进行查询
                string sql = "SELECT A.CommodityID ,A.CommodityName,B.SortName" +
                   ",A.CommodityPrice,A.IsDiscount,A.ReducedPrice  FROM [Commodity] AS A " +
                   " JOIN [CommoditySort]  AS B ON A.SortID=B.SortID";

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                this.gvShow.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作错误！" + ex, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private void tsbChange_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.commodityID = Convert.ToInt32(this.gvShow.CurrentRow.Cells[0].Value);
            add.ShowDialog();
            All();              
        }

        private void tsbDelet_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr.str);
            try
            {

                if (this.gvShow.CurrentRow != null)
                {
                    string message = string.Format("确定要删除商品名称为 {0} 的数据吗?", this.gvShow.CurrentRow.Cells[1].Value);

                    // 通过谈出对话框让用户选择
                    if (MessageBox.Show(message, "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open();
                        StringBuilder sb = new StringBuilder();
                        int num = Convert.ToInt32(this.gvShow.CurrentRow.Cells[0].Value);
                        // 删除语句
                        sb.AppendFormat("DELETE FROM [Commodity] WHERE CommodityID={0}", num);

                        // 执行删除操作

                        SqlCommand command = new SqlCommand(sb.ToString(), conn);

                        int result = command.ExecuteNonQuery();
                        if (result == 1)
                        {
                            MessageBox.Show("删除成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            All();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作失败！" + ex, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                conn.Close();
            }

        }

        private void frmShow_Load(object sender, EventArgs e)
        {
           
        }

      

    }
}
