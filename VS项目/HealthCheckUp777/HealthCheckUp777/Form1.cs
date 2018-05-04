using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCheckUp777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 所选名称的所有项目
        public void Show()
        {

        //    Dictionary<string, HealthCheckSet> aa = new Dictionary<string, HealthCheckSet>();

        }
        
        #endregion

        #region 给检查项目赋值
        public void Add()
        {
            HealthCheckSet hcs = new HealthCheckSet();

            HealthCheckItem hci = new HealthCheckItem();
            hci.Name = "身高";
            hci.Description = "用于检查身高";
            hci.Price = 5;
            hcs.AllLItems.Add(hci);

            HealthCheckItem hci1 = new HealthCheckItem();
            hci1.Name = "体重";
            hci1.Description = "用于检查体重";
            hci1.Price = 5;
            hcs.AllLItems.Add(hci1);

            HealthCheckItem hci2 = new HealthCheckItem();
            hci2.Name = "肝功能";
            hci2.Description = "用于检查肝功能";
            hci2.Price = 50;
            hcs.AllLItems.Add(hci2);

            HealthCheckItem hci3 = new HealthCheckItem();
            hci3.Name = "B超";
            hci3.Description = "用于检查B超";
            hci3.Price = 30;
            hcs.AllLItems.Add(hci3);

            HealthCheckItem hci4 = new HealthCheckItem();
            hci4.Name = "血糖";
            hci4.Description = "用于检查血糖";
            hci4.Price = 15;
            hcs.AllLItems.Add(hci4);

            HealthCheckItem hci5 = new HealthCheckItem();
            hci5.Name = "肺活量";
            hci5.Description = "用于检查肺活量";
            hci5.Price = 15;
            hcs.AllLItems.Add(hci5);

             cboProject.Items.Add("请选择");
            cboProject.SelectedIndex = 0;
           
            this.cboProject.DataSource = hcs.AllLItems;
            this.cboProject.DisplayMember = "Name";
            this.cboProject.ValueMember = "Price";

       
        }
        
        #endregion


        #region 给项目名称赋值


        public void Fuzhi()
        {
            HealthCheckSet hcs = new HealthCheckSet();
            hcs.items.Add("入学检查");
            hcs.items.Add("当兵检查");
            hcs.items.Add("入职检查");


        }

        #endregion
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Add();
            HealthCheckSet hcs = new HealthCheckSet();

          
            
            this.cboLie.Items.Add("请选择");//添加项
            cboLie.SelectedIndex = 0;
            foreach (var item in hcs.items )
            {
                cboLie.Items.Add(item);
            }
            

        }
        #region   单击添加名称
        Dictionary<string, HealthCheckSet> HealthSet2 = new Dictionary<string, HealthCheckSet>();
        private void btnAddTaoCan_Click(object sender, EventArgs e)
        {

            if (this.tboName.Text.Trim() != null)//非空判断
            {
                    
                HealthCheckSet hcs = new HealthCheckSet();//创建套餐列表类的对象
                HealthSet2.Add(tboName.Text, hcs);//使用Add方法添加进去
                this.cboLie.Items.Clear();//先清除项
                this.cboLie.Items.Add("请选择");//添加项

                foreach (string key in HealthSet2.Keys)//利用foreach循环将用户要添加的套餐名称加到集合中
                {

                    this.cboLie.Items.Add(key);//加到列表项中
                }
                cboLie.Text = tboName.Text;
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("请输入一个套餐名称！");
            }


        }

        
        #endregion

        #region 显示检查项目
        private void cboLie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLie.Text.Equals("请选择"))
            {
                lblName.Text = "";
            }
            else
            {
                lblName.Text = cboLie.Text;
            }
        }
        
        #endregion

        #region 点击保存

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }
        #endregion
 
     



    }
}
