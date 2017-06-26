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
    public partial class signRecord : Form
    {
        [DllImport("user32.dll")]//*********************拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public signRecord()
        {
            InitializeComponent();
        }
        String numStr;
        public signRecord(String str)
        {
            numStr = str;
            InitializeComponent();
        }
        int mCount;
        //获取该月的天数
        public int getMouthDate()
        {
            DateTime time = DateTime.Now;
            mCount = DateTime.DaysInMonth(time.Year,time.Month);
            return mCount;
        }
        //获取该月正常签到或迟到的次数
        public int getCount(String f)
        {
            String cmdText = "select count(*) from sign where eid=@id and sflag=@flag";
            SqlParameter idsprm = new SqlParameter("@id", numStr);
            SqlParameter fsprm = new SqlParameter("@flag",f);
            SqlParameter[] sprms = new SqlParameter[] { idsprm,fsprm };
            int count = DBhelper.GetCountPrm(cmdText, sprms);
            if (count < 0)
            {
                count = 0;
            }
            return count;
        }
        private void signRecord_Load(object sender, EventArgs e)
        {
            getMouthDate();
            daycount.Text = mCount.ToString();
            zcqd.Text = getCount("True").ToString();
            cd.Text = getCount("False").ToString();
            wqd.Text = (mCount - getCount("True") - getCount("False")).ToString();
            //获取该月
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            String strYM = currentTime.ToString("y");
            for (int i = 1; i < mCount;i++ )
            {
                String cmdText = "select * from sign where eid=@eid and sdate='" + strYM +i+ "日'";
                //MessageBox.Show(cmdText);
                SqlParameter eidsprm = new SqlParameter("@eid", numStr);
                // SqlParameter dsprm = new SqlParameter("@date", strYM+"%");
                SqlParameter[] sprms = new SqlParameter[] { eidsprm };
                SqlDataReader r = DBhelper.GetDR(cmdText, sprms);
                if (!r.HasRows)
                {
                    //没找到该数据，说明该天未签到
                    String sdate =strYM+i+"日";
                    String stime = "";
                    String sflag="未签到";
                    String[] strs = { sdate, stime, sflag };
                    ListViewItem item = new ListViewItem(strs, 0);
                    listView1.Items.Add(item);
                }
                while (r.Read())
                {
                    String sdate = r["sdate"].ToString();
                    String stime = r["stime"].ToString();
                    //MessageBox.Show(r["sflag"].ToString());
                    String f = r["sflag"].ToString();
                    String sflag;
                    if (f == "True")
                    {
                        sflag = "签到";
                    }
                    else
                    {
                        sflag = "迟到";
                    }
                    String[] strs = { sdate, stime, sflag };
                    ListViewItem item = new ListViewItem(strs, 0);
                    listView1.Items.Add(item);
                }
            }
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            //右上角退出
            this.Close();
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            this.close.BackColor = Color.Transparent;
            this.close.ForeColor = Color.FromArgb(200, 200, 200);
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            this.close.ForeColor = Color.White;
            this.close.BackColor = Color.FromArgb(255, 48, 48);
        }

        private void signRecord_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//调用移动无边框窗体控件函数
 
        }
    }
}
