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

namespace backStage
{
    public partial class frmSongInfo : Form
    {
        public frmSongInfo()
        {
            InitializeComponent();
        }

        private void frmSongInfo_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            dataGridView1.AutoGenerateColumns = false;
            if (ds.Tables["song_info"] != null)
            {
                ds.Tables["song_info"].Clear();
            }
            SqlConnection conn = new SqlConnection(conStr.str);
            string sql = "select song_name,song_ab,song_word_count,songtype_name,singer_name from song_info,singer_info as b,song_type as a where song_info.songtype_id = a.songtype_id and song_info.singer_id=b.singer_id";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "xinxi");
            dataGridView1.DataSource = ds.Tables["xinxi"];

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SqlConnection conn = new SqlConnection(conStr.str);
            try
            {
                conn.Open();
                string sql = "delete  from song_info where song_name='" + name + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int a = cmd.ExecuteNonQuery();
                DialogResult result = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (a > 0)
                    {
                        MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }  

        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddSong ads= new frmAddSong();
            ads.name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ads.panduan = 2;
            ads.Show();

        }
    }
}
