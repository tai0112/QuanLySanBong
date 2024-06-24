namespace WindowsFormsApp1
{
    partial class dtgvThueSan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpSan = new System.Windows.Forms.FlowLayoutPanel();
            this.dtgvSanThue = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtDichVu = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.cboTenSan = new System.Windows.Forms.ComboBox();
            this.cboMaSan = new System.Windows.Forms.ComboBox();
            this.cboMaLoaiSan = new System.Windows.Forms.ComboBox();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpThoiGianTra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpThoiGianThue = new System.Windows.Forms.DateTimePicker();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanThue)).BeginInit();
            this.txtDichVu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpSan
            // 
            this.flpSan.BackColor = System.Drawing.Color.SeaGreen;
            this.flpSan.Location = new System.Drawing.Point(30, 8);
            this.flpSan.Name = "flpSan";
            this.flpSan.Size = new System.Drawing.Size(421, 421);
            this.flpSan.TabIndex = 0;
            // 
            // dtgvSanThue
            // 
            this.dtgvSanThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanThue.Location = new System.Drawing.Point(68, 6);
            this.dtgvSanThue.Name = "dtgvSanThue";
            this.dtgvSanThue.RowHeadersWidth = 51;
            this.dtgvSanThue.Size = new System.Drawing.Size(851, 234);
            this.dtgvSanThue.TabIndex = 1;
            this.dtgvSanThue.Click += new System.EventHandler(this.dtgvSanThue_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(779, 680);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 36);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtDichVu
            // 
            this.txtDichVu.BackColor = System.Drawing.Color.SeaGreen;
            this.txtDichVu.Controls.Add(this.btnSua);
            this.txtDichVu.Controls.Add(this.cboTenSan);
            this.txtDichVu.Controls.Add(this.cboMaSan);
            this.txtDichVu.Controls.Add(this.cboMaLoaiSan);
            this.txtDichVu.Controls.Add(this.cboMaKH);
            this.txtDichVu.Controls.Add(this.label9);
            this.txtDichVu.Controls.Add(this.label8);
            this.txtDichVu.Controls.Add(this.dtpThoiGianTra);
            this.txtDichVu.Controls.Add(this.label2);
            this.txtDichVu.Controls.Add(this.label5);
            this.txtDichVu.Controls.Add(this.dtpThoiGianThue);
            this.txtDichVu.Controls.Add(this.txtThanhTien);
            this.txtDichVu.Controls.Add(this.label1);
            this.txtDichVu.Controls.Add(this.label4);
            this.txtDichVu.Controls.Add(this.label3);
            this.txtDichVu.Controls.Add(this.txtId);
            this.txtDichVu.Controls.Add(this.label7);
            this.txtDichVu.Controls.Add(this.label6);
            this.txtDichVu.Controls.Add(this.btnBoQua);
            this.txtDichVu.Controls.Add(this.btnXoa);
            this.txtDichVu.Controls.Add(this.btnLuu);
            this.txtDichVu.Controls.Add(this.btnAdd);
            this.txtDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDichVu.Location = new System.Drawing.Point(0, 0);
            this.txtDichVu.Name = "txtDichVu";
            this.txtDichVu.Size = new System.Drawing.Size(503, 434);
            this.txtDichVu.TabIndex = 16;
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.Image = global::WindowsFormsApp1.Properties.Resources.icons8_fix_24;
            this.btnSua.Location = new System.Drawing.Point(208, 397);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 29);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cboTenSan
            // 
            this.cboTenSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cboTenSan.FormattingEnabled = true;
            this.cboTenSan.Location = new System.Drawing.Point(236, 202);
            this.cboTenSan.Name = "cboTenSan";
            this.cboTenSan.Size = new System.Drawing.Size(242, 32);
            this.cboTenSan.TabIndex = 32;
            // 
            // cboMaSan
            // 
            this.cboMaSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cboMaSan.FormattingEnabled = true;
            this.cboMaSan.Location = new System.Drawing.Point(237, 165);
            this.cboMaSan.Name = "cboMaSan";
            this.cboMaSan.Size = new System.Drawing.Size(242, 32);
            this.cboMaSan.TabIndex = 31;
            this.cboMaSan.SelectedIndexChanged += new System.EventHandler(this.cboMaSan_SelectedIndexChanged);
            // 
            // cboMaLoaiSan
            // 
            this.cboMaLoaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cboMaLoaiSan.FormattingEnabled = true;
            this.cboMaLoaiSan.Location = new System.Drawing.Point(237, 129);
            this.cboMaLoaiSan.Name = "cboMaLoaiSan";
            this.cboMaLoaiSan.Size = new System.Drawing.Size(242, 32);
            this.cboMaLoaiSan.TabIndex = 30;
            this.cboMaLoaiSan.SelectedValueChanged += new System.EventHandler(this.cboMaLoaiSan_SelectedValueChanged);
            // 
            // cboMaKH
            // 
            this.cboMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(237, 90);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(242, 32);
            this.cboMaKH.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(77, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 22);
            this.label9.TabIndex = 26;
            this.label9.Text = "Tên sân:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "Mã KH:";
            // 
            // dtpThoiGianTra
            // 
            this.dtpThoiGianTra.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGianTra.CustomFormat = "dd/MM/yy hh:m tt";
            this.dtpThoiGianTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGianTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianTra.Location = new System.Drawing.Point(236, 272);
            this.dtpThoiGianTra.Name = "dtpThoiGianTra";
            this.dtpThoiGianTra.Size = new System.Drawing.Size(243, 26);
            this.dtpThoiGianTra.TabIndex = 19;
            this.dtpThoiGianTra.ValueChanged += new System.EventHandler(this.dtpThoiGianTra_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Thời gian trả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Thành tiền:";
            // 
            // dtpThoiGianThue
            // 
            this.dtpThoiGianThue.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGianThue.CustomFormat = "dd/MM/yy hh:m tt";
            this.dtpThoiGianThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGianThue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianThue.Location = new System.Drawing.Point(236, 239);
            this.dtpThoiGianThue.Name = "dtpThoiGianThue";
            this.dtpThoiGianThue.Size = new System.Drawing.Size(243, 26);
            this.dtpThoiGianThue.TabIndex = 17;
            this.dtpThoiGianThue.ValueChanged += new System.EventHandler(this.dtpThoiGianThue_ValueChanged);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(236, 304);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(243, 29);
            this.txtThanhTien.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Thời gian thuê:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mã sân:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã loại:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(236, 58);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(243, 29);
            this.txtId.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(211, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Thuê Sân";
            // 
            // btnBoQua
            // 
            this.btnBoQua.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnBoQua.Image = global::WindowsFormsApp1.Properties.Resources.icons8_skip_24;
            this.btnBoQua.Location = new System.Drawing.Point(400, 397);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(86, 29);
            this.btnBoQua.TabIndex = 9;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Image = global::WindowsFormsApp1.Properties.Resources.icons8_cancel_24;
            this.btnXoa.Location = new System.Drawing.Point(306, 397);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 29);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Image = global::WindowsFormsApp1.Properties.Resources.icons8_save_24;
            this.btnLuu.Location = new System.Drawing.Point(112, 397);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(86, 29);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Image = global::WindowsFormsApp1.Properties.Resources.icons8_minecraft_optifine_24;
            this.btnAdd.Location = new System.Drawing.Point(14, 397);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 29);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Chế độ";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.dtgvSanThue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 434);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 254);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDichVu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 434);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Controls.Add(this.flpSan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(503, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 434);
            this.panel3.TabIndex = 19;
            // 
            // dtgvThueSan
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(975, 688);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Name = "dtgvThueSan";
            this.Text = "frmThueSan";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanThue)).EndInit();
            this.txtDichVu.ResumeLayout(false);
            this.txtDichVu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSan;
        private System.Windows.Forms.DataGridView dtgvSanThue;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel txtDichVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpThoiGianTra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpThoiGianThue;
        private System.Windows.Forms.ComboBox cboTenSan;
        private System.Windows.Forms.ComboBox cboMaSan;
        private System.Windows.Forms.ComboBox cboMaLoaiSan;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}