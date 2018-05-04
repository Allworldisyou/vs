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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }
        public int commodityID = 0;
        private void btnCancle_Click(object sender, EventArgs e)//点击取消
        {
           DialogResult result = MessageBox.Show("是否取消","温馨提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
           if (result == DialogResult.Yes)
           {
               this.Close();
           }
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            // 添加
            if (this.commodityID == 0)
            {
                SqlConnection conn = new SqlConnection(connStr.str);

                string sql = "select * from [CommoditySort]";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();

                da.Fill(ds, "pwd");

                DataRow row = ds.Tables["pwd"].NewRow();
                row[0] = -1;
                row[1] = "请选择";
                ds.Tables["pwd"].Rows.InsertAt(row, 0);

                cboSort.DataSource = ds.Tables["pwd"];
                cboSort.DisplayMember = "SortName";
                cboSort.ValueMember = "SortID";
            }
            // 修改
            else
            {
                this.btnReserve.Text = "修改(&U)";
                SqlConnection conn = new SqlConnection(connStr.str);

                string sql = "select * from [CommoditySort]";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();

                da.Fill(ds, "pwd");

                DataRow row = ds.Tables["pwd"].NewRow();
                row[0] = -1;
                row[1] = "请选择";
                ds.Tables["pwd"].Rows.InsertAt(row, 0);

                cboSort.DataSource = ds.Tables["pwd"];
                cboSort.DisplayMember = "SortName";
                cboSort.ValueMember = "SortID";
                this.GetCommidity();

            }


        }

        private void butReserve_Click(object sender, EventArgs e) // 点击保存按钮
        {
            add();
        }
        public void add()
        {
            if (this.CheckInput())
            {
                // 判断commodityID 0为添加数据 其他数字为修改数据
                if (this.commodityID == 0)
                {
                    this.InsertCommodity();
                }
                else
                {
                    this.UpdateCommodity();
                }
            }


        }

        private void GetCommidity()//修改前得到的信息
        {
            SqlConnection conn = new SqlConnection(connStr.str);
            try
            {
                StringBuilder sb = new StringBuilder();

                //得到信息
                sb.AppendFormat("SELECT * FROM [Commodity] WHERE CommodityID={0}", this.commodityID);
                SqlCommand com = new SqlCommand(sb.ToString(), conn);
                conn.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    //得到信息给控件值
                    this.tboName.Text = reader["CommodityName"].ToString();
                    this.cboSort.SelectedValue = reader["SortID"].ToString();
                    this.udPrice.Value = Convert.ToDecimal(reader["CommodityPrice"].ToString());
                    this.cbDisCount.Checked = Convert.ToBoolean(reader["IsDiscount"].ToString());
                    this.udCountPrice.Value = Convert.ToDecimal(reader["ReducedPrice"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作错误！" + ex, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
        }

        private bool CheckInput()//修改时名称不能为空
        {
            bool ok = true;
            this.tboName.Text = this.tboName.Text.Trim();
            if (this.tboName.Text.Length == 0)
            {
                MessageBox.Show("名称不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ok = false;
            }
            return ok;
        }

        private void UpdateCommodity()//修改方法
        {
            SqlConnection conn = new SqlConnection(connStr.str);
            try
            {
                StringBuilder sql = new StringBuilder();

                //修改数据库语句
                sql.AppendFormat("UPDATE [Commodity] SET [CommodityName]='{0}'", this.tboName.Text);
                sql.AppendFormat(" ,[SortID]='{0}'", Convert.ToInt32(this.cboSort.SelectedValue));
                sql.AppendFormat(" ,[CommodityPrice]='{0}'", this.udPrice.Value);
                sql.AppendFormat(" ,[IsDiscount]='{0}'", this.cbDisCount.Checked ? 1 : 0);
                sql.AppendFormat(" ,[ReducedPrice]='{0}'", this.udCountPrice.Value);
                sql.AppendFormat(" WHERE [CommodityID]={0}", this.commodityID);
                //执行SQL语句
                SqlCommand com = new SqlCommand(sql.ToString(), conn);
                conn.Open();
                int result = com.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("修改成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
        }






        private void InsertCommodity()//添加方法
        {
            SqlConnection conn = new SqlConnection(connStr.str);
            try
            {
                StringBuilder sql = new StringBuilder();

                sql.AppendLine("INSERT INTO [Commodity]");
                sql.AppendFormat(" VALUES('{0}',{1},{2},{3},{4})",
                    this.tboName.Text, Convert.ToInt32(this.cboSort.SelectedValue), this.udPrice.Value, this.cbDisCount.Checked ? 1 : 0, this.udCountPrice.Value);
                SqlCommand com = new SqlCommand(sql.ToString(), conn);
                conn.Open();
                int result = com.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("添加成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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

        private void cbDisCount_CheckedChanged(object sender, EventArgs e)
        {
            //判断是否特价
            if (cbDisCount.Checked)
            {
                //是否特价就和特价价格发生反应
                this.udCountPrice.Enabled = true;
            }
            else
            {
                //是否特价如果不选则和预售的价格相等
                this.udCountPrice.Enabled = false;
                this.udCountPrice.Value = this.udPrice.Value;

            }

        }

    }
}
