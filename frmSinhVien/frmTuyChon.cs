using System;
using System.Windows.Forms;

namespace frmSinhVien
{
	public enum TuyChon
	{
		MaSV,
		HoTen,
		NgaySinh
	}

	public partial class frmTuyChon : Form
	{
		public TuyChon Kieu { get; set; }
		public string ChuoiTim { get; set; }

		public frmTuyChon()
		{
			InitializeComponent();
		}

		private void frmTuyChon_Load(object sender, EventArgs e)
		{
			rdMaSV.Checked = true;
		}

		private void btnSapXep_Click(object sender, EventArgs e)
		{
			if (rdMaSV.Checked) Kieu = TuyChon.MaSV;
			else if (rdHoTen.Checked) Kieu = TuyChon.HoTen;
			else if (rdNgaySinh.Checked) Kieu = TuyChon.NgaySinh;

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtTuKhoa.Text))
			{
				MessageBox.Show("Hãy nhập thông tin tìm!", "Lỗi nhập thông tin",
								MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (rdMaSV.Checked) Kieu = TuyChon.MaSV;
			else if (rdHoTen.Checked) Kieu = TuyChon.HoTen;
			else if (rdNgaySinh.Checked) Kieu = TuyChon.NgaySinh;

			ChuoiTim = txtTuKhoa.Text.Trim();
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}