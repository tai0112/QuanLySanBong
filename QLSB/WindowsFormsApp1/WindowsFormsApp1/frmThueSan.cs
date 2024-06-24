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
    public partial class dtgvThueSan : Form
    {
        static int witdh = 100;
        static int height = 100;
        Connection cnn = new Connection();
        SqlConnection conn;
        SqlCommand cmd;
        Modify mdf = new Modify();
        public dtgvThueSan()
        {
            InitializeComponent();
            loadSan();
            loadView();
            dtpThoiGianThue.ShowUpDown = true;
            dtpThoiGianTra.ShowUpDown = true;
            resetValue();
        }

        void loadView()
        {
            string queryKH = "select * from KHACHHANG";
            cboMaKH.DataSource = mdf.GetData(queryKH);
            cboMaKH.DisplayMember = "MaKH";
            string queryMaLoaiSan = "select * from LOAISAN";
            cboMaLoaiSan.DataSource = mdf.GetData(queryMaLoaiSan);
            cboMaLoaiSan.DisplayMember = "MaLoaiSan";
            string queryThueSan = "select * from THUESAN";
            dtgvSanThue.DataSource = mdf.GetData(queryThueSan);
        }

        void resetValue()
        {
            cboTenSan.SelectedIndex = -1;
            cboMaKH.SelectedIndex = -1;
            cboMaLoaiSan.SelectedIndex = -1;
            cboMaSan.SelectedIndex = -1;
            cboMaSan.Text = "";
            txtThanhTien.Text = "";
            txtId.Text = "";
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            txtId.ReadOnly = true;
            btnSua.Enabled = false;
        }
        void loadSan()
        {
            conn = cnn.GetConnection();
            conn.Open();
            string query = "select * from SAN";
            cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string maLoaiSan = reader["MaLoaiSan"].ToString();
                string tenLoaiSan = reader["TenSan"].ToString();
                string maSan = reader["MaSan"].ToString();
                Button btn = new Button();
                btn.Text = tenLoaiSan;
                btn.Tag = maLoaiSan;
                btn.Click += Btn_Click;
                btn.Width = witdh;
                btn.Height = height;
                btn.BackgroundImage = WindowsFormsApp1.Properties.Resources.san;
                btn.Font = new System.Drawing.Font("Times New Roman", 14, FontStyle.Bold);
                btn.ForeColor = Color.White;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                flpSan.Controls.Add(btn);
            }
            reader.Close();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string query = "select * from SAN where TenSan = '" + btn.Text.ToString() + "'";
            DataTable dtb = mdf.GetData(query);
            string maSan = "";
            foreach (DataRow row in dtb.Rows)
            {
                maSan = row[0].ToString();
            }
            cboTenSan.Text = btn.Text;
            cboMaLoaiSan.Text = btn.Tag.ToString();
            cboMaSan.Text = maSan;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMaLoaiSan_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            string dt = cbo.Text;
            if (dt != "System.Data.DataRowView")
            {
                string queryMaSan = "select * from SAN where MaLoaiSan = '" + cbo.Text + "'";
                cboMaSan.DataSource = mdf.GetData(queryMaSan);
                cboMaSan.DisplayMember = "MaSan";
            }
        }

        private void cboMaSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            string queryMaSan = "select * from SAN where MaSan = '" + cbo.Text + "'";
            cboTenSan.DataSource = mdf.GetData(queryMaSan);
            cboTenSan.DisplayMember = "TenSan";
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            loadView();
            resetValue();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            txtId.ReadOnly = false;
            btnSua.Enabled = true;
        }



        void getPay()
        {
            if (cboMaLoaiSan.Text != "" && cboMaSan.Text != "" && cboTenSan.Text != "")
            {
                int gioThue = (int)dtpThoiGianThue.Value.Hour;
                int gioTra = (int)dtpThoiGianTra.Value.Hour;
                string query = "select * from LoaiSan where MaLoaiSan = '" + cboMaLoaiSan.Text + "'";
                DataTable dt = mdf.GetData(query);
                int tien = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    tien = (int)dr[2];
                }
                txtThanhTien.Text = ((gioTra - gioThue) * tien).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin sân muốn thuê!!", "Thông báo");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboMaKH.Text != "" && cboMaLoaiSan.Text != "" && cboMaSan.Text != "" && cboTenSan.Text != "")
            {
                conn = cnn.GetConnection();
                conn.Open();
                string queryCheck = "select * from THUESAN where MaLoaiSan = @maLoaiSan and MaSan = @maSan and ThoiDiemThue between @thoiDiemThue and @thoiDiemTra";
                cmd = new SqlCommand(queryCheck, conn);
                cmd.Parameters.AddWithValue("@maLoaiSan", cboMaLoaiSan.Text);
                cmd.Parameters.AddWithValue("@maSan", cboMaSan.Text);
                cmd.Parameters.AddWithValue("@thoiDiemThue", dtpThoiGianThue.Value.ToString("yyyy-MM-dd hh:mm tt"));
                cmd.Parameters.AddWithValue("@thoiDiemTra", dtpThoiGianTra.Value.ToString("yyyy-MM-dd hh:mm tt"));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Sân đã có người thuê vui lòng chọn sân hoặc thời gian thuê khác!!!", "Thông báo");
                    resetValue();
                    reader.Close();
                    return;
                }
                reader.Close();
                string query = "insert into THUESAN(MaKH, MaLoaiSan, MaSan, TenSan, ThoiDiemThue, ThoiDiemTra, ThanhTien) values(@maKH, @maLoaiSan, @maSan, @tenSan, @thoiDiemThue, @thoiDiemTra, @thanhTien)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maKH", cboMaKH.Text);
                cmd.Parameters.AddWithValue("@maLoaiSan", cboMaLoaiSan.Text);
                cmd.Parameters.AddWithValue("@maSan", cboMaSan.Text);
                cmd.Parameters.AddWithValue("@tenSan", cboTenSan.Text);
                cmd.Parameters.AddWithValue("@thoiDiemThue", dtpThoiGianThue.Value.ToString("yyyy-MM-dd hh:mm tt"));
                cmd.Parameters.AddWithValue("@thoiDiemTra", dtpThoiGianTra.Value.ToString("yyyy-MM-dd hh:mm tt"));
                cmd.Parameters.AddWithValue("@thanhTien", txtThanhTien.Text);
                cmd.ExecuteNonQuery();
                loadView();
                resetValue();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                conn = cnn.GetConnection();
                conn.Open();
                string query = "delete THUESAN where MaThueSan = @maThueSan";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maThueSan", txtId.Text);
                cmd.ExecuteNonQuery();
                loadView();
                resetValue();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập id bản ghi muốn xoá!!", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                conn = cnn.GetConnection();
                conn.Open();
                string query = "update ThueSan set MaKH = @maKH, MaLoaiSan = @maLoaiSan, MaSan = @maSan, TenSan = @tenSan, ThoiDiemThue = @thoiDiemThue, ThoiDiemTra = @thoiDiemTra, ThanhTien = @thanhTien";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maKH", cboMaKH.Text);
                cmd.Parameters.AddWithValue("@maLoaiSan", cboMaLoaiSan.Text);
                cmd.Parameters.AddWithValue("@maSan", cboMaSan.Text);
                cmd.Parameters.AddWithValue("@tenSan", cboTenSan.Text);
                cmd.Parameters.AddWithValue("@thoiDiemThue", dtpThoiGianThue.Value.ToString("yyyy-MM-dd hh:mm tt"));
                cmd.Parameters.AddWithValue("@thoiDiemTra", dtpThoiGianTra.Value.ToString("yyyy-MM-dd hh:mm tt"));
                cmd.Parameters.AddWithValue("@thanhTien", cboMaKH.Text);
                cmd.ExecuteNonQuery();
                loadView();
                resetValue();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập id bản ghi muốn sửa!!", "Thông Báo");
            }
        }

        private void dtgvSanThue_Click(object sender, EventArgs e)
        {
            txtId.Text = dtgvSanThue.CurrentRow.Cells["MaThueSan"].Value.ToString();
            cboMaKH.Text = dtgvSanThue.CurrentRow.Cells["MaKH"].Value.ToString();
            cboMaLoaiSan.Text = dtgvSanThue.CurrentRow.Cells["MaLoaiSan"].Value.ToString();
            cboMaSan.Text = dtgvSanThue.CurrentRow.Cells["MaSan"].Value.ToString();
            cboTenSan.Text = dtgvSanThue.CurrentRow.Cells["TenSan"].Value.ToString();
            dtpThoiGianThue.Text = dtgvSanThue.CurrentRow.Cells["ThoiDiemThue"].Value.ToString();
            dtpThoiGianTra.Text = dtgvSanThue.CurrentRow.Cells["ThoiDiemTra"].Value.ToString();
            txtThanhTien.Text = dtgvSanThue.CurrentRow.Cells["ThanhTien"].Value.ToString();

        }

        private void dtpThoiGianThue_ValueChanged(object sender, EventArgs e)
        {
            getPay();
        }

        private void dtpThoiGianTra_ValueChanged(object sender, EventArgs e)
        {
            getPay();
        }
    }
}
