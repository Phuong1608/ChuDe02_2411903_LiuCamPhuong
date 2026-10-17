namespace QLSVKhoaCNTT
{
	partial class frmSinhVienKhoaCNTT
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
			this.components = new System.ComponentModel.Container();
			this.pbHinh = new System.Windows.Forms.PictureBox();
			this.grbThongTin = new System.Windows.Forms.GroupBox();
			this.btnMacDinh = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.mtxtSoDT = new System.Windows.Forms.MaskedTextBox();
			this.cboLop = new System.Windows.Forms.ComboBox();
			this.rdNu = new System.Windows.Forms.RadioButton();
			this.rdNam = new System.Windows.Forms.RadioButton();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.txtHinh = new System.Windows.Forms.TextBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.mtxtMSSV = new System.Windows.Forms.MaskedTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lvSinhVien = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
			this.btnTaiLai = new System.Windows.Forms.ToolStripMenuItem();
			this.grbDSSV = new System.Windows.Forms.GroupBox();
			this.OpenFileDialogHinh = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
			this.grbThongTin.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.grbDSSV.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbHinh
			// 
			this.pbHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbHinh.Location = new System.Drawing.Point(12, 12);
			this.pbHinh.Name = "pbHinh";
			this.pbHinh.Size = new System.Drawing.Size(174, 223);
			this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbHinh.TabIndex = 0;
			this.pbHinh.TabStop = false;
			// 
			// grbThongTin
			// 
			this.grbThongTin.Controls.Add(this.btnMacDinh);
			this.grbThongTin.Controls.Add(this.btnLuu);
			this.grbThongTin.Controls.Add(this.btnThoat);
			this.grbThongTin.Controls.Add(this.btnBrowse);
			this.grbThongTin.Controls.Add(this.mtxtSoDT);
			this.grbThongTin.Controls.Add(this.cboLop);
			this.grbThongTin.Controls.Add(this.rdNu);
			this.grbThongTin.Controls.Add(this.rdNam);
			this.grbThongTin.Controls.Add(this.dtpNgaySinh);
			this.grbThongTin.Controls.Add(this.txtHinh);
			this.grbThongTin.Controls.Add(this.txtDiaChi);
			this.grbThongTin.Controls.Add(this.txtEmail);
			this.grbThongTin.Controls.Add(this.txtHoTen);
			this.grbThongTin.Controls.Add(this.mtxtMSSV);
			this.grbThongTin.Controls.Add(this.label6);
			this.grbThongTin.Controls.Add(this.label5);
			this.grbThongTin.Controls.Add(this.label4);
			this.grbThongTin.Controls.Add(this.label3);
			this.grbThongTin.Controls.Add(this.label9);
			this.grbThongTin.Controls.Add(this.label8);
			this.grbThongTin.Controls.Add(this.label7);
			this.grbThongTin.Controls.Add(this.label2);
			this.grbThongTin.Controls.Add(this.label1);
			this.grbThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.grbThongTin.Location = new System.Drawing.Point(192, 12);
			this.grbThongTin.Name = "grbThongTin";
			this.grbThongTin.Size = new System.Drawing.Size(635, 223);
			this.grbThongTin.TabIndex = 1;
			this.grbThongTin.TabStop = false;
			this.grbThongTin.Text = "Thông tin sinh viên";
			// 
			// btnMacDinh
			// 
			this.btnMacDinh.Location = new System.Drawing.Point(138, 192);
			this.btnMacDinh.Name = "btnMacDinh";
			this.btnMacDinh.Size = new System.Drawing.Size(99, 30);
			this.btnMacDinh.TabIndex = 24;
			this.btnMacDinh.Text = "Mặc định";
			this.btnMacDinh.UseVisualStyleBackColor = true;
			this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(267, 192);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(99, 30);
			this.btnLuu.TabIndex = 25;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(389, 192);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(112, 30);
			this.btnThoat.TabIndex = 24;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnBrowse
			// 
			this.btnBrowse.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnBrowse.Location = new System.Drawing.Point(512, 161);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(104, 26);
			this.btnBrowse.TabIndex = 23;
			this.btnBrowse.Text = "Chọn hình";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// mtxtSoDT
			// 
			this.mtxtSoDT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.mtxtSoDT.Location = new System.Drawing.Point(457, 119);
			this.mtxtSoDT.Mask = "000-000-0000";
			this.mtxtSoDT.Name = "mtxtSoDT";
			this.mtxtSoDT.Size = new System.Drawing.Size(159, 27);
			this.mtxtSoDT.TabIndex = 22;
			// 
			// cboLop
			// 
			this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cboLop.FormattingEnabled = true;
			this.cboLop.Items.AddRange(new object[] {
            "CTK43",
            "CTK44",
            "CTK45",
            "CTK46"});
			this.cboLop.Location = new System.Drawing.Point(457, 84);
			this.cboLop.Name = "cboLop";
			this.cboLop.Size = new System.Drawing.Size(159, 27);
			this.cboLop.TabIndex = 21;
			// 
			// rdNu
			// 
			this.rdNu.AutoSize = true;
			this.rdNu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.rdNu.Location = new System.Drawing.Point(555, 55);
			this.rdNu.Name = "rdNu";
			this.rdNu.Size = new System.Drawing.Size(51, 23);
			this.rdNu.TabIndex = 20;
			this.rdNu.Text = "Nữ";
			this.rdNu.UseVisualStyleBackColor = true;
			// 
			// rdNam
			// 
			this.rdNam.AutoSize = true;
			this.rdNam.Checked = true;
			this.rdNam.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.rdNam.Location = new System.Drawing.Point(457, 55);
			this.rdNam.Name = "rdNam";
			this.rdNam.Size = new System.Drawing.Size(62, 23);
			this.rdNam.TabIndex = 19;
			this.rdNam.TabStop = true;
			this.rdNam.Text = "Nam";
			this.rdNam.UseVisualStyleBackColor = true;
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.CustomFormat = "dd/mm/yyyy";
			this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgaySinh.Location = new System.Drawing.Point(457, 22);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(159, 27);
			this.dtpNgaySinh.TabIndex = 18;
			// 
			// txtHinh
			// 
			this.txtHinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtHinh.Location = new System.Drawing.Point(94, 161);
			this.txtHinh.Name = "txtHinh";
			this.txtHinh.ReadOnly = true;
			this.txtHinh.Size = new System.Drawing.Size(412, 27);
			this.txtHinh.TabIndex = 17;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtDiaChi.Location = new System.Drawing.Point(94, 127);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(236, 27);
			this.txtDiaChi.TabIndex = 16;
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtEmail.Location = new System.Drawing.Point(94, 93);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(236, 27);
			this.txtEmail.TabIndex = 15;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtHoTen.Location = new System.Drawing.Point(94, 59);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(236, 27);
			this.txtHoTen.TabIndex = 14;
			// 
			// mtxtMSSV
			// 
			this.mtxtMSSV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.mtxtMSSV.Location = new System.Drawing.Point(94, 28);
			this.mtxtMSSV.Mask = "0000000";
			this.mtxtMSSV.Name = "mtxtMSSV";
			this.mtxtMSSV.Size = new System.Drawing.Size(236, 27);
			this.mtxtMSSV.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.Location = new System.Drawing.Point(346, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = "Phái";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.Location = new System.Drawing.Point(346, 91);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = "Lớp";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(346, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 20);
			this.label4.TabIndex = 10;
			this.label4.Text = "Số điện thoại";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(346, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Ngày sinh";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label9.Location = new System.Drawing.Point(6, 128);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(60, 20);
			this.label9.TabIndex = 8;
			this.label9.Text = "Địa chỉ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label8.Location = new System.Drawing.Point(6, 95);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 20);
			this.label8.TabIndex = 7;
			this.label8.Text = "Email";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label7.Location = new System.Drawing.Point(11, 168);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 20);
			this.label7.TabIndex = 6;
			this.label7.Text = "Hình";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(6, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Họ và tên";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(6, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "MSSV";
			// 
			// lvSinhVien
			// 
			this.lvSinhVien.CheckBoxes = true;
			this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
			this.lvSinhVien.ContextMenuStrip = this.contextMenuStrip1;
			this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lvSinhVien.FullRowSelect = true;
			this.lvSinhVien.GridLines = true;
			this.lvSinhVien.HideSelection = false;
			this.lvSinhVien.Location = new System.Drawing.Point(3, 29);
			this.lvSinhVien.Name = "lvSinhVien";
			this.lvSinhVien.Size = new System.Drawing.Size(893, 302);
			this.lvSinhVien.TabIndex = 2;
			this.lvSinhVien.UseCompatibleStateImageBehavior = false;
			this.lvSinhVien.View = System.Windows.Forms.View.Details;
			this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "MSSV";
			this.columnHeader1.Width = 80;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Họ và tên";
			this.columnHeader2.Width = 140;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Phái";
			this.columnHeader3.Width = 50;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Ngày sinh";
			this.columnHeader8.Width = 100;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Lớp";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Số ĐT";
			this.columnHeader4.Width = 110;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Email";
			this.columnHeader5.Width = 150;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Địa chỉ";
			this.columnHeader6.Width = 90;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Hình";
			this.columnHeader7.Width = 110;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnXoa,
            this.btnTaiLai});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(190, 52);
			// 
			// btnXoa
			// 
			this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(189, 24);
			this.btnXoa.Text = "Xóa";
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnTaiLai
			// 
			this.btnTaiLai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnTaiLai.Name = "btnTaiLai";
			this.btnTaiLai.Size = new System.Drawing.Size(189, 24);
			this.btnTaiLai.Text = "Tải lại danh sách";
			this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
			// 
			// grbDSSV
			// 
			this.grbDSSV.Controls.Add(this.lvSinhVien);
			this.grbDSSV.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.grbDSSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.grbDSSV.Location = new System.Drawing.Point(0, 241);
			this.grbDSSV.Name = "grbDSSV";
			this.grbDSSV.Size = new System.Drawing.Size(899, 334);
			this.grbDSSV.TabIndex = 13;
			this.grbDSSV.TabStop = false;
			this.grbDSSV.Text = "Danh sách sinh viên";
			// 
			// OpenFileDialogHinh
			// 
			this.OpenFileDialogHinh.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
			// 
			// frmSinhVienKhoaCNTT
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(899, 575);
			this.Controls.Add(this.grbDSSV);
			this.Controls.Add(this.grbThongTin);
			this.Controls.Add(this.pbHinh);
			this.Name = "frmSinhVienKhoaCNTT";
			this.Text = "Quản lý thông tin sinh viên khoa CNTT";
			this.Load += new System.EventHandler(this.frmSinhVienKhoaCNTT_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
			this.grbThongTin.ResumeLayout(false);
			this.grbThongTin.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.grbDSSV.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbHinh;
		private System.Windows.Forms.GroupBox grbThongTin;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox grbDSSV;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListView lvSinhVien;
		private System.Windows.Forms.RadioButton rdNu;
		private System.Windows.Forms.RadioButton rdNam;
		private System.Windows.Forms.DateTimePicker dtpNgaySinh;
		private System.Windows.Forms.TextBox txtHinh;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.MaskedTextBox mtxtMSSV;
		private System.Windows.Forms.MaskedTextBox mtxtSoDT;
		private System.Windows.Forms.ComboBox cboLop;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Button btnMacDinh;
		private System.Windows.Forms.OpenFileDialog OpenFileDialogHinh;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem btnXoa;
		private System.Windows.Forms.ToolStripMenuItem btnTaiLai;
	}
}

