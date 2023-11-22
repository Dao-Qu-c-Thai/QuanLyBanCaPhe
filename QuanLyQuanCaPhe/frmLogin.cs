
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QUanLyQuanCaPhe.QL_NguoiDung;

namespace QUanLyQuanCaPhe.GUI
{
    public partial class frmLogin : Form
    {
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        public frmLogin()
        {
            InitializeComponent();
            
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.label3.BackColor = Color.Transparent;
            this.CenterToScreen();
            this.txt_pass.PasswordChar = '*';
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.txt_user.Text)) 
            {
                MessageBox.Show("Không được bỏ trống " + label2.Text.ToLower());
                txt_pass.Focus();  
                return; 
            }
            if (string.IsNullOrEmpty(this.txt_pass.Text))
            {
                MessageBox.Show("Không được bỏ trống " + label3.Text.ToLower());
                txt_pass.Focus();
                return;
            }
            int kq = CauHinh.Check_Config();
            if (kq == 0)
            {
                ProcessLogin();
                txt_pass.Clear();
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");
                ProcessConfig();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");
                ProcessConfig();
            }
        }
        public void ProcessLogin()
        {
            LoginResult result;
            result = CauHinh.Check_User(txt_user.Text, txt_pass.Text);
            if (result == LoginResult.Invailid)
            {
                MessageBox.Show("Sai" + label1.Text + " OR " + label2.Text);
                return;
            }
            else if (result == LoginResult.Disabled)
            {
                MessageBox.Show("Tài khoản đã bị khóa");
                return;
            }
            if (Program.mainFrm == null || Program.mainFrm.IsDisposed)
            {
                Program.mainFrm = new frmMain(txt_user.Text);
                Program.mainFrm.IsMdiContainer = true;
            }
            this.Visible = false;
            Program.mainFrm.Show();
        }
        public void ProcessConfig()
        {
            LoginResult result;
            result = CauHinh.Check_User(txt_user.Text, txt_pass.Text);
            if (result == LoginResult.Invailid)
            {
                MessageBox.Show("Sai " + label1.Text + " OR " + label2.Text);
                return;
            }
            else if (result == LoginResult.Disabled)
            {
                MessageBox.Show("Tài khoản đã bị khóa");
                return;
            }
            if (Program.mainFrm == null || Program.mainFrm.IsDisposed)
            {
                Program.mainFrm = new frmMain();
            }
            this.Visible = false;
            Program.mainFrm.Show();
        }
    }
}
