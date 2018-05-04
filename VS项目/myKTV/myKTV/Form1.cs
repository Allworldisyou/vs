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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 歌星点歌
        private void button1_Click(object sender, EventArgs e)
        {
            frmSingerName name = new frmSingerName();
            name.Show();
        }
        #endregion

        #region 退出
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("是否退出","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result ==DialogResult.Yes )
            {
                Application.Exit();
            }
        }
        #endregion

        #region 拼音点歌
        private void btnSpell_Click(object sender, EventArgs e)
        {

            frmPinYin p = new frmPinYin();
            p.Show();
        }
        #endregion

        #region 类型点歌
        private void btnStyle_Click(object sender, EventArgs e)
        {
            frmLeiXing lx = new frmLeiXing();
            lx.Show();
        }
        #endregion

        #region 金曲排行
        private void btnCharts_Click(object sender, EventArgs e)
        {
            
            frmShow show = new frmShow();
            show.lyj = @"select song_info.song_name,singer_info.singer_name,song_url from song_info inner join singer_info on song_info.singer_id=singer_info.singer_id order by song_info.song_play_count desc";
            show.Show();
        }
        #endregion

        #region 字数点歌
        private void btnCount_Click(object sender, EventArgs e)
        {
            frmCount count = new frmCount();
            count.Show();
        }
        #endregion

        #region 已点歌曲
        private void sbAll_Click(object sender, EventArgs e)
        {
            frmAllSong all = new frmAllSong();
            all.ShowDialog();
        }
        #endregion

        #region 重唱
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PlayList.PlayAgain();
            
        }
        #endregion

        #region 服务
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("当前无服务！");
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
            frmMusic music = new frmMusic();
            music.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = PlayList.PlayingSongName();
            textBox2.Text = PlayList.NextSongName();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PlayList.CutSong();
        }
    }
}
