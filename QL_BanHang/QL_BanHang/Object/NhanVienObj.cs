using System;
using System.Collections.Generic;
using System.Text;

namespace QL_BanHang.Object
{
    class NhanVienObj
    {
        string ma, ten, gioitinh, sdt, matkhau ,diachi;
        DateTime namsinh;

        public DateTime NamSinh { get => namsinh; set => namsinh = value; }
        public string MatKhau { get => matkhau; set => matkhau = value; }
        public string MaNhanVien { get => ma; set => ma = value; }
        public string TenNhanVien { get => ten; set => ten = value; }
        public string GioiTinh { get => gioitinh; set => gioitinh = value; }
        public string SDT { get => sdt; set => sdt = value; }
        public string DiaChi { get => diachi; set => diachi = value; }

        public NhanVienObj() { }
        public NhanVienObj(string ma , string ten , string gioitinh , string sdt , string matkhau, DateTime namsinh,string diachi)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.sdt = sdt;
            this.matkhau = matkhau;
            this.namsinh = namsinh;
            this.diachi = diachi;
            
        }
    }
}
