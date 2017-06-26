using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
namespace login
{
    public partial class login : Form
    {
        [DllImport("user32.dll")]//*********************拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        //记录员工号
        public login()
        {
            InitializeComponent();
        }
       
        private void close_Click(object sender, EventArgs e)
        {
            //右上角退出
            this.Close();
        }
        yzcode yzc = new yzcode();

        private void login_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Image = yzc.identifying(pictureBox1.Width,pictureBox1.Height);

        }

        private void change_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = yzc.identifying(pictureBox1.Width, pictureBox1.Height);
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//调用移动无边框窗体控件函数
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

        private void registerbtn_Click(object sender, EventArgs e)
        {
            register r = new register();
            r.Show();     
        }

        //点击登录，进行验证码验证，和数据库数据验证
        private void loginbtn_Click(object sender, EventArgs e)
        {
            int flag=0;
            //字符串转为小写,进行比较判断
            if (yzc.Check.ToLower() == this.check.Text.ToLower())
            {
                //验证码正确,输入框变绿
                this.checktext.ForeColor = Color.Green;
                this.checktext.Text = "验证码输入正确!";
                flag = 1;
            }
            else
            {
                //验证码错误,有红色字体提示
                this.checktext.ForeColor = Color.Red;
                this.checktext.Text = "验证码输入错误!";
                this.check.Focus();
                flag = 0;
            }
              //没有输入内容
            if (this.number.Text == "" || this.paw.Text == "")
            {
                this.nptext.ForeColor = Color.Red;
                this.nptext.Text = "帐号或密码不能为空！！";
            }
            else {
                this.nptext.Text = "";
                //管理员登录

                if (comboBox1.Text=="管理员")
                {
                    this.nptext.ForeColor = Color.Green;
                    this.nptext.Text = "管理员帐号正在登录中....";
                    if (this.number.Text == "admin")
                    {
                        if (this.paw.Text == "admin")
                        {
                            if (flag == 1)
                            {
                                MessageBox.Show("管理者，欢迎你的登录！！");
                                adminMain am = new adminMain();
                                am.Show();
                            }
                            else
                            {
                                this.pwdtext.ForeColor = Color.Green;
                                this.pwdtext.Text = "密码正确！！";
                            }

                        }
                        else
                        {

                            this.pwdtext.ForeColor = Color.Red;
                            this.pwdtext.Text = "密码不正确！！";
                        }
                    }
                    else {

                        this.nptext.ForeColor = Color.Red;
                        this.nptext.Text = "管理员帐号不正确，应为admin";
                    }
                   

                }
                //用户登录
                else
                {
                    this.nptext.ForeColor = Color.Green;
                    this.nptext.Text = "用户帐号正在登录中....";
                    String cmdText = "select count(*) from employee where eid=@num";
                    SqlParameter numsprm = new SqlParameter("@num", number.Text.Trim());
                    SqlParameter[] sprm = new SqlParameter[] { numsprm };
                    int count = DBhelper.GetCountPrm(cmdText, sprm);
                    if (count < 1)
                    {
                        this.nptext.ForeColor = Color.Red;
                        this.nptext.Text = "帐号不存在！！";
                    }
                    else
                    {
                        String cmdText1 = "select count(*) from employee where eid=@number and password=@pwd";
                        SqlParameter numsprm1 = new SqlParameter("@number", number.Text.Trim());
                        SqlParameter pwdsprm = new SqlParameter("@pwd", paw.Text.Trim());
                        SqlParameter[] sprm1 = new SqlParameter[] { numsprm1, pwdsprm };
                        int count1 = DBhelper.GetCountPrm(cmdText1, sprm1);
                        if (count1 < 1)
                        {
                            this.pwdtext.ForeColor = Color.Red;
                            this.pwdtext.Text = "密码不正确！！";
                        }
                        else
                        {
                            this.pwdtext.ForeColor = Color.Green;
                            this.pwdtext.Text = "密码正确！！";   
                            if (flag == 1)
                            {
                              
                                MessageBox.Show(number.Text.Trim() + "欢迎你的登录！！");
                                Constant.number = number.Text.Trim();
                                Main m = new Main();
                                m.Show();
                    
                            }

                        }
                    }

                }
            
            }
            

        }


    }
}
