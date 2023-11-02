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

namespace QUanLyQuanCaPhe
{
    public partial class UC_NhanVien : UserControl
    {
        NhanVien_DAL nv = new NhanVien_DAL();
        public UC_NhanVien()
        {
            InitializeComponent();
            getData();
        }
        public void getData()
        {
            data_dsnv.DataSource = nv.getData();
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
    }
}
