using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstText
{

    //班级类
    public class Grade
    {
        //一个泛型集合，用于存放学生集合
        List<Student> list = new List<Student>();

        //Point类型的形参，其功能是能以形参指定的位置为起点，一字排开显示所有的学生对象
        public List<string> DisplayStudent(Point point)
        {
            int count = 0;
            List<string> newList = new List<string>();
            foreach (Student item in list)
            {
                count++;
                newList.Add(item.StudentName + ":" + (point.X + 65 * count) + ":" + (point.Y + 35));
            }
            return newList;
        }



        //添加学生
        public void AddStudent(Student stu)
        {
            list.Add(stu);
        }

    }
}
