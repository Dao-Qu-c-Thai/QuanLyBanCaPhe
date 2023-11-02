using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVien_DAL
    {
        QUANLYCAPHE1DataContext data = new QUANLYCAPHE1DataContext();
        public NhanVien_DAL() { }

        public List<NHANVIEN> getData()
        {
            return data.NHANVIENs.Select(k=>k).ToList();
        }
    }
}
