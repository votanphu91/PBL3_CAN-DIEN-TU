using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PBL3_Candientu1
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {

            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-3TT8640\WINCC;Initial Catalog=test;Integrated Security=True");   // ket noi voi CSDL
            try
            {
                Con.Open();
                string tk = txtUsername.Text;   // gan bien tk de tri xuat trong CSDL
                string mk = txtPassword.Text;
                string sql = "select *from DangNhaptk where Taikhoan='" + tk + "' and MatKhau='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, Con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    this.Hide();
                    frmMain main = new frmMain();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tai khoan hoac mat khau sai\n vui long nhap lai", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
