using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_0200
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Book> dic = new Dictionary<string, Book>();
            Book one = new Book();
            one.BookName = "山海经";
            one.BookPrice = 43;
            dic.Add(one.BookName,one);

            Book two = new Book();
            two.BookName = "天才在左疯子在右";
            two.BookPrice = 24;
            dic.Add(two.BookName, two);



            foreach (var item in dic.Keys)
            {
                Console.WriteLine(item+"     "+dic[item]);
                
            }
            Console.ReadKey();
        }
    }
}
