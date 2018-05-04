using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetTv
{
    //节目单实体
    public class TvProgram
    {
        //播出时间
        public DateTime PlayTime { get; set; }
        //播出时间档
        public string ShiDuan { get; set; }
        public string Name { get; set; }
        //视频路径
        public string Path { get; set; }
    }
}
