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
    public partial class TraSach : UserControl
    {
        private Connect conn = new Connect();
        private DataTable sinhvien, sach;
        private int index;

        public TraSach()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            sinhvien = conn.getTable("select sv.ID, HoTen, MaMuon, m.SOLUONG, NgayMuon, NgayHon, PhuTrach from Muon m join SinhVien sv on m.ID = sv.ID and m.NgayTra='1900-01-01'");
            sinhvien.Columns.Add("STT");
            for (int i = 0; i < sinhvien.Rows.Count; i++)
            {
                sinhvien.Rows[i]["STT"] = i + 1;
            }
            dataSinhVien.DataSource = sinhvien;
        }

        private void bntTra_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtID.Text, "") != 0 && index >= 0)
            {
                bool k1 = conn.Update("update muon set NgayTra='" + dateNgayTra.Value + "' where MaMuon='" + dataSinhVien.Rows[index].Cells[2].Value + "'");
                for (int i = 0; i < dataSach.RowCount; i++)
                {
                    conn.Update("update sach set tinhtrang ='tra' where MaSach='" + dataSach.Rows[i].Cells[0].Value + "'");
                }
                if (k1)
                {
                    MessageBox.Show("Đã Trả Sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi Không Thực Thiện Được", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Sinh Viên Tra Sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void TraSach_Load(object sender, EventArgs e)
        {

            LoadData();
        }

        private void dataSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
                txtID.Text = dataSinhVien.Rows[index].Cells[0].Value.ToString();
                txtHoTen.Text = dataSinhVien.Rows[index].Cells[1].Value.ToString();
                dateNgayHen.Text = dataSinhVien.Rows[index].Cells[5].Value.ToString();
                LoadSach();
            }
        }


        private void LoadSach()
        {
            sach = conn.getTable("select s.MaSach, TenSach, TacGia, NXB, SoTrang, Gia, Loai from Sach s join CTMuon ct on s.MaSach=ct.MaSach where ct.MaMuon='"+dataSinhVien.Rows[index].Cells[2].Value+"'");
            sach.Columns.Add("STT");
            for (int i = 0; i < sach.Rows.Count; i++)
            {
                sach.Rows[i]["STT"] = i + 1;
            }
            dataSach.DataSource = sach;
        }

    }
}
