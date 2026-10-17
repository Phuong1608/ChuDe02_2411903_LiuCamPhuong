using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
namespace QLSVKhoaCNTT
{
	public partial class frmSinhVienKhoaCNTT : Form
	{
		private ArrayList dsSinhVien;
		private bool daThayDoi = false;
		public frmSinhVienKhoaCNTT()
		{
			InitializeComponent();
			dsSinhVien = new ArrayList();
		}
		

		
		private SinhVien GetSinhVien()
		{
			SinhVien sv = new SinhVien();

			sv.MSSV = mtxtMSSV.Text;
			sv.HoTen = txtHoTen.Text;
			sv.NgaySinh = dtpNgaySinh.Value;
			sv.Lop = cboLop.Text;
			sv.SoDienThoai = mtxtSoDT.Text;
			sv.Email = txtEmail.Text;
			sv.DiaChi = txtDiaChi.Text;
			sv.Hinh = txtHinh.Text;
			sv.Phai = rdNam.Checked;
			return sv;
		}
		private void HienThiListView()
		{
			lvSinhVien.Items.Clear();
			foreach (SinhVien sv in dsSinhVien)
			{
				ListViewItem item = new ListViewItem(sv.MSSV);
				item.SubItems.Add(sv.HoTen);
				if (sv.Phai)
					item.SubItems.Add("Nam");
				else
					item.SubItems.Add("Nữ");
				item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
				item.SubItems.Add(sv.Lop);
				item.SubItems.Add(sv.SoDienThoai);
				item.SubItems.Add(sv.Email);
				item.SubItems.Add(sv.DiaChi);
				item.SubItems.Add(sv.Hinh);
				lvSinhVien.Items.Add(item);
			}
		}

		private SinhVien TimSinhVien(string mssv)
		{
			foreach (SinhVien sv in dsSinhVien)
			{
				if (sv.MSSV == mssv)
				{
					return sv;
				}
			}
			return null;
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			if (OpenFileDialogHinh.ShowDialog() == DialogResult.OK)
			{
				txtHinh.Text = OpenFileDialogHinh.FileName;
				pbHinh.Image = Image.FromFile(OpenFileDialogHinh.FileName);
			}
		}

		private void btnMacDinh_Click(object sender, EventArgs e)
		{
			mtxtMSSV.Text = "";
			txtHoTen.Text = "";
			txtEmail.Text = "";
			txtDiaChi.Text = "";
			txtHinh.Text = "";
			mtxtSoDT.Text = "";
			dtpNgaySinh.Value = DateTime.Now;
			rdNam.Checked = true;
			cboLop.SelectedIndex = -1;
			pbHinh.Image = null;
		}
		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			SinhVien svMoi = GetSinhVien();
			SinhVien svCu = TimSinhVien(svMoi.MSSV);
			if (svCu != null)
			{
				svCu.HoTen = svMoi.HoTen;
				svCu.Phai = svMoi.Phai;
				svCu.NgaySinh = svMoi.NgaySinh;
				svCu.Lop = svMoi.Lop;
				svCu.SoDienThoai = svMoi.SoDienThoai;
				svCu.Email = svMoi.Email;
				svCu.DiaChi = svMoi.DiaChi;
				svCu.Hinh = svMoi.Hinh;
			}
			else
			{
				dsSinhVien.Add(svMoi);
			}
			HienThiListView();
			daThayDoi = true;
		}

		private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvSinhVien.SelectedItems.Count == 0)
				return;
			ListViewItem item = lvSinhVien.SelectedItems[0];
			mtxtMSSV.Text = item.SubItems[0].Text;
			txtHoTen.Text = item.SubItems[1].Text;
			if (item.SubItems[2].Text == "Nam")
				rdNam.Checked = true;
			else
				rdNu.Checked = true;
			dtpNgaySinh.Value = DateTime.ParseExact
				(item.SubItems[3].Text,"dd/MM/yyyy",null);
			cboLop.Text = item.SubItems[4].Text;
			mtxtSoDT.Text = item.SubItems[5].Text;
			txtEmail.Text = item.SubItems[6].Text;
			txtDiaChi.Text = item.SubItems[7].Text;
			txtHinh.Text = item.SubItems[8].Text;
			if (txtHinh.Text != "" && File.Exists(txtHinh.Text))
			{
				pbHinh.ImageLocation = txtHinh.Text;
			}
			else
			{
				pbHinh.Image = null;
			}
		}

		private void DocFile()
		{
			string duongDan = "DSNV.txt";
			if (!File.Exists(duongDan))
				return;
			string[] dsDong = File.ReadAllLines(duongDan);
			foreach (string dong in dsDong)
			{
				if (dong.Trim() == "")
					continue;
				string[] s = dong.Split('\t');
				if (s.Length < 9)
					continue;

				SinhVien sv = new SinhVien();

				sv.MSSV = s[0];
				sv.HoTen = s[1];
				if (s[2] == "1")
					sv.Phai = true;
				else
					sv.Phai = false;
				sv.NgaySinh = DateTime.ParseExact(s[3],
					"dd/MM/yyyy",null);
				sv.Lop = s[4];
				sv.SoDienThoai = s[5];
				sv.Email = s[6];
				sv.DiaChi = s[7];
				sv.Hinh = s[8];
				dsSinhVien.Add(sv);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (lvSinhVien.SelectedItems.Count == 0)
				return;
			for (int i = lvSinhVien.SelectedItems.Count - 1; i >= 0; i--)
			{
				string mssv = lvSinhVien.SelectedItems[i].SubItems[0].Text;

				SinhVien sv = TimSinhVien(mssv);

				if (sv != null)
				{
					dsSinhVien.Remove(sv);
				}
			}
			HienThiListView();
			daThayDoi = true;
		}
		private void btnTaiLai_Click(object sender, EventArgs e)
		{
			dsSinhVien.Clear();
			DocFile();
			HienThiListView();
			daThayDoi = false;
		}
		private void LuuFile()
		{
			StreamWriter sw = new StreamWriter("DSNV.txt", false);
			foreach (SinhVien sv in dsSinhVien)
			{
				string phai = "0";
				if (sv.Phai)
					phai = "1";
				string dong =
					sv.MSSV + "\t" +
					sv.HoTen + "\t" +
					phai + "\t" +
					sv.NgaySinh.ToString("dd/MM/yyyy") + "\t" +
					sv.Lop + "\t" +
					sv.SoDienThoai + "\t" +
					sv.Email + "\t" +
					sv.DiaChi + "\t" +
					sv.Hinh;
				sw.WriteLine(dong);
			}
			sw.Close();
		}
		private void frmSinhVien_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (daThayDoi)
			{
				DialogResult kq = MessageBox.Show(
					"Danh sách sinh viên đã thay đổi. Bạn có muốn lưu không?",
					"Thông báo",
					MessageBoxButtons.OKCancel,
					MessageBoxIcon.Question);

				if (kq == DialogResult.OK)
				{
					LuuFile();
				}
			}
		}

		private void frmSinhVienKhoaCNTT_Load(object sender, EventArgs e)
		{
			DocFile();
			HienThiListView();
			daThayDoi = false;
		}
	}
}
