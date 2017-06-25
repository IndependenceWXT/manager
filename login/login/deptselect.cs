using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace login
{
    public partial class deptselect : Form
    {
        [DllImport("user32.dll")]//*********************拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        public deptselect()
        {
            InitializeComponent();
        }
        int depid;
        int pagecount = 0;//总页数
        int index;//当前页
        int pagesize = 4;//每页显示的记录数
        String cmdT;
        //设置分页
        private void SetDGV()
        {
            if (int.Parse(allpage.Text) == 0)
            {
                MessageBox.Show("该部门目前没有人员");
                dataGridView1.DataSource = DBhelper.GetPartTable(cmdT, index, pagesize);
                currentpage.Text = index.ToString();
            }
            else {
                if (index >= 1 && index <= pagecount)
                {

                    dataGridView1.DataSource = DBhelper.GetPartTable(cmdT, index, pagesize);
                    currentpage.Text = index.ToString();
                }
                else if (index < 1)
                {
                    MessageBox.Show("当前是第一页");
                    index = 1;
                }
                else
                {
                    MessageBox.Show("当前是最后一页");
                    index = pagecount;

                }
            
            }
            

        }
        //设置所有部门名称
        void setDept()
        {
            String cmdText = "select dname from dept";
            SqlParameter[] sprm = new SqlParameter[] { };
            SqlDataReader dr = DBhelper.GetDR(cmdText, sprm);
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["dname"].ToString());
            }
            dr.Close();
        }
        //根据部门名称获取部门id
        public int getDeptId(String name)
        {
            String cmdText = "select id from dept where dname=@n";
            SqlParameter namesprm = new SqlParameter("@n", name);
            SqlParameter[] sprm = new SqlParameter[] {namesprm };
            SqlDataReader dr = DBhelper.GetDR(cmdText, sprm);
            if (!dr.HasRows)
            {
                MessageBox.Show("没有找到该数据！");
            }
            dr.Read();
            return (int)dr["id"];
        }
        //获取每个部门的人数
        public int getDeptCountPerson(int depid)
        {
            String cmdText = "select count(*) from employee where did=@id";
            SqlParameter idsprm = new SqlParameter("@id", depid);
            SqlParameter[] sprms = new SqlParameter[] { idsprm };
            int count = DBhelper.GetCountPrm(cmdText, sprms);
            if (count < 0)
            {
                count = 0;
            }
            return count;
        }

        private void deptselect_Load(object sender, EventArgs e)
        {
            setDept();
            comboBox1.Text = "财务部";
            depid=getDeptId(comboBox1.Text);
            allcount.Text=getDeptCountPerson(depid).ToString();
            cmdT = "select eid as 员工号,ename as 姓名,eage as 年龄,etel as 手机号,ecreatedate as 入职日期  from employee where did=" + depid + "";
            DataTable dt = DBhelper.GetTable(cmdT);
            int count = dt.Rows.Count;
            if (count % pagesize == 0)
            {
                pagecount = count / pagesize;
            }
            else
            {
                pagecount = count / pagesize + 1;
            }
            allpage.Text = pagecount.ToString();
            index = 1;
            SetDGV();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            depid = getDeptId(comboBox1.Text);
            allcount.Text = getDeptCountPerson(depid).ToString();
            cmdT = "select eid as 员工号,ename as 姓名,eage as 年龄,etel as 手机号,ecreatedate as 入职日期  from employee where did=" + depid + "";
            DataTable dt = DBhelper.GetTable(cmdT);
            int count = dt.Rows.Count;
            if (count % pagesize == 0)
            {
                pagecount = count / pagesize;
            }
            else
            {
                pagecount = count / pagesize + 1;
            }
            allpage.Text = pagecount.ToString();
            index = 1;
            SetDGV();
        }

        private void firstpage_Click(object sender, EventArgs e)
        {
            if (int.Parse(allpage.Text) == 0)
            {
                MessageBox.Show("该部门目前没有人员");
            }
            else
            {
                index = 1;
                dataGridView1.DataSource = DBhelper.GetPartTable(cmdT, index, pagesize); 
            }
             
        }

        private void prevpage_Click(object sender, EventArgs e)
        {
            if (int.Parse(allpage.Text) == 0)
            {
                MessageBox.Show("该部门目前没有人员");
            }
            else {
                if (index <= 1)
                {
                    MessageBox.Show("当前已经是第一页了");
                    index = 1;
                }
                else
                {
                    index--;
                    dataGridView1.DataSource = DBhelper.GetPartTable(cmdT, index, pagesize);

                }
            }
            
        }

        private void nextpage_Click(object sender, EventArgs e)
        {
            if (int.Parse(allpage.Text) == 0)
            {
                MessageBox.Show("该部门目前没有人员");
            }
            else
            {
                if (index >= pagecount)
                {
                    MessageBox.Show("当前已经是最后一页了");
                    index = pagecount;
                }
                else
                {
                    index++;
                    dataGridView1.DataSource = DBhelper.GetPartTable(cmdT, index, pagesize);

                }

            }
           
        }

        private void lastpage_Click(object sender, EventArgs e)
        {
            if (int.Parse(allpage.Text) == 0)
            {
                MessageBox.Show("该部门目前没有人员");
            }
            else {
                index = pagecount;
                dataGridView1.DataSource = DBhelper.GetPartTable(cmdT, index, pagesize);
            }
           
        }
        private void close_MouseEnter(object sender, EventArgs e)
        {
            this.close.ForeColor = Color.White;
            this.close.BackColor = Color.FromArgb(255, 48, 48);
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            this.close.BackColor = Color.Transparent;
            this.close.ForeColor = Color.FromArgb(200, 200, 200);
        }

        private void close_Click(object sender, EventArgs e)
        {
            //右上角退出
            this.Close();
        }
    }
}
