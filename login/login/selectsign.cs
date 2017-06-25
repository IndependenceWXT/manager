using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;


namespace login
{
    public partial class selectsign : Form
    {
        [DllImport("user32.dll")]//*********************拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public selectsign()
        {
            InitializeComponent();
        }
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
            else
            {
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
        //设置签到了的所有日期到comboBox1中
        void setDate()
        {
            //去重处理
            String cmdText = "select distinct sdate from sign";
            SqlParameter[] sprm = new SqlParameter[] { };
            SqlDataReader dr = DBhelper.GetDR(cmdText, sprm);
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["sdate"].ToString());
            }
            dr.Close();
        }
        //根据ID找到用户名
        public String setFindName(String str)
        {
            String name="";
            //去重处理
            String cmdText = "select ename from employee where eid=@eid";
            SqlParameter eidsprm = new SqlParameter("@eid", str);
            SqlParameter[] sprm = new SqlParameter[] {eidsprm };
            SqlDataReader dr = DBhelper.GetDR(cmdText, sprm);
            while (dr.Read())
            {
                name = dr["ename"].ToString();
            }
            return name;
        }
        //获取该天正常签到或迟到的次数
        public int getCount(String str,String f)
        {
            String cmdText = "select count(*) from sign where sdate=@date and sflag=@flag";
            SqlParameter dsprm = new SqlParameter("@date", str);
            SqlParameter fsprm = new SqlParameter("@flag", f);
            SqlParameter[] sprms = new SqlParameter[] { dsprm, fsprm };
            int count = DBhelper.GetCountPrm(cmdText, sprms);
            if (count < 0)
            {
                count = 0;
            }
            return count;
        }
        //获取员工人数
        public int getPersonCount()
        {
            String cmdText = "select count(*) from employee";
            SqlParameter[] sprms = new SqlParameter[] {};
            int count = DBhelper.GetCountPrm(cmdText, sprms);
            if (count < 0)
            {
                count = 0;
            }
            return count;
        }
        private void selectsign_Load(object sender, EventArgs e)
        {
            setDate();
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            String strYMD = currentTime.ToLongDateString();
            comboBox1.Text = strYMD;

            allpeople.Text = getPersonCount().ToString();
            zc.Text = getCount(comboBox1.Text,"True").ToString();
            cd.Text = getCount(comboBox1.Text, "False").ToString();
            wqd.Text = (getPersonCount() - getCount(comboBox1.Text, "True") - getCount(comboBox1.Text, "False")).ToString();
        

            cmdT = "select eid as 员工号,stime as 签到时间,sflag as 签到状态  from sign where sdate='" + comboBox1.Text + "'";
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
            zc.Text = getCount(comboBox1.Text, "True").ToString();
            cd.Text = getCount(comboBox1.Text, "False").ToString();
            wqd.Text = (getPersonCount() - getCount(comboBox1.Text, "True") - getCount(comboBox1.Text, "False")).ToString();
            cmdT = "select eid as 员工号,stime as 签到时间,sflag as 签到状态  from sign where sdate='" + comboBox1.Text + "'";
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
            else
            {
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
            else
            {
                index = pagecount;
                dataGridView1.DataSource = DBhelper.GetPartTable(cmdT, index, pagesize);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
             //右上角退出
            this.Close();
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

        private void selectsign_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//调用移动无边框窗体控件函数

        }

     
        
        }

     
}
