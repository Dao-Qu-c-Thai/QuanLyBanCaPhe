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
        public List<NHANVIEN> searchNV(NHANVIEN n)
        {
            List<NHANVIEN> list = new List<NHANVIEN>();
            var lst = from nv in data.NHANVIENs where nv.TENNV==n.TENNV select nv;
            list.AddRange(lst);
            return list;
        }
        public bool themNhanVien(NHANVIEN nv)
        {
            try
            {
                data.NHANVIENs.InsertOnSubmit(nv);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public bool deleteNhanVien(NHANVIEN nv)
        {
            try
            {
                NHANVIEN nhanvien = data.NHANVIENs.Where(n => n.MANV == nv.MANV).FirstOrDefault();
                if (nhanvien != null)
                {
                    data.NHANVIENs.DeleteOnSubmit(nv);
                    data.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateNhanVien(NHANVIEN nv)
        {
            try
            {
                NHANVIEN nhanvien = data.NHANVIENs.Where(n => n.MANV == nv.MANV).FirstOrDefault();
                if (nhanvien != null)
                {
                    nhanvien.TENNV = nv.TENNV;
                    nhanvien.DIACHI = nv.DIACHI;
                    nhanvien.SDT = nv.SDT;
                    nhanvien.CHUCVU = nv.CHUCVU;
                    nhanvien.NgayVaoLam = nv.NgayVaoLam;
                    nhanvien.TenDangNhap = nv.TenDangNhap;
                    nhanvien.GIOITINH = nv.GIOITINH;
                    data.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
