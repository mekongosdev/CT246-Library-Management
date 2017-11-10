using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTV.Object;

namespace QLTV
{
    public partial class DangNhap : Form
    {
        private Connect conn = new Connect();

        public DangNhap()
        {
            InitializeComponent();
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntDangNhap_Click(object sender, EventArgs e)
        {
            if(string.Compare(conn.getString("select UserName from TaiKhoan where UserName ='"+txtTaiKhoan.Text+"'"),txtTaiKhoan.Text) == 0)
            {
                if (string.Compare(conn.getString("select Password from TaiKhoan where UserName ='" + txtTaiKhoan.Text + "'"), txtMatKhau.Text) == 0)
                {
                    
                    MessageBox.Show("Đăng Nhập Thành Công","Thông báo");
                    Main main = new Main(txtTaiKhoan.Text);
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Sai Mật Khẩu");
                    txtMatKhau.Focus();
                    txtMatKhau.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Sai Tài Khoản");
                txtTaiKhoan.Focus();
                txtTaiKhoan.Text = "";
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
