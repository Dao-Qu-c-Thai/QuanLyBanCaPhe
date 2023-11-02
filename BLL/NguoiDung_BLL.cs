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
    public class NguoiDung_BLL
    {
        NguoiDung_DAL dal = new NguoiDung_DAL();
        public NguoiDung_BLL() { }
        public DataTable getNguoiDung()
        {
            return dal.GetData();
        }
        public bool themNguoiDung(NguoiDung nd) 
        {
            try
            {
                dal.themNguoiDung(nd);
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool updateNguoiDung(NguoiDung nd)
        {
            try
            {
                dal.updateNguoiDung(nd);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
