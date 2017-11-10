using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTV.Object;

namespace QLTV
{
    public partial class Sach : UserControl
    {
        private Connect conn = new Connect();
        private DataTable sach;
        private int index;

        public Sach()
        {
            InitializeComponent();
        }

        private void LoadDaTa()
        {
            sach = conn.getTable("select MaSach, TenSach, TacGia, NXB, SoTrang, Gia, Loai from Sach");
            sach.Columns.Add("STT");
            for (int i = 0; i < sach.Rows.Count; i++)
            {
                sach.Rows[i]["STT"] = i + 1;
            }
            dataSinhVien.DataSource = sach;
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            LoadDaTa();
            txtMa.Focus();
        }

        private Boolean Check()
        {
            if (string.Compare(txtMa.Text, "") == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Mã", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtMa.Focus();
                return false;
            }
            if (string.Compare(txtTenSach.Text, "") == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Sách", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTenSach.Focus();
                return false;
            }
            if (string.Compare(txtTacGia.Text, "") == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Tác Giả", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTacGia.Focus();
                return false;
            }
            if (string.Compare(txtNXB.Text, "") == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập NXB", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNXB.Focus();
                return false;
            }
            if (string.Compare(txtSoTrang.Text, "") == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Số Trang", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSoTrang.Focus();
                return false;
            }
            if (string.Compare(txtGia.Text, "") == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Giá", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtGia.Focus();
                return false;
            }
            if (string.Compare(txtLoai.Text, "") == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Loại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtLoai.Focus();
                return false;
            }
            return true;
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                bool kt = conn.Update(@"insert into Sach values('"+txtMa.Text+"','"+txtTenSach.Text+"','"+txtTacGia.Text+
                                    "','"+txtNXB.Text+"','"+txtLoai.Text+"','"+txtSoTrang.Text+"','"+txtGia.Text+"','Tra')");
                if (kt)
                {
                    MessageBox.Show("Thêm Thành Công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadDaTa();
                }
                else
                {
                    MessageBox.Show("Mã Sách Đã Tồn Tại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {

            if (Check())
            {
                bool kt = conn.Update(@"update Sach set TenSach='"+txtTenSach.Text+"',TacGia='"+txtTacGia.Text+
                                "',NXB='"+txtNXB.Text+"',SoTrang='"+txtSoTrang.Text+"',Gia='"+txtGia.Text+"',Loai='"+txtLoai.Text+"' where maSach='"+txtMa.Text+"'");
                if (kt)
                {
                    MessageBox.Show("Sửa Thành Công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadDaTa();
                }
                else
                {
                    MessageBox.Show("Không Có Loại Sách Này", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            bool kt = conn.Update("delete from Sach where MaSach='"+"'");
            if(kt)
            {
                MessageBox.Show("Xóa Thành Công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadDaTa();
            }
            else
            {
                MessageBox.Show("Không Có Loại Sách Này", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void bntInDS_Click(object sender, EventArgs e)
        {
            frmBaoCao print = new frmBaoCao("select MaSach, TenSach, TacGia, NXB, SoTrang, Gia, Loai from Sach", "Sach", "rptSach");
            print.ShowDialog();
        }

        private void dataSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
                txtMa.Text = dataSinhVien.Rows[index].Cells["MaSach"].Value.ToString();
                txtTenSach.Text = dataSinhVien.Rows[index].Cells["TenSach"].Value.ToString();
                txtTacGia.Text = dataSinhVien.Rows[index].Cells["TacGia"].Value.ToString();
                txtNXB.Text = dataSinhVien.Rows[index].Cells["NXB"].Value.ToString();
                txtSoTrang.Text = dataSinhVien.Rows[index].Cells["SoTrang"].Value.ToString();
                txtGia.Text = dataSinhVien.Rows[index].Cells["Gia"].Value.ToString();
                txtLoai.Text = dataSinhVien.Rows[index].Cells["Loai"].Value.ToString();
            }
        }

    }
}
