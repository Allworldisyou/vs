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

namespace backStage
{
    public partial class frmAddSinger : Form
    {
        public frmAddSinger()
        {
            InitializeComponent();
        }


        public string aa;
        public string id;
        public string gender;
        public int panduan;
        public string chuan;
        private void frmAddSinger_Load(object sender, EventArgs e)
        {
           SqlConnection conn = new SqlConnection(conStr.str);
            try
            {
                
                string sql1 = "select * from dbo.singer_type";
                //conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql1, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow rows = ds.Tables[0].NewRow();
                rows[0] = -1;
                rows[1] = "全部地区";
                ds.Tables[0].Rows.InsertAt(rows, 0);
                cboAddress.DataSource = ds.Tables[0];
                cboAddress.DisplayMember = "singerType_name";
                cboAddress.ValueMember = "singertype_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "异常");
            }

            if (panduan == 2)
            {
                btnYes.Text = "修改";
                try
                {
                    conn.Open();
                    string sql3 = "select singer_id,singer_name,singertype_name,singer_gender,singer_photo_url,singer_description from singer_info,singer_type  where singer_info.singertype_id=singer_type.singertype_id and singer_id='" + chuan + "'";
                    SqlCommand cmd = new SqlCommand(sql3, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader["singer_id"].ToString();
                        tboName.Text = reader["singer_name"].ToString();
                        cboAddress.Text = reader["singertype_name"].ToString();
                        gender = reader["singer_gender"].ToString();
                        gennder2();
                        aa = reader["singer_photo_url"].ToString();
                        pictureBox1.Image = Image.FromFile("C:\\Users\\wkyy\\Desktop\\images\\" + reader["singer_photo_url"].ToString());
                        rtbMiaoshu.Text = reader["singer_description"].ToString();
                    }
                    reader.Close();

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

        }
        public void gennder2()
        {
            if (gender.Equals("男"))
            {
                rbMan.Checked = true;
            }
            else if (gender.Equals("女"))
            {
                rbWoman.Checked = true;
            }
            else if (gender.Equals("组合"))
            {
                rbAll.Checked = true;
            }

        }


        private void btnYes_Click(object sender, EventArgs e)
        {

            string name = tboName.Text;
            string Address = cboAddress.Text;
            string Adress_id = "";
            string gender = "";
            if (rbMan.Checked)
            {
                gender = "男";
            }
            else if (rbWoman.Checked)
            {
                gender = "女";
            }
            else if (rbAll.Checked)
            {
                gender = "组合";
            }
            string beizhu = rtbMiaoshu.Text;
            SqlConnection conn = new SqlConnection(conStr.str);
            //获取地区Id
            try
            {

                conn.Open();
                string sql = @"select singertype_id from singer_type where singerType_name='" + Address + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Adress_id = reader["singertype_id"].ToString();
                }
                reader.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }


            if (panduan == 2)
            {
                try
                {
                    string sql = "update singer_info set singer_name='" + name + "',singertype_id='" + Adress_id + "',singer_gender='" + gender + "',singer_photo_url='" + aa + "',singer_description='" + beizhu + "'  where singer_id='" + id + "'";

                    conn.Open();
                    SqlCommand com = new SqlCommand(sql, conn);

                    int result = com.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("修改成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                //修改
                try
                {
                    conn.Open();
                    string sql = "insert into dbo.singer_info values('" + name + "','" + Adress_id + "','" + gender + "','" + aa + "','" + beizhu + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int co = cmd.ExecuteNonQuery();
                    if (co > 0)
                    {
                        MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK);
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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "所有文件(*.jpg)|*jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string fi = openFileDialog1.FileName;
                aa = openFileDialog1.SafeFileName;
                pictureBox1.Image = Image.FromFile(fi);
                MessageBox.Show(aa);
            }

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否取消？", "操作提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
