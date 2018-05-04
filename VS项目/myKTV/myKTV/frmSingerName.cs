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

namespace myKTV
{
    public partial class frmSingerName : Form
    {
        public frmSingerName()
        {
            InitializeComponent();
        }
        public string gender;
        private void frmSingerName_Load(object sender, EventArgs e)
        {
            lvShow.Show();
            lvShow.Dock = DockStyle.Fill;
            lvXiangxi.Visible = false;
            lvZhuTi.Visible = false;
            //SqlConnection conn = new SqlConnection(connStr.str);
            //conn.Open();
            //string sql = "";

        }

        private void lvShow_Click(object sender, EventArgs e)
        {
            lvShow.Visible = false;
            lvXiangxi.Show();
            lvZhuTi.Visible = false;
            lvXiangxi.Dock = DockStyle.Fill;
            gender = lvShow.SelectedItems[0].Text;
            
        }

        private void lvXiangxi_Click(object sender, EventArgs e)
        {
            lvShow.Visible = false;
            lvXiangxi.Visible = false;
            lvZhuTi.Show();
            lvZhuTi.Dock = DockStyle.Fill;
            string city = lvXiangxi.SelectedItems[0].Text;

            SqlConnection conn = new SqlConnection(connStr.str);
            int i = 0;
            try
            {
               
                conn.Open();
                string sql = @"select singer_name,singer_photo_url,singertype_name,singer_gender from singer_info inner join singer_type as a on singer_info.singertype_id = a.singertype_id  where singertype_name = '"+city+"' and  singer_gender='" +gender+ "'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    string singername = reader["singer_name"].ToString();
                    string singertp ="C:\\Users\\wkyy\\Desktop\\images\\" + reader["singer_photo_url"].ToString();
                    this.imageList1.Images.Add(Image.FromFile(singertp));
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = i;
                    item.Text = singername;
                    i++;
                    lvZhuTi.Items.Add(item);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

            
        }

        private void lvZhuTi_Click(object sender, EventArgs e)
        {
            frmShow gd = new frmShow();
            string name = lvZhuTi.SelectedItems[0].Text;
            gd.lyj = "select song_name,singer_name,song_url from singer_info inner join  song_info as a on singer_info.singer_id = a.singer_id where singer_name='" + name + "'";
            gd.Show();

        }
    }
}
