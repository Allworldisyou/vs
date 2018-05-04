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
    public partial class frmLeiXing : Form
    {
        public frmLeiXing()
        {
            InitializeComponent();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            string type = lvType.SelectedItems[0].Tag.ToString();
            frmShow show = new frmShow();
            show.lyj = @"select  song_info.song_name,singer_info.singer_name,song_url from song_info inner join singer_info on song_info.singer_id = singer_info.singer_id where song_info.songtype_id ='" + type + "'";
            show.Show();
            
        }

        private void frmLeiXing_Load(object sender, EventArgs e)
        {

        }
    }
}
