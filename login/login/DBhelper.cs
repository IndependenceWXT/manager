using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace login
{
    class DBhelper
    {
        //数据库连接操作
        public static SqlConnection GetConnection()
        {
            string dbPath = Application.StartupPath + "\\manager.mdf";
            string conStr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + dbPath + ";Integrated Security=True;Connect Timeout=30;User Instance=True";
            //string conStr = @"Data Source=.;AttachDbFilename=" + dbPath + ";Integrated Security=True";       
            SqlConnection con = new SqlConnection(conStr);
            return con;
        }
        //查询个数
        public static int GetCount(string cmdText)
        {
            SqlConnection con = DBhelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        //查询是否存在，单条件或多条件查询
        public static int GetCountPrm(string cmdText, SqlParameter[] sprms)
        {
            SqlConnection con = DBhelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddRange(sprms);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        //添加，删除，更新 操作
        public static int Add(string cmdText, SqlParameter[] sprms)
        {
            SqlConnection con = DBhelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddRange(sprms);
            int count = cmd.ExecuteNonQuery();
            return count;
        }
        //获取查询到的结果集
        public static SqlDataReader GetDR(string cmdText, SqlParameter[] prm)
        {
            SqlConnection con = DBhelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddRange(prm);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public static DataTable GetTable(string cmdText)
        {
            SqlConnection con = DBhelper.GetConnection();
            SqlCommand cmd = new SqlCommand(cmdText, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds,"st");
            DataTable dt = ds.Tables["st"];    
            return dt;
        }
        //获取inder页的数据集
        //index:页
        //maxRecords：每页显示的记录数
        //(index-1)*maxRecords:index页记录的起始索引
        //返回值第index页的结果集
        public static DataTable GetPartTable(string cmdText, int index, int maxRecords)
        {
            SqlConnection con = DBhelper.GetConnection(); 
            SqlCommand cmd = new SqlCommand(cmdText, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, (index - 1) * maxRecords, maxRecords, "st");
            DataTable dt = ds.Tables["st"];
            return dt;
        }
        //获取SqlDataAdapter对象
        public static SqlDataAdapter GetSDA(string cmdText)
        {
            SqlConnection con = DBhelper.GetConnection();
            SqlCommand cmd = new SqlCommand(cmdText, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            return sda;
        }


    }
}
