using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.QUANLYCAPHE1TableAdapters;
using DTO;

namespace DAL
{
    public class NguoiDungNhomNguoiDung_DAL
    {
        QL_NguoiDungNhomNguoiDungTableAdapter da = new QL_NguoiDungNhomNguoiDungTableAdapter();
        public NguoiDungNhomNguoiDung_DAL() { }
        public DataTable GetDataMaNhom(NguoiDungNhomNguoiDung ng)
        {
            return da.GetDataByMaNhom(ng.MaNhom);
        }
        public bool themNguoiDungVaoNhom(NguoiDungNhomNguoiDung ng)
        {
            try
            {
                da.Insert(ng.TenDN, ng.MaNhom, ng.GhiChu);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int KTKC(NguoiDungNhomNguoiDung ng)
        {
            int kq = da.KTKC(ng.TenDN, ng.MaNhom).Value;
            return kq;
        }
        public bool deleteNguoiDung(NguoiDungNhomNguoiDung ng)
        {
            try
            {
                da.DeleteQuery(ng.TenDN, ng.MaNhom);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
