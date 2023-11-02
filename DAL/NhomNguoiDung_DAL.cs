using DAL.QUANLYCAPHE1TableAdapters;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhomNguoiDung_DAL
    {
        QL_NhomNguoiDungTableAdapter da = new QL_NhomNguoiDungTableAdapter();
        public NhomNguoiDung_DAL() { }

        public DataTable getData()
        {
            return da.GetData();
        }

        public bool themNhom(NhomNguoiDung nh)
        {
            try
            {
                da.Insert(nh.MaNhom,nh.TenNhom,nh.GhiChu);
                return true;
            }
            catch
            { return false; }

        }
        public bool updateNhom(NhomNguoiDung nh)
        {
            try
            {
                da.UpdateNhom(nh.TenNhom,nh.GhiChu,nh.MaNhom);
                return true;
            }
            catch
            { return false; }
        }
        public bool deleteNhom(NhomNguoiDung nh)
        {
            try
            {
                da.Delete(nh.MaNhom,nh.TenNhom,nh.GhiChu);
                return true;
            }
            catch
            { return false; }
        }
    }
}
