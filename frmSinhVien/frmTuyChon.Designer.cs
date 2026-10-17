namespace frmSinhVien
{
	partial class frmTuyChon
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
			this.gbThongTin = new System.Windows.Forms.GroupBox();
			this.rdNgaySinh = new System.Windows.Forms.RadioButton();
			this.rdHoTen = new System.Windows.Forms.RadioButton();
			this.rdMaSV = new System.Windows.Forms.RadioButton();
			this.lblNhapThongTin = new System.Windows.Forms.Label();
			this.txtTuKhoa = new System.Windows.Forms.TextBox();
			this.btnTim = new System.Windows.Forms.Button();
			this.btnSapXep = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.gbThongTin.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbThongTin
			// 
			this.gbThongTin.Controls.Add(this.rdNgaySinh);
			this.gbThongTin.Controls.Add(this.rdHoTen);
			this.gbThongTin.Controls.Add(this.rdMaSV);
			this.gbThongTin.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbThongTin.Location = new System.Drawing.Point(30, 20);
			this.gbThongTin.Name = "gbThongTin";
			this.gbThongTin.Size = new System.Drawing.Size(480, 80);
			this.gbThongTin.TabIndex = 0;
			this.gbThongTin.TabStop = false;
			this.gbThongTin.Text = "Chọn thông tin";
			// 
			// rdNgaySinh
			// 
			this.rdNgaySinh.AutoSize = true;
			this.rdNgaySinh.Location = new System.Drawing.Point(330, 35);
			this.rdNgaySinh.Name = "rdNgaySinh";
			this.rdNgaySinh.Size = new System.Drawing.Size(102, 24);
			this.rdNgaySinh.TabIndex = 2;
			this.rdNgaySinh.TabStop = true;
			this.rdNgaySinh.Text = "Ngày Sinh";
			this.rdNgaySinh.UseVisualStyleBackColor = true;
			// 
			// rdHoTen
			// 
			this.rdHoTen.AutoSize = true;
			this.rdHoTen.Location = new System.Drawing.Point(180, 35);
			this.rdHoTen.Name = "rdHoTen";
			this.rdHoTen.Size = new System.Drawing.Size(87, 24);
			this.rdHoTen.TabIndex = 1;
			this.rdHoTen.TabStop = true;
			this.rdHoTen.Text = "Họ Tên";
			this.rdHoTen.UseVisualStyleBackColor = true;
			// 
			// rdMaSV
			// 
			this.rdMaSV.AutoSize = true;
			this.rdMaSV.Checked = true;
			this.rdMaSV.Location = new System.Drawing.Point(30, 35);
			this.rdMaSV.Name = "rdMaSV";
			this.rdMaSV.Size = new System.Drawing.Size(83, 24);
			this.rdMaSV.TabIndex = 0;
			this.rdMaSV.TabStop = true;
			this.rdMaSV.Text = "Mã SV";
			this.rdMaSV.UseVisualStyleBackColor = true;
			// 
			// lblNhapThongTin
			// 
			this.lblNhapThongTin.AutoSize = true;
			this.lblNhapThongTin.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNhapThongTin.Location = new System.Drawing.Point(30, 120);
			this.lblNhapThongTin.Name = "lblNhapThongTin";
			this.lblNhapThongTin.Size = new System.Drawing.Size(121, 20);
			this.lblNhapThongTin.TabIndex = 1;
			this.lblNhapThongTin.Text = "Nhập thông tin:";
			// 
			// txtTuKhoa
			// 
			this.txtTuKhoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTuKhoa.Location = new System.Drawing.Point(160, 117);
			this.txtTuKhoa.Name = "txtTuKhoa";
			this.txtTuKhoa.Size = new System.Drawing.Size(350, 28);
			this.txtTuKhoa.TabIndex = 2;
			// 
			// btnTim
			// 
			this.btnTim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTim.Location = new System.Drawing.Point(210, 165);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(90, 32);
			this.btnTim.TabIndex = 4;
			this.btnTim.Text = "Tìm";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// btnSapXep
			// 
			this.btnSapXep.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSapXep.Location = new System.Drawing.Point(310, 165);
			this.btnSapXep.Name = "btnSapXep";
			this.btnSapXep.Size = new System.Drawing.Size(90, 32);
			this.btnSapXep.TabIndex = 3;
			this.btnSapXep.Text = "Sắp xếp";
			this.btnSapXep.UseVisualStyleBackColor = true;
			this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Location = new System.Drawing.Point(410, 165);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(100, 32);
			this.btnThoat.TabIndex = 5;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// frmTuyChon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 220);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnSapXep);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.txtTuKhoa);
			this.Controls.Add(this.lblNhapThongTin);
			this.Controls.Add(this.gbThongTin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTuyChon";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Tùy Chọn";
			this.Load += new System.EventHandler(this.frmTuyChon_Load);
			this.gbThongTin.ResumeLayout(false);
			this.gbThongTin.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbThongTin;
		private System.Windows.Forms.RadioButton rdNgaySinh;
		private System.Windows.Forms.RadioButton rdHoTen;
		private System.Windows.Forms.RadioButton rdMaSV;
		private System.Windows.Forms.Label lblNhapThongTin;
		private System.Windows.Forms.TextBox txtTuKhoa;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.Button btnSapXep;
		private System.Windows.Forms.Button btnThoat;
	}
}