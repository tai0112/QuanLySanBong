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
    public partial class frmKhachHang : Form
    {
        Modify mdf = new Modify();
        SqlConnection conn;
        Connection cnn = new Connection();
        SqlCommand cmd;
        public frmKhachHang()
        {
            InitializeComponent();
            loadView();
        }

        void loadView()
        {
            string getKhachHang = "select * from KhachHang";
            dtgvKhachHang.DataSource = mdf.GetData(getKhachHang);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadView();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string data = txtTimKiem.Text.Trim();
            if(data != "")
            {
                string query = "select * from KHACHHANG where MaKH like N'%" + data + "%' or TenKH like N'%" + data + "%' or DiaChi like N'%" + data + "%' or DienThoaiKH like N'%" + data + "%'";
                dtgvKhachHang.DataSource = mdf.GetData(query);
            }else
            {
                loadView();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void resetData()
        {
            txtId.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            txtId.ReadOnly = true;
            btnSua.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            txtId.Enabled = true;
            txtId.ReadOnly = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                SqlConnection conn = cnn.GetConnection();
                conn.Open();
                string query = "delete from KHACHHANG where MaKH = @id";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.ExecuteNonQuery();
                loadView();
                resetData();
                conn.Close();
            }else
            {
                MessageBox.Show("Xin mời nhập mã khách hàng muốn xoá!!", "Thông báo");
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtHoTen.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "")
            {
                SqlConnection conn = cnn.GetConnection();
                conn.Open();
                string query = "insert into KHACHHANG(TenKH, DiaChi, DienThoaiKH) values(@tenKH, @diaChi, @DienThoaiKH)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tenKH", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@diaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@DienThoaiKH", txtSDT.Text);
                cmd.ExecuteNonQuery();
                loadView();
                resetData();
                conn.Close();
            }else
            {
                MessageBox.Show("Xin mời nhập đủ thông tin khách hàng!!", "Thông báo");
            }
        }

        private void dtgvKhachHang_Click(object sender, EventArgs e)
        {
            txtId.Text = dtgvKhachHang.CurrentRow.Cells["MaKH"].Value.ToString();
            txtHoTen.Text = dtgvKhachHang.CurrentRow.Cells["TenKH"].Value.ToString();
            txtDiaChi.Text = dtgvKhachHang.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtSDT.Text = dtgvKhachHang.CurrentRow.Cells["DienThoaiKH"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                conn = cnn.GetConnection();
                conn.Open();
                string query = "update KHACHHANG set TenKH = @tenKH, DiaChi = @diaChi, DienThoaiKH = @dienThoaiKH where MaKH = @maKH";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tenKH", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@diaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@dienThoaiKH", txtSDT.Text);
                cmd.Parameters.AddWithValue("@maKH", txtId.Text);
                cmd.ExecuteNonQuery();
                loadView();
                resetData();
                conn.Close();
            }else
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng muốn sửa!!!", "Thông báo");
            }
        }
    }
}
