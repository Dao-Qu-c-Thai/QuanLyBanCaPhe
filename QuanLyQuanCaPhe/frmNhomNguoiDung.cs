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
    public partial class frmNhomNguoiDung : Form
    {
        NhomNguoiDung_BLL bll = new NhomNguoiDung_BLL();

        public frmNhomNguoiDung()
        {
            InitializeComponent();
            this.CenterToScreen();
            load_data();
        }
        public void load_data()
        {
            data_nhom.DataSource = bll.getData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            NhomNguoiDung nh = new NhomNguoiDung();
            if (txt_manhom.Text.Trim() == null || txt_tennhom.Text.Trim() == null || txt_ghichu.Text.Trim() == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else
            {
                nh.MaNhom = txt_manhom.Text;
                nh.TenNhom = txt_tennhom.Text;
                nh.GhiChu = txt_ghichu.Text;

                if (bll.themNhom(nh) == true)
                {
                    MessageBox.Show("Thêm nhóm người dùng thành công!!");
                    load_data();
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm nhóm người dùng thất bại!!");
                    return;
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            NhomNguoiDung nh = new NhomNguoiDung();
            if(txt_manhom.Text.Trim() == null || txt_tennhom.Text.Trim() == null || txt_ghichu.Text.Trim() == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else
            {
                nh.MaNhom = txt_manhom.Text;
                nh.TenNhom = txt_tennhom.Text;
                nh.GhiChu = txt_ghichu.Text;
                if ((MessageBox.Show("Bạn có muốn cập nhật thông tin không???",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                {
                    if (bll.updateNhom(nh) == true)
                    {
                        MessageBox.Show("Cập nhật thông tin nhóm người dùng thành công!!");
                        load_data();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin nhóm người dùng thất bại!!");
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void data_nhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(data_nhom.Rows.Count >= -1)
            {
                txt_manhom.Text = data_nhom.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tennhom.Text = data_nhom.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_ghichu.Text = data_nhom.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            NhomNguoiDung nh = new NhomNguoiDung();
            if (txt_manhom.Text.Trim() == null || txt_tennhom.Text.Trim() == null || txt_ghichu.Text.Trim() == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else
            {
                if ((MessageBox.Show("Bạn có muốn xóa thông tin không???",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                {
                    nh.MaNhom = txt_manhom.Text;
                    nh.TenNhom = txt_tennhom.Text;
                    nh.GhiChu = txt_ghichu.Text;

                    if (bll.deleteNhom(nh) == true)
                    {
                        MessageBox.Show("Xóa nhóm người dùng thành công!!");
                        load_data();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhóm người dùng thất bại!!");
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }
}
