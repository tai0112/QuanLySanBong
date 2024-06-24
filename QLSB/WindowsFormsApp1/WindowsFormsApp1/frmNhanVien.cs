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
    public partial class frmNhanVien : Form
    {
        SqlConnection conn;
        Connection cnn = new Connection();
        SqlCommand cmd;
        Modify mdf = new Modify();
        public frmNhanVien()
        {
            InitializeComponent();
            loadView();
            resetValue();
        }

        void loadView()
        {
            string queryNhanVien = "select * from NHANVIEN";
            dtgvNhanVien.DataSource = mdf.GetData(queryNhanVien);
        }

        void resetValue()
        {
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtId.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtTenNhanVien.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtLuongCoBan.Text = string.Empty;
            txtId.ReadOnly = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "" && txtTenNhanVien.Text != "" && txtSDT.Text != "" && txtLuongCoBan.Text != "" && txtDiaChi.Text != "") 
            {
                conn = cnn.GetConnection();
                conn.Open();
                string queryBangLuong = "insert into BANGLUONG(MaNV, LuongCoBan) values(@maNV, @luongCB)";
                cmd = new SqlCommand(queryBangLuong, conn);
                cmd.Parameters.AddWithValue("@maNV", txtId.Text);
                cmd.Parameters.AddWithValue("@luongCB", txtLuongCoBan.Text);
                cmd.ExecuteNonQuery();
                string queryNhanVien = "insert into NHANVIEN(MaNV, HoTenNV, DiaChiNV, SDT) values(@maNV, @hotenNV, @diaChiNV, @SDT)";
                cmd = new SqlCommand(queryNhanVien, conn);
                cmd.Parameters.AddWithValue("@maNV", txtId.Text);
                cmd.Parameters.AddWithValue("@hotenNV", txtTenNhanVien.Text);
                cmd.Parameters.AddWithValue("@diaChiNV", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                cmd.ExecuteNonQuery();
                loadView();
                resetValue();
                conn.Close();
            }else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên muốn thêm!!", "Thông báo");
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            resetValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                conn = cnn.GetConnection();
                conn.Open();
                string queryNhanVien = "delete from NHANVIEN where MaNV = @maNV";
                cmd = new SqlCommand(queryNhanVien, conn);
                cmd.Parameters.AddWithValue("@maNV", txtId.Text);
                cmd.ExecuteNonQuery();
                string queryBangLuong = "delete from BANGLUONG where MaNV = @maNV";
                cmd = new SqlCommand(queryBangLuong, conn);
                cmd.Parameters.AddWithValue("@maNV", txtId.Text);
                cmd.ExecuteNonQuery();
                loadView();
                resetValue();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên muốn xoá", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                conn = cnn.GetConnection();
                conn.Open();
                string query = "update NHANVIEN set HoTenNV = @hoTenNV, DiaChiNV = @diaChiNV, SDT = @sdt where MaNV = @maNV";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@hoTenNV", txtTenNhanVien.Text);
                cmd.Parameters.AddWithValue("@DiaChiNV", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                cmd.Parameters.AddWithValue("@maNV", txtId.Text);
                cmd.ExecuteNonQuery();
                loadView();
                resetValue();
            }else
            {
                MessageBox.Show("Vui lòng nhập thông tin nhân viên muốn xoá!!!", "Thông báo");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtId.ReadOnly = false;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from NHANVIEN where MaNV like '" + txtTimKiem.Text.Trim() + "' or HoTenNV like N'%" + txtTimKiem.Text.Trim() + "%' or DiaChiNV like N'%" + txtTimKiem.Text.Trim() + "%' or SDT like N'%" + txtTimKiem.Text.Trim() + "%'";
            dtgvNhanVien.DataSource = mdf.GetData(query);
        }

        private void txtLuongCoBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dtgvNhanVien_Click(object sender, EventArgs e)
        {
            txtId.Text = dtgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            txtTenNhanVien.Text = dtgvNhanVien.CurrentRow.Cells["HoTenNV"].Value.ToString();
            txtSDT.Text = dtgvNhanVien.CurrentRow.Cells["SDT"].Value.ToString();
            txtDiaChi.Text = dtgvNhanVien.CurrentRow.Cells["DiaChiNV"].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
