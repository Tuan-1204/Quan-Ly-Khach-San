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

        public void setData(SqlCommand cmd, string message)
        {
            SqlConnection conn = GetConnection();
            // SqlCommand cmd = new SqlCommand(query, conn); // BỎ DÒNG NÀY

            try
            {
                // Gán kết nối cho cmd đã nhận
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi chi tiết hơn
                MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
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


        public void ResetIdentity(string tableName)
        {
            SqlConnection conn = GetConnection();
            // Câu lệnh DBCC CHECKIDENT
            string query = $"DBCC CHECKIDENT ('{tableName}', RESEED, 0)";
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show($"ID tự động tăng của bảng {tableName} đã được reset!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reset ID: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }


}
