namespace Form2
{
    partial class frmGiangVien
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
			this.lbl1 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cboMaSo = new System.Windows.Forms.ComboBox();
			this.rdNam = new System.Windows.Forms.RadioButton();
			this.rdNu = new System.Windows.Forms.RadioButton();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.mtxtSoDT = new System.Windows.Forms.MaskedTextBox();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.chklbNgoaiNgu = new System.Windows.Forms.CheckedListBox();
			this.lbDanhSachHP = new System.Windows.Forms.ListBox();
			this.lbHocPhanDay = new System.Windows.Forms.ListBox();
			this.btnChon = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThongBao = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.linhlbLienHe = new System.Windows.Forms.LinkLabel();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnTim = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lbl1.Location = new System.Drawing.Point(53, 5);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(567, 35);
			this.lbl1.TabIndex = 0;
			this.lbl1.Text = "THÔNG TIN GIẢNG VIÊN KHOA CNTT";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mã Số";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Họ Tên";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Ngày Sinh";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 156);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Ngoại Ngữ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(289, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Giới Tính";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(289, 91);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "Số ĐT";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(289, 126);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(108, 23);
			this.label7.TabIndex = 7;
			this.label7.Text = "Địa chỉ mail";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(114, 271);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(170, 23);
			this.label8.TabIndex = 8;
			this.label8.Text = "Danh sách môn học";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(365, 271);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(196, 23);
			this.label9.TabIndex = 9;
			this.label9.Text = "Môn học giáo viên dạy";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(447, 507);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(68, 19);
			this.label10.TabIndex = 10;
			this.label10.Text = "Website";
			// 
			// cboMaSo
			// 
			this.cboMaSo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboMaSo.FormattingEnabled = true;
			this.cboMaSo.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004"});
			this.cboMaSo.Location = new System.Drawing.Point(115, 50);
			this.cboMaSo.Name = "cboMaSo";
			this.cboMaSo.Size = new System.Drawing.Size(103, 29);
			this.cboMaSo.TabIndex = 11;
			// 
			// rdNam
			// 
			this.rdNam.AutoSize = true;
			this.rdNam.Checked = true;
			this.rdNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdNam.Location = new System.Drawing.Point(386, 50);
			this.rdNam.Name = "rdNam";
			this.rdNam.Size = new System.Drawing.Size(68, 26);
			this.rdNam.TabIndex = 12;
			this.rdNam.TabStop = true;
			this.rdNam.Text = "Nam";
			this.rdNam.UseVisualStyleBackColor = true;
			// 
			// rdNu
			// 
			this.rdNu.AutoSize = true;
			this.rdNu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdNu.Location = new System.Drawing.Point(451, 50);
			this.rdNu.Name = "rdNu";
			this.rdNu.Size = new System.Drawing.Size(56, 26);
			this.rdNu.TabIndex = 13;
			this.rdNu.Text = "Nữ";
			this.rdNu.UseVisualStyleBackColor = true;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHoTen.Location = new System.Drawing.Point(115, 85);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(156, 29);
			this.txtHoTen.TabIndex = 14;
			// 
			// mtxtSoDT
			// 
			this.mtxtSoDT.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtSoDT.Location = new System.Drawing.Point(386, 89);
			this.mtxtSoDT.Mask = "(\\0633).000.000";
			this.mtxtSoDT.Name = "mtxtSoDT";
			this.mtxtSoDT.Size = new System.Drawing.Size(120, 29);
			this.mtxtSoDT.TabIndex = 15;
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.CalendarFont = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpNgaySinh.CustomFormat = "dd/MM/yyy";
			this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgaySinh.Location = new System.Drawing.Point(115, 123);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(156, 29);
			this.dtpNgaySinh.TabIndex = 16;
			// 
			// txtMail
			// 
			this.txtMail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMail.Location = new System.Drawing.Point(386, 120);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(149, 29);
			this.txtMail.TabIndex = 17;
			// 
			// chklbNgoaiNgu
			// 
			this.chklbNgoaiNgu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chklbNgoaiNgu.FormattingEnabled = true;
			this.chklbNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật",
            "Tiếng Nga"});
			this.chklbNgoaiNgu.Location = new System.Drawing.Point(115, 159);
			this.chklbNgoaiNgu.Name = "chklbNgoaiNgu";
			this.chklbNgoaiNgu.Size = new System.Drawing.Size(156, 100);
			this.chklbNgoaiNgu.TabIndex = 18;
			// 
			// lbDanhSachHP
			// 
			this.lbDanhSachHP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDanhSachHP.FormattingEnabled = true;
			this.lbDanhSachHP.ItemHeight = 21;
			this.lbDanhSachHP.Items.AddRange(new object[] {
            "Tin học cơ sở ",
            "Lập trình cấu trúc C/C++",
            "Cở sở dữ liệu",
            "Tiếng Anh B1",
            "Tiếng Anh B2",
            "Lập trình hướng đối tượng",
            "Mạng máy tính",
            "Công nghệ phần mềm",
            "Phân tích TKHDT"});
			this.lbDanhSachHP.Location = new System.Drawing.Point(113, 298);
			this.lbDanhSachHP.Name = "lbDanhSachHP";
			this.lbDanhSachHP.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lbDanhSachHP.Size = new System.Drawing.Size(171, 151);
			this.lbDanhSachHP.TabIndex = 19;
			// 
			// lbHocPhanDay
			// 
			this.lbHocPhanDay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbHocPhanDay.FormattingEnabled = true;
			this.lbHocPhanDay.ItemHeight = 21;
			this.lbHocPhanDay.Location = new System.Drawing.Point(369, 298);
			this.lbHocPhanDay.Name = "lbHocPhanDay";
			this.lbHocPhanDay.Size = new System.Drawing.Size(156, 130);
			this.lbHocPhanDay.TabIndex = 20;
			// 
			// btnChon
			// 
			this.btnChon.Location = new System.Drawing.Point(314, 331);
			this.btnChon.Name = "btnChon";
			this.btnChon.Size = new System.Drawing.Size(37, 23);
			this.btnChon.TabIndex = 21;
			this.btnChon.Text = ">>";
			this.btnChon.UseVisualStyleBackColor = true;
			this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(314, 372);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(37, 23);
			this.btnXoa.TabIndex = 22;
			this.btnXoa.Text = "<<";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThongBao
			// 
			this.btnThongBao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThongBao.ForeColor = System.Drawing.Color.Blue;
			this.btnThongBao.Location = new System.Drawing.Point(271, 467);
			this.btnThongBao.Name = "btnThongBao";
			this.btnThongBao.Size = new System.Drawing.Size(109, 32);
			this.btnThongBao.TabIndex = 23;
			this.btnThongBao.Text = "Thông Báo";
			this.btnThongBao.UseVisualStyleBackColor = true;
			this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.Red;
			this.btnCancel.Location = new System.Drawing.Point(400, 466);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(106, 32);
			this.btnCancel.TabIndex = 24;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.Color.Blue;
			this.btnExit.Location = new System.Drawing.Point(531, 466);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(80, 32);
			this.btnExit.TabIndex = 25;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			// 
			// linhlbLienHe
			// 
			this.linhlbLienHe.AutoSize = true;
			this.linhlbLienHe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linhlbLienHe.Location = new System.Drawing.Point(541, 507);
			this.linhlbLienHe.Name = "linhlbLienHe";
			this.linhlbLienHe.Size = new System.Drawing.Size(60, 19);
			this.linhlbLienHe.TabIndex = 26;
			this.linhlbLienHe.TabStop = true;
			this.linhlbLienHe.Text = "Liên hệ";
			this.linhlbLienHe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLienHe_LinkClicked);
			// 
			// btnThem
			// 
			this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.Color.DarkGreen;
			this.btnThem.Location = new System.Drawing.Point(164, 467);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(68, 32);
			this.btnThem.TabIndex = 27;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnTim
			// 
			this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnTim.ForeColor = System.Drawing.Color.Blue;
			this.btnTim.Location = new System.Drawing.Point(72, 466);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(57, 33);
			this.btnTim.TabIndex = 28;
			this.btnTim.Text = "Tìm";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// frmGiangVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(623, 530);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.linhlbLienHe);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnThongBao);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnChon);
			this.Controls.Add(this.lbHocPhanDay);
			this.Controls.Add(this.lbDanhSachHP);
			this.Controls.Add(this.chklbNgoaiNgu);
			this.Controls.Add(this.txtMail);
			this.Controls.Add(this.dtpNgaySinh);
			this.Controls.Add(this.mtxtSoDT);
			this.Controls.Add(this.txtHoTen);
			this.Controls.Add(this.rdNu);
			this.Controls.Add(this.rdNam);
			this.Controls.Add(this.cboMaSo);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmGiangVien";
			this.Text = "Thông tin giảng viên";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboMaSo;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.MaskedTextBox mtxtSoDT;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.CheckedListBox chklbNgoaiNgu;
        private System.Windows.Forms.ListBox lbDanhSachHP;
        private System.Windows.Forms.ListBox lbHocPhanDay;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThongBao;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel linhlbLienHe;
        private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnTim;
	}
}

