using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    public class Ticket
    {
        public Ticket() { }

        public ScheduleItem ScheduleItem;//放映场次
        public Seat Seat;//所属座位对象
        public int Price;//票价

        //计算票价
        public virtual void CalcPrint() 
        {
        }
        //打印售票信息
        public virtual void Print()
        {
        }

        //显示当前出票信息
        public virtual void Show()
        {
        }


    }
}
