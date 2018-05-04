using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_0100
{
    public class SimpleFactory
    {
        public static All getInstance(string fu)
        {
              All all = null;
            switch (fu)
            {
                case "+":
                    all = new Add();
                    break;
                case "-":
                    all = new Sub();
                    break;
                case "*":
                    all = new Mul();
                    break;
                case "/":
                    all = new Div();
                    break;
            }
            return all;
        }
    }
}
