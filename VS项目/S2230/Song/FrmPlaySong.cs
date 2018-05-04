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
    public partial class FrmPlaySong : Form
    {
        private FrmPlaySong()
        {
            InitializeComponent();
        }

        private static FrmPlaySong ps;

        public string url;

        public void play()
        {
            axWindowsMediaPlayer1.URL = url;
        }

        public static FrmPlaySong pSong()
        {
            if (ps==null)
            {
                ps = new FrmPlaySong();

            }
            return ps;
        }


        private void FrmPlaySong_Load(object sender, EventArgs e)
        {
            ps = null;
        }
    }
}
