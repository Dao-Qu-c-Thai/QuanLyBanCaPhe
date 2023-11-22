using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace QUanLyQuanCaPhe
{
    public partial class frmPhanQuyen : Form
    {
        PhanQuyen_BLL bll = new PhanQuyen_BLL();
        NhomNguoiDung nh = new NhomNguoiDung();
        public frmPhanQuyen()
        {
            InitializeComponent();
            this.CenterToScreen();
            load_data();
        }
        public void load_data()
        {
            data_nhomnguoidung.DataSource = bll.getDataNhomNguoiDung();
        }

        private void data_nhomnguoidung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_nhomnguoidung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(data_nhomnguoidung.Rows.Count >= -1) {
                nh.MaNhom = data_nhomnguoidung.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            data_quyenchucnang.DataSource =  bll.getDataPhanQuyen(nh);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            int dem = 0;
            int sodong = data_quyenchucnang.RowCount;
            foreach(DataGridViewRow item in data_quyenchucnang.Rows)
            {
                if(dem < sodong - 1)
                {
                    if (bll.KTKC_PhanQuyen(nh.MaNhom, item.Cells[0].Value.ToString()) == false)
                    {
                        try
                        {
                            bll.insertPhanQuyen(nh.MaNhom, item.Cells[0].Value.ToString(), (bool)item.Cells[2].Value);
                        }
                        catch
                        {
                            bll.insertPhanQuyen(nh.MaNhom, item.Cells[0].Value.ToString(), false);
                        }
                    }
                    else
                    {
                        bll.updatePhanQuyen(nh.MaNhom, item.Cells[0].Value.ToString(),
                            (item.Cells[2] == null) ? false : (bool)(item.Cells[2].Value));
                    }
                    dem++;
                }
                else
                {
                    return;
                }
            }
            MessageBox.Show("Phân quyền thành công");
        }
    }
}
