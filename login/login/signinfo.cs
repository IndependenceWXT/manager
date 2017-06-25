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
    public partial class signinfo : Form
    {
        [DllImport("user32.dll")]//*********************拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        String numStr;
        int flag=0;//0表示迟到，1表示正常签到
        String strYMD;//当前日期
        String strT;//当前时间
        int strH;//当前的小时
        public signinfo()
        {
            InitializeComponent();
        }
         public signinfo(String str)
        {
            numStr = str;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString();
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

        private void signinfo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//调用移动无边框窗体控件函数

        }
        //根据id获取员工名字
        public String getPersonName()
        {
            String cmdText = "select ename from employee where eid=@num";
            SqlParameter numsprm = new SqlParameter("@num", numStr);
            SqlParameter[] sprm = new SqlParameter[] { numsprm };
            SqlDataReader dr = DBhelper.GetDR(cmdText, sprm);
            if (!dr.HasRows)
            {
                MessageBox.Show("没有找到该数据！");
            }
            dr.Read();
            return dr["ename"].ToString();
        }
        //判断今天有没有签到过
        public int getDate()
        {
            int dayflag=0;
            String cmdText = "select * from sign where eid=@n and sdate=@d";
            SqlParameter nsprm = new SqlParameter("@n", numStr);
            SqlParameter dsprm = new SqlParameter("@d", strYMD);
            SqlParameter[] sprm = new SqlParameter[] { nsprm,dsprm };
            SqlDataReader dr = DBhelper.GetDR(cmdText, sprm);
            if (!dr.HasRows)
            {
                dayflag = 0;
            }
            else {
                dr.Read();
                dayflag = 1;
            }
           
            return dayflag;
        }
        private void signinfo_Load(object sender, EventArgs e)
        {
           
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            strYMD = currentTime.ToLongDateString();
            strT = currentTime.ToString("t");
            strH = currentTime.Hour; 
            int day = getDate();
            if (day == 1)
            {
                //说明已经签到了
                btn.Text = "已签到";
                btn.Enabled = false;
                MessageBox.Show("今天已经签到过了，明天再来！！");

            }
            MessageBox.Show(strYMD);
            
        }
        private void btn_Click(object sender, EventArgs e)
        {
            int day = getDate();
            if (day == 1)
            {

            }
            else {
                //超过9点，视为迟到
                if (strH < 9)
                {
                    flag = 1;
                }
                else {
                    flag = 0;
                }
                
                String name = getPersonName();
                //MessageBox.Show("当前日期："+strYMD+"\n当前时间："+strT);
                String cmdText = "insert into sign(eid,sflag,sdate,stime) values(@eid,@sflag,@sdate,@stime)";
                SqlParameter eidsprm = new SqlParameter("@eid", numStr);
                SqlParameter sflagsprm = new SqlParameter("@sflag", flag);
                SqlParameter sdatesprm = new SqlParameter("@sdate", strYMD);
                SqlParameter stimesprm = new SqlParameter("@stime", strT);
                SqlParameter[] sprms = new SqlParameter[] { eidsprm, sflagsprm, sdatesprm, stimesprm };
                int count = DBhelper.Add(cmdText, sprms);
                if (count > 0)
                {
                    MessageBox.Show(name + "签到成功！！");
                    btn.Text = "已签到";
                    btn.Enabled = false;

                }
                else
                {
                    MessageBox.Show("签到失败！");
                }

            
            
            }
           
           


        }
    }
}
