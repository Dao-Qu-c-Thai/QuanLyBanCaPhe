using QUanLyQuanCaPhe.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUanLyQuanCaPhe
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UC_NhanVien nv = new UC_NhanVien();
            pal_main.Controls.Clear();
            pal_main.Controls.Add(nv);
        }

        private void pal_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Order order = new UC_Order();
            pal_main.Controls.Clear();
            pal_main.Controls.Add(order);
        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNguoiDung frm =  new frmNguoiDung();
            frm.Show();
        }

        private void nhómNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhomNguoiDung frm = new frmNhomNguoiDung();
            frm.Show();
        }

        private void mànHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManHinh frm = new frmManHinh(); 
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void thêmNgườiDùngVàoNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemNguoIDungVaoNhom frm = new frmThemNguoIDungVaoNhom();
            frm.Show();
        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhanQuyen frm = new frmPhanQuyen();
            frm.Show();
        }
    }
}
