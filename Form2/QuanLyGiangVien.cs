using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form2
{
    public enum KieuTim
    {
        TheoMa,
        TheoHoTen,
        TheoSDT
    }
    public delegate int SoSanh(object a, object b);

    public class QuanLyGiangVien

    {
        private List<GiangVien> dsGiangVien;

        public GiangVien this[int index]
        {
            get { return this.dsGiangVien[index]; }
            set { this.dsGiangVien[index] = value; }
        }

        public QuanLyGiangVien()
        {
            this.dsGiangVien = new List<GiangVien>();
        }

        public void SapXep(SoSanh ss)
        {
            for (int i = 0; i < this.dsGiangVien.Count - 1; i++)
            {
                for (int j = i + 1; j < this.dsGiangVien.Count; j++)
                {
                    if (ss(this.dsGiangVien[i], this.dsGiangVien[j]) > 0)
                    {
                        GiangVien temp = this.dsGiangVien[i];
                        this.dsGiangVien[i] = this.dsGiangVien[j];
                        this.dsGiangVien[j] = temp;
                    }
                }
            }
        }
        
		public void Them(GiangVien gv)
        {
            this.dsGiangVien.Add(gv);
        }

        public GiangVien Tim(object temp, SoSanh ss)
        {
            for (int i = 0; i < this.dsGiangVien.Count; i++)
            {
                if (ss(this.dsGiangVien[i], temp) == 0)
                {
                    return this.dsGiangVien[i];
                }
            }

            return null;
        }

        public GiangVien Xoa(object temp, SoSanh ss)
        {
            GiangVien gv = this.Tim(temp, ss);

            if (gv != null)
            {
                this.dsGiangVien.Remove(gv);
            }

            return gv;
        }
		public int SoSanhTheoMa(object a, object b)
		{
			GiangVien gv = a as GiangVien;
			string maSo = b.ToString();

			return string.Compare(gv.MaSo, maSo);
		}
		public int SoSanhTheoHoTen(object a, object b)
		{
			GiangVien gv = a as GiangVien;
			string hoTen = b.ToString();

			return string.Compare(gv.HoTen, hoTen);
		}

		public int SoSanhTheoSDT(object a, object b)
		{
			GiangVien gv = a as GiangVien;
			string soDT = b.ToString();

			return string.Compare(gv.SoDT, soDT);
		}
	}
}

