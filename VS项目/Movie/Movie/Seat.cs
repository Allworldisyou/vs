using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    public class Seat
    {
        public Seat(string Num,System.Drawing.Color Color)
        {
            this.num = Num;
            this.color = Color;
        }

        public string num { get; set; }
        public System.Drawing.Color color { get; set; }
    }
}
