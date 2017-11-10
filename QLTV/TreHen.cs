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
    public partial class TreHen : UserControl
    {
        private DataTable trehen;
        private Connect conn = new Connect();

        public TreHen()
        {
            InitializeComponent();
        }

        private void bntXem_Click(object sender, EventArgs e)
        {
            trehen = conn.getTable(@"select s.MaSach, TenSach, TacGia, NgayMuon, NgayHon, sv.ID, HoTen from SinhVien sv
							join Muon m on sv.ID = m.ID join CTMUON ct on ct.MAMUON = m.MAMUON join SACH s on s.MASACH = ct.MASACH
                            where NgayMuon >='"+dateTu.Value+"' and NgayMuon <= '"+dateDen.Value+"' and NgayHon <'"+DateTime.Today+"' and NgayTra ='1900-01-01'");
            trehen.Columns.Add("STT");
            for (int i = 0; i < trehen.Rows.Count; i++)
            {
                trehen.Rows[i]["STT"] = i + 1;
            }

            dataTreHen.DataSource = trehen;
        }

        private void InBC_Click(object sender, EventArgs e)
        {
            frmBaoCao print = new frmBaoCao(@"select s.MaSach, TenSach, TacGia, NgayMuon, NgayHon, sv.ID, HoTen from SinhVien sv
							join Muon m on sv.ID = m.ID join CTMUON ct on ct.MAMUON = m.MAMUON join SACH s on s.MASACH = ct.MASACH
                            where NgayMuon >='" + dateTu.Value + "' and NgayMuon <= '" + dateDen.Value + "' and NgayHon <'" + DateTime.Today + "' and NgayTra ='1900-01-01'","Muon","rptTreHen");
            print.ShowDialog();
        }


    }
}
