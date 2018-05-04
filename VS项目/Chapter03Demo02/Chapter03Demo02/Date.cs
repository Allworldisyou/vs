using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03Demo02
{
    class Date
    {
        public int[] GetDate()
        {
            int[] iArray = new int[30];
            iArray[0] = 1;
            iArray[1] = 1;
            for (int i = 2; i < 30; i++) 
            {
                iArray[i] = iArray[i - 1] + iArray[i - 2];
            }
            foreach (var item in iArray)
            {
                Console.WriteLine(item+"  ");
            }
           
            return iArray;
        }
    }
}
