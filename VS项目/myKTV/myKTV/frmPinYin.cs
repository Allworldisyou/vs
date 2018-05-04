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
    public partial class frmPinYin : Form
    {
        public frmPinYin()
        {
            InitializeComponent();
        }

        private void txtPinYin_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr.str);
            string yin = txtPinYin.Text.ToString().ToUpper();
            try
            {
                conn.Open();
                string sql = @"select song_info.song_name,singer_info.singer_name,song_info.song_url from song_info inner join singer_info on song_info.singer_id = singer_info.singer_id where song_ab like '%" + yin + "%'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "ss");
                gvShow.DataSource = ds.Tables["ss"];

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void frmPinYin_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr.str);
            try
            {
                conn.Open();
                string sql = " select song_info.song_name,singer_info.singer_name,song_info.song_url from song_info inner join singer_info on song_info.singer_id = singer_info.singer_id";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataSet ds = new DataSet();
                da.Fill(ds);
                gvShow.DataSource = ds.Tables[0];

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

        private void gvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvShow.SelectedRows[0].Cells[0].Value.ToString() != string.Empty)
            {
                Song Song = new Song();
                Song.SongName = gvShow.SelectedRows[0].Cells[0].Value.ToString();
                Song.singerName = gvShow.SelectedRows[0].Cells[1].Value.ToString();
                Song.SongURL = gvShow.SelectedRows[0].Cells[2].Value.ToString();
                Song.playState = SongPlayState.unplayed;//播放状态为未播
                PlayList.AddSong(Song);

                //frmMusic music = new frmMusic();
                //string ShowName = gvShow.SelectedRows[0].Cells[0].Value.ToString();
                //SqlConnection conn = new SqlConnection(connStr.str);
                //try
                //{
                //    conn.Open();
                //    string sql = "select *from song_info where song_name='" + ShowName + "'";
                //    // MessageBox.Show(sql);
                //    SqlCommand cmd = new SqlCommand(sql, conn);
                //    SqlDataReader reader = cmd.ExecuteReader();
                //    while (reader.Read())
                //    {
                //        music.songUrl = "C:\\Users\\wkyy\\Music\\" + reader["song_url"].ToString();



                //    }
                //    reader.Close();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("异常" + ex, "提示");

                //}
                //finally
                //{
                //    conn.Close();
                //}
            }
        }
    }
}
