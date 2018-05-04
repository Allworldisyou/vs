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

namespace MobileManager
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conStr.str);
            try
            {
                conn.Open();

                string sql = "  select * from mobilebrand ";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cboBrand.DataSource = ds.Tables[0];

                cboBrand.DisplayMember = "Brand";
                cboBrand.ValueMember = "BrandID";
                //MessageBox.Show(cboBrand.ValueMember);
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        public string brand;   
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string brandName = cboBrand.Text;
            
            SqlConnection conn = new SqlConnection(conStr.str);
            //获取手机型号ID
            try
            {
                conn.Open();
                string sql = "select * from mobilebrand where Brand = '" + brandName + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                      brand = dr["BrandID"].ToString();
                }
              
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
           

            #region  判断不为空
     
            if (tboStyle.Text !=string.Empty )
            {
                if (tboPrice.Text != string.Empty)
                {
                    if (tboSize.Text != string.Empty)
                    {
                        if (tboWeight.Text != string.Empty)
                        {
                            if (tboFianlly.Text != string.Empty)
                            {
                                try
                                {
                                    conn.Open();
                                    string sql1 = "insert into MobileInfo values('" + brand + "','" + tboStyle.Text + "','" + tboPrice.Text + "','" + tboSize.Text + "','" + tboWeight.Text + "','" + tboFianlly.Text + "')";
                                    SqlCommand cmd = new SqlCommand(sql1, conn);
                                    int sum = cmd.ExecuteNonQuery();
                                    if (sum > 0)
                                    {
                                        MessageBox.Show("添加成功");
                                    }
                                    else
                                    {
                                        MessageBox.Show("添加失败");
                                    }
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.ToString());
                                }
                                finally
                                {
                                    conn.Close();

                                }
                            }
                            else
                            {
                                MessageBox.Show("手机终端款式为空");
                            }
                        }
                        else
                        {
                            MessageBox.Show("手机重量为空");
                        }
                    }
                    else
                    {
                        MessageBox.Show("手机尺寸为空");
                    }
                }
                else
                {
                    MessageBox.Show("手机价格为空");
                }
            }
            else
            {
                MessageBox.Show("手机型号为空");
            }


            #endregion




        }
    }
}
