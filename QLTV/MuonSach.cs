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
    public partial class MuonSach : UserControl
    {
        private Connect conn = new Connect();
        private DataTable sach = new DataTable();
        private int index;

        public MuonSach()
        {
            InitializeComponent();
            
        }

        private void MuonSach_Load(object sender, EventArgs e)
        {

            cmbMaSach.DataSource = conn.getTable("select MaSach from Sach where tinhtrang='tra'");
            cmbMaSach.DisplayMember = "MaSach";
            cmbMaSach.ValueMember = "MaSach";

            txtID.DataSource = conn.getTable("select ID from SinhVien");
            txtID.DisplayMember = "ID";
            txtID.ValueMember = "ID";


            //sach = conn.getTable("select MaSach, TenSach, TacGia, NXB, SoTrang, Gia, Loai from Sach where MaSach=''");
            sach.Columns.Add("STT");
            dataSach.DataSource = sach;


            //load dư liêu k vào mã sách trong datagriview
           // MaSach.DataSource = conn.getTable(@"select MaSach, TenSach, TacGia, NXB, SoTrang, Gia, Loai from Sach except 
					                            //select s.MaSach, TenSach, TacGia, NXB, SoTrang, Gia, Loai from Sach s join CTMuon m on m.MaSach = s.MASACH");

        }

        private Boolean Check()
        {
            if (string.Compare(txtMaMuon.Text, "") == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Mượn", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtMaMuon.Focus();
                return false;
            }
            if (string.Compare(txtHoTen.Text, "") == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Người Phụ Trách", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtHoTen.Focus();
                return false;
            }
            if (string.Compare(txtID.Text, "") == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập ID Người Mượn", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtID.Focus();
                return false;
            }
            if (string.Compare(txtSoLuong.Text, "") == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập SoLuong", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSoLuong.Focus();
                return false;
            }

            int temp = DateTime.Compare(dateNgayMuon.Value, dateNgayHen.Value) != 0 ? DateTime.Compare(dateNgayMuon.Value, dateNgayHen.Value) : 0;

            if ( temp >= 0)
            {
                MessageBox.Show("Ngày Hẹn Phải Lớn Hơn Hoặc Bàng Ngày Mượn", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dateNgayHen.Focus();
                return false;
            }

            if (Int16.Parse(txtSoLuong.Text.ToString()) <= 0 )
            {
                MessageBox.Show("Số Sách Mượn Không Hợp Lệ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return true;
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            
            if (sach.Rows.Count < 5)
            {
                sach.Rows.Add();
                for (int i = 0; i < sach.Rows.Count; i++)
                {
                    sach.Rows[i]["STT"] = i + 1;
                }
                txtSoLuong.Text = dataSach.Rows.Count.ToString();
            }
            else
            {
                MessageBox.Show("Số Sách Mượn Quá Mức Cho Phép", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void bntluu_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                Boolean tk = conn.Update("insert into Muon values('" + txtMaMuon.Text + "','" + txtID.Text + "','" + txtSoLuong.Text + "','" + dateNgayMuon.Value + "','','" + dateNgayHen.Value + "','" + txtHoTen.Text + "')");
                if (tk)
                {
                    for (int i = 0; i < dataSach.RowCount; i++)
                    {
                        conn.Update("insert into CTMuon values('" + dataSach.Rows[i].Cells[0].Value + "','" + txtMaMuon.Text + "')");
                        conn.Update("update sach set tinhtrang ='muon' where MaSach='" + dataSach.Rows[i].Cells[0].Value + "'");
                    }
                    if (MessageBox.Show("Bạn Có Muốn Xuất Phiếu Mượn Không", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        frmBaoCao print = new frmBaoCao(@"select sv.ID, sv.HOTEN, NGAYMUON, NGAYHON, m.MAMUON, m.PHUTRACH,
		                                                m.SOLUONG, s.MASACH,s.TENSACH,s.TACGIA,s.NXB,s.SOTRANG,s.GIA,s.LOAI from SinhVien sv
							                            join Muon m on sv.ID = m.ID join CTMUON ct on ct.MAMUON = m.MAMUON join SACH s on s.MASACH = ct.MASACH where sv.ID='" + txtID.Text + "' and m.MaMuon='" + txtMaMuon.Text + "'", "Muon", "rptPhieuMuon");
                        print.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Lưu Thành Công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("Mã Mượn Đã Tồn Tại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void dataSach_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
                if (dataSach.CurrentCell.ColumnIndex == 0)
                {
                // Check box column
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
                }
        }

        void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ((ComboBox)sender).SelectedIndex;
            //cmbMaSach.Items.RemoveAt(selectedIndex);
        }

        private void dataSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            try
            {
                if (dataSach.Rows.Count > 0 && sach.Rows.Count > 0)
                {
                    DataTable table = new DataTable();
                    table = conn.getTable("select TenSach, TacGia, NXB, SoTrang, Gia, Loai from Sach where MaSach='" + dataSach.Rows[index].Cells[0].Value.ToString() + "'");
                    dataSach.Rows[index].Cells[1].Value = table.Rows[0][0].ToString();
                    dataSach.Rows[index].Cells[2].Value = table.Rows[0][1].ToString();
                    dataSach.Rows[index].Cells[3].Value = table.Rows[0][2].ToString();
                    dataSach.Rows[index].Cells[4].Value = table.Rows[0][3].ToString();
                    dataSach.Rows[index].Cells[5].Value = table.Rows[0][4].ToString();
                    dataSach.Rows[index].Cells[6].Value = table.Rows[0][5].ToString();
                    //MessageBox.Show(table.Rows[0][1].ToString());
                }
            }
            catch (Exception)
            {
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                sach.Rows.Remove(sach.Rows[index]);
                if (index > 0) index--;
                for (int i = 0; i < sach.Rows.Count; i++)
                {
                    sach.Rows[i]["STT"] = i + 1;
                }
                txtSoLuong.Text = dataSach.Rows.Count.ToString();
            }
        }

        private void dataSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < sach.Rows.Count; i++)
            {
                if (i != index && index >= 0 && !String.IsNullOrWhiteSpace(dataSach[0, index].Value.ToString()))
                {
                    try
                    {
                        if (string.Compare(dataSach[0, i].Value.ToString(), dataSach[0, index].Value.ToString()) == 0)
                        {
                            MessageBox.Show("Sách Đã Được Chọn", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            dataSach[0, index].Value = "";
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        private void txtID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNguoiMuon.Text = conn.getString("select HoTen from SinhVien Where ID='" + txtID.SelectedValue + "'");
        }

        private void dataSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
