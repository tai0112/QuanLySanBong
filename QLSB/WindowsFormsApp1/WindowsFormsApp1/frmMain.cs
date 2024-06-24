using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public delegate void isAdmin(int admin);
        public isAdmin Sender;
        public frmMain()
        {
            InitializeComponent();
            Sender = new isAdmin(getAdm);
        }

        public void getAdm(int admin)
        {
            txtCheck.Text = admin.ToString();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(txtCheck.Text == "0")
            {
                btnNhanVien.Visible = false;
                btnTK.Visible = false;
                btnDichVu.Visible = false;
                btnLoaiSan.Visible = false;
                btnTKDT.Visible = false;
            }
        }

       

        private void btnNhanVien_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
        }

        private void btnKhachHang_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());
        }

        private void btnDichVu_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmDichVu());
        }

        private void btnThueSan_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new dtgvThueSan());
        }

        private void btnLoaiSan_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmLoaiSan());
        }

        private void btnHoaDon_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon());
        }

      

        private void btnTK_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLTK());
        }

        private void btnTKDT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeDoanhThu());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }

}
