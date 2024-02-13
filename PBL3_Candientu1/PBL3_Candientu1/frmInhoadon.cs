using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_Candientu1
{
    public partial class frmInhoadon : Form
    {
        private frmScaner frmscaner;
        public frmInhoadon(frmScaner frmscaner)
        {
            InitializeComponent();
            this.frmscaner = frmscaner;
        }

        public void frmInhoadon_Load(object sender, EventArgs e)
        {
            double tongtienhang = this.frmscaner.Tongtienhang;
            double tongkhoiluong = this.frmscaner.Tongkhoiluong;
            string tenkhachhang = this.frmscaner.TenKhachHang;
            string sodienthoai = this.frmscaner.UID_Khachhang;

            ReportParameter Tongtienhang = new ReportParameter("Tongtienhang", tongtienhang.ToString());            // tao cac paramerter hien thi dulieu vao bao cao report
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { Tongtienhang });
            ReportParameter Tongkhoiluong = new ReportParameter("Tongkhoiluong", tongkhoiluong.ToString());
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { Tongkhoiluong });
            ReportParameter TenKhachHang = new ReportParameter("TenKhachHang", tenkhachhang);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { TenKhachHang });
            ReportParameter UID_Khachhang = new ReportParameter("UID_Khachhang", sodienthoai);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { UID_Khachhang });

            this.reportViewer1.RefreshReport();
            
        }
    }
}
