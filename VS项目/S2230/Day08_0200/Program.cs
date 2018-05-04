using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day08_0200
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Book.xml");
            XmlElement xmlRoot = xmlDoc.DocumentElement;

            foreach (XmlNode item in xmlRoot.ChildNodes)
            {
                Console.WriteLine(item.Attributes["id"].Value.ToString());
                Console.WriteLine("图书名称:"+item["bookName"].InnerText);
                Console.WriteLine("=====================================");
            }
            Console.ReadKey();
        }
    }
}
