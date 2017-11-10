using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTV.Object;
using Microsoft.Reporting.WinForms;

namespace QLTV
{
    public partial class frmBaoCao : Form
    {
        private Connect ketnoi = new Connect();
        private DataSet ds;
        private string name, sql, tenbc;


        public frmBaoCao(string sql, string name, string tenbc)
        {
            InitializeComponent();
            this.name = name;
            this.sql = sql;
            this.tenbc = tenbc;
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            ds = ketnoi.getSet(sql);
            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
            rpvBaoCao.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo
            rpvBaoCao.LocalReport.ReportPath = "E:/QLTV/QLTV/report/" + tenbc + ".rdlc";
            //Nếu có dữ liệu
            //  if (ds.Tables[0].Rows.Count > 0)
            //  {
            //Tạo nguồn dữ liệu cho báo cáo
            ReportDataSource rds = new ReportDataSource();
            rds.Name = name;
            rds.Value = ds.Tables[0];
            //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
            rpvBaoCao.LocalReport.DataSources.Clear();
            //Add dữ liệu vào báo cáo
            rpvBaoCao.LocalReport.DataSources.Add(rds);
            //Refresh lại báo cáo

            this.rpvBaoCao.RefreshReport();
        }
    }
}
