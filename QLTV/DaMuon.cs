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
    public partial class DaMuon : UserControl
    {
        private Connect conn = new Connect();
        private DataTable sinhvien;

        public DaMuon()
        {
            InitializeComponent();
        }

        private void bntXem_Click(object sender, EventArgs e)
        {
            sinhvien = conn.getTable(@"select sv.ID, HoTen, m.MaMuon, m.SOLUONG, NgayMuon, NgayHon, PhuTrach from sinhvien sv
                                    join Muon m on sv.ID= m.ID where ngaytra = '1900-01-01' and ngaymuon >='"+dateTu.Value+"' and ngaymuon<='"+dateDen.Value+"'");
            sinhvien.Columns.Add("STT");
            for (int i = 0; i < sinhvien.Rows.Count; i++)
            {
                sinhvien.Rows[i]["STT"] = i + 1;
            }
            dataSinhVien.DataSource = sinhvien;
        }

        private void InBC_Click(object sender, EventArgs e)
        {
            frmBaoCao print = new frmBaoCao(@"select sv.ID, HoTen, m.MaMuon, m.SOLUONG, NgayMuon, NgayHon, PhuTrach from sinhvien sv
                                    join Muon m on sv.ID= m.ID where ngaytra = '1900-01-01' and ngaymuon >='" + dateTu.Value + "' and ngaymuon<='" + dateDen.Value + "'","DaMuon","rptDaMuon");
            print.ShowDialog();
        }
    }
}
