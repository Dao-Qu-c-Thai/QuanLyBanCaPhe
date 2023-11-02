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
    public partial class frmThemNguoIDungVaoNhom : Form
    {
        NhomNguoiDung_BLL bll = new NhomNguoiDung_BLL();
        NguoiDungNhomNguoiDung_BLL bll_nhomNguoiDung = new NguoiDungNhomNguoiDung_BLL();
        NguoiDung_BLL bll_NguoiDung = new NguoiDung_BLL();
        string tenDN = "";
        string tenDN_nhom = "";
        string maNhom_nhom = "";
        public frmThemNguoIDungVaoNhom()
        {
            InitializeComponent();
            this.CenterToScreen();
            load_data();
        }
        public void load_data()
        {
            cob_tennhom.DisplayMember = "TenNhom";
            cob_tennhom.ValueMember = "MaNhom";
            cob_tennhom.DataSource = bll.getData();
            data_NguoiDung.DataSource = bll_NguoiDung.getNguoiDung();
        }
        public void load_data_theoMa()
        {
            NguoiDungNhomNguoiDung ng = new NguoiDungNhomNguoiDung();
            ng.MaNhom = cob_tennhom.SelectedValue.ToString();
            data_NguoiDungNhomNguoiDung.DataSource = bll_nhomNguoiDung.GetData(ng);
        }

        private void cob_tennhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                NguoiDungNhomNguoiDung ng = new NguoiDungNhomNguoiDung();
                ng.MaNhom = cob_tennhom.SelectedValue.ToString();
                data_NguoiDungNhomNguoiDung.DataSource = bll_nhomNguoiDung.GetData(ng);

            }
            catch (Exception ex) { }
        }

        private void data_NguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(data_NguoiDung.Rows.Count >= -1) 
            {
                tenDN = data_NguoiDung.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            NguoiDungNhomNguoiDung ng = new NguoiDungNhomNguoiDung();
            ng.TenDN = tenDN;
            ng.MaNhom = cob_tennhom.SelectedValue.ToString();
            ng.GhiChu = "";
            if(bll_nhomNguoiDung.KTKC(ng) == true)
            {
                MessageBox.Show("Tài khoản này đã tồn tại trong nhóm " + ng.MaNhom);
                return;
            }
            else
            {
                bll_nhomNguoiDung.themNguoiDungVaoNhom(ng);
                load_data_theoMa();
                MessageBox.Show("Thêm người dùng vào nhóm " + ng.MaNhom + " thành công!!");
            }
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            NguoiDungNhomNguoiDung ng = new NguoiDungNhomNguoiDung();
            ng.TenDN = tenDN_nhom;
            ng.MaNhom = maNhom_nhom;
            if (bll_nhomNguoiDung.deleteNguoiDung(ng) == true)
            {
                MessageBox.Show("Xóa người dùng trong nhóm " + ng.MaNhom + " thành công!!");
                load_data_theoMa();
            }
            else
            {
                MessageBox.Show("Xóa người dùng trong nhóm " + ng.MaNhom + " thất bại!!");
            }
        }

        private void data_NguoiDungNhomNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(data_NguoiDungNhomNguoiDung.Rows.Count >= -1) 
            {
                tenDN_nhom = data_NguoiDungNhomNguoiDung.Rows[e.RowIndex].Cells[0].Value.ToString();
                maNhom_nhom = data_NguoiDungNhomNguoiDung.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
