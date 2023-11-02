using DAL.QUANLYCAPHE1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NguoiDung_DAL
    {
        QL_NguoiDungTableAdapter da = new QL_NguoiDungTableAdapter();
        public NguoiDung_DAL() { }
        public DataTable GetData()
        {
            return da.GetData();
        }
        public bool themNguoiDung(NguoiDung nd)
        {
            try
            {
                da.Insert(nd.TenDangNhap, nd.MatKhau, nd.HoatDong);
                return true;
            }catch
            { return false; }
            
        }
        public bool updateNguoiDung(NguoiDung nd)
        {
            try
            {
                da.UpdateNguoiDung(nd.MatKhau, nd.HoatDong, nd.TenDangNhap);
                return true;
            }
            catch
            { return false; }
        }

    }
}
