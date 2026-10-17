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
    public partial class frmTBGiangVien : Form
    {
        public frmTBGiangVien()
        {
            InitializeComponent();
        }
        public void SetText (string s)
        {
            this.lblThongBao.Text = s;
        }

        private void frmGiangVien_Load (object sender, EventArgs e)
        {
            string lienHe = "https://cntt.dlu.edu.vn/";
            this.linhlbLienHe.Links.Add(0, lienHe.Length, lienHe);
            this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];            
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDanhSachHP.SelectedItems.Count - 1;

            while (i >= 0)
            {
                this.lbHocPhanDay.Items.Add(
                    this.lbDanhSachHP.SelectedItems[i]);

                this.lbDanhSachHP.Items.Remove(
                    this.lbDanhSachHP.SelectedItems[i]);

                i--;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbHocPhanDay.SelectedItems.Count - 1;

            while (i >= 0)
            {
                this.lbDanhSachHP.Items.Add(
                    this.lbHocPhanDay.SelectedItems[i]);

                this.lbHocPhanDay.Items.Remove(
                    this.lbHocPhanDay.SelectedItems[i]);

                i--;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        public void Reset()
        {
            this.cboMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.mtxtSoDT.Text = "";
            this.rdNam.Checked = true;

            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
                chklbNgoaiNgu.SetItemChecked(i, false);

            foreach (object ob in this.lbHocPhanDay.Items)
            {
                this.lbDanhSachHP.Items.Add(ob);
            }

            this.lbHocPhanDay.Items.Clear();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            frmTBGiangVien frm = new frmTBGiangVien();
            frm.SetText(GetGiangVien().ToString());
            frm.ShowDialog();
        }

        //Lấy thông tin của giảng viên được nhập trên form
        public GiangVien GetGiangVien()
        {
            string gt = "Nam";
            if (rdNu.Checked)
                gt = "Nữ";

            GiangVien gv = new GiangVien();
            gv.MaSo = this.cboMaSo.Text;
            gv.GioiTinh = gt;
            gv.HoTen = this.txtHoTen.Text;
            gv.NgaySinh = this.dtpNgaySinh.Value;
            gv.Mail = this.txtMail.Text;
            gv.SoDT = this.mtxtSoDT.Text;

            string ngoaiNgu = "";
            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
            {
                if (chklbNgoaiNgu.GetItemChecked(i))
                    ngoaiNgu += chklbNgoaiNgu.Items[i] + ";";
            }

            gv.NgoaiNgu = ngoaiNgu.Split(';');

            DanhMucHocPhan dshp = new DanhMucHocPhan();
            foreach (object hp in lbHocPhanDay.Items)
            {
                dshp.Them(new HocPhan(hp.ToString()));
            }

            gv.dsHocPhan = dshp;
            return gv;
        }
        private void linklblLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strlink = e.Link.LinkData.ToString();
            //Process.Start(strlink);
        }


    }

    public class HocPhan
    {
        public int ID { get; set; }
        public string TenHP { get; set; }
        public int SoTC { get; set; }

        public HocPhan(string ten)
        {
            this.TenHP = ten;
        }
        public HocPhan(int id, string ten, int tc)
        {
            this.ID = id;
            this.TenHP = ten;
            this.SoTC = tc;
        }
        public override string ToString()
        {
            return TenHP;
        }
    }

    public class DanhMucHocPhan
    {
        public List<HocPhan> ds;
        public DanhMucHocPhan()
        {
            ds = new List<HocPhan>();
        }
        public HocPhan this[int index]
        {
            get { return ds[index] as HocPhan; }
            set { ds[index] = value; }
        }
        public void Them(HocPhan hp)
        {
            ds.Add(hp);
        }
        public override string ToString()
        {
            string s = "Danh sach mon hoc: ";
            foreach (object mh in ds)
            {
                s += mh as HocPhan + ";";
            }
            return s;
        }
    }

    public class GiangVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public DanhMucHocPhan dsHocPhan;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string SoDT;
        public string Mail;
        public GiangVien()
        {
            dsHocPhan = new DanhMucHocPhan();
            NgoaiNgu = new string[20];
        }
            public GiangVien(
            string maso,
            string sdt,
            string mail,
            string hoten,
            DateTime ngaysinh,
            DanhMucHocPhan ds,
            string[] nn,
            string gt)
        {
            this.MaSo = maso;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.dsHocPhan = ds;
            this.NgoaiNgu = nn;
            this.SoDT = sdt;
            this.Mail = mail;
            this.GioiTinh = gt;
        }
        public override string ToString()
        {
            string s = "Mã số: " + MaSo + "\n"
                     + "Họ tên: " + HoTen + "\n"
                     + "Ngày sinh: " + NgaySinh + "\n"
                     + "Giới tính: " + GioiTinh + "\n"
                     + "Số ĐT: " + SoDT + "\n"
                     + "Mail: " + Mail + "\n";
            string sngoaiNgu = "Ngoại ngữ: ";
            foreach (string t in NgoaiNgu)            
                sngoaiNgu += t + ";";            
            string monDay = "Danh sách môn dạy: ";
            foreach (HocPhan hp in dsHocPhan.ds)
            {
                monDay += hp + ";";
            }
            s += "\n" + sngoaiNgu + "\n" + monDay;
            return s;
        }
    }



}
