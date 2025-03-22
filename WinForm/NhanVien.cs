using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    internal class NhanVien
    {
        private string Manv;
        private string Hoten;
        private string Gioitinh;
        private string Ngaysinh;
        private string Diachi;
        private string Sdt;
        private string Email;
        private bool Tinhtrang;
        public NhanVien()
        {
            this.Manv = null;
            this.Hoten = null;
            this.Gioitinh = null;
            this.Ngaysinh = null;
            this.Diachi = null;
            this.Sdt = null;
            this.Email = null;
            this.Tinhtrang = true;
        }
        public NhanVien(string masv, string hoten, string gioitinh, string ngaysinh, string diachi, string sdt, string email, bool tinhtrang)
        {
            Manv = masv;
            Hoten = hoten;
            Gioitinh = gioitinh;
            Ngaysinh = ngaysinh;
            Diachi = diachi;
            Sdt = sdt;
            Email = email;
            Tinhtrang = tinhtrang;
        }
        public string MANV
        {
            get { return this.Manv; }
            set { this.Manv = value; }
        }
        public string HOTEN
        {
            get { return this.Hoten; }
            set { this.Hoten = value; }
        }
        public string GIOITINH
        {
            get { return this.Gioitinh; }
            set { this.Gioitinh = value; }
        }
        public string NGAYSINH
        {
            get { return this.Ngaysinh; }
            set { this.Ngaysinh = value; }
        }
        public string DIACHI
        {
            get { return this.Diachi; }
            set { this.Diachi = value; }
        }
        public string SDT
        {
            get { return this.Sdt; }
            set { this.Sdt = value; }
        }
        public string EMAIL
        {
            get { return this.Email; }
            set { this.Email = value; }
        }
        public bool TINHTRANG
        {
            get { return this.Tinhtrang; }
            set { this.Tinhtrang = value; }
        }
    }
}
