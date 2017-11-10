using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTV
{
    public partial class Main : Form
    {
        private string tk;
        public Main(string tk)
        {
            InitializeComponent();
            this.tk = tk;
        }

        private void bntSinhVien_Click(object sender, EventArgs e)
        {
            this.Text = "QUẢN LÝ SINH VIÊN";
            SinhVien sinhvien = new SinhVien();
            sinhvien.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(sinhvien);
        }

        private void bntSach_Click(object sender, EventArgs e)
        {
            this.Text = "QUẢN LÝ SÁCH";
            Sach sach = new Sach();
            sach.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(sach);
        }

        private void bntTimKiem_Click(object sender, EventArgs e)
        {
            this.Text = "TÌM KIẾM SÁCH";
            TimKiem tim = new TimKiem();
            tim.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(tim);
        }

        private void bntMuonSach_Click(object sender, EventArgs e)
        {
            this.Text = "MƯỢN SÁCH";
            MuonSach muon = new MuonSach();
            muon.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(muon);
        }

        private void bntTraSach_Click(object sender, EventArgs e)
        {
            this.Text = "MƯỢN SÁCH";
            TraSach tra = new TraSach();
            tra.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(tra);
        }

        private void bntDaMuon_Click(object sender, EventArgs e)
        {
            this.Text = "BÁO CÁO SINH VIÊN MƯỢN SÁCH";
            DaMuon damuon = new DaMuon();
            damuon.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(damuon);

        }

        private void bntDaTra_Click(object sender, EventArgs e)
        {
            this.Text = "BÁO CÁO SINH VIÊN TRẢ SÁCH";
            TrongThuVien datra = new TrongThuVien();
            datra.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(datra);
        }

        private void bntTreHen_Click(object sender, EventArgs e)
        {
            this.Text = "BÁO CÁO SINH VIÊN TRỄ HẸN";
            TreHen trehen = new TreHen();
            trehen.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(trehen);
        }

        private void bntDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap = new DangNhap();
            dangnhap.ShowDialog();
            this.Close();
        }

        private void bntDoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau doimatkhau = new DoiMatKhau(tk);
            doimatkhau.ShowDialog();
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

    }
}
