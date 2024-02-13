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
    public partial class frmMain : Form
    {
        private Form activeForm;
        public frmMain() 
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;         // loại  bỏ đi các đường viền để cho form con giống với form cha
            childForm.Dock = DockStyle.Fill;                          // thuộc tính dock fill lấp đầy toàn bộ không gian của form cha
            this.panel4.Controls.Add(childForm);
            this.panel4.Tag = childForm;                              // thêm form con vào trong panel 4
            childForm.BringToFront();                                 // đẩy form con mới lên dể nó hiển thị phía trước 
            childForm.Show();                                         // hiển thị lên màn hình ở trong panel 4
        }

        private void btnScanerQR_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmScaner(), sender);

        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ban co muon dang xuat khong", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }

        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAddProduct(), sender);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frmScaner(), sender);
        }
    }
}
