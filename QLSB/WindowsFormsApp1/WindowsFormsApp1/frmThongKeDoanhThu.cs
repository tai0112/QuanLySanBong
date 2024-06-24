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
    public partial class frmThongKeDoanhThu : Form
    {
        SqlConnection conn;
        Connection cnn = new Connection();
        SqlCommand cmd;
        Modify mdf = new Modify();
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        void loadView()
        {
            SqlCommand checkNull;
            string query = "";
            string getTotal = "";
            string check = "";
            conn = cnn.GetConnection();
            conn.Open();
            if (cboKieuThongKe.Text == "Tháng")
            {
                query = "select * from CHITIETHOADON where MONTH(NgayTao) = '" + dtpThoiDiemThongKe.Value.Month.ToString() + "'";
                getTotal = "select sum(ThanhTien) from CHITIETHOADON where MONTH(NgayTao) = @ngayTao";
                check = "select count(*) from CHITIETHOADON where MONTH(NgayTao) = @ngayTao";
                cmd = new SqlCommand(getTotal, conn);
                cmd.Parameters.AddWithValue("@ngayTao", dtpThoiDiemThongKe.Value.Month.ToString());
                checkNull = new SqlCommand(check, conn);
                checkNull.Parameters.AddWithValue("@ngayTao", dtpThoiDiemThongKe.Value.Month.ToString());
            }
            else if (cboKieuThongKe.Text == "Năm")
            {
                query = "select * from CHITIETHOADON where YEAR(NgayTao) = '" + dtpThoiDiemThongKe.Value.Year.ToString() + "'";
                getTotal = "select sum(ThanhTien) from CHITIETHOADON where YEAR(NgayTao) = @ngayTao";
                check = "select count(*) from CHITIETHOADON where YEAR(NgayTao) = @ngayTao";
                cmd = new SqlCommand(getTotal, conn);
                cmd.Parameters.AddWithValue("@ngayTao", dtpThoiDiemThongKe.Value.Year.ToString());
                checkNull = new SqlCommand(check, conn);
                checkNull.Parameters.AddWithValue("@ngayTao", dtpThoiDiemThongKe.Value.Year.ToString());
            }
            else
            {
                query = "select * from CHITIETHOADON where NgayTao = '" + dtpThoiDiemThongKe.Value.ToString("yyyy-MM-dd") + "'";
                getTotal = "select sum(ThanhTien) from CHITIETHOADON where NgayTao = @ngayTao";
                check = "select count(*) from CHITIETHOADON where NgayTao = @ngayTao";
                cmd = new SqlCommand(getTotal, conn);
                cmd.Parameters.AddWithValue("@ngayTao", dtpThoiDiemThongKe.Value.ToString("yyyy-MM-dd"));
                checkNull = new SqlCommand(check, conn);
                checkNull.Parameters.AddWithValue("@ngayTao", dtpThoiDiemThongKe.Value.ToString("yyyy-MM-dd"));
            }
            int count = (int)checkNull.ExecuteScalar();
            if (count > 0)
            {
                int total = (int)cmd.ExecuteScalar();
                txtTongDoanhThu.Text = total.ToString();
                dtgvThongKe.DataSource = mdf.GetData(query);
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu vào ngày " + dtpThoiDiemThongKe.Value.ToString("yyyy-MM-dd"));
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            loadView();
        }
    }
}
