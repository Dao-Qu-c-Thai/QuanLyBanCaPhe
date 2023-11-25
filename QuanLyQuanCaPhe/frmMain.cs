using BLL;
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
using BLL;
using DAL;

namespace QUanLyQuanCaPhe
{
    public partial class frmMain : Form
    {
        private string tenDangNhap;
        NguoiDungNhomNguoiDung_BLL bll = new NguoiDungNhomNguoiDung_BLL();
        PhanQuyen_BLL bll_PhanQuyen = new PhanQuyen_BLL();
        public frmMain()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public frmMain(string tenDN)
        {
            InitializeComponent();
            this.CenterToScreen();
            tenDangNhap = tenDN;
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
            List<string> nhomND = bll.GetMaNhomND(tenDangNhap); 
            foreach(string item in nhomND)
            {
                DataTable dsQuyen = bll_PhanQuyen.getMaMH(item);
                foreach(DataRow mh in dsQuyen.Rows)
                {
                    FindMenuPhanQuyen(this.menuStrip1.Items, mh[0].ToString(), Convert.ToBoolean(mh[1].ToString()));
                }
            }
            UC_Order order = new UC_Order();
            pal_main.Controls.Clear();
            pal_main.Controls.Add(order);

        }

        private void FindMenuPhanQuyen(ToolStripItemCollection mnuItems, string pScreenName, bool pEnable)
        {
            foreach(ToolStripItem menu in mnuItems)
            {
                if(menu is ToolStripMenuItem && ((ToolStripMenuItem)menu).DropDownItems.Count > 0) 
                {
                    FindMenuPhanQuyen(((ToolStripMenuItem)(menu)).DropDownItems,pScreenName,pEnable);
                    menu.Enabled = checkAllMenuChildVisible(((ToolStripMenuItem)(menu)).DropDownItems);
                    menu.Visible = menu.Enabled;
                }
                else if (string.Equals(pScreenName, menu.Tag))
                {
                    menu.Enabled = pEnable;
                    menu.Visible = pEnable;
                }
            }
        }
        private bool checkAllMenuChildVisible(ToolStripItemCollection mnuItems)
        {
            foreach(ToolStripItem menuItem in mnuItems)
            {
                if(menuItem is ToolStripMenuItem && menuItem.Enabled)
                {
                    return true;
                }
                else if(menuItem is ToolStripSeparator) { continue; }
            }
            return false;
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
