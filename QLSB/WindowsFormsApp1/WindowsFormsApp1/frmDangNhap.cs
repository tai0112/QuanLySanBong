using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmDangNhap : Form
    {
        int admin = 0;
        Modify mdf = new Modify();
        SqlCommand cmd;
        Connection cnn = new Connection();
        SqlConnection conn;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text != "" && txtMatKhau.Text != "")
            {
                conn = cnn.GetConnection();
                conn.Open();
                string username = txtTenDangNhap.Text;
                string password = txtMatKhau.Text.Trim();
                string query = "select * from ACCOUNT where Username = @username and Password = @password";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    reader.Read();
                    string queryUser = "select * from ACCOUNT where Username = '" + username + "' and Password = '" + password + "'";
                    DataTable dtb = mdf.GetData(queryUser);
                    foreach(DataRow dr in dtb.Rows)
                    {
                        admin = (int)dr[2];
                    }
                    frmMain frm = new frmMain();
                    frm.Sender(admin);
                    frm.ShowDialog();
                }else
                {
                    MessageBox.Show("Bạn đã nhập sai thông tin đăng nhập!!!", "Thông báo");
                }
            }
            resetValue();
        }
        void resetValue()
        {
            txtMatKhau.Text = string.Empty;
            txtTenDangNhap.Text = string.Empty;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTaoTK frm = new frmTaoTK();
            frm.ShowDialog();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
