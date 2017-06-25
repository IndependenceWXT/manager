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
    public partial class deptinfo : Form
    {
        [DllImport("user32.dll")]//*********************拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public deptinfo()
        {
            InitializeComponent();
        }
        int depid;//记录部门的id
        int depcount;//记录各个部门的人数
        String depname;//记录部门名称
        String deptel;//记录部门电话

        //获取每个部门的人数
        public int getDeptCountPerson(int depid)
        {
            String cmdText = "select count(*) from employee where did=@id";
            SqlParameter idsprm = new SqlParameter("@id", depid);
            SqlParameter[] sprms = new SqlParameter[] { idsprm };
            int count = DBhelper.GetCountPrm(cmdText, sprms);
            if(count<0){
                count = 0;
            }
            return count;
        }
        //获取部门总数
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

        private void deptinfo_Load(object sender, EventArgs e)
        {
            alldept.Text = getDeptCount().ToString();
            String cmdText = "select * from dept";
            SqlParameter[] sprms = new SqlParameter[] { };
            SqlDataReader r = DBhelper.GetDR(cmdText, sprms);
            if (!r.HasRows)
            {
                MessageBox.Show("没有找到该数据！");
            }
            while( r.Read())
            {      
                depid = (int)r["id"];
                depcount = getDeptCountPerson(depid);
                depname = r["dname"].ToString();
                deptel = r["dtel"].ToString();
                String[] strs = {depname,deptel,depcount.ToString() };
                ListViewItem item = new ListViewItem(strs, 0);
                listView1.Items.Add(item);
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

        private void deptinfo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//调用移动无边框窗体控件函数

        }
    }
}
