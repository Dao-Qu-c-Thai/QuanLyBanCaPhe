using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhomNguoiDung_BLL
    {
        NhomNguoiDung_DAL dal = new NhomNguoiDung_DAL();
        public NhomNguoiDung_BLL() { }
        public DataTable getData()
        {
            return dal.getData();
        }
        public bool themNhom(NhomNguoiDung nh)
        {
            try
            {
                dal.themNhom(nh);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateNhom(NhomNguoiDung nh)
        {
            try
            {
                dal.updateNhom(nh);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteNhom(NhomNguoiDung nh)
        {
            try
            {
                dal.deleteNhom(nh);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
