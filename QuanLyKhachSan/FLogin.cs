using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            this.AcceptButton = this.BtnLogin;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
//check và hiển thị hộp thoại xác nhận thoát
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //quên mật khẩu
        private void lblResetpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        //hiển thị mật khẩu
        private void chekPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chekPass.Checked)
            {
                txbPassword.PasswordChar = '\0'; // Hiển thị mật khẩu
            }
            else
            {
                txbPassword.PasswordChar = '*'; // Ẩn mật khẩu
            }
        }
        //mật khẩu dạng *
        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            //ẩn lỗi khi người dùng nhập lại 
            lblError.Visible = false;
        }
        //check username 
        private void txbUsername_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
        // khi ấn thì chuyển vào dashboard hệ thống
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(txbUsername.Text == "admin" && txbPassword.Text == "admin")
            {
                lblError.Visible = false;
                FDashBoard ds = new FDashBoard();
                this.Hide();
                ds.Show();
           
            }
            else
            {
                lblError.Visible = true;
                txbPassword.Clear();
            }
        }
        //hiển thị lỗi khi username và password không đúng
        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }
}
