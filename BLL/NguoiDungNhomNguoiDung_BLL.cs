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
    public class NguoiDungNhomNguoiDung_BLL
    {
        NguoiDungNhomNguoiDung_DAL dal = new NguoiDungNhomNguoiDung_DAL();
        public NguoiDungNhomNguoiDung_BLL() { }
        public DataTable GetData(NguoiDungNhomNguoiDung ng)
        {
            return dal.GetDataMaNhom(ng);
        }
        public List<string> GetMaNhomND(string tenDN)
        {
            return dal.GetMaNhomND(tenDN);
        }
        public bool themNguoiDungVaoNhom(NguoiDungNhomNguoiDung ng)
        {
            try
            {
                dal.themNguoiDungVaoNhom(ng);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool KTKC(NguoiDungNhomNguoiDung ng)
        {
            if(dal.KTKC(ng) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool deleteNguoiDung(NguoiDungNhomNguoiDung ng)
        {
            try
            {
                dal.deleteNguoiDung(ng);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
