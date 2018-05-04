using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    public class SongInfo
    {
        public SongInfo() { }
        public SongInfo(string SongName,string SongUrl) 
        {
            this.SongName = SongName;
            this.SongUrl = SongUrl;
        }
        public string SongName { get; set; }
        public string SongUrl { get; set; }
    }
}
