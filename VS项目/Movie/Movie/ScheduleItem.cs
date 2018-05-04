using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    public class ScheduleItem
    {
        public string Time { get; set; }//放映时间属性
        public Movie Movies { get; set; }//本场所放映电影属性
    }
}
