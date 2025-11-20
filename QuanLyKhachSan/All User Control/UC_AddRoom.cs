using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.All_User_Control
{
   
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddRoom()
        {
            InitializeComponent();
            this.DgvAddRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAddRoom_CellClick);

        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            //hien thi tat ca cac phong
            query = "select * from rooms";
            DataSet ds = fn.GetData(query);
            DgvAddRoom.DataSource = ds.Tables[0];
            DgvAddRoom.DefaultCellStyle.Font = new Font("Segoe UI", 10.5f, FontStyle.Regular);
            DgvAddRoom.DefaultCellStyle.Padding = new Padding(3);
            DgvAddRoom.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            DgvAddRoom.ColumnHeadersDefaultCellStyle.Padding = new Padding(3);
            DgvAddRoom.RowTemplate.Height = 28;
            DgvAddRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            if (DgvAddRoom.Columns.Count > 4) // Đảm bảo có đủ cột (ID, roomNo, roomType, bed, price, Status)
            {
                // Điều chỉnh độ rộng cột thủ công cho giao diện đẹp mắt
                DgvAddRoom.Columns[0].Width = 50;  // ID (Tự tăng)
                DgvAddRoom.Columns[1].Width = 80;  // Số phòng (roomNo)
                DgvAddRoom.Columns[2].Width = 180; // Loại phòng (roomType) - Cần rộng nhất
                DgvAddRoom.Columns[3].Width = 120; // Loại giường (bed)
                DgvAddRoom.Columns[4].Width = 100; // Giá tiền (price)

                // Cột cuối cùng (Status/Note) tự động điền phần còn lại để lấp đầy DataGridView
                DgvAddRoom.Columns[DgvAddRoom.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

    
       

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra đầu vào cơ bản (Đã bổ sung kiểm tra)
            if (string.IsNullOrEmpty(txtRoomNumber.Text) ||
                string.IsNullOrEmpty(txtTypeRoom.Text) ||
                string.IsNullOrEmpty(txtTypeBed.Text) ||
                string.IsNullOrEmpty(txtPrice.Text))
            {
                // Thông báo khi chưa nhập đầy đủ thông tin
                MessageBox.Show("Vui lòng điền đầy đủ tất cả thông tin !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng lại, không thực hiện thêm dữ liệu
            }

            // 2. Xử lý và chuyển đổi kiểu dữ liệu
            string roomNo = txtRoomNumber.Text;
            string type = txtTypeRoom.Text;
            string bed = txtTypeBed.Text;
            string rawPrice = txtPrice.Text.Replace("VND", "")
                                  .Replace(".", "")
                                  .Replace(",", "")
                                  .Trim();

            long priceValue;

            // Kiểm tra xem giá có phải là số hợp lệ không
            if (!long.TryParse(rawPrice, out priceValue)) // SỬ DỤNG rawPrice ĐÃ LÀM SẠCH
            {
                MessageBox.Show("Giá tiền phải là một số hợp lệ!", "Lỗi kiểu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Tạo SqlCommand với Parameters
            try
            {
                // Khai báo câu lệnh SQL với các tham số (@roomNo, @type, @bed, @price)
                string query = "INSERT INTO rooms (roomNo, roomType, bed, price) VALUES (@roomNo, @type, @bed, @price)";
                SqlCommand cmd = new SqlCommand(query);

                // Thêm các tham số và giá trị tương ứng
                cmd.Parameters.AddWithValue("@roomNo", roomNo);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@bed", bed);
                cmd.Parameters.AddWithValue("@price", priceValue);

                // 4. Gọi hàm setData đã được sửa đổi
                fn.setData(cmd, "Đã thêm phòng thành công!");

                // 5. Cập nhật giao diện
                UC_AddRoom_Load(this, null);
                clearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình thực thi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearAll()
        {
            txtRoomNumber.Clear();
            txtTypeRoom.SelectedIndex = -1;
            txtTypeBed.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this,null);
        }

        private void btnDeleteRooms_Click(object sender, EventArgs e)
        {
            // 1. Lấy Room Number từ TextBox
            if (string.IsNullOrEmpty(txtRoomNumber.Text))
            {
                MessageBox.Show("Vui lòng nhập Số phòng cần xóa vào ô 'Số phòng'!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string roomNo = txtRoomNumber.Text;

            // 2. Xác nhận của người dùng
            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa phòng số {roomNo} không? Hành động này không thể hoàn tác.",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // 3. Tạo SqlCommand với Parameters cho lệnh DELETE
                    string query = "DELETE FROM rooms WHERE roomNo = @roomNo";
                    SqlCommand cmd = new SqlCommand(query);

                    // Thêm tham số
                    cmd.Parameters.AddWithValue("@roomNo", roomNo);

                    // 4. Gọi hàm setData để thực thi lệnh XÓA
                    fn.setData(cmd, $"Phòng số {roomNo} đã được xóa thành công!");

                    fn.ResetIdentity("rooms");

                    // 6. Cập nhật giao diện
                    UC_AddRoom_Load(this, null); // Load lại DataGridView
                    clearAll(); // Xóa các trường nhập liệu
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình xóa: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DgvAddRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào header cột hay không
            if (e.RowIndex < 0) return;

            // Lấy ra hàng hiện tại mà người dùng click vào
            DataGridViewRow selectedRow = DgvAddRoom.Rows[e.RowIndex];

            try
            {
                txtRoomNumber.Text = selectedRow.Cells[1].Value?.ToString();

         
                txtTypeRoom.Text = selectedRow.Cells[2].Value?.ToString();

            
                txtTypeBed.Text = selectedRow.Cells[3].Value?.ToString();

                txtPrice.Text = selectedRow.Cells[4].Value?.ToString();

            }
            catch (Exception ex)
            {
              
                MessageBox.Show("Lỗi khi đọc dữ liệu từ bảng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        
    }
}
