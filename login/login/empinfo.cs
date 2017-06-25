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
    public partial class empinfo : Form
    {
        [DllImport("user32.dll")]//*********************拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public empinfo()
        {
            InitializeComponent();
        }
        int id;//自动设置id
        DataTable dt;
        SqlDataAdapter sda;
        //获取最后一项的员工id
        public void getLastId()
        {
            String cmdText = "select id from employee";
            SqlParameter[] sprm = new SqlParameter[] {};
            SqlDataReader dr = DBhelper.GetDR(cmdText, sprm);
            if (!dr.HasRows)
            {
                MessageBox.Show("没有找到该数据！");
            }
            while(dr.Read()){
                id = (int)dr["id"];
            }
        }
        private void empinfo_Load(object sender, EventArgs e)
        {
            getLastId();
            sda = DBhelper.GetSDA("select id as 员工ID,eid as 员工工号, ename as 员工姓名,eage as 年龄,etel as 联系方式,ecreatedate as 入职日期  from employee");
            SqlCommandBuilder acb = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds, "st");
            dt = ds.Tables["st"];
            dataGridView1.DataSource = dt;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            //是否选中一行数据
            if (this.dataGridView1.CurrentRow.Selected)
            {
                DialogResult dr = MessageBox.Show("确定要删除么？", "友好提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.Yes)
                {
                    this.dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    sda.Update(dt);
                    MessageBox.Show("删除成功！");
                }
            }
            else
            {
                MessageBox.Show("请先选中一行数据，然后在进行删除！");
                return;
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //判断该员工号是否已经存在
            String cmdText = "select * from employee where eid=@num";
            SqlParameter numsprm = new SqlParameter("@num", num.Text.Trim());
            SqlParameter[] sprms = new SqlParameter[] { numsprm };
            SqlDataReader dr = DBhelper.GetDR(cmdText, sprms);
            if (!dr.HasRows)
            {    
                //进行添加操作
                DataRow newrow = dt.NewRow();
                id = id + 1;
                //把最后一项的id+1作为该员工的员工id
                newrow["员工ID"] = id;
                newrow["员工工号"] = num.Text.Trim();
                newrow["员工姓名"] = name.Text.Trim();
                newrow["年龄"] = age.Text.Trim();
                newrow["联系方式"] = tel.Text.Trim();
                newrow["入职日期"] = date.Text.Trim();
                dt.Rows.Add(newrow);
                sda.Update(dt);
                MessageBox.Show("添加成功！！");  

            }
            else
            {
                MessageBox.Show("工号是员工的唯一标识，该员工已经存在！"+"\n"+"请重新填写员工信息！！");
            }
            dr.Close();
           
            
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

        private void empinfo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//调用移动无边框窗体控件函数
  
        }
    }
}
