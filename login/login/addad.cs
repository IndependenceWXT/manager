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
    public partial class addad : Form
    {
        [DllImport("user32.dll")]//*********************拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public addad()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {

            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            String strYMD = currentTime.ToLongDateString();
            MessageBox.Show(strYMD);
            String cmdText = "insert into ad(cont,date) values(@con,@date)";
            SqlParameter consprm = new SqlParameter("@con", richTextBox1.Text.Trim());
            SqlParameter datesprm = new SqlParameter("@date", strYMD);
            SqlParameter[] sprm = new SqlParameter[] { consprm, datesprm };
            int count = DBhelper.Add(cmdText, sprm);
            if (count > 0)
            {
                MessageBox.Show("添加成功");
            }
            else
            {

                MessageBox.Show("添加失败");
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

        private void addad_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//调用移动无边框窗体控件函数

        }
    }
}
