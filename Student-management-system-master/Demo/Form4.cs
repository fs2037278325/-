using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
            Table();
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//结束整个程序
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        public void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "select *from 老师表";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())

            {
                string 工号, 姓名, 密码, 职称;
                工号 = dr["工号"].ToString();
                姓名 = dr["姓名"].ToString();
                密码 = dr["密码"].ToString();
                职称 = dr["职称"].ToString();

                string[] str = { 工号, 姓名, 密码, 职称};
                dataGridView1.Rows.Add(str);

            }
            dr.Close();//关闭
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 添加教师信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form41 form41 = new Form41(this);
            form41.ShowDialog();//打开
        }

        private void 修改教师信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] vs = { dataGridView1.SelectedCells[0].Value.ToString(),
                dataGridView1.SelectedCells[1].Value.ToString(),
                dataGridView1.SelectedCells[2].Value.ToString(),
                dataGridView1.SelectedCells[3].Value.ToString(),
                dataGridView1.SelectedCells[4].Value.ToString() };

            MessageBox.Show(vs[0] + vs[1]);

            Form41 form41 = new Form41(vs, this);
            form41.ShowDialog();

        }

        private void 删除教师信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("请确认删除", "提示", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                string TID, Tname;
                TID = dataGridView1.SelectedCells[0].Value.ToString();
                Tname = dataGridView1.SelectedCells[1].Value.ToString();
                string sql = "delete from 老师表 where 工号='" + TID + "'and 姓名='" + Tname + "'";

                MessageBox.Show(sql);

                Dao dao = new Dao();
                dao.Excute(sql);
                Table();
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
