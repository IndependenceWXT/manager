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
    public partial class empalter : Form
    {
        [DllImport("user32.dll")]//*********************拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public empalter()
        {
            InitializeComponent();
          
        }
        String lastName;
        //设置所有员工姓名
        void setPersonName()
        {
            String cmdText = "select ename from employee";
            SqlParameter[] sprm = new SqlParameter[] { };
            SqlDataReader dr = DBhelper.GetDR(cmdText, sprm);
            while (dr.Read())
            {
                lastName = dr["ename"].ToString();
                comboBox1.Items.Add(dr["ename"].ToString());
            }
            dr.Close();
        }
        void setFirstName()
        {
            String cmdText = "select ename from employee";
            SqlParameter[] sprm = new SqlParameter[] { };
            SqlDataReader dr = DBhelper.GetDR(cmdText, sprm);
            if(dr.Read())
            lastName = dr["ename"].ToString();
            dr.Close();
        }
        //设置部门名称
        void setDeptName()
        {
            String cmdText = "select dname from dept";
            SqlParameter[] sprm = new SqlParameter[] { };
            SqlDataReader dr = DBhelper.GetDR(cmdText, sprm);
            while (dr.Read())
            {
                dept.Items.Add(dr["dname"].ToString());
            }
            dr.Close();
        }

        //根据员工姓名获取员工ID
        public int getEmpId(String name)
        {
            String cmdText = "select id from employee where ename=@n";
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
            SqlParameter idsprm = new SqlParameter("@d",id);
            SqlParameter[] sprm = new SqlParameter[] { idsprm };
            SqlDataReader dr = DBhelper.GetDR(cmdText, sprm);
            if (!dr.HasRows)
            {
                MessageBox.Show("没有找到该数据");
            }
            dr.Read();
            return dr["dname"].ToString();
        }

        private void empalter_Load(object sender, EventArgs e)
        {
            setFirstName();
            setPersonName();
            setDeptName();
            comboBox1.Text = lastName;
            String cmdText = "select * from employee where ename=@ename";
            SqlParameter enamesprm = new SqlParameter("@ename", lastName);
            SqlParameter[] sprm = new SqlParameter[] { enamesprm };
            SqlDataReader r = DBhelper.GetDR(cmdText, sprm);
            if (!r.HasRows)
            {
                MessageBox.Show("没有找到该数据！");
            }
            else
            {
                r.Read();
                num.Text = r["eid"].ToString();
                name.Text = r["ename"].ToString();
                age.Text = r["eage"].ToString();
                tel.Text = r["etel"].ToString();
                date.Text = r["ecreatedate"].ToString();
                //根据did在dept表中找到部门名称
                if (r["did"]==null || r["did"].ToString().Equals(""))
                {
                    dept.Text = "";
                }else{
                    MessageBox.Show("dept"+getDeptName((int)r["did"]));
                    String deptname = getDeptName((int)r["did"]);
                     dept.Text = deptname;
                }
               

            }
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cmdText = "select * from employee where ename=@ename";
            SqlParameter enamesprm = new SqlParameter("@ename", comboBox1.Text);
            SqlParameter[] sprm = new SqlParameter[] { enamesprm };
            SqlDataReader r = DBhelper.GetDR(cmdText, sprm);
            if (!r.HasRows)
            {
                MessageBox.Show("没有找到该数据！");
            }
            else
            {
                r.Read();
                num.Text = r["eid"].ToString();
                name.Text = r["ename"].ToString();
                age.Text = r["eage"].ToString();
                tel.Text = r["etel"].ToString();
                date.Text = r["ecreatedate"].ToString();
                //根据did在dept表中找到部门名称 
                if (r["did"]==null || r["did"].ToString().Equals(""))
                {
                    dept.Text = "";
                }
                else
                {
                    dept.Text = getDeptName((int)r["did"]);
                }
            }
          
            
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int id = getEmpId(comboBox1.Text);
            String cmdText = "select id from employee where eid=@num";
            SqlParameter numsprm = new SqlParameter("@num", num.Text.Trim());
            SqlParameter[] sprms = new SqlParameter[] { numsprm };
            SqlDataReader dr = DBhelper.GetDR(cmdText, sprms);
            dr.Read();
            if (!dr.HasRows || (int)dr["id"] == id)
            {
                    //进行更新数据库操作操作
                    String cmdText1 = "update employee set eid=@eid,ename=@name,eage=@age,etel=@tel,ecreatedate=@cd,did=@did where id=@id";
                    SqlParameter eidsprm = new SqlParameter("@eid", num.Text.Trim());
                    SqlParameter nasprm = new SqlParameter("@name", name.Text.Trim());
                    SqlParameter agesprm = new SqlParameter("@age", age.Text.Trim());
                    SqlParameter telsprm = new SqlParameter("@tel", tel.Text.Trim());
                    SqlParameter cdsprm = new SqlParameter("@cd", date.Value);
                    SqlParameter idsprm = new SqlParameter("@id", id);
                    //根据输入的部门名获取部门id
                    MessageBox.Show(getDeptId(dept.Text).ToString());
                    int did = getDeptId(dept.Text);
                
                    SqlParameter didsprm = new SqlParameter("@did", did);
                    SqlParameter[] sprms1 = new SqlParameter[] { eidsprm, nasprm, agesprm, telsprm, cdsprm, didsprm, idsprm };
                    int count = DBhelper.Add(cmdText1, sprms1);
                    if (count > 0)
                    {
                        MessageBox.Show("更新成功！");
                        //更新之前要clear一下，否则重复
                        comboBox1.Items.Clear();
                        //更新comboBox列表
                        setPersonName();
                      
                    }
                    else
                    {
                        MessageBox.Show("更新失败！");
                    }
                //更新修改后的员工名字
                    comboBox1.Text = name.Text;  

            }
            else
            {
                MessageBox.Show("该员工工号已经存在"+"\n"+"请再次填写");
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
        private void empalter_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//调用移动无边框窗体控件函数

        }

    }
}
