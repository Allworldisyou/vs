using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_0100
{
    public abstract class All
    {
        private int numberLeft;

      
        private int numberRight;


        public abstract int Cale();
        
        
        public int NumberLeft
        {
            get { return numberLeft; }
            set { numberLeft = value; }
        }
 
        public int NumberRight
        {
            get { return numberRight; }
            set { numberRight = value; }
        }


    }
}
