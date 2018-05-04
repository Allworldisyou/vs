using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_0100
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 初始
            //ArrayList list = new ArrayList();
            //list.Add("zero");
            //list.Add("one");
            //list.Add("two");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("===========================");
            //list.Remove("zero");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("==========================");
            //list.RemoveAt(0);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine(); 
            #endregion

            ArrayList list = new ArrayList() 
            {
                new Book(){BookName1="越狱"},
                new Book(){BookName1="绿眼女子"},
                new Book(){BookName1="偷窃"}
            };

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine(); 
        }
    }
}
