using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Bf
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 序列化
            //List<Person> list = new List<Person>();
            //Person p1 = new Person();
            //p1.Name = "AAA";
            //p1.Age = 21;
            //Person p2 = new Person();
            //p2.Name = "BBB";
            //p2.Age = 22;
            //list.Add(p1);
            //list.Add(p2);  



            //BinaryFormatter bf = new BinaryFormatter();
            //FileStream fs = new FileStream("save.txt", FileMode.Create);
            //bf.Serialize(fs, list);
            //fs.Close();
            //Console.WriteLine("序列化成功"); 
            #endregion


            #region 反序列化
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("save.txt",FileMode.Open);
            List<Person> list = (List<Person>)bf.Deserialize(fs);
            foreach (Person item in list)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Age);
                Console.WriteLine("==========================");
            }



            
            #endregion
            Console.ReadKey();

        }
    }
}
