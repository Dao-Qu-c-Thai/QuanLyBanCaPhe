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
    public partial class frmManHinh : Form
    {
        ManHinh_BLL bll = new ManHinh_BLL();
        public frmManHinh()
        {
            InitializeComponent();
            load_data();
        }

        public void load_data()
        {
            data_mh.DataSource = bll.getData();
        }

        private void data_mh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(data_mh.Rows.Count >= -1) 
            {
                txt_manh.Text = data_mh.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tenmh.Text = data_mh.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MaHinh mh = new MaHinh();
            if(txt_manh.Text.Trim() == null || txt_tenmh.Text.Trim()==null )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else
            {
                mh.MaMH = txt_manh.Text;
                mh.TenMH = txt_tenmh.Text;
               
                if (bll.themManHinh(mh) == true)
                {
                    MessageBox.Show("Thêm màn hình thành công!!");
                    load_data();
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm màn hình không thành công!!");
                    return;
                }
            }
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            MaHinh mh = new MaHinh();
            if (txt_manh.Text.Trim() == null || txt_tenmh.Text.Trim() == null)
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
                    mh.MaMH = txt_manh.Text;
                    mh.TenMH = txt_tenmh.Text;

                    if (bll.deleteManHinh(mh) == true)
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            MaHinh mh = new MaHinh();
            if (txt_manh.Text.Trim() == null || txt_tenmh.Text.Trim() == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else
            {
                mh.MaMH = txt_manh.Text;
                mh.TenMH = txt_tenmh.Text;
                if ((MessageBox.Show("Bạn có muốn cập nhật thông tin không???",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                {
                    if (bll.updateManHinh(mh) == true)
                    {
                        MessageBox.Show("Cập nhật màn hình thành công!!");
                        load_data();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật màn hình thất bại!!");
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
