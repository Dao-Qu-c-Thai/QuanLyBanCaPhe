using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDungNhomNguoiDung
    {
        string tenDN;
        string maNhom;
        string ghiChu;

        public string TenDN { get => tenDN; set => tenDN = value; }
        public string MaNhom { get => maNhom; set => maNhom = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
