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
    public partial class alterdept : Form
    {

        [DllImport("user32.dll")]//*********************拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public alterdept()
        {
            InitializeComponent();
        }
        DataTable dt;
        SqlDataAdapter sda;
        int id;//自动设置id
        public int getDeptCount()
        {
            String cmdText = "select count(*) from dept";
            int count = DBhelper.GetCount(cmdText);
            if (count < 0)
            {
                count = 0;
            }
            return count;
        }
        private void alterdept_Load(object sender, EventArgs e)
        {
            id = getDeptCount();
            //注意要查询到主键，否则会报错
            sda = DBhelper.GetSDA("select id as 部门ID, dname as 部门名称,dtel as 部门联系方式 from dept");
            SqlCommandBuilder acb = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds, "st");
            dt = ds.Tables["st"];
            dataGridView1.DataSource = dt;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
           
            DataRow newrow = dt.NewRow();
            newrow["部门ID"] = id;
            newrow["部门名称"] = textBox1.Text.Trim();
            newrow["部门联系方式"] = textBox2.Text.Trim();
            dt.Rows.Add(newrow);
            sda.Update(dt);
            MessageBox.Show("添加成功！！");
            id = id + 1;
        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            sda.Update(dt);
            MessageBox.Show("更新成功！！");
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            //是否选中一行数据
            if (this.dataGridView1.CurrentRow.Selected)
            {
                DialogResult dr = MessageBox.Show("确定要删除么？", "友好提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.Yes)
                {
                    this.dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    sda.Update(dt);
                    MessageBox.Show("删除成功！");
                }
            }
            else
            {
                MessageBox.Show("请先选中一行数据，然后在进行删除！");
                return;
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

        private void alterdept_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//调用移动无边框窗体控件函数
  
        }

       
    }
}
