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
    public partial class frmQLTK : Form
    {
        int isAdmin = 0;
        SqlConnection conn;
        Connection cnn = new Connection();
        Modify mdf = new Modify();
        SqlCommand cmd;
        public frmQLTK()
        {
            InitializeComponent();
            loadView();
        }

        void resetValue()
        {
            txtTenDangNhap.Text = string.Empty;
            txtMK.Text = string.Empty;
            txtNhapLaiMK.Text = string.Empty;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
        }
        void loadView()
        {
            string query = "select * from ACCOUNT";
            dtgvTK.DataSource = mdf.GetData(query);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            resetValue();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() != "")
            {
                conn = cnn.GetConnection();
                conn.Open();
                if (cbAdmin.Checked)
                {
                    isAdmin = 1;
                }
                string query = "update ACCOUNT set Username = @username, Password = @password, type = @type where Username = @username";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", txtTenDangNhap.Text.Trim());
                cmd.Parameters.AddWithValue("@password", txtMK.Text.Trim());
                cmd.Parameters.AddWithValue("@type", isAdmin);
                cmd.ExecuteNonQuery();
                loadView();
                resetValue();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản muốn sửa!!!", "Thông báo");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() != "" && txtMK.Text.Trim() != "" && txtNhapLaiMK.Text.Trim() != "")
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
                else if (txtMK.Text.Trim() == txtNhapLaiMK.Text.Trim())
                {
                    reader.Close();
                    if (cbAdmin.Checked)
                    {
                        isAdmin = 1;
                    }
                    string queryAddNewUser = "insert into ACCOUNT(Username, Password, type) values(@username, @password, @type)";
                    cmd = new SqlCommand(queryAddNewUser, conn);
                    cmd.Parameters.AddWithValue("@username", txtTenDangNhap.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtMK.Text.Trim());
                    cmd.Parameters.AddWithValue("@type", isAdmin);
                    cmd.ExecuteNonQuery();
                    loadView();
                    resetValue();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin đã nhập", "Thông báo");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text != "")
            {
                conn = cnn.GetConnection();
                conn.Open();
                string query = "delete from ACCOUNT where Username = @username";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("username", txtTenDangNhap.Text);
                cmd.ExecuteNonQuery();
                loadView();
                resetValue();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản muốn xoá!!!", "Thông báo");
            }
        }

        private void dtgvTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvTK.CurrentRow.Cells["type"].Value.ToString() == "1")
            {
                cbAdmin.Checked = true;
            }
            else
            {
                cbAdmin.Checked = false;
            }
            txtTenDangNhap.Text = dtgvTK.CurrentRow.Cells["Username"].Value.ToString();
            txtMK.Text = dtgvTK.CurrentRow.Cells["Password"].Value.ToString();
        }
    }
}
