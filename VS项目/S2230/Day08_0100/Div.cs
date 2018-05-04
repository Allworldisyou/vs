using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_0100
{
    //除法
    class Div:All
    {
        public override int Cale()
        {
            if (NumberRight ==0)
            {
                throw new Exception("除数不能为0");
            }
            return this.NumberLeft / this.NumberRight;
        }
    }
}
