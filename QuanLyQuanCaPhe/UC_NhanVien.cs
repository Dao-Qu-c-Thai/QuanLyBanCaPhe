using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace QUanLyQuanCaPhe
{
    public partial class UC_NhanVien : UserControl
    {
        //private NguoiDung nd;
        NhanVien_DAL dal = new NhanVien_DAL();
        public UC_NhanVien()
        {
            InitializeComponent();
            getData();
        }
        public void getData()
        {
            data_dsnv.DataSource = dal.getData();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void data_dsnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(data_dsnv.Rows.Count > -1) 
            {
                txt_manv.Text = data_dsnv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_hoten.Text = data_dsnv.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_diachi.Text = data_dsnv.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_sdt.Text = data_dsnv.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_chucvu.Text = data_dsnv.Rows[e.RowIndex].Cells[5].Value.ToString();
                string ngay = data_dsnv.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_ngayvaolam.Text = data_dsnv.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_user.Text = data_dsnv.Rows[e.RowIndex].Cells[7].Value.ToString();

                string gioiTinh = data_dsnv.Rows[e.RowIndex].Cells[4].Value.ToString();
                if(gioiTinh == "NAM")
                {
                    chk_nam.Checked= true;
                    chk_nu.Checked= false;
                }else if(gioiTinh == "NỮ")
                {
                    chk_nam.Checked= false;
                    chk_nu.Checked= true;
                }
            }
        }

        private void chk_nam_CheckedChanged(object sender, EventArgs e)
        {
            chk_nu.Checked = false;
        }

        private void chk_nu_CheckedChanged(object sender, EventArgs e)
        {
            chk_nam.Checked = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.TENNV = txt_hoten.Text;
            data_dsnv.DataSource = dal.searchNV(nv);
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.MANV = int.Parse(txt_manv.Text);
            nv.TENNV=txt_hoten.Text;
            nv.DIACHI=txt_diachi.Text;
            nv.SDT=txt_sdt.Text;
            nv.CHUCVU=txt_chucvu.Text;
            nv.NgayVaoLam= DateTime.Parse(txt_ngayvaolam.Text);
            nv.TenDangNhap = txt_user.Text;

            if (chk_nam.Checked == true)
            {
                nv.GIOITINH = "NAM";
            }
            else if (chk_nu.Checked == true)
            {
                nv.GIOITINH = "NỮ";
            }
            try
            {
                dal.themNhanVien(nv);
                MessageBox.Show("Thêm nhân viên thành công!!!");
                getData();
            }
            catch
            {
                MessageBox.Show("Thêm nhân viên thất bại!!!");
            }
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.MANV = int.Parse(txt_manv.Text);
            if(MessageBox.Show("Bạn có muốn xóa nhân viên này không???","Cảnh báo",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                dal.deleteNhanVien(nv);
                MessageBox.Show("Xóa nhân viên thành công!!");
                getData();
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại!!!");
            }
            
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.MANV = int.Parse(txt_manv.Text);
            nv.TENNV = txt_hoten.Text;
            nv.DIACHI = txt_diachi.Text;
            nv.SDT = txt_sdt.Text;
            nv.CHUCVU = txt_chucvu.Text;
            nv.NgayVaoLam = DateTime.Parse(txt_ngayvaolam.Text);
            nv.TenDangNhap = txt_user.Text;

            if (chk_nam.Checked == true)
            {
                nv.GIOITINH = "NAM";
            }
            else if (chk_nu.Checked == true)
            {
                nv.GIOITINH = "NỮ";
            }
            if (MessageBox.Show("Bạn có muốn cập nhật thông tin nhân viên này không???", "Cảnh báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                dal.updateNhanVien(nv);
                MessageBox.Show("Cập nhật thông tin nhân viên thành công!!");
                getData();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thất bại!!!");
            }
           
            
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_user.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống!!");
            }
            else
            {
                frmNguoiDung frm = new frmNguoiDung(txt_user.Text.ToString());
                frm.ShowDialog();
                
            }
        }
    }
}
