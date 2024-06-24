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
    public partial class frmDichVu : Form
    {
        Connection cnn = new Connection();
        Modify mdf = new Modify();
        SqlConnection conn;
        SqlCommand cmd;
        public frmDichVu()
        {
            InitializeComponent();
            loadView();
            resetData();
        }

        void loadView()
        {
            string queryDichVu = "select * from DICHVU";
            dtgvDichVu.DataSource = mdf.GetData(queryDichVu);
        }

        void resetData()
        {
            txtTenDichVu.Text = "";
            txtGiaDichVu.Text = "";
            txtId.Text = "";
            txtId.ReadOnly = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            txtId.ReadOnly = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtGiaDichVu.Text != "" && txtTenDichVu.Text != "")
            {
                conn = cnn.GetConnection();
                conn.Open();
                string query = "insert into DICHVU(TenDichVu, GiaTien) values(@tenDichVu, @giaDichVu)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tenDichVu", txtTenDichVu.Text);
                cmd.Parameters.AddWithValue("@giaDichVu", txtGiaDichVu.Text);
                cmd.ExecuteNonQuery();
                loadView();
                resetData();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin dịch vụ muốn thêm", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                conn = cnn.GetConnection();
                conn.Open();
                string query = "delete from DICHVU where MaDichVu = @maDichVu";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maDichVu", txtId.Text);
                cmd.ExecuteNonQuery();
                loadView();
                resetData();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã dịch vụ muốn xoá", "Thông tin");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                conn = cnn.GetConnection();
                conn.Open();
                string query = "update DICHVU set TenDichVu = @tenDichVu, GiaTien = @giaTien where MaDichVu = @maDichVu";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maDichVu", txtId.Text);
                cmd.Parameters.AddWithValue("@tenDichVu", txtTenDichVu.Text);
                cmd.Parameters.AddWithValue("@giaTien", txtGiaDichVu.Text);
                cmd.ExecuteNonQuery();
                loadView();
                resetData();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã dịch vụ muốn xoá", "Thông báo");
            }
        }

        private void dtgvDichVu_Click(object sender, EventArgs e)
        {
            txtId.Text = dtgvDichVu.CurrentRow.Cells["MaDichVu"].Value.ToString();
            txtTenDichVu.Text = dtgvDichVu.CurrentRow.Cells["TenDichVu"].Value.ToString();
            txtGiaDichVu.Text = dtgvDichVu.CurrentRow.Cells["GiaTien"].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
