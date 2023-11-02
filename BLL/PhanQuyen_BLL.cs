using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class PhanQuyen_BLL
    {
        PhanQuyen_DAL dal = new PhanQuyen_DAL();
        public PhanQuyen_BLL() { }  
        //public DataTable getDataPhanQuyen(NhomNguoiDung nh)
        //{
        //     return dal.getDataPhanQuyen(nh);
        //}
        public DataTable getDataNhomNguoiDung()
        {
            return dal.getDataNhomNguoiDung();
        }
        public bool KTKC_PhanQuyen(string maNhom,string maMH)
        {
            if(dal.KTKC_PhanQuyen(maNhom,maMH) == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool insertPhanQuyen(string maNhom,string maMH, bool coQuyen)
        {
            try
            {
                dal.insertPhanQuyen(maNhom, maMH, coQuyen);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updatePhanQuyen(string maNhom, string maMH, bool coQuyen)
        {

            try
            {
                dal.updatePhanQuyen(maNhom, maMH, coQuyen);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
