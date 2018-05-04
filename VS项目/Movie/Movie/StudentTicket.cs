using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    public class StudentTicket:Ticket
    {
        public int Discount;//获取折扣
        public override void CalcPrint()
        {
          
        }
        public override void Print()
        {
            base.Print();
        }
        public override void Show()
        {
            base.Show();
        }

    }
}
