using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDontotKnow
{
    class Program
    {
        static void Main(string[] args)
        {
        
        }
        ///<summary>
        /// 递归输出Fibonacci
        ///</summary>
        public ulong FibonacciRecursionCount(int n, int[] countArray)
        {
            countArray[n]++;  //count the compute number.

            if (n < 0)
                throw new ArgumentOutOfRangeException("n must > 0.");

            if (n == 1 || n == 2)
                return 1;
            return FibonacciRecursionCount(n - 1, countArray) + FibonacciRecursionCount(n - 2, countArray);


        }
        
    }
}
