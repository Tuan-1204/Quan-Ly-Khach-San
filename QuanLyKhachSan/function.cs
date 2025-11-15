using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace QuanLyKhachSan
{
    class function
    {
        protected SqlConnection GetConnection()
        {
            // 1. Khai báo chuỗi kết nối
            SqlConnection conn = new SqlConnection
            {
                ConnectionString =
                   "Data Source=DESKTOP-OQUQHKQ\\SQLEXPRESS;" +
                   "Initial Catalog=dbMyHotel;" +
                   "Integrated Security=True"
            };
            return conn;
        }

        public DataSet GetData(String query) {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            SqlDataAdapter  da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query, String message) {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= conn;
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public SqlDataReader getForCombo(String query)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= conn;
            conn.Open();
            cmd = new SqlCommand(query, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
    }
}
