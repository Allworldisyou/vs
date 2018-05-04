using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myKTV
{
    public partial class frmCount : Form
    {
        public frmCount()
        {
            InitializeComponent();
        }

        private void frmCount_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                ListViewItem li = new ListViewItem();
                li.Text = (i + 1) + "个字";
                li.Tag = (i + 1);
                listView1.Items.Add(li);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            string number =listView1.SelectedItems[0].Tag.ToString();
            frmShow show = new frmShow();
            show.lyj = @"select song_info.song_name,singer_info.singer_name,song_url from song_info inner join singer_info on song_info.singer_id = singer_info.singer_id where song_word_count = '"+number+"'";
            show.Show();
        }
    }
}
