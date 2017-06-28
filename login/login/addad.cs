using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace login
{
    public partial class addad : Form
    {

        public addad()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {

            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            String strYMD = currentTime.ToLongDateString();
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

        private void addad_Load(object sender, EventArgs e)
        {

        }




    }
}
