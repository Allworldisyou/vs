using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetTv
{
    //解析xml文件，将xml中的节点转换成 泛型集合

    public abstract class ChannelBase
    {
        //频道名称
        public string ChannelName { get; set; }
        //频道路径
        public string Path { get; set; }
        //节目列表，该频道上的所有的节目列表
        public List<TvProgram> TvList { get; set; }
        //获取频道列表：通过Fetch方法获取该频道的所有节目列表
        public abstract void Fetch();
    }
}
