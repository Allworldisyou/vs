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

namespace Flight07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionStr.str);

            string sql = @"SELECT * FROM [Ticket].[dbo].[CityInfo]";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            da.Fill(ds, "City");
            DataRow dr = ds.Tables["City"].NewRow();
            dr["Id"] = -1;
            dr["CityName"] = "请选择";

            ds.Tables["City"].Rows.InsertAt(dr, 0);
            cboLeaveCity.DataSource = ds.Tables["City"];

            cboLeaveCity.DisplayMember = "CityName";

            //实际显示的值
            cboLeaveCity.ValueMember = "Id";
            DataView dv = new DataView(ds.Tables["City"]);
            cboArriveCity.DataSource = dv;

            cboArriveCity.DisplayMember = "CityName";
            cboArriveCity.ValueMember = "Id";
    }

        private void btnSelect_Click(object sender, EventArgs e)
        {
           
        /// <summary>
        /// 查询按钮把数据库的信息显示到DataGridView中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
             //创建连接对象
            SqlConnection con = new SqlConnection(connectionStr.str);
            try
            {
                int grade = Convert.ToInt32( cboLeaveCity.SelectedValue);
                int grade1 = Convert.ToInt32(cboArriveCity.SelectedValue);
                //拼接sql语句
                string sql = @"select f.FlightNO,a.Airways,f.LeaveTime,f.LandTime,f.Price 
               from FlightInfo as f,AirwaysInfo as a 
               where f.AirwaysId = a.Id and f.LeaveCity ='" + grade + "' and f.Destination = '" + grade1 + "'";
                                                
                DataSet ds = new DataSet();
                SqlDataAdapter sa = new SqlDataAdapter(sql, con);
                sa.Fill(ds);//填充数据
                gvShow.DataSource = ds.Tables[0];//绑定数据源
            }
                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出吗！！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
             SqlConnection conn = new SqlConnection(connectionStr.str);
             

             string date = dtpGoTime.Value.ToString();//时间控件转字符串
            conn.Open();
            Random rd = new Random();
            int num1 = rd.Next(10000, 10000000);//随机数
            string sql = "insert into  OrderInfo ([OrderId],[FlightNo],[LeaveDate],[Number])values('" + num1 + "','" + txtNo.Text + "','" + date + "','" + udNumber.Text + "')";
            try
            {
                if (txtNo.Text==string.Empty)
                {
                    MessageBox.Show("请选择一个航班！");
                }

              
                SqlCommand cmd = new SqlCommand(sql, conn);
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("增加'" + udNumber.Text + "'张成功!");
                }
                else
                {
                    MessageBox.Show("增加失败！");
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("异常！"+ex, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
        }

        private void gvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //在第二个分组框显示信息
            //拿到当前选中项的航班号
            string Flightnum = Convert.ToString(gvShow.SelectedRows[0].Cells[0].Value);
            //航空公司
            string Airways = Convert.ToString(gvShow.SelectedRows[0].Cells[1].Value);
            //出发时间
            string LeaveTime = Convert.ToString(gvShow.SelectedRows[0].Cells[2].Value);
            //到达时间
            string LandTime = Convert.ToString(gvShow.SelectedRows[0].Cells[3].Value);
            //成人票价
            string Price = Convert.ToString(gvShow.SelectedRows[0].Cells[4].Value);
            //出发地
            string formCity = cboLeaveCity.Text;
            //目的地
            string toidCity = cboArriveCity.Text;

            txtNo.Text = Flightnum.ToString();
            textBox1.Text = Airways;
            txtTime.Text = LeaveTime;
            txtArriveTime.Text = LandTime;
            txtMoney.Text = Price.ToString();
            txtFrom.Text = formCity;
            txtWhere.Text = toidCity;

        }
   }
}