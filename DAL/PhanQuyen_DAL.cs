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
    public class PhanQuyen_DAL
    {
        GetPhanQuyenTableAdapter da = new GetPhanQuyenTableAdapter();
        QL_NhomNguoiDungTableAdapter da_nh = new QL_NhomNguoiDungTableAdapter();
        QL_PhanQuyenTableAdapter da_phanquyen = new QL_PhanQuyenTableAdapter();
        QL_PhanQuyen1TableAdapter da_phanquyen1 = new QL_PhanQuyen1TableAdapter();
        public PhanQuyen_DAL() { }
        public DataTable getDataPhanQuyen(NhomNguoiDung nh)
        {
            return da.GetData(nh.MaNhom);
        }
        public DataTable getDataNhomNguoiDung()
        {
            return da_nh.GetData();
        }
        public DataTable getMaMH(string maNhomND)
        {
            return da_phanquyen1.GetData(maNhomND);
        }
        public string KTKC_PhanQuyen(string maNhom,string maMH)
        {
             return da.KTKC_PhanQuyen(maNhom, maMH);
        }
        public bool insertPhanQuyen(string maNhom,string maMH, bool coQuyen)
        {
            try
            {
                da_phanquyen.Insert(maNhom, maMH, coQuyen);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updatePhanQuyen(string maNhom,string maMH,bool coQuyen)
        {
            try
            {
                da_phanquyen.UpdateQuery(coQuyen, maNhom, maMH);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
