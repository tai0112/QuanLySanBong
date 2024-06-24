namespace WindowsFormsApp1
{
    partial class frmLoaiSan
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvLoaiSan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSuaSan = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMaLoaiSan = new System.Windows.Forms.ComboBox();
            this.txtIdSan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBoQuaSan = new System.Windows.Forms.Button();
            this.btnXoaSan = new System.Windows.Forms.Button();
            this.btnLuuSan = new System.Windows.Forms.Button();
            this.btnCheDo = new System.Windows.Forms.Button();
            this.txtTenSan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtgvSan = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiSan)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSan)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(975, 570);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(967, 541);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản Lý Loại Sân";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(508, 3);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(456, 498);
            this.panel5.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnBoQua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtGiaTien);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTenLoai);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 498);
            this.panel1.TabIndex = 1;
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.Image = global::WindowsFormsApp1.Properties.Resources.icons8_fix_24;
            this.btnSua.Location = new System.Drawing.Point(95, 457);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 29);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(144, 260);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(243, 29);
            this.txtId.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 22);
            this.label7.TabIndex = 26;
            this.label7.Text = "Mã ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "Thêm Loại Sân";
            // 
            // btnBoQua
            // 
            this.btnBoQua.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnBoQua.Image = global::WindowsFormsApp1.Properties.Resources.icons8_skip_24;
            this.btnBoQua.Location = new System.Drawing.Point(370, 457);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(86, 29);
            this.btnBoQua.TabIndex = 8;
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
            this.btnXoa.Location = new System.Drawing.Point(187, 457);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 29);
            this.btnXoa.TabIndex = 6;
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
            this.btnLuu.Location = new System.Drawing.Point(278, 457);
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
            this.btnAdd.Location = new System.Drawing.Point(4, 457);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Chế độ";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.Location = new System.Drawing.Point(144, 330);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(243, 29);
            this.txtGiaTien.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Giá tiền:";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoai.Location = new System.Drawing.Point(144, 295);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(243, 29);
            this.txtTenLoai.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên loại sân:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.Controls.Add(this.dtgvLoaiSan);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(505, 498);
            this.panel4.TabIndex = 28;
            // 
            // dtgvLoaiSan
            // 
            this.dtgvLoaiSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLoaiSan.Location = new System.Drawing.Point(74, 235);
            this.dtgvLoaiSan.Name = "dtgvLoaiSan";
            this.dtgvLoaiSan.RowHeadersWidth = 51;
            this.dtgvLoaiSan.Size = new System.Drawing.Size(353, 252);
            this.dtgvLoaiSan.TabIndex = 0;
            this.dtgvLoaiSan.Click += new System.EventHandler(this.dtgvLoaiSan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Loại Sân";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 501);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(961, 37);
            this.panel3.TabIndex = 27;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Image = global::WindowsFormsApp1.Properties.Resources.icons8_exit_24;
            this.btnThoat.Location = new System.Drawing.Point(874, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 29);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(967, 541);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản Lý Sân";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(505, 3);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(459, 535);
            this.panel7.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.btnSuaSan);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cboMaLoaiSan);
            this.panel2.Controls.Add(this.txtIdSan);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnBoQuaSan);
            this.panel2.Controls.Add(this.btnXoaSan);
            this.panel2.Controls.Add(this.btnLuuSan);
            this.panel2.Controls.Add(this.btnCheDo);
            this.panel2.Controls.Add(this.txtTenSan);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 535);
            this.panel2.TabIndex = 29;
            // 
            // btnSuaSan
            // 
            this.btnSuaSan.Enabled = false;
            this.btnSuaSan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnSuaSan.Image = global::WindowsFormsApp1.Properties.Resources.icons8_fix_24;
            this.btnSuaSan.Location = new System.Drawing.Point(97, 465);
            this.btnSuaSan.Name = "btnSuaSan";
            this.btnSuaSan.Size = new System.Drawing.Size(86, 29);
            this.btnSuaSan.TabIndex = 5;
            this.btnSuaSan.Text = "Sửa";
            this.btnSuaSan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaSan.UseVisualStyleBackColor = true;
            this.btnSuaSan.Click += new System.EventHandler(this.btnSuaSan_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(211, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 29);
            this.label8.TabIndex = 31;
            this.label8.Text = "Thêm sân";
            // 
            // cboMaLoaiSan
            // 
            this.cboMaLoaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cboMaLoaiSan.FormattingEnabled = true;
            this.cboMaLoaiSan.Location = new System.Drawing.Point(160, 343);
            this.cboMaLoaiSan.Name = "cboMaLoaiSan";
            this.cboMaLoaiSan.Size = new System.Drawing.Size(242, 32);
            this.cboMaLoaiSan.TabIndex = 2;
            // 
            // txtIdSan
            // 
            this.txtIdSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSan.Location = new System.Drawing.Point(160, 308);
            this.txtIdSan.Name = "txtIdSan";
            this.txtIdSan.ReadOnly = true;
            this.txtIdSan.Size = new System.Drawing.Size(243, 29);
            this.txtIdSan.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Mã ID:";
            // 
            // btnBoQuaSan
            // 
            this.btnBoQuaSan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnBoQuaSan.Image = global::WindowsFormsApp1.Properties.Resources.icons8_skip_24;
            this.btnBoQuaSan.Location = new System.Drawing.Point(370, 465);
            this.btnBoQuaSan.Name = "btnBoQuaSan";
            this.btnBoQuaSan.Size = new System.Drawing.Size(86, 29);
            this.btnBoQuaSan.TabIndex = 8;
            this.btnBoQuaSan.Text = "Bỏ Qua";
            this.btnBoQuaSan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBoQuaSan.UseVisualStyleBackColor = true;
            this.btnBoQuaSan.Click += new System.EventHandler(this.btnBoQuaSan_Click);
            // 
            // btnXoaSan
            // 
            this.btnXoaSan.Enabled = false;
            this.btnXoaSan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaSan.Image = global::WindowsFormsApp1.Properties.Resources.icons8_cancel_24;
            this.btnXoaSan.Location = new System.Drawing.Point(188, 465);
            this.btnXoaSan.Name = "btnXoaSan";
            this.btnXoaSan.Size = new System.Drawing.Size(86, 29);
            this.btnXoaSan.TabIndex = 6;
            this.btnXoaSan.Text = "Xoá";
            this.btnXoaSan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaSan.UseVisualStyleBackColor = true;
            this.btnXoaSan.Click += new System.EventHandler(this.btnXoaSan_Click);
            // 
            // btnLuuSan
            // 
            this.btnLuuSan.Enabled = false;
            this.btnLuuSan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuuSan.Image = global::WindowsFormsApp1.Properties.Resources.icons8_save_24;
            this.btnLuuSan.Location = new System.Drawing.Point(279, 465);
            this.btnLuuSan.Name = "btnLuuSan";
            this.btnLuuSan.Size = new System.Drawing.Size(86, 29);
            this.btnLuuSan.TabIndex = 7;
            this.btnLuuSan.Text = "Lưu";
            this.btnLuuSan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuSan.UseVisualStyleBackColor = true;
            this.btnLuuSan.Click += new System.EventHandler(this.btnLuuSan_Click);
            // 
            // btnCheDo
            // 
            this.btnCheDo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheDo.Image = global::WindowsFormsApp1.Properties.Resources.icons8_minecraft_optifine_24;
            this.btnCheDo.Location = new System.Drawing.Point(5, 465);
            this.btnCheDo.Name = "btnCheDo";
            this.btnCheDo.Size = new System.Drawing.Size(86, 29);
            this.btnCheDo.TabIndex = 4;
            this.btnCheDo.Text = "Chế độ";
            this.btnCheDo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheDo.UseVisualStyleBackColor = true;
            this.btnCheDo.Click += new System.EventHandler(this.btnCheDo_Click);
            // 
            // txtTenSan
            // 
            this.txtTenSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSan.Location = new System.Drawing.Point(160, 381);
            this.txtTenSan.Name = "txtTenSan";
            this.txtTenSan.Size = new System.Drawing.Size(243, 29);
            this.txtTenSan.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tên sân:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(74, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 22);
            this.label10.TabIndex = 15;
            this.label10.Text = "Mã loại:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SeaGreen;
            this.panel6.Controls.Add(this.dtgvSan);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(502, 535);
            this.panel6.TabIndex = 32;
            // 
            // dtgvSan
            // 
            this.dtgvSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSan.Location = new System.Drawing.Point(68, 266);
            this.dtgvSan.Name = "dtgvSan";
            this.dtgvSan.RowHeadersWidth = 51;
            this.dtgvSan.Size = new System.Drawing.Size(375, 228);
            this.dtgvSan.TabIndex = 30;
            this.dtgvSan.Click += new System.EventHandler(this.dtgvSan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Sân";
            // 
            // frmLoaiSan
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(975, 570);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmLoaiSan";
            this.Text = "frmLoaiSan";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiSan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgvLoaiSan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIdSan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBoQuaSan;
        private System.Windows.Forms.Button btnXoaSan;
        private System.Windows.Forms.Button btnLuuSan;
        private System.Windows.Forms.Button btnCheDo;
        private System.Windows.Forms.TextBox txtTenSan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgvSan;
        private System.Windows.Forms.ComboBox cboMaLoaiSan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnSuaSan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
    }
}