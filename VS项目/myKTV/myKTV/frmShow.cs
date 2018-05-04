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
    public partial class frmShow : Form
    {
        public frmShow()
        {
            InitializeComponent();
        }
        public string lyj;
        frmMusic music = new frmMusic();
        private void frmShow_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr.str);

            SqlDataAdapter da = new SqlDataAdapter(lyj, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddSong();
        }

            public void AddSong()
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString() != string.Empty)
            	{
                 Song Song = new Song();
                 Song.SongName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                 Song.singerName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                 Song.SongURL = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                 Song.playState = SongPlayState.unplayed;//播放状态为未播
                 PlayList.AddSong(Song);
            	}
            }

        }
    }

