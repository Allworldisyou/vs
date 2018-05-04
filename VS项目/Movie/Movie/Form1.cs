using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Movie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zuowei();
        }

        Schedule sd = new Schedule();
        public void intrv()
        {
            string namem = string.Empty;
            TreeNode node = null;
            foreach (ScheduleItem item in sd.Dis.Values)
            {
                if (item.Movies.MovieName != namem)
                {
                    node = new TreeNode(item.Movies.MovieName);
                    treeView1.Nodes.Add(node);
                }
                TreeNode tn = new TreeNode(item.Time);
                node.Nodes.Add(tn);
                namem = item.Movies.MovieName;
            }
        }

        #region 动态生成座位


        public int setrows = 7;
        public int seatline = 5;
        Dictionary<string, Label> labels = new Dictionary<string, Label>();
        Dictionary<string, Seat> seats = new Dictionary<string, Seat>();
        public void zuowei()
        {
            for (int i = 0; i < setrows; i++)
            {
                for (int j = 0; j < seatline; j++)
                {
                    Label lab = new Label();
                    lab.BackColor = Color.Yellow;
                    lab.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular,
                        System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    lab.AutoSize = false;
                    lab.Size = new System.Drawing.Size(50, 25);
                    lab.Text = (j + 1).ToString() + "-" + (i + 1).ToString();
                    lab.TextAlign = ContentAlignment.MiddleCenter;

                    lab.Location = new Point(40 + (i * 80), 40 + (j * 44));
                    
                    lab.Click += lab_Click;
                    tabPage2.Controls.Add(lab);
                    labels.Add(lab.Text, label1);

                    Seat seat = new Seat((j + 1).ToString() + "-" + (i + 1).ToString(), Color.Yellow);

                    seats.Add(seat.num, seat);


                }
            }
        }







        void lab_Click(object sender, EventArgs e)
        {
        } 
        #endregion



        private void 获取新放映列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sd.ShowMxl();
            intrv();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
       
        #region 加载信息
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {



            if (treeView1.SelectedNode.Level != 0)
            {
                string time = this.treeView1.SelectedNode.Text;

                Movie movie = new Movie();
                ScheduleItem item = sd.Dis[time];

                //演员
                lblMainActer.Text = item.Movies.Actor;
                //导演
                lblDirection.Text = item.Movies.Director;


                lblPrice.Text = item.Movies.Price.ToString();

                lblType.Text = item.Movies.MovieType.ToString();


                //片名

                lblName.Text = treeView1.SelectedNode.Parent.Text;

                lblTime.Text = treeView1.SelectedNode.Text;
                pbPhoto.Image = Image.FromFile(lblName.Text + ".jpg");

                groupBox1.Visible = true;

                lblDisCount.Visible = false;


            }

        }
        
        #endregion
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string time = this.treeView1.SelectedNode.Text;

            ScheduleItem item = sd.Dis[time];
            this.cmbDisCount.Enabled = false;
            this.txtCustomer.Text = "";
            this.txtCustomer.Enabled = false;
            this.cmbDisCount.Text = "";
            this.lblDisCount.Text = item.Movies.Price.ToString();
 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            this.txtCustomer.Enabled = true;
            this.cmbDisCount.Enabled = false;
            this.cmbDisCount.Text = "";
            this.lblDisCount.Text = "0";  
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Text = "";
            this.cmbDisCount.Enabled = true;
            this.cmbDisCount.Text = "7";

            if (this.lblPrice.Text != "")
            {
                lblDisCount.Text = (Convert.ToInt32(lblPrice.Text) * Convert.ToInt32(cmbDisCount.Text) / 10).ToString();
            }  
           
        }


    }
}
