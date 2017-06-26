using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
namespace login
{
    public partial class Main : Form
    {
        String strText = Constant.number;
        public Main()
        {
            InitializeComponent();
        }
        //根据员工ID获取员工姓名
        public String getEmpName(String num)
        {
            String cmdText = "select ename from employee where eid=@n";
            SqlParameter namesprm = new SqlParameter("@n", num);
            SqlParameter[] sprm = new SqlParameter[] { namesprm };
            SqlDataReader dr = DBhelper.GetDR(cmdText, sprm);
            if (!dr.HasRows)
            {
                MessageBox.Show("没有找到该数据！");
            }
            dr.Read();
            return dr["ename"].ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            dtime.Text = DateTime.Now.ToString();
        }
        private void Main_Load(object sender, EventArgs e)
        {

            yonghu.Text =getEmpName(strText);
        }

        private void 我的信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myInformation myinfo = new myInformation(strText);
            myinfo.Show();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alterdept ad = new alterdept();
            ad.Show();
        }

        private void 部门信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deptinfo d=new deptinfo();
            d.Show();

        }

        private void 查询部门ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deptselect d = new deptselect();
            d.Show();
        }

        private void 修改部门信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alterdept ad = new alterdept();
            ad.Show();
        }

        private void 我要签到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            signinfo s = new signinfo(strText);
            s.Show();
        }

        private void 我的考勤记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            signRecord s = new signRecord(strText);
            s.Show();
        }

        private void 查询考勤记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectsign s = new selectsign();
            s.Show();
        }

        private void 查看员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empinfo ei = new empinfo();
            ei.Show();
        }

        private void 更改员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empalter ea = new empalter();
            ea.Show();
        }

        private void 修改密码ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            alterpwd a = new alterpwd();
            a.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 查看公告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectad s = new selectad();
            s.Show();
        }

      
    }
}
