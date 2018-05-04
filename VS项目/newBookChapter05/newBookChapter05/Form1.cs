using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newBookChapter05
{
    public partial class Form1 : Form
    { 
        SqlConnection conn = new SqlConnection(connections.str);
        public Form1()
        {
            InitializeComponent();
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            string sql = "select * from Grade";



            //第一种方法
            //SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            //DataSet ds = new DataSet();
            //da.Fill(ds,"id");
            //cboClass.DataSource = ds.Tables["id"];
            //cboClass.DisplayMember = "GradeName";
            //cboClass.ValueMember = "GradeId";


            //第二种

            SqlDataAdapter da1 = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(sql, conn);
            da1.SelectCommand = cmd;
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "s");
            DataRow rows = ds1.Tables["s"].NewRow();
            rows[0] = -1;
            rows[1] = "全部";
            ds1.Tables["s"].Rows.InsertAt(rows,0);
            cboClass.DataSource = ds1.Tables["s"];
            cboClass.DisplayMember = "GradeName";
            cboClass.ValueMember = "GradeId";


            dgvMain.AutoGenerateColumns = false;
            string sql1 = "select * from Student";
            SqlDataAdapter da = new SqlDataAdapter(sql1, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "user");
            dgvMain.DataSource = ds.Tables["user"];
                                         
        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(connections.str);
            string sql = "select * from Student";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "s");
            dgvMain.DataSource = ds.Tables["s"];
            if (tvMenu.SelectedNode != null)
            {
                DataView dv = new DataView(ds.Tables["s"]);
                if (tvMenu.SelectedNode.Level == 1)
                {
                    string num = tvMenu.SelectedNode.Text;//获取treeView的点击值
                    dv.RowFilter = string.Format("GradeId='{0}'", num);//设置筛选条件
                }
                else if (tvMenu.SelectedNode.Level == 2)
                {
                    string sex = tvMenu.SelectedNode.Text;//获取treeView的点击值
                    string gradename = tvMenu.SelectedNode.Parent.Text;
                    dv.RowFilter = string.Format("Sex='{0}'and GradeId={1}", sex, gradename);//设置筛选条件
                }
                dgvMain.DataSource = dv;//重新筛选

            }

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
