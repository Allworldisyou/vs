using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_0200
{
    class Book
    {
        public string BookName { get; set; }
        public int BookPrice { get; set; }
        public override string ToString()
        {

            return BookName.ToString();
        }
    }
}
