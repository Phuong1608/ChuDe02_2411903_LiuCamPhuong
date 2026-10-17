namespace frmSinhVien
{
	partial class frmSinhVien
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBoxTTSV = new System.Windows.Forms.GroupBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tslTongSoSV = new System.Windows.Forms.ToolStripStatusLabel();
			this.btnMacDinh = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.clbChuyenNganh = new System.Windows.Forms.CheckedListBox();
			this.rdNu = new System.Windows.Forms.RadioButton();
			this.rdNam = new System.Windows.Forms.RadioButton();
			this.pbHinh = new System.Windows.Forms.PictureBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.txtHinh = new System.Windows.Forms.TextBox();
			this.cboLop = new System.Windows.Forms.ComboBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.mtxtMaSo = new System.Windows.Forms.MaskedTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBoxDSSV = new System.Windows.Forms.GroupBox();
			this.lvSinhVien = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cmsListView = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmsFont = new System.Windows.Forms.ToolStripMenuItem();
			this.cmsMauChu = new System.Windows.Forms.ToolStripMenuItem();
			this.cmsSapXep = new System.Windows.Forms.ToolStripMenuItem();
			this.cmsTimKiem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenFileDialogHinh = new System.Windows.Forms.OpenFileDialog();
			this.msMain = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuMoFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
			this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuThem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuXoa = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSua = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFont = new System.Windows.Forms.ToolStripMenuItem();
			this.menuMauChu = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSapXep = new System.Windows.Forms.ToolStripMenuItem();
			this.menuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBoxTTSV.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
			this.groupBoxDSSV.SuspendLayout();
			this.cmsListView.SuspendLayout();
			this.msMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 28);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBoxTTSV);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBoxDSSV);
			this.splitContainer1.Size = new System.Drawing.Size(1273, 560);
			this.splitContainer1.SplitterDistance = 569;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 0;
			// 
			// groupBoxTTSV
			// 
			this.groupBoxTTSV.Controls.Add(this.statusStrip1);
			this.groupBoxTTSV.Controls.Add(this.btnMacDinh);
			this.groupBoxTTSV.Controls.Add(this.btnThoat);
			this.groupBoxTTSV.Controls.Add(this.btnSua);
			this.groupBoxTTSV.Controls.Add(this.btnXoa);
			this.groupBoxTTSV.Controls.Add(this.btnThem);
			this.groupBoxTTSV.Controls.Add(this.clbChuyenNganh);
			this.groupBoxTTSV.Controls.Add(this.rdNu);
			this.groupBoxTTSV.Controls.Add(this.rdNam);
			this.groupBoxTTSV.Controls.Add(this.pbHinh);
			this.groupBoxTTSV.Controls.Add(this.btnBrowse);
			this.groupBoxTTSV.Controls.Add(this.txtHinh);
			this.groupBoxTTSV.Controls.Add(this.cboLop);
			this.groupBoxTTSV.Controls.Add(this.txtDiaChi);
			this.groupBoxTTSV.Controls.Add(this.dtpNgaySinh);
			this.groupBoxTTSV.Controls.Add(this.txtHoTen);
			this.groupBoxTTSV.Controls.Add(this.mtxtMaSo);
			this.groupBoxTTSV.Controls.Add(this.label8);
			this.groupBoxTTSV.Controls.Add(this.label7);
			this.groupBoxTTSV.Controls.Add(this.label2);
			this.groupBoxTTSV.Controls.Add(this.label6);
			this.groupBoxTTSV.Controls.Add(this.label5);
			this.groupBoxTTSV.Controls.Add(this.label4);
			this.groupBoxTTSV.Controls.Add(this.label3);
			this.groupBoxTTSV.Controls.Add(this.label1);
			this.groupBoxTTSV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxTTSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxTTSV.Location = new System.Drawing.Point(0, 0);
			this.groupBoxTTSV.Margin = new System.Windows.Forms.Padding(4);
			this.groupBoxTTSV.Name = "groupBoxTTSV";
			this.groupBoxTTSV.Padding = new System.Windows.Forms.Padding(4);
			this.groupBoxTTSV.Size = new System.Drawing.Size(569, 560);
			this.groupBoxTTSV.TabIndex = 0;
			this.groupBoxTTSV.TabStop = false;
			this.groupBoxTTSV.Text = "Thông tin sinh viên";
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTongSoSV});
			this.statusStrip1.Location = new System.Drawing.Point(4, 530);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(561, 26);
			this.statusStrip1.TabIndex = 17;
			this.statusStrip1.Text = "statusStrip1";
			this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
			// 
			// tslTongSoSV
			// 
			this.tslTongSoSV.Name = "tslTongSoSV";
			this.tslTongSoSV.Size = new System.Drawing.Size(138, 20);
			this.tslTongSoSV.Text = "Tổng số sinh viên: 0";
			// 
			// btnMacDinh
			// 
			this.btnMacDinh.Location = new System.Drawing.Point(341, 490);
			this.btnMacDinh.Margin = new System.Windows.Forms.Padding(4);
			this.btnMacDinh.Name = "btnMacDinh";
			this.btnMacDinh.Size = new System.Drawing.Size(107, 31);
			this.btnMacDinh.TabIndex = 15;
			this.btnMacDinh.Text = "Mặc Định";
			this.btnMacDinh.UseVisualStyleBackColor = true;
			this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(468, 490);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(95, 28);
			this.btnThoat.TabIndex = 16;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(239, 490);
			this.btnSua.Margin = new System.Windows.Forms.Padding(4);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(80, 28);
			this.btnSua.TabIndex = 14;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(131, 490);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(84, 28);
			this.btnXoa.TabIndex = 13;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(16, 490);
			this.btnThem.Margin = new System.Windows.Forms.Padding(4);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(81, 28);
			this.btnThem.TabIndex = 12;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// clbChuyenNganh
			// 
			this.clbChuyenNganh.CheckOnClick = true;
			this.clbChuyenNganh.FormattingEnabled = true;
			this.clbChuyenNganh.Items.AddRange(new object[] {
            "Mạng truyền thông",
            "Công nghệ phần mềm",
            "Khoa học máy tính",
            "Trí tuệ nhân tạo",
            "Hệ thống thông tin",
            "Tin học ứng dụng"});
			this.clbChuyenNganh.Location = new System.Drawing.Point(201, 320);
			this.clbChuyenNganh.Margin = new System.Windows.Forms.Padding(4);
			this.clbChuyenNganh.Name = "clbChuyenNganh";
			this.clbChuyenNganh.Size = new System.Drawing.Size(247, 154);
			this.clbChuyenNganh.TabIndex = 11;
			// 
			// rdNu
			// 
			this.rdNu.AutoSize = true;
			this.rdNu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdNu.Location = new System.Drawing.Point(285, 280);
			this.rdNu.Margin = new System.Windows.Forms.Padding(4);
			this.rdNu.Name = "rdNu";
			this.rdNu.Size = new System.Drawing.Size(54, 25);
			this.rdNu.TabIndex = 10;
			this.rdNu.TabStop = true;
			this.rdNu.Text = "Nữ";
			this.rdNu.UseVisualStyleBackColor = true;
			// 
			// rdNam
			// 
			this.rdNam.AutoSize = true;
			this.rdNam.Checked = true;
			this.rdNam.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdNam.Location = new System.Drawing.Point(203, 280);
			this.rdNam.Margin = new System.Windows.Forms.Padding(4);
			this.rdNam.Name = "rdNam";
			this.rdNam.Size = new System.Drawing.Size(66, 25);
			this.rdNam.TabIndex = 9;
			this.rdNam.TabStop = true;
			this.rdNam.Text = "Nam";
			this.rdNam.UseVisualStyleBackColor = true;
			// 
			// pbHinh
			// 
			this.pbHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbHinh.Location = new System.Drawing.Point(20, 35);
			this.pbHinh.Margin = new System.Windows.Forms.Padding(4);
			this.pbHinh.Name = "pbHinh";
			this.pbHinh.Size = new System.Drawing.Size(195, 170);
			this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbHinh.TabIndex = 16;
			this.pbHinh.TabStop = false;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(463, 235);
			this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(56, 28);
			this.btnBrowse.TabIndex = 7;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// txtHinh
			// 
			this.txtHinh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHinh.Location = new System.Drawing.Point(200, 235);
			this.txtHinh.Margin = new System.Windows.Forms.Padding(4);
			this.txtHinh.Name = "txtHinh";
			this.txtHinh.ReadOnly = true;
			this.txtHinh.Size = new System.Drawing.Size(247, 29);
			this.txtHinh.TabIndex = 6;
			// 
			// cboLop
			// 
			this.cboLop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboLop.FormattingEnabled = true;
			this.cboLop.Items.AddRange(new object[] {
            "CTK31",
            "CTK32",
            "CTK33",
            "CTK34",
            "CTK32CD",
            "CTK33CD",
            "CTK34CD"});
			this.cboLop.Location = new System.Drawing.Point(338, 185);
			this.cboLop.Margin = new System.Windows.Forms.Padding(4);
			this.cboLop.Name = "cboLop";
			this.cboLop.Size = new System.Drawing.Size(132, 29);
			this.cboLop.TabIndex = 5;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiaChi.Location = new System.Drawing.Point(338, 145);
			this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(228, 29);
			this.txtDiaChi.TabIndex = 4;
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.CalendarFont = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
			this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgaySinh.Location = new System.Drawing.Point(338, 105);
			this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(132, 30);
			this.dtpNgaySinh.TabIndex = 3;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHoTen.Location = new System.Drawing.Point(338, 68);
			this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(225, 29);
			this.txtHoTen.TabIndex = 2;
			// 
			// mtxtMaSo
			// 
			this.mtxtMaSo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtMaSo.Location = new System.Drawing.Point(338, 32);
			this.mtxtMaSo.Margin = new System.Windows.Forms.Padding(4);
			this.mtxtMaSo.Mask = "SV.00000";
			this.mtxtMaSo.Name = "mtxtMaSo";
			this.mtxtMaSo.Size = new System.Drawing.Size(132, 29);
			this.mtxtMaSo.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(53, 320);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(131, 22);
			this.label8.TabIndex = 8;
			this.label8.Text = "Chuyên Ngành";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(53, 280);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 22);
			this.label7.TabIndex = 7;
			this.label7.Text = "Giới Tính";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(53, 238);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 22);
			this.label2.TabIndex = 6;
			this.label2.Text = "Hình";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(235, 71);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 22);
			this.label6.TabIndex = 5;
			this.label6.Text = "Họ Tên";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(235, 187);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 22);
			this.label5.TabIndex = 4;
			this.label5.Text = "Lớp";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(235, 148);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 22);
			this.label4.TabIndex = 3;
			this.label4.Text = "Địa Chỉ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(235, 110);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 22);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ngày Sinh";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(235, 35);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã Số";
			// 
			// groupBoxDSSV
			// 
			this.groupBoxDSSV.Controls.Add(this.lvSinhVien);
			this.groupBoxDSSV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxDSSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxDSSV.Location = new System.Drawing.Point(0, 0);
			this.groupBoxDSSV.Margin = new System.Windows.Forms.Padding(4);
			this.groupBoxDSSV.Name = "groupBoxDSSV";
			this.groupBoxDSSV.Padding = new System.Windows.Forms.Padding(4);
			this.groupBoxDSSV.Size = new System.Drawing.Size(699, 560);
			this.groupBoxDSSV.TabIndex = 0;
			this.groupBoxDSSV.TabStop = false;
			this.groupBoxDSSV.Text = "Danh sách sinh viên";
			// 
			// lvSinhVien
			// 
			this.lvSinhVien.CheckBoxes = true;
			this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
			this.lvSinhVien.ContextMenuStrip = this.cmsListView;
			this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvSinhVien.FullRowSelect = true;
			this.lvSinhVien.GridLines = true;
			this.lvSinhVien.HideSelection = false;
			this.lvSinhVien.Location = new System.Drawing.Point(4, 27);
			this.lvSinhVien.Margin = new System.Windows.Forms.Padding(4);
			this.lvSinhVien.Name = "lvSinhVien";
			this.lvSinhVien.Size = new System.Drawing.Size(691, 529);
			this.lvSinhVien.TabIndex = 17;
			this.lvSinhVien.UseCompatibleStateImageBehavior = false;
			this.lvSinhVien.View = System.Windows.Forms.View.Details;
			this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã số";
			this.columnHeader1.Width = 95;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Họ tên";
			this.columnHeader2.Width = 130;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Ngày sinh";
			this.columnHeader3.Width = 85;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Địa chỉ";
			this.columnHeader4.Width = 75;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Lớp";
			this.columnHeader5.Width = 65;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Hình";
			this.columnHeader6.Width = 100;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Giới tính";
			this.columnHeader7.Width = 70;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Chuyên ngành";
			this.columnHeader8.Width = 480;
			// 
			// cmsListView
			// 
			this.cmsListView.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmsListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsFont,
            this.cmsMauChu,
            this.cmsSapXep,
            this.cmsTimKiem});
			this.cmsListView.Name = "cmsListView";
			this.cmsListView.Size = new System.Drawing.Size(140, 100);
			// 
			// cmsFont
			// 
			this.cmsFont.Name = "cmsFont";
			this.cmsFont.Size = new System.Drawing.Size(210, 24);
			this.cmsFont.Text = "Font";
			this.cmsFont.Click += new System.EventHandler(this.menuFont_Click);
			// 
			// cmsMauChu
			// 
			this.cmsMauChu.Name = "cmsMauChu";
			this.cmsMauChu.Size = new System.Drawing.Size(210, 24);
			this.cmsMauChu.Text = "Màu chữ";
			this.cmsMauChu.Click += new System.EventHandler(this.menuMauChu_Click);
			// 
			// cmsSapXep
			// 
			this.cmsSapXep.Name = "cmsSapXep";
			this.cmsSapXep.Size = new System.Drawing.Size(210, 24);
			this.cmsSapXep.Text = "Sắp xếp";
			this.cmsSapXep.Click += new System.EventHandler(this.menuSapXep_Click);
			// 
			// cmsTimKiem
			// 
			this.cmsTimKiem.Name = "cmsTimKiem";
			this.cmsTimKiem.Size = new System.Drawing.Size(210, 24);
			this.cmsTimKiem.Text = "Tìm kiếm";
			this.cmsTimKiem.Click += new System.EventHandler(this.menuTimKiem_Click);
			// 
			// OpenFileDialogHinh
			// 
			this.OpenFileDialogHinh.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
			// 
			// msMain
			// 
			this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit});
			this.msMain.Location = new System.Drawing.Point(0, 0);
			this.msMain.Name = "msMain";
			this.msMain.Size = new System.Drawing.Size(1273, 28);
			this.msMain.TabIndex = 1;
			this.msMain.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMoFile,
            this.menuThoat});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(46, 24);
			this.menuFile.Text = "File";
			// 
			// menuMoFile
			// 
			this.menuMoFile.Name = "menuMoFile";
			this.menuMoFile.Size = new System.Drawing.Size(224, 26);
			this.menuMoFile.Text = "Mở File";
			this.menuMoFile.Click += new System.EventHandler(this.menuMoFile_Click);
			// 
			// menuThoat
			// 
			this.menuThoat.Name = "menuThoat";
			this.menuThoat.Size = new System.Drawing.Size(224, 26);
			this.menuThoat.Text = "Thoát";
			this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);
			// 
			// menuEdit
			// 
			this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThem,
            this.menuXoa,
            this.menuSua,
            this.menuFont,
            this.menuMauChu,
            this.menuSapXep,
            this.menuTimKiem});
			this.menuEdit.Name = "menuEdit";
			this.menuEdit.Size = new System.Drawing.Size(49, 24);
			this.menuEdit.Text = "Edit";
			// 
			// menuThem
			// 
			this.menuThem.Name = "menuThem";
			this.menuThem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
			this.menuThem.Size = new System.Drawing.Size(224, 26);
			this.menuThem.Text = "Thêm";
			this.menuThem.Click += new System.EventHandler(this.menuThem_Click);
			// 
			// menuXoa
			// 
			this.menuXoa.Name = "menuXoa";
			this.menuXoa.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Y)));
			this.menuXoa.Size = new System.Drawing.Size(224, 26);
			this.menuXoa.Text = "Xóa";
			this.menuXoa.Click += new System.EventHandler(this.menuXoa_Click);
			// 
			// menuSua
			// 
			this.menuSua.Name = "menuSua";
			this.menuSua.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
			this.menuSua.Size = new System.Drawing.Size(224, 26);
			this.menuSua.Text = "Sửa";
			this.menuSua.Click += new System.EventHandler(this.menuSua_Click);
			// 
			// menuFont
			// 
			this.menuFont.Name = "menuFont";
			this.menuFont.Size = new System.Drawing.Size(224, 26);
			this.menuFont.Text = "Font";
			this.menuFont.Click += new System.EventHandler(this.menuFont_Click);
			// 
			// menuMauChu
			// 
			this.menuMauChu.Name = "menuMauChu";
			this.menuMauChu.Size = new System.Drawing.Size(224, 26);
			this.menuMauChu.Text = "Màu chữ";
			this.menuMauChu.Click += new System.EventHandler(this.menuMauChu_Click);
			// 
			// menuSapXep
			// 
			this.menuSapXep.Name = "menuSapXep";
			this.menuSapXep.Size = new System.Drawing.Size(224, 26);
			this.menuSapXep.Text = "Sắp xếp";
			this.menuSapXep.Click += new System.EventHandler(this.menuSapXep_Click);
			// 
			// menuTimKiem
			// 
			this.menuTimKiem.Name = "menuTimKiem";
			this.menuTimKiem.Size = new System.Drawing.Size(224, 26);
			this.menuTimKiem.Text = "Tìm kiếm";
			this.menuTimKiem.Click += new System.EventHandler(this.menuTimKiem_Click);
			// 
			// frmSinhVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1273, 588);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.msMain);
			this.MainMenuStrip = this.msMain;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmSinhVien";
			this.Text = "Demo Sinh Viên";
			this.Load += new System.EventHandler(this.frmSinhVien_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBoxTTSV.ResumeLayout(false);
			this.groupBoxTTSV.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
			this.groupBoxDSSV.ResumeLayout(false);
			this.cmsListView.ResumeLayout(false);
			this.msMain.ResumeLayout(false);
			this.msMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox groupBoxTTSV;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBoxDSSV;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpNgaySinh;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.MaskedTextBox mtxtMaSo;
		private System.Windows.Forms.ComboBox cboLop;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.CheckedListBox clbChuyenNganh;
		private System.Windows.Forms.RadioButton rdNu;
		private System.Windows.Forms.RadioButton rdNam;
		private System.Windows.Forms.PictureBox pbHinh;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtHinh;
		private System.Windows.Forms.Button btnMacDinh;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.ListView lvSinhVien;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.OpenFileDialog OpenFileDialogHinh;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tslTongSoSV;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;

		// Menu control declarations
		private System.Windows.Forms.MenuStrip msMain;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem menuMoFile;
		private System.Windows.Forms.ToolStripMenuItem menuThoat;
		private System.Windows.Forms.ToolStripMenuItem menuEdit;
		private System.Windows.Forms.ToolStripMenuItem menuThem;
		private System.Windows.Forms.ToolStripMenuItem menuXoa;
		private System.Windows.Forms.ToolStripMenuItem menuSua;
		private System.Windows.Forms.ToolStripMenuItem menuFont;
		private System.Windows.Forms.ToolStripMenuItem menuMauChu;
		private System.Windows.Forms.ToolStripMenuItem menuSapXep;
		private System.Windows.Forms.ToolStripMenuItem menuTimKiem;
		private System.Windows.Forms.ContextMenuStrip cmsListView;
		private System.Windows.Forms.ToolStripMenuItem cmsFont;
		private System.Windows.Forms.ToolStripMenuItem cmsMauChu;
		private System.Windows.Forms.ToolStripMenuItem cmsSapXep;
		private System.Windows.Forms.ToolStripMenuItem cmsTimKiem;
	}
}