using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace login
{
    public partial class adminMain : Form
    {
        public adminMain()
        {
            InitializeComponent();
        }

        private void 添删员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empinfo ei = new empinfo();
            ei.Show();
        }

        private void 编辑员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empalter ea = new empalter();
            ea.Show();
        }

        private void 考勤记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectsign s = new selectsign();
            s.Show();
        }

        private void 部门信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deptinfo d = new deptinfo();
            d.Show();
        }

        private void 查询部门情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deptselect d = new deptselect();
            d.Show();
        }

        private void 修改部门信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alterdept ad = new alterdept();
            ad.Show();
        }

        private void 添加公告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addad a = new addad();
            a.Show();
        }

        private void 查询公告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectad s = new selectad();
            s.Show();
        }

        private void 删除公告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletead d = new deletead();
            d.Show();
        }
    }
}
