using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDung
    {
        string tenDangNhap;
        string matKhau;
        bool hoatDong;

        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public bool HoatDong { get => hoatDong; set => hoatDong = value; }
    }
}
