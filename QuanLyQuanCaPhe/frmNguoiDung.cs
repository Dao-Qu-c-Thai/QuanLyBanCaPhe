using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace QUanLyQuanCaPhe
{
    public partial class frmNguoiDung : Form
    {
        
        NguoiDung_BLL bll = new NguoiDung_BLL();

        public frmNguoiDung()
        {
            InitializeComponent();
            this.CenterToParent();
            loadData();
        }

        public void loadData()
        {
            data_NguoiDung.DataSource = bll.getNguoiDung();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            NguoiDung nd = new NguoiDung();
            nd.TenDangNhap = txt_tenDangNhap.Text;
            nd.MatKhau = txt_mk.Text;
            if(chk_hd.Checked == true)
            {
                nd.HoatDong = true;
            }
            else
            {
                nd.HoatDong = false;
            }
            if(bll.themNguoiDung(nd) == true)
            {
                MessageBox.Show("Thêm người dùng thành công!!");
                loadData();
                return;
            }
            else
            {
                MessageBox.Show("Thêm người dùng không thành công!!");
                return;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            NguoiDung nd = new NguoiDung();
            nd.TenDangNhap = txt_tenDangNhap.Text;
            nd.MatKhau = txt_mk.Text;
            if (chk_hd.Checked == true)
            {
                nd.HoatDong = true;
            }
            else
            {
                nd.HoatDong = false;
            }
            if((MessageBox.Show("Bạn có muốn cập nhật thông tin không???",
                "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes))
            {
                if (bll.updateNguoiDung(nd) == true)
                {
                    MessageBox.Show("Cập nhật thông tin người dùng thành công!!");
                    loadData();
                    return;
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin người dùng thất bại!!");
                    return;
                }
            }
            else
            {
                return;
            }
            
        }

        private void data_NguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(data_NguoiDung.Rows.Count >= -1)
            {
                txt_tenDangNhap.Text = data_NguoiDung.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_mk.Text = data_NguoiDung.Rows[e.RowIndex].Cells[1].Value.ToString();
                string hd = data_NguoiDung.Rows[e.RowIndex].Cells[2].Value.ToString();
                if(hd == "True")
                {
                    chk_hd.Checked = true;
                }
                else { chk_hd.Checked = false; }
            }
        }
    }
}
