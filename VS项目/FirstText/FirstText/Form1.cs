using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Grade grade = new Grade();

            #region 添加人员
            
            Student stu1 = new Student();
            stu1.StudentName = "壹";
            grade.AddStudent(stu1);

            Student stu2 = new Student();
            stu2.StudentName = "贰";
            grade.AddStudent(stu2);

            Student stu3 = new Student();
            stu3.StudentName = "叁";
            grade.AddStudent(stu3);

            Student stu4 = new Student();
            stu4.StudentName = "肆";
            grade.AddStudent(stu4);

            Student stu5 = new Student();
            stu5.StudentName = "伍";
            grade.AddStudent(stu5);

            Student stu6 = new Student();
            stu6.StudentName = "陆";
            grade.AddStudent(stu6);

            #endregion
            
            //单列集合调用grade类point集合方法
            List<string> list = grade.DisplayStudent(new Point() { X = 1, Y = 1 });

            //循环创造button
            foreach (string item in list)
            {
                string[] temp = item.Split(':');
                string t1 = temp[0];

                int x = Convert.ToInt32(temp[1]);
                int y = Convert.ToInt32(temp[2]);
                Button btn = new Button();
                btn.Text = t1;
                btn.Size = new System.Drawing.Size(60, 25);
                //对齐方式
                btn.TextAlign = ContentAlignment.MiddleCenter;
                //设置位置         坐标
                btn.Location = new Point(20 + x, 30 + y);
                this.Controls.Add(btn);
            }
        }
    }
}
