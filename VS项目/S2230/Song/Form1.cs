using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Song
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<SongInfo> list = new List<SongInfo>()
            {
                new SongInfo("爱情转移-陈奕迅.mp3","C:\\Users\\wkyy\\Music\\爱情转移-陈奕迅.mp3"),
                new SongInfo("虫儿飞 (Live)-郑伊健.mp3","C:\\Users\\wkyy\\Music\\虫儿飞 (Live)-郑伊健.mp3"),
                new SongInfo("红昭愿-音阙诗听.mp3","C:\\Users\\wkyy\\Music\\红昭愿-音阙诗听.mp3")
            };
            dgvShow.DataSource = new BindingList<SongInfo>(list);
        }

        private void 播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlaySong playSong = FrmPlaySong.pSong();
            playSong.url=dgvShow.SelectedRows[0].Cells[1].Value.ToString();
            playSong.play();
            playSong.Show();
        }
    }
}
