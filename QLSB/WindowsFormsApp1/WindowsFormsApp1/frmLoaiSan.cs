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
    public partial class frmLoaiSan : Form
    {
        public static int witdh = 100;
        public static int height = 100;
        Modify mdf = new Modify();
        Connection cnn = new Connection();
        SqlConnection conn;
        SqlCommand cmd;
        public frmLoaiSan()
        {
            InitializeComponent();
            //loadSan();
            loadView();
            resetData();
        }

        public void resetData()
        {
            txtIdSan.Text = "";
            cboMaLoaiSan.SelectedIndex = -1;
            txtTenSan.Text = "";
            txtId.Text = "";
            txtTenLoai.Text = "";
            txtGiaTien.Text = "";
            btnXoaSan.Enabled = false;
            btnLuuSan.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            txtIdSan.ReadOnly = true;
            txtId.ReadOnly = true;
        }

        void loadView()
        {
            string queryLoaiSan = "select * from LOAISAN";
            dtgvLoaiSan.DataSource = mdf.GetData(queryLoaiSan);
            cboMaLoaiSan.DataSource = mdf.GetData(queryLoaiSan);
            cboMaLoaiSan.DisplayMember = "MaLoaiSan";
            string querySan = "select * from SAN";
            dtgvSan.DataSource = mdf.GetData(querySan);
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtId.ReadOnly = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenLoai.Text != "" && txtGiaTien.Text != "")
            {
                conn = cnn.GetConnection();
                conn.Open();
                string query = "insert into LOAISAN values(@tenLoai, @giaTien)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tenLoai", txtTenLoai.Text);
                cmd.Parameters.AddWithValue("@giaTien", txtGiaTien.Text);
                cmd.ExecuteNonQuery();
                loadView();
                resetData();
                conn.Close();
            }else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin loại sân!!", "Thông báo");
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                conn = cnn.GetConnection();
                conn.Open();
                string query = "delete from LOAISAN where MaLoaiSan = @maLoaiSan";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maLoaiSan", txtId.Text);
                cmd.ExecuteNonQuery();
                loadView();
                resetData();
                conn.Close();
            }else
            {
                MessageBox.Show("Vui lòng nhập id loại sân muốn xoá!!","Thông báo");
            }
        }

        //void loadSan()
        //{
        //    conn = cnn.GetConnection();
        //    conn.Open();
        //    string query = "select * from SAN";
        //    cmd = new SqlCommand(query, conn);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    while(reader.Read()) 
        //    {
        //        string maLoaiSan = reader["MaLoaiSan"].ToString();
        //        string tenLoaiSan = reader["TenLoaiSan"].ToString();
        //        Button btn = new Button();
        //        btn.Text = tenLoaiSan + "-" + maLoaiSan;
        //        btn.Click += Btn_Click;
        //        btn.Width = witdh;
        //        btn.Height = height;
        //        btn.BackgroundImage = WindowsFormsApp1.Properties.Resources.san;
        //        btn.Font = new System.Drawing.Font("Times New Roman", 14, FontStyle.Bold);
        //        btn.ForeColor = Color.White;
        //        btn.BackgroundImageLayout = ImageLayout.Stretch;
        //        flpSan.Controls.Add(btn);
        //    }
        //}

        

        private void btnCheDo_Click(object sender, EventArgs e)
        {
            btnXoaSan.Enabled = true;
            btnLuuSan.Enabled = true;
            btnSuaSan.Enabled = true;
            txtIdSan.ReadOnly = false;
        }

        private void btnBoQuaSan_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void btnXoaSan_Click(object sender, EventArgs e)
        {
            if(txtIdSan.Text != "")
            {
                conn = cnn.GetConnection();
                conn.Open();
                string query = "delete from SAN where MaSan = @maSan";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maSan", txtIdSan.Text);
                cmd.ExecuteNonQuery();
                loadView();
                resetData();
                conn.Close();
            }else
            {
                MessageBox.Show("Xin mời nhập mã sân muốn xoá!!", "Thông báo");
            }
        }

        private void btnLuuSan_Click(object sender, EventArgs e)
        {
            if(txtTenSan.Text != "" && cboMaLoaiSan.Text != "")
            {
                conn = cnn.GetConnection();
                conn.Open();
                string query = "insert into SAN(MaLoaiSan, TenSan) values(@maLoaiSan, @tenSan)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maLoaiSan", cboMaLoaiSan.Text);
                cmd.Parameters.AddWithValue("@tenSan", txtTenSan.Text);
                cmd.ExecuteNonQuery();
                loadView();
                resetData();
                conn.Close();
            }else
            {
                MessageBox.Show("Xin mời nhập đủ thông tin sân muốn thêm!!", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                conn = cnn.GetConnection();
                conn.Open();
                string query = "update LOAISAN set TenLoaiSan = @tenLoaiSan, GiaTien = @giaTien where MaLoaiSan = @maLoaiSan";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tenLoaiSan", txtTenLoai.Text);
                cmd.Parameters.AddWithValue("@giaTien", txtGiaTien.Text);
                cmd.Parameters.AddWithValue("@maLoaiSan", txtId.Text);
                cmd.ExecuteNonQuery();
                loadView();
                resetData();
                conn.Close();
            }else
            {
                MessageBox.Show("Vui lòng nhập mã loại sân muốn sửa!!", "Thông báo");
            }
        }

        private void btnSuaSan_Click(object sender, EventArgs e)
        {
            if(txtIdSan.Text != "") 
            {
                conn = cnn.GetConnection();
                conn.Open();
                string query = "update SAN set MaLoaiSan = @maLoaiSan, TenSan = @tenSan where MaSan = @maSan";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maLoaiSan", cboMaLoaiSan.Text);
                cmd.Parameters.AddWithValue("@tenSan", txtTenSan.Text);
                cmd.Parameters.AddWithValue("@maSan", txtIdSan.Text);
                cmd.ExecuteNonQuery();
                loadView();
                resetData();
                conn.Close();
            }else
            {
                MessageBox.Show("Vui lòng nhập mã sân muốn sửa!!", "Thông Báo");
            }
        }

        private void dtgvLoaiSan_Click(object sender, EventArgs e)
        {
            txtId.Text = dtgvLoaiSan.CurrentRow.Cells["MaLoaiSan"].Value.ToString();
            txtTenLoai.Text = dtgvLoaiSan.CurrentRow.Cells["TenLoaiSan"].Value.ToString();
            txtGiaTien.Text = dtgvLoaiSan.CurrentRow.Cells["GiaTien"].Value.ToString();
        }

        private void dtgvSan_Click(object sender, EventArgs e)
        {
            txtIdSan.Text = dtgvSan.CurrentRow.Cells["MaSan"].Value.ToString();
            cboMaLoaiSan.Text = dtgvSan.CurrentRow.Cells["MaLoaiSan"].Value.ToString();
            txtTenSan.Text = dtgvSan.CurrentRow.Cells["TenSan"].Value.ToString();

        }
    }
}
