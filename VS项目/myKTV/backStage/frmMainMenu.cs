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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }
        //增加歌曲
        private void 歌曲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmAddSong addSong = new frmAddSong();
            addSong.ShowDialog();
        }

        private void 歌手ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddSinger singer = new frmAddSinger();
            singer.ShowDialog();
        }

        private void 登录密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdatePassWord pwd = new frmUpdatePassWord();
            pwd.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出？", "操作提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void 查询歌手ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSingerInfo singer = new frmSingerInfo();
            singer.Show();
        }

        private void 查询歌曲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSongInfo song = new frmSongInfo();
            song.Show();
        }
    }
}
