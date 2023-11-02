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
    public class ManHinh_DAL
    {
        DM_ManHinhTableAdapter da = new DM_ManHinhTableAdapter();
        public ManHinh_DAL() { }
        public DataTable GetData()
        {
            return da.GetData();
        }
        public bool themManHinh(MaHinh mh)
        {
            try
            {
                da.Insert(mh.MaMH, mh.TenMH);
                return true;
            }
            catch
            { return false; }

        }
        public bool updateManHinh(MaHinh mh)
        {
            try
            {
                da.UpdateMH(mh.TenMH, mh.MaMH);
                return true;
            }
            catch
            { return false; }
        }
        public bool deleteManHinh(MaHinh mh)
        {
            try
            {
                da.Delete(mh.MaMH, mh.TenMH);
                return true;
            }
            catch
            { return false; }
        }
    }
}
