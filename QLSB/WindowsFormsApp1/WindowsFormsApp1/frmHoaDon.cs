using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class frmHoaDon : Form
    {
        SqlConnection conn;
        Connection cnn = new Connection();
        SqlCommand cmd;
        Modify mdf = new Modify();
        public frmHoaDon()
        {
            InitializeComponent();
            loadView();
            resetValue();
        }

        void loadView()
        {
            string queryMaThueSan = "select * from THUESAN";
            cboMaThueSan.DataSource = mdf.GetData(queryMaThueSan);
            cboMaThueSan.DisplayMember = "MaThueSan";
            string queryDichVu = "select * from DICHVU";
            cboDichVu.DataSource = mdf.GetData(queryDichVu);
            cboDichVu.DisplayMember = "TenDichVu";
            string queryNhanVien = "select * from NHANVIEN";
            cboMaNV.DataSource = mdf.GetData(queryNhanVien);
            cboMaNV.DisplayMember = "MaNV";
            string queryHD = "select * from HOADON";
            string queryChiTietHoaDon = "select * from CHITIETHOADON";
            dtgvChiTietHD.DataSource = mdf.GetData(queryChiTietHoaDon);

        }

        void resetValue()
        {
            cboMaNV.SelectedIndex = -1;
            cboMaThueSan.SelectedIndex = -1;
            cboDichVu.SelectedIndex = -1;
            txtMaHD.Enabled = false;
            txtMaDV.Text = string.Empty;
            nbudSoLuong.Value = 0;
            txtMaKH.Text = string.Empty;
            txtTenNV.Text = string.Empty;
            txtMaHD.Text = string.Empty;
            txtMaSan.Text = string.Empty;
            txtGiaDV.Text = string.Empty;
            txtMaLoaiSan.Text = string.Empty;
            txtThanhTien.Text = string.Empty;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            txtMaHD.ReadOnly = true;
        }

        private void cboMaThueSan_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            string dt = cbo.Text;
            if (dt != "System.Data.DataRowView")
            {
                string data = cboMaThueSan.Text;
                int thanhTien = 0;
                int maLoaiSan = 0;
                int maSan = 0;
                int maKH = 0;
                string queryUpdateData = "select * from THUESAN where MaThueSan = '" + data + "'";
                DataTable dtb = mdf.GetData(queryUpdateData);
                foreach (DataRow dr in dtb.Rows)
                {
                    thanhTien = (int)dr[7];
                    maLoaiSan = (int)dr[2];
                    maSan = (int)dr[3];
                    maKH = (int)dr[1];
                }
                int tongTien = 0;
                if (cboDichVu.SelectedIndex != -1 && cboDichVu.Text != "System.Data.DataRowView" && txtGiaDV.Text != "")
                {
                    tongTien = thanhTien + Convert.ToInt32(this.txtGiaDV.Text);
                }
                else
                {
                    tongTien = thanhTien;
                }
                if (maKH != 0)
                {
                    txtMaKH.Text = maKH.ToString();
                }
                txtGia.Text = thanhTien.ToString();
                txtMaLoaiSan.Text = maLoaiSan.ToString();
                txtMaSan.Text = maSan.ToString();
                txtThanhTien.Text = tongTien.ToString();
            }
        }

        private void nbudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            string updateData = "select * from DICHVU where TenDichVu = N'" + cboDichVu.Text + "'";
            DataTable dtb = mdf.GetData(updateData);
            int donGia = 0;
            foreach (DataRow dr in dtb.Rows)
            {
                donGia = (int)dr[2];
            }
            int thanhTien = donGia * (int)nbudSoLuong.Value;
            txtGiaDV.Text = thanhTien.ToString();
            int giaSan = 0;
            if (cboMaThueSan.SelectedIndex != -1)
            {
                giaSan = Convert.ToInt32(this.txtGia.Text);
            }
            int tongTien = thanhTien + giaSan;
            txtThanhTien.Text = tongTien.ToString();
        }

        private void cboMaNV_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.Text != "System.Data.DataRowView" && cb.SelectedIndex != -1)
            {
                string query = "select * from NHANVIEN where MaNV = '" + cb.Text + "'";
                DataTable dtb = mdf.GetData(query);
                string tenNV = "";
                foreach (DataRow dr in dtb.Rows)
                {
                    tenNV = dr[1].ToString();
                }
                txtTenNV.Text = tenNV;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheDo_Click(object sender, EventArgs e)
        {
            txtMaHD.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
            txtMaHD.ReadOnly = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            resetValue();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text != "" && cboMaNV.SelectedIndex != -1 && cboMaThueSan.SelectedIndex != -1 && cboDichVu.SelectedIndex != -1)
            {
                conn = cnn.GetConnection();
                conn.Open();
                string queryCheck = "select * from HOADON where MaHD = @maHD";
                cmd = new SqlCommand(queryCheck, conn);
                cmd.Parameters.AddWithValue("@maHD", txtMaHD.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    string queryCTHD = "insert into CHITIETHOADON(MaHD, MaThueSan, MaLoaiSan, MaSan, MaDichVu, NgayTao, ThanhTien, SoLuong, TenDichVu) " +
                    "values(@maHD, @maThueSan, @maLoaiSan, @maSan, @maDichVu, @ngayTao, @thanhTien, @soLuong, @tenDichVu)";
                    cmd = new SqlCommand(queryCTHD, conn);
                    cmd.Parameters.AddWithValue("@maHD", txtMaHD.Text);
                    cmd.Parameters.AddWithValue("@maThueSan", cboMaThueSan.Text);
                    cmd.Parameters.AddWithValue("@maLoaiSan", txtMaLoaiSan.Text);
                    cmd.Parameters.AddWithValue("@maSan", txtMaSan.Text);
                    cmd.Parameters.AddWithValue("@maDichVu", txtMaDV.Text);
                    cmd.Parameters.AddWithValue("@soLuong", nbudSoLuong.Value);
                    cmd.Parameters.AddWithValue("@ngayTao", dtpNgayTao.Value.ToString("yyyy-MM-dd hh:mm tt"));
                    cmd.Parameters.AddWithValue("@thanhTien", txtThanhTien.Text);
                    cmd.Parameters.AddWithValue("@tenDichVu", cboDichVu.Text);
                    cmd.ExecuteNonQuery();

                    string getTotal = "select sum(ThanhTien) as total from CHITIETHOADON where MaHD = @maHD";
                    cmd = new SqlCommand(getTotal, conn);
                    cmd.Parameters.AddWithValue("@maHD", txtMaHD.Text);

                    string getQuantity = "select count(*) as total from CHITIETHOADON where MaHD = @maHD";
                    cmd = new SqlCommand(getQuantity, conn);
                    cmd.Parameters.AddWithValue("@maHD", txtMaHD.Text);
                    int check = (int)cmd.ExecuteScalar();
                    if (check > 0)
                    {
                        int total = (int)cmd.ExecuteScalar();
                        string updateHD = "update HOADON set ThanhTien = @thanhTien where MaHD = @maHD";
                        cmd = new SqlCommand(updateHD, conn);
                        cmd.Parameters.AddWithValue("@maHD", txtMaHD.Text);
                        cmd.Parameters.AddWithValue("@thanhTien", total);
                        cmd.ExecuteNonQuery();
                    }

                }
                else
                {
                    reader.Close();
                    string queryHD = "insert into HOADON(MaHD, MaKH, MaNV, ThanhTien) values(@maHD, @maKH, @maNV, @thanhTien)";
                    cmd = new SqlCommand(queryHD, conn);
                    cmd.Parameters.AddWithValue("@maHD", txtMaHD.Text);
                    cmd.Parameters.AddWithValue("@maKH", txtMaKH.Text);
                    cmd.Parameters.AddWithValue("@maNV", cboMaNV.Text);
                    cmd.Parameters.AddWithValue("@thanhTien", txtThanhTien.Text);
                    cmd.ExecuteNonQuery();
                    string queryCTHD = "insert into CHITIETHOADON(MaHD, MaThueSan, MaLoaiSan, MaSan, MaDichVu, NgayTao, ThanhTien, SoLuong, TenDichVu) " +
                        "values(@maHD, @maThueSan, @maLoaiSan, @maSan, @maDichVu, @ngayTao, @thanhTien, @soLuong, @tenDichVu)";
                    cmd = new SqlCommand(queryCTHD, conn);
                    cmd.Parameters.AddWithValue("@maHD", txtMaHD.Text);
                    cmd.Parameters.AddWithValue("@maThueSan", cboMaThueSan.Text);
                    cmd.Parameters.AddWithValue("@maLoaiSan", txtMaLoaiSan.Text);
                    cmd.Parameters.AddWithValue("@maSan", txtMaSan.Text);
                    cmd.Parameters.AddWithValue("@maDichVu", txtMaDV.Text);
                    cmd.Parameters.AddWithValue("@soLuong", nbudSoLuong.Value);
                    cmd.Parameters.AddWithValue("@ngayTao", dtpNgayTao.Value.ToString("yyyy-MM-dd hh:mm tt"));
                    cmd.Parameters.AddWithValue("@thanhTien", txtThanhTien.Text);
                    cmd.Parameters.AddWithValue("@tenDichVu", cboDichVu.Text);
                    cmd.ExecuteNonQuery();
                }
                loadView();
                resetValue();
                conn.Close();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin hoá đơn!!!", "Thông báo");
            }

        }

        private void cboDichVu_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.Text != "System.Data.DataRowView" && cb.SelectedIndex != -1)
            {
                string query = "select * from DICHVU where TenDichVu = N'" + cb.Text + "'";
                DataTable dtb = mdf.GetData(query);
                int maDV = 0;
                foreach (DataRow dr in dtb.Rows)
                {
                    maDV = (int)dr[0];
                }
                txtMaDV.Text = maDV.ToString();
            }
        }

        private void dtgvChiTietHD_Click(object sender, EventArgs e)
        {
            int soLuong = 0;
            cboMaThueSan.Text = dtgvChiTietHD.CurrentRow.Cells["MaThueSan"].Value.ToString();
            txtMaHD.Text = dtgvChiTietHD.CurrentRow.Cells["MaHD"].Value.ToString();
            txtMaLoaiSan.Text = dtgvChiTietHD.CurrentRow.Cells["MaLoaiSan"].Value.ToString();
            txtMaSan.Text = dtgvChiTietHD.CurrentRow.Cells["MaSan"].Value.ToString();
            txtMaDV.Text = dtgvChiTietHD.CurrentRow.Cells["MaDichVu"].Value.ToString();
            txtThanhTien.Text = dtgvChiTietHD.CurrentRow.Cells["ThanhTien"].Value.ToString();
            dtpNgayTao.Text = dtgvChiTietHD.CurrentRow.Cells["NgayTao"].Value.ToString();
            if (dtgvChiTietHD.CurrentRow.Cells["SoLuong"].Value.ToString() != "")
            {
                soLuong = (int)dtgvChiTietHD.CurrentRow.Cells["SoLuong"].Value;
            }
            nbudSoLuong.Value = soLuong;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text != "")
            {
                conn = cnn.GetConnection();
                conn.Open();
                string getQuantity = "select count(*) as total from CHITIETHOADON where MaHD = @maHD";
                cmd = new SqlCommand(getQuantity, conn);
                cmd.Parameters.AddWithValue("@maHD", txtMaHD.Text);
                int check = (int)cmd.ExecuteScalar();
                if (check > 1)
                {
                    string query = "delete from CHITIETHOADON where MaHD = @maHD and MaDichVu = @maDV";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maHD", txtMaHD.Text);
                    cmd.Parameters.AddWithValue("@maDV", txtMaDV.Text);
                    cmd.ExecuteNonQuery();

                    string getTotal = "select sum(ThanhTien) as total from CHITIETHOADON where MaHD = @maHD";
                    cmd = new SqlCommand(getTotal, conn);
                    cmd.Parameters.AddWithValue("@maHD", txtMaHD.Text);

                    int total = (int)cmd.ExecuteScalar();
                    string updateHD = "update HOADON set ThanhTien = @thanhTien where MaHD = @maHD";
                    cmd = new SqlCommand(updateHD, conn);
                    cmd.Parameters.AddWithValue("@maHD", txtMaHD.Text);
                    cmd.Parameters.AddWithValue("@thanhTien", total);
                    cmd.ExecuteNonQuery();
                    loadView();
                    resetValue();

                }
                else
                {
                    string query = "delete from CHITIETHOADON where MaHD = @maHD and MaDichVu = @maDV";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maHD", txtMaHD.Text);
                    cmd.Parameters.AddWithValue("@maDV", txtMaDV.Text);
                    cmd.ExecuteNonQuery();

                    string queryHD = "delete from HOADON where MaHD = @maHD";
                    cmd = new SqlCommand(queryHD, conn);
                    cmd.Parameters.AddWithValue("@maHD", txtMaHD.Text);
                    cmd.ExecuteNonQuery();
                    loadView();
                    resetValue();
                }


            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã hoá đơn muốn xoá!!!", "Thông báo");
            }
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image img = Resources.san;
            e.Graphics.DrawImage(img, 0, 0, img.Width, img.Height);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
