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
    public partial class TrongThuVien : UserControl
    {
        private Connect conn = new Connect();
        private DataTable sach;

        public TrongThuVien()
        {
            InitializeComponent();
        }

        private void TrongThuVien_Load(object sender, EventArgs e)
        {
            sach = conn.getTable("select MaSach, TenSach, TacGia, NXB, SoTrang, Gia, Loai from Sach where tinhtrang = 'tra'");
            sach.Columns.Add("STT");
            for (int i = 0; i < sach.Rows.Count; i++)
            {
                sach.Rows[i]["STT"] = i + 1;
            }
            dataSinhVien.DataSource = sach;
        }
    }
}
