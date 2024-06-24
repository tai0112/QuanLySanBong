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

namespace WindowsFormsApp1
{
    public partial class frmTaoTK : Form
    {
        SqlConnection conn;
        Modify mdf = new Modify();
        Connection cnn = new Connection();
        SqlCommand cmd;
        public frmTaoTK()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void resetValue()
        {
            txtTenDangNhap.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            txtNhapLaiMK.Text = string.Empty;
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() != "" && txtPassword.Text.Trim() != "" && txtRepeatPassword.Text.Trim() != "")
            {
                conn = cnn.GetConnection();
                conn.Open();
                string query = "select * from ACCOUNT where Username = @username";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", txtTenDangNhap.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Vui lòng chọn tên đăng nhập khác!!!", "Thông báo");
                }
                else if (txtPassword.TextLength <= 6)
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu trên 6 kí tự", "Thông báo");
                }
                else if (txtPassword.Text.Trim() == txtRepeatPassword.Text.Trim())
                {
                    reader.Close();
                    string queryAddNewUser = "insert into ACCOUNT(Username,Password) values(@username, @password)";
                    cmd = new SqlCommand(queryAddNewUser, conn);
                    cmd.Parameters.AddWithValue("@username", txtTenDangNhap.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtMatKhau.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo tài khoản thành công!!!", "Thông báo");
                    this.Close();
                    resetValue();
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin đã nhập", "Thông báo");
                }
            }
        }
    }
}
