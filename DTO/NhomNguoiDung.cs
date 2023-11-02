using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhomNguoiDung
    {
        string maNhom;
        string tenNhom;
        string ghiChu;

        public string MaNhom { get => maNhom; set => maNhom = value; }
        public string TenNhom { get => tenNhom; set => tenNhom = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
