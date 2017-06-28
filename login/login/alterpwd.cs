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
    public partial class alterpwd : Form
    {
        [DllImport("user32.dll")]//*********************拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public alterpwd()
        {
            InitializeComponent();
        }
        string strnum = "";
        public alterpwd(String str)
        {
            strnum = str;
            InitializeComponent();
        }
        private void alterbtn_Click(object sender, EventArgs e)
        {
            //密码不为空
            if (this.pwd.Text == "")
            {
                this.pwdtext.ForeColor = Color.Red;
                this.pwdtext.Text = "请设置密码！";
                this.pwd.Focus();
            }
            else
            {
                this.pwdtext.ForeColor = Color.Green;
                this.pwdtext.Text = "OK";
            }
            //须二次输入密码
            if (this.againpwd.Text == "")
            {
                this.apwdtext.ForeColor = Color.Red;
                this.apwdtext.Text = "请再次输入密码！";
                this.againpwd.Focus();
            }
            else
            {
                //两次密码须一致
                if (this.pwd.Text == this.againpwd.Text)
                {
                    this.apwdtext.ForeColor = Color.Green;
                    this.apwdtext.Text = "OK";
                    String cmdText = "update employee set password=@pwd where eid=@eid";
                    SqlParameter pwdsprm = new SqlParameter("@pwd",pwd.Text.Trim());
                    SqlParameter eidsprm = new SqlParameter("@eid", strnum);                 
                    SqlParameter[] sprms = new SqlParameter[] {pwdsprm, eidsprm};
                    int count = DBhelper.Add(cmdText, sprms);
                    if (count > 0)
                    {
                        MessageBox.Show("修改成功！");
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                    }

                }
                else
                {
                    this.apwdtext.ForeColor = Color.Red;
                    this.apwdtext.Text = "两次密码不一致！！";
                    this.againpwd.Focus();

                }

            }
           
        }

        private void alterpwd_Load(object sender, EventArgs e)
        {
            num.Text = strnum;
        }

        private void alterpwd_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//调用移动无边框窗体控件函数
    
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
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


       
    }
}
