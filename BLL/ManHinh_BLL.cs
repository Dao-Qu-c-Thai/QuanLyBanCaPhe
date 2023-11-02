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
    public class ManHinh_BLL
    {
        ManHinh_DAL dal = new ManHinh_DAL();
        public ManHinh_BLL() { }
        public DataTable getData()
        {
            return dal.GetData();
        }
        public bool themManHinh(MaHinh mh)
        {
            try
            {
                dal.themManHinh(mh);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateManHinh(MaHinh mh)
        {
            try
            {
                dal.updateManHinh(mh);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteManHinh(MaHinh mh)
        {
            try
            {
                dal.deleteManHinh(mh);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
