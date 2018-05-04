using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //定义检查项目
        HealthCheckItem height, weight, sight, hearing, liverFun, ekg, bWaves, bloodPressure, bloodTest;
        //定义1个系统默认检查套餐“入学体检”
        HealthSet setA;

        //保存原始的Item数据
        Dictionary<string, HealthCheckItem> AllItems = new Dictionary<string, HealthCheckItem>();
        //保存套餐中的Item数据
        Dictionary<string, HealthCheckItem> items = new Dictionary<string, HealthCheckItem>();
        //使用字典保存套餐集合
        public Dictionary<string, HealthSet> HealthSet = new Dictionary<string, HealthSet>();


        /// <summary>
        /// 创建所有检查项目，并保存在AllItems集合中
        /// </summary>
        public void InitItems()
        {
            height = new HealthCheckItem("身高", 5, "用于检查身高.");
            weight = new HealthCheckItem("体重", 5, "用于检查体重.");
            sight = new HealthCheckItem("视力", 10, "用于检查视力.");
            hearing = new HealthCheckItem("听力", 10, "用于检查听力.");
            liverFun = new HealthCheckItem("肝功能", 50, "用于检查肝功能.");
            bWaves = new HealthCheckItem("B超", 30, "用于检查B超.");
            ekg = new HealthCheckItem("心电图", 50, "用于检查心电图.");
            bloodPressure = new HealthCheckItem("血压", 20, "用于检查血压.");
            bloodTest = new HealthCheckItem("血常规", 20, "用于检查血常规.");
            AllItems.Add(height.Name, height);
            AllItems.Add(weight.Name, weight);
            AllItems.Add(sight.Name, sight);
            AllItems.Add(hearing.Name, hearing);
            AllItems.Add(liverFun.Name, liverFun);
            AllItems.Add(bWaves.Name, bWaves);
            AllItems.Add(ekg.Name, ekg);
            AllItems.Add(bloodPressure.Name, bloodPressure);
            AllItems.Add(bloodTest.Name, bloodTest);

            cboProject.Items.Add("请选择");
            cboProject.SelectedIndex = 0;
            foreach (var item in AllItems.Keys)
            {
                this.cboProject.Items.Add(item);
            }



        }

        /// <summary>
        /// 生成默认套餐数据
        /// </summary>
        private void InitSets()
        {
            //创建1种默认套餐对象
            items = new Dictionary<string, HealthCheckItem>();
            items.Add(height.Name, height);
            items.Add(weight.Name, weight);
            items.Add(liverFun.Name, liverFun);

            setA = new HealthSet("入学体检", items);
            //计算套餐价格
            setA.CalcPrice();
            this.HealthSet.Add("入学体检", setA);
        }

     
        // 加载体检套餐
        public void InitHealthSetList()
        {
            this.cboItem.Items.Clear();
            this.cboItem.Items.Add("请选择");

            foreach (string key in this.HealthSet.Keys)
            {
                this.cboItem.Items.Add(key);
            }
            this.cboItem.SelectedIndex = 0;
        }

        /// <summary>
        /// 填充套餐的DataGridView
        /// </summary>
        /// <param name="set"></param>
        private void UpdateSet(HealthSet set)
        {
            //注意：Dictionary的Values转换为List，可以使用ToList() .该方法必须引入命名空间System.Linq;(.NET FrameWork 4)
            this.dgvShowAll.DataSource = new BindingList<HealthCheckItem>(set.Items.Values.ToList());
        }

        //窗体加载事件
        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblShowName.Text = "";
            this.lblShowPrice.Text = "";
            this.btnDelete.Enabled = false;

            //初始化所有检查项目
            InitItems();
            //初始化默认套餐
            InitSets();
            //加载套餐列表
            InitHealthSetList();

        }


        //套餐列表下拉事件
        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string setName = this.cboItem.Text;
            if (setName == "请选择")
            {
                this.dgvShowAll.DataSource = new BindingList<HealthCheckItem>();
                lblShowName.Text = "";
                lblShowPrice.Text = "";
                return;
            }
            //设置套餐名称
            lblShowName.Text = setName;
            //设置套餐总价
            lblShowPrice.Text = this.HealthSet[setName].Price.ToString();
            //更新套餐检查项目
            UpdateSet(HealthSet[setName]);
            //设置删除按钮为“可用状态”
            this.btnDelete.Enabled = true;


        }


        //添加套餐点击事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(this.tboName.Text.Trim()))
            {
                MessageBox.Show("请输入套餐名称!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            HealthSet Hch = new HealthSet();
            this.HealthSet.Add(this.tboName.Text.Trim(), Hch);

            this.InitHealthSetList();
            this.cboItem.SelectedIndex = this.HealthSet.Count;
            MessageBox.Show("添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //添加项目点击事件
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            #region 输入判断
            if (this.cboProject.SelectedIndex == 0)
            {
                MessageBox.Show("请选择一个项目。");
                return;
            }

            string cboSetText = this.cboItem.Text;
            if (cboSetText == "请选择")
            {
                MessageBox.Show("请选择套餐！");
                return;
            }
            #endregion

            #region 添加操作
            int index = this.cboItem.SelectedIndex - 1;
            string wantAdd = this.cboProject.Text;
            if (!this.HealthSet[cboSetText].Items.Keys.ToList().Contains(wantAdd))
            {
                //添加检查项
                this.HealthSet[cboSetText].Items.Add(wantAdd, AllItems[wantAdd]);
                //重新计算总价格
                this.HealthSet[cboSetText].CalcPrice();
                //更新
                UpdateSet(this.HealthSet[cboSetText]);
                this.tboName.Text = this.HealthSet[cboSetText].Name;  //刷新窗体集合A名称
                this.lblShowPrice.Text = this.HealthSet[cboSetText].Price.ToString();    //刷新集合A价格
                MessageBox.Show("添加成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("该项目存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
            

        }

        //点击删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string setName = this.cboItem.Text;

            if (this.dgvShowAll.SelectedRows.Count== 0)
            {
                MessageBox.Show("没有选择删除项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //获取选中检查项目的索引
            int index = this.dgvShowAll.SelectedRows[0].Index;
            string key = this.dgvShowAll.SelectedRows[0].Cells[0].Value.ToString();
           
            //删除检察项                                                                                                                                                                                                                                 
            this.HealthSet[setName].Items.Remove(key);

            //重新计算价格
            this.HealthSet[setName].CalcPrice();
            //更新DataGridView显示
            UpdateSet(HealthSet[setName]);
            //重设标签显示
            this.lblShowName.Text = setName;
            lblShowPrice.Text = this.HealthSet[setName].Price.ToString();
            MessageBox.Show("删除成功。");
        }


        //所有检查项目下拉框
        private void cboProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboProject.Text != "请选择")
            {
                this.btnAddNew.Enabled = true;
            }
            else
            {
                this.btnAddNew.Enabled = false;
            }
        }
        
    }
}
