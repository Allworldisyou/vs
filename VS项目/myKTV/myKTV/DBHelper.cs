using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myKTV
{


    public enum SongPlayState
    {
        //未播放，播放，重播，切歌
        unplayed, played, again, cut
    }
    public class Song
    {
        public string SongName;//歌曲名称
        public string SongURL;//歌曲路径
        public string singerName;
        public SongPlayState playState = SongPlayState.unplayed;//默认未播放

        //状态为已播
        public void SetSongPlayed()
        {
            this.playState = SongPlayState.played;
        }
        //重唱
        public void SetPlayAgain()
        {
            this.playState = SongPlayState.again;
        }
        //切歌
        public void SetSongCut()
        {
            this.playState = SongPlayState.cut;
        }
        class DBHelper
        {
        }
    }
}
