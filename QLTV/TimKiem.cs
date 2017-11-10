using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using QLTV.Object;
using System.Windows.Forms;

namespace QLTV
{
    public partial class TimKiem : UserControl
    {
        private Connect conn = new Connect();
        private DataTable sach;

        public TimKiem()
        {
            InitializeComponent();
            
        }

        private Boolean Check()
        {
            if(string.Compare(cmbTim.Text,"") == 0)
            {
                MessageBox.Show("Bạn Chưa Chọn Loại Tìm kiếm", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbTim.Focus();
                return false;
            }
            if (string.Compare(txtTim.Text, "") == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Cần Tìm kiếm", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTim.Focus();
                return false;
            }
            

            return true;
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            
            if (Check())
            {
                if (string.Compare(cmbTim.Text, "Mã Sách") == 0)
                {
                    sach = conn.getTable("select MaSach, TenSach, TacGia, NXB, SoTrang, Gia, Loai from Sach where MaSach='" + txtTim.Text + "'");
                }
                if (string.Compare(cmbTim.Text, "Tên Sách") == 0)
                {
                    sach = conn.getTable("select MaSach, TenSach, TacGia, NXB, SoTrang, Gia, Loai from Sach where TenSach LIKE '%" + txtTim.Text + "%'");
                }
                if (string.Compare(cmbTim.Text, "Tác Giả") == 0)
                {
                    sach = conn.getTable("select MaSach, TenSach, TacGia, NXB, SoTrang, Gia, Loai from Sach where TacGia='" + txtTim.Text + "'");
                }
                if (string.Compare(cmbTim.Text, "NXB") == 0)
                {
                    sach = conn.getTable("select MaSach, TenSach, TacGia, NXB, SoTrang, Gia, Loai from Sach where NXB='" + txtTim.Text + "'");
                }
                if (string.Compare(cmbTim.Text, "Chủ Đề") == 0)
                {
                    sach = conn.getTable("select MaSach, TenSach, TacGia, NXB, SoTrang, Gia, Loai from Sach where Loai='" + txtTim.Text + "'");
                }
                if (sach.Columns.Count < 8 )
                {
                    sach.Columns.Add("STT");
                }
                for (int i = 0; i < sach.Rows.Count; i++)
                {
                    sach.Rows[i]["STT"] = i + 1;
                }
                dataSach.DataSource = sach;
            }


        }


    }
}
