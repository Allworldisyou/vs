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
    public partial class frmAllSong : Form
    {
        public frmAllSong()
        {
            InitializeComponent();
        }
        public static string [] song = new string [50];


  
        public void SongList() 
     {
         
        lvSong.Items.Clear();
             for (int i = 0; i < PlayList.SongList.Length; i++)
            {
             if (PlayList.SongList[i]!=null)
                {
                ListViewItem item = new ListViewItem(PlayList.SongList[i].SongName);
                item.Tag = i;
                //判断状态
                string playstate = PlayList.SongList[i].playState == SongPlayState.unplayed ? "未播放" : "已播";
                item.SubItems.Add(playstate);
                lvSong.Items.Add(item);
                }
            }
     }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAllSong_Load(object sender, EventArgs e)
        {
            this.timer1.Start();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PlayList.PlayAgain();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PlayList.CutSong();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            SongList();
        }


    }
}
