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
    public partial class myInformation : Form
    {
        [DllImport("user32.dll")]//*********************拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public myInformation()
        {
            InitializeComponent();
        }
        string strText = "";
        public myInformation(String str)
        {
            strText = str;
            InitializeComponent();
        }
        String strImage = null;//记录选择的图片
        byte[] imgname = new byte[1024];//记录之前的图片



        //该员工的id
        int id;


        //获取数据库中所有部门的名字
        void setDept()
        {
            String cmdText = "select dname from dept";
            SqlParameter[] sprm = new SqlParameter[] { };
            SqlDataReader dr = DBhelper.GetDR(cmdText,sprm);
            while (dr.Read())
            {
                dept.Items.Add(dr["dname"].ToString());
            }
            dr.Close();
        }
        //根据部门名称获取部门id
        public int getDeptId(String name)
        {
            String cmdText = "select id from dept where dname=@n";
            SqlParameter namesprm = new SqlParameter("@n", name);
            SqlParameter[] sprm = new SqlParameter[] { namesprm };
            SqlDataReader dr = DBhelper.GetDR(cmdText, sprm);
            if (!dr.HasRows)
            {
                MessageBox.Show("没有找到该数据！");
            }
            dr.Read();
            return (int)dr["id"];
        }
        //根据部门id获取部门名称
        public String getDeptName(int id)
        {
            String cmdText = "select dname from dept where id=@d";
            SqlParameter idsprm = new SqlParameter("@d", id);
            SqlParameter[] sprm = new SqlParameter[] { idsprm };
            SqlDataReader dr = DBhelper.GetDR(cmdText, sprm);
            if (!dr.HasRows)
            {
                MessageBox.Show("没有找到该数据！");
            }
            dr.Read();
            return dr["dname"].ToString();
        }


        private void myInformation_Load(object sender, EventArgs e)
        {
            setDept();
            //把信息，填入对应的textbox中
            int deptid;
            String cmdText = "select * from employee where eid=@enum";
            SqlParameter numsprm = new SqlParameter("@enum", strText);
            SqlParameter[] sprm = new SqlParameter[] { numsprm };
            SqlDataReader r = DBhelper.GetDR(cmdText, sprm);
            if (!r.HasRows)
            {
                MessageBox.Show("没有找到该数据！");
            }
            else
            {
                r.Read();
                id =(int)r["id"];
                deptid = (int)r["did"];
                num.Text = r["eid"].ToString();
                name.Text = r["ename"].ToString();
                age.Text = r["eage"].ToString();
                tel.Text = r["etel"].ToString();
                createdate.Text = r["ecreatedate"].ToString();
                if (r["img"].ToString().Equals("") || r["img"]==null)
                {
                    img.Image = null;
                  
                }
                else {
                    MemoryStream MStream = new MemoryStream((byte[])r["img"]);
                    imgname = (byte[])r["img"];
                    img.Image = Image.FromStream(MStream);
                }
                //根据did在dept表中找到部门名称
                dept.Text = getDeptName(deptid);   
                
            }
            r.Close();
        }
       private void lookbtn_Click(object sender, EventArgs e)
       {
           openFileDialog1.Filter = "图像文件|*.jpg";
           if (openFileDialog1.ShowDialog() == DialogResult.OK)
           {
               img.Image = Image.FromFile(openFileDialog1.FileName);
               strImage = openFileDialog1.FileName;
           }
       }
        private void alterbtn_Click(object sender, EventArgs e)
        {
            //点击按钮编辑信息
            if(this.alterbtn.Text == "编辑资料"){
                num.ReadOnly = false;
                name.ReadOnly = false;
                age.Enabled=true;
                tel.ReadOnly = false;
                createdate.Enabled = true;
                dept.Enabled = true;
                lookbtn.Enabled = true;
                this.alterbtn.Text = "保存资料";
            }
            //点击按钮保存信息
            else if (this.alterbtn.Text == "保存资料")
            {
                num.ReadOnly = true;
                name.ReadOnly = true;
                age.Enabled = false;
                tel.ReadOnly = false;
                createdate.Enabled = false;
                dept.Enabled = false;
                lookbtn.Enabled = false;
                MessageBox.Show("save");
                this.alterbtn.Text = "编辑资料";
                //查询修改后的部门id
                int deid=getDeptId(dept.Text.Trim());
                //要保证员工号的唯一性，
                //两种情况，第一种员工号未修改的情况，保证查找id是对应原来的id
                //第二种员工号修改了，保证查找的id是不存在
                String cmdText = "select id from employee where eid=@num";
                SqlParameter numsprm = new SqlParameter("@num", num.Text.Trim());
                SqlParameter[] sprms = new SqlParameter[] { numsprm };
                SqlDataReader dr = DBhelper.GetDR(cmdText, sprms);
                dr.Read();
                if (!dr.HasRows ||(int)dr["id"] == id)
                {
                    this.numtext.ForeColor = Color.Green;
                    this.numtext.Text = "OK";
                    //进行更新操作
                        MessageBox.Show("更新中。。。。");
                            byte[] byteImage;
                            if (strImage == null)
                                byteImage = imgname;
                            else
                            {
                                FileStream FStream = new FileStream(strImage, FileMode.Open, FileAccess.Read);
                                BinaryReader BReader = new BinaryReader(FStream);
                                byteImage = BReader.ReadBytes((int)FStream.Length);
                            }
                            String cmdText1 = "update employee set eid=@eid,ename=@name,eage=@age,etel=@tel,ecreatedate=@cd,did=@did,img=@img where id=@id";
                            SqlParameter imgsprm = new SqlParameter("@img", byteImage);
                            SqlParameter eidsprm = new SqlParameter("@eid", num.Text.Trim());
                            SqlParameter nasprm = new SqlParameter("@name", name.Text.Trim());
                            SqlParameter agesprm = new SqlParameter("@age", age.Text.Trim());
                            SqlParameter telsprm = new SqlParameter("@tel", tel.Text.Trim());
                            SqlParameter cdsprm = new SqlParameter("@cd", createdate.Value);
                            SqlParameter idsprm = new SqlParameter("@id", id);
                            SqlParameter didsprm = new SqlParameter("@did", deid);
                            SqlParameter[] sprms1 = new SqlParameter[] { eidsprm, nasprm, agesprm, telsprm, cdsprm,didsprm, imgsprm, idsprm };
                            int count = DBhelper.Add(cmdText1, sprms1);
                            if (count > 0)
                            {
                                MessageBox.Show("更新成功！");
                            }
                            else
                            {
                                MessageBox.Show("更新失败！");
                            }
                   
                     }
                    else
                    {
                        this.numtext.ForeColor = Color.Red;
                        this.numtext.Text = "已存在";
                        MessageBox.Show("该工号属于他人，请检查是否填错");
                    }
                    dr.Close();
               

            }
            else {}
          
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

        private void myinfo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//调用移动无边框窗体控件函数

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

       

       

       
      


    }
}
