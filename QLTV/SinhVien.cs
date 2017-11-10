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
    public partial class SinhVien : UserControl
    {
        private Connect conn = new Connect();
        private DataTable sinhvien;
        private int index;

        public SinhVien()
        {
            InitializeComponent();
        }

        private void LoadDaTa()
        {
            sinhvien = conn.getTable("select ID, HoTen, GioiTinh, NgaySinh, NgayCap, Khoa, Lop, SDT, DiaChi from SinhVien");
            sinhvien.Columns.Add("STT");
            for (int i = 0; i < sinhvien.Rows.Count; i++)
            {
                sinhvien.Rows[i]["STT"] = i + 1;
            }
            dataSinhVien.DataSource = sinhvien;
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {

            LoadDaTa();
            txtID.Focus();
        }

        private Boolean Check()
        {
            if (string.Compare(txtID.Text,"") == 0) 
            {
                MessageBox.Show("Bạn Chưa Nhập ID","THÔNG BÁO",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtID.Focus();
                return false;
            }
            if (string.Compare(txtHoTen.Text, "") == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Họ Tên", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtHoTen.Focus();
                return false;
            }
            if (string.Compare(cmbGioiTinh.Text, "") == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Giới Tính", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbGioiTinh.Focus();
                return false;
            }
            if (string.Compare(txtKhoa.Text, "") == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Khoa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKhoa.Focus();
                return false;
            }
            if (string.Compare(txtLop.Text, "") == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Lớp", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtLop.Focus();
                return false;
            }
            if (string.Compare(txtSDT.Text, "") == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập SDT", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSDT.Focus();
                return false;
            }
            if (string.Compare(txtDiaChi.Text, "") == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Địa Chỉ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtDiaChi.Focus();
                return false;
            }
            return true;
        }


        private void bntThem_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                bool kt = conn.Update(@"insert into SinhVien values('"+txtID.Text+"','"+txtHoTen.Text+"','"+cmbGioiTinh.Text+
                            "','"+dateNgaySinh.Value.ToString("MM/dd/yyyy")+"','"+txtSDT.Text+"','"+txtDiaChi.Text+"','"+dateNgayCap.Value+"','"+txtLop.Text+"','"+txtKhoa.Text+"',0)");
                if (kt == true)
                {
                    MessageBox.Show("Thêm Thành Công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadDaTa();
                }
                else
                    MessageBox.Show("Thêm Thất Bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dataSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
                txtID.Text = dataSinhVien.Rows[index].Cells["ID"].Value.ToString();
                txtHoTen.Text = dataSinhVien.Rows[index].Cells["HoTen"].Value.ToString();
                cmbGioiTinh.Text = dataSinhVien.Rows[index].Cells["GioiTinh"].Value.ToString();
                dateNgaySinh.Text = dataSinhVien.Rows[index].Cells["NgaySinh"].Value.ToString();
                dateNgayCap.Text = dataSinhVien.Rows[index].Cells["NgayCapThe"].Value.ToString();
                txtKhoa.Text = dataSinhVien.Rows[index].Cells["Khoa"].Value.ToString();
                txtLop.Text = dataSinhVien.Rows[index].Cells["Lop"].Value.ToString();
                txtSDT.Text = dataSinhVien.Rows[index].Cells["SDT"].Value.ToString();
                txtDiaChi.Text = dataSinhVien.Rows[index].Cells["DiaChi"].Value.ToString();
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            if(Check())
            {
               bool kt = conn.Update(@"update SinhVien set HoTen='"+txtHoTen.Text+"',GioiTinh='"+cmbGioiTinh.Text+"', NgaySinh='"+dateNgaySinh.Value+
                    "', NgayCap='"+dateNgayCap.Value+"',Khoa='"+ txtKhoa.Text+"',Lop='"+txtLop.Text+"',SDT='"+txtSDT.Text+"',DiaChi='"+txtDiaChi.Text+"' where ID='"+txtID.Text+"'");
               if (kt == true)
               {
                   MessageBox.Show("Sữa Thành Công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                   LoadDaTa();
               }
               else
                   MessageBox.Show("Không Có Sinh Viên Này", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            bool kt = conn.Update("Delete from SinhVien where ID='" + dataSinhVien.Rows[index].Cells["ID"].Value.ToString()+ "'");
            if (kt == true)
            {
                MessageBox.Show("Xóa Thành Công","THÔNG BÁO", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                LoadDaTa();
                txtID.Text = "";
                txtHoTen.Text = "";
                txtKhoa.Text = "";
                txtLop.Text = "";
                txtSDT.Text = "";
                txtDiaChi.Text = "";
            }
            else
                MessageBox.Show("Không Có Sinh Viên Này", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bntInDS_Click(object sender, EventArgs e)
        {
            frmBaoCao print = new frmBaoCao("select ID, HoTen, GioiTinh, NgaySinh, NgayCap, Khoa, Lop, SDT, DiaChi from SinhVien","SinhVien","rptSinhVien");
            print.ShowDialog();
        }

        
    }
}
