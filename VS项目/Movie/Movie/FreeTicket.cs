using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    public class FreeTicket:Ticket
    {
        public string CustomerName;//获取赠票人信息


        public override void CalcPrint()
        {

        }
        public override void Print()
        {
            base.Price = 0;
        }
        public override void Show()
        {
            base.Show();
        }
    }
}
