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
    public partial class Form31 : Form
    {
        string SNO;
        public Form31(string Sno)
        {
            SNO = Sno;
            InitializeComponent();
            Table();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Table()
        {
            dataGridView2.Rows.Clear();
            string sql = "select *from 选课表 where 学号='" + SNO + "'";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);

            while (dr.Read())
            {
                string CNO = dr["课程号"].ToString();
                string sql2 = "select *from 选课表 where 课程号='" + CNO + "'";

                IDataReader dr2 = dao.read(sql2);
                dr2.Read();

                string 课程号, 课程名, 授课老师, 学分,学时;
                课程号 = dr2["课程号"].ToString();
                课程名 = dr2["课程名"].ToString();
                授课老师 = dr2["授课老师"].ToString();
                学分 = dr2["学分"].ToString();
                学时 = dr2["学时"].ToString();

                string[] str = { 课程号, 课程名, 授课老师, 学分,学时 };
                dataGridView2.Rows.Add(str);
            }
            dr.Close();//关闭
        }

        private void 取消选课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string 课程号 = dataGridView2.SelectedCells[0].Value.ToString();
            string sql = "delete SC where 学号='" + SNO + "'and Cno = '" + 课程号 + "'";

            Dao dao = new Dao();
            dao.Excute(sql);
            Table();
        }

        private void Form31_Load(object sender, EventArgs e)
        {

        }
    }
}
