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
    public partial class register : Form
    {
        [DllImport("user32.dll")]//*********************拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public register()
        {
            InitializeComponent();
        }
        yzcode yzc = new yzcode();
        private void register_Load(object sender, EventArgs e)
        {
            this.img.Image = yzc.identifying(img.Width, img.Height);
        }
        private void change_Click(object sender, EventArgs e)
        {
            this.img.Image = yzc.identifying(img.Width, img.Height);
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

        private void loginbtn_Click(object sender, EventArgs e)
        {
         
            login l = new login();
            l.Show();
            
        }

        private void register_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//调用移动无边框窗体控件函数
        }

        private void register_Load_1(object sender, EventArgs e)
        {

        }
        int flag = 0, flag1 = 0, flag2 = 0;
        private void registerbtn_Click(object sender, EventArgs e)
        {
            
            //帐号不为空
            if (this.num.Text == "")
            {
                this.numtext.ForeColor = Color.Red;
                this.numtext.Text = "请输入你的员工号！";
                this.num.Focus();
            }
            else {  
                 //账号不能在数据库中已存在
                 String cmdText = "select count(*) from employee where eid=@num";
                 SqlParameter numsprm = new SqlParameter("@num", num.Text.Trim());
                 SqlParameter[] sprm = new SqlParameter[] { numsprm };
                 int count = DBhelper.GetCountPrm(cmdText, sprm);
                 if (count >= 1)
                 {
                     this.numtext.ForeColor = Color.Red;
                     this.numtext.Text = "帐号已经注册过了了！！";
                 }
                 else {
                     this.numtext.ForeColor = Color.Green;
                     this.numtext.Text = "OK";
                     flag1=1;
                 }
            }
            //密码不为空
            if (this.pwd.Text == "")
            {
                this.pwdtext.ForeColor = Color.Red;
                this.pwdtext.Text = "请设置密码！";
                this.pwd.Focus();
            }
            else {
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
            else {
                //两次密码须一致
                if (this.pwd.Text == this.againpwd.Text)
                {
                    this.apwdtext.ForeColor = Color.Green;
                    this.apwdtext.Text = "OK";
                    flag2 = 1;
                }
                else
                {
                    this.apwdtext.ForeColor = Color.Red;
                    this.apwdtext.Text = "两次密码不一致！！";
                    this.againpwd.Focus();

                }
            
            }
           
            //须填写真实姓名
            if (this.name.Text == "")
            {
                this.nametext.ForeColor = Color.Red;
                this.nametext.Text = "请输入你的真实姓名！";
                this.name.Focus();
            }
            else
            {
                this.nametext.ForeColor = Color.Green;
                this.nametext.Text = "OK";
            }
           
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
            if (flag == 1 && flag1 == 1 && flag2 == 1 && this.name.Text != "")
            {
                
                //验证通过，数据插入数据库中
                String cmdText = "insert into employee(eid,password,ename) values(@num,@pwd,@name)";
                SqlParameter numsprm = new SqlParameter("@num", num.Text);
                SqlParameter pwdsprm = new SqlParameter("@pwd", pwd.Text);
                SqlParameter namesprm = new SqlParameter("@name", name.Text);
                SqlParameter[] sprms=new SqlParameter[] { numsprm,pwdsprm, namesprm};
                int count = DBhelper.Add(cmdText, sprms);            
                if (count > 0)
                {
                    MessageBox.Show(num.Text.Trim() + "注册成功！！");
                    Main m = new Main();
                    m.Show();
                }
                else
                {
                    MessageBox.Show("注册失败！");
                }
               
           
            
            }


        }

       
    }
}
