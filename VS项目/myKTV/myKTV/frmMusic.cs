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
    public partial class frmMusic : Form
    {
        public frmMusic()
        {
            InitializeComponent();
        }
        public string songUrl;
        public Song CurrentSong;
        //public  Song zhuangtai = wmpMusic.playState;

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            //fangfa();
        }
       

        private void frmMusic_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        //每次点击歌曲后都在数据库中将该歌曲的点击次数增加1
        public void AddSongCount(string song_name)
        {
            SqlConnection con = new SqlConnection(connStr.str);
            string sql = "update song_info set song_play_count=song_play_count+1 where song_name='" + song_name + "'";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void PlaySong()
        {
            CurrentSong = PlayList.GetPlaySong();//事先定义的类里的方法
            if (CurrentSong != null)
            {
                AddSongCount(CurrentSong.SongName);//次数加一
                CurrentSong.playState = SongPlayState.played; //将歌曲改成正在播放状态
                wmpMusic.URL = "C:\\Users\\wkyy\\Music\\"+ CurrentSong.SongURL;   //获得歌曲的路径 
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CurrentSong == null)
            {
                PlaySong();

            }
            if (CurrentSong != null && wmpMusic.playState == WMPLib.WMPPlayState.wmppsStopped)//判断歌曲的播放状态是否为快要停止
            {
                CurrentSong.playState = SongPlayState.played; //将该歌曲状态改成已播放   
                CurrentSong = null;
                PlayList.ChargeInde();  //Playlist中定义的方法
            }
            if (CurrentSong != null && this.CurrentSong.playState == SongPlayState.cut)//切歌
            {
                this.wmpMusic.URL = "";
                CurrentSong = null;
            }
            if (CurrentSong != null && this.CurrentSong.playState == SongPlayState.again)//重播
            {
                this.PlaySong();
            }

        }



    }
}
