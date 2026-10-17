using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    public partial class frmTimGiangVien : Form
    {
		private QuanLyGiangVien qlgv;
		public frmTimGiangVien()
        {
            InitializeComponent();
        }
		public void SetQLGV(QuanLyGiangVien qlgv)
		{
			this.qlgv = qlgv;
		}

		
		private void frmTimGiangVien_Load(object sender, EventArgs e)
		{
			rdMaGV.Checked = true;
			lblTimTheo.Text = "Mã GV";
		}

		private void rdMaGV_CheckedChanged(object sender, EventArgs e)
		{
			if (rdMaGV.Checked)
			{
				lblTimTheo.Text = "Mã GV:";
			}
		}
		private void rdHoTen_CheckedChanged(object sender, EventArgs e)
		{
			if (rdHoTen.Checked)
			{
				lblTimTheo.Text = "Họ tên:";
			}
		}
		private void rdSoDT_CheckedChanged(object sender, EventArgs e)
		{
			if (rdSoDT.Checked)
			{
				lblTimTheo.Text = "Số ĐT:";
			}
		}
		private void btnTim_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtTim.Text))
			{
				MessageBox.Show("Vui lòng nhập thông tin cần tìm.");
				return;
			}

			GiangVien gv = null;

			if (rdMaGV.Checked)
			{
				gv = qlgv.Tim(txtTim.Text, qlgv.SoSanhTheoMa);
			}
			else if (rdHoTen.Checked)
			{
				gv = qlgv.Tim(txtTim.Text, qlgv.SoSanhTheoHoTen);
			}
			else if (rdSoDT.Checked)
			{
				gv = qlgv.Tim(txtTim.Text, qlgv.SoSanhTheoSDT);
			}

			if (gv != null)
			{
				frmTBGiangVien frm = new frmTBGiangVien();
				frm.SetText(gv.ToString());
				frm.ShowDialog();
			}
			else
			{
				MessageBox.Show(
					"Không tìm thấy thông tin giảng viên.",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
		}
	}
}
