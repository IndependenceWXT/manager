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
    public partial class selectad : Form
    {
        [DllImport("user32.dll")]//*********************拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public selectad()
        {
            InitializeComponent();
        }
        //设置发布公告的时间
        void setDate()
        {
            String cmdText = "select distinct date from ad";
            SqlParameter[] sprm = new SqlParameter[] { };
            SqlDataReader dr = DBhelper.GetDR(cmdText, sprm);
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["date"].ToString());
            }
            dr.Close();
        }
        //获取每个时间公告的条数
        public int getDateCountAD(String date)
        {
            String cmdText = "select count(*) from ad where date=@d";
            SqlParameter dsprm = new SqlParameter("@d", date);
            SqlParameter[] sprms = new SqlParameter[] { dsprm };
            int count = DBhelper.GetCountPrm(cmdText, sprms);
            if (count < 0)
            {
                count = 0;
            }
            return count;
        }
        private void selectad_Load(object sender, EventArgs e)
        {
          
            setDate();
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            String strYMD = currentTime.ToLongDateString();
            comboBox1.Text = strYMD;
            count.Text = getDateCountAD(comboBox1.Text).ToString();
            String cmdText = "select * from ad where date='" + comboBox1.Text + "' ";
            dataGridView1.DataSource = DBhelper.GetTable(cmdText);
            this.dataGridView1.Columns[0].FillWeight = 20;
            this.dataGridView1.Columns[1].FillWeight = 170;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            count.Text = getDateCountAD(comboBox1.Text).ToString();
            String cmdText = "select * from ad where date='" + comboBox1.Text + "' ";
            dataGridView1.DataSource = DBhelper.GetTable(cmdText);
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

        private void selectad_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//调用移动无边框窗体控件函数

        }
    }
}
