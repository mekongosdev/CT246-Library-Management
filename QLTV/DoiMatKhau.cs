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
    public partial class DoiMatKhau : Form
    {
        private string tk;
        private Connect conn = new Connect();

        public DoiMatKhau(string tk)
        {
            InitializeComponent();
            this.tk = tk;
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            if (string.Compare(conn.getString("select Password from TaiKhoan where UserName ='" + tk + "'"), txtMatkhauCu.Text) == 0)
            {
                if (string.Compare(txtMatKhauMoi.Text, txtMatKhauXacNhan.Text) == 0)
                {
                    conn.Update("update TaiKhoan set password='"+txtMatKhauXacNhan.Text+"' where UserName='"+tk+"'");
                    MessageBox.Show("Đổi Mật Khẩu Thành Công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai Mật Khẩu Xác Thực Không Đúng");
                    txtMatKhauXacNhan.Focus();
                    txtMatKhauXacNhan.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Mật Khẩu Củ Không Đúng");
                txtMatkhauCu.Focus();
                txtMatkhauCu.Text = "";
            }
        }

    }
}
