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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.IO;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using System.Net.Http.Headers;
using ZXing.QrCode.Internal;
using Microsoft.Reporting.WinForms;

namespace PBL3_Candientu1
{
    public partial class frmScaner : Form
    {
        public double Tongtienhang { get; set; }
        public double Tongkhoiluong { get; set; }
        public string TenKhachHang { get; set; }
        public string UID_Khachhang { get; set; }

        public frmScaner()
        {
            InitializeComponent();
            btnConnect.Enabled = true;     // an nut ngat ket noi
            btnDisconnect.Enabled = false;
            txtQR.Enabled = false;
        }
        private FilterInfoCollection filterInfoCollection;          // tạo biến thu thập có bao nhiêu camera kết nối với máy tính
        private VideoCaptureDevice captureDevice;                   // biến chọn camera để ghi hình để sử dụng

        private void frmScaner_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);              // thao tác với camera
            foreach (FilterInfo filterInfo in filterInfoCollection) cboDevice.Items.Add(filterInfo.Name);  // đẩy danh sách các camera vào combox
            cboDevice.SelectedIndex = 0;                                                                   // chọn camera đầu tiên hiển thị lên combox
            khoi_tao_bang();
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            // thiet lap cong com giao tiep may tinh tuy vao cong com nhan ma nguoi lt thiet lap theo y muon

            serialPort1.PortName = "COM5";
            serialPort1.BaudRate = Convert.ToInt32(9600);
            serialPort1.Open();

            // an nut ket noi di

            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            txtQR.Enabled = true;
            // ket noi va bat camera lên

            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;                                                       
            captureDevice.Start();
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();                    // ảnh thu được từ camera chụp được show lên trên picturebox
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    txtQR.Text = result.ToString();
                    timer1.Stop();
                    serialPort1.Write("1");                                      // gui tin hieu xuong VDK de phat coi keu
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }

        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();                // ngat giao tiep rs232
            btnConnect.Enabled = true;          // an nut ngat ket noi
            btnDisconnect.Enabled = false;
            txtQR.Text = "";
            txtQR.Enabled = false;
            timer2.Stop();
            timer3.Stop();
            if (captureDevice.IsRunning)         // Neu may anh runing thi ta off capture_device
            {
                captureDevice.Stop();
            }
            if (pictureBox1.Image != null)       // Giai phong hinh anh da scaner QR de tiep tuc scan cac lan sau
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string tam = serialPort1.ReadExisting();
            if (tam != "")
            {
                txtKhoiluong.Text = tam;
            }

        }
        string strCon = @"Data Source=DESKTOP-3TT8640\WINCC;Initial Catalog=test;Integrated Security=True";     // tạo chuổi kết nối với SQL
        SqlConnection sqlCon = null;
        double sum = 0;
        string donvi_tam;
        int tam1 = 0;
        private void txtQR_TextChanged_1(object sender, EventArgs e)
        {
            if (txtQR.Text != "")
            {
                if (sqlCon == null)                                                                     // rong thi tao va dong thi mo
                {
                    sqlCon = new SqlConnection(strCon);
                }
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                string maBarcode = txtQR.Text.Trim();                                                   // doi tuong thuc thi tri van lay csdl
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                using (SqlCommand cmd = new SqlCommand("select * from BAI62 where Barcode ='" + maBarcode + "'", sqlCon))         // gui truy van vao ket noi
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())      // thuc thidoc du lieu
                    {
                        while (reader.Read())
                        {
                            string tenhanghoa = reader.GetString(1);
                            string donvitinh = reader.GetString(2);
                            donvi_tam = donvitinh;
                            string giaThanh = reader.GetString(3);
                            txtTenhanghoa.Text = tenhanghoa;
                            txtGiathanh.Text = giaThanh;

                            int a = Convert.ToInt32(reader.GetString(3));                    // bien gia thanh
                            double b = Convert.ToDouble(txtKhoiluong.Text);                  // bien khoi luong
                            Tongtienhang = Tongtienhang + a * b;
                            Tongkhoiluong = Tongkhoiluong + b;
                            sum = a * b;

                            txtThanhtien.Text = Convert.ToString(sum);
                            txtTongkhoiluong.Text = Convert.ToString(Tongkhoiluong);
                            txtTongtienhang.Text = Convert.ToString(Tongtienhang);
                            txtTonghoadon.Text = Convert.ToString(Tongtienhang);
                            Add_dulieu();
                        }
                        reader.Close();
                    }
                }
                if (dataGridView1.Rows.Count - 1 > 0 && tam1 == 1)
                {
                    using (SqlCommand sqlCmd2 = new SqlCommand("Insert into DL_Banhang(Macode,TenSanPham,Soluong,Giaban,Thanhtien,Ngaymuahang) values(@code,@tensanpham,@soluong,@giaban,@thanhtien,@ngaymuahang)", sqlCon))
                    {
                        sqlCmd2.CommandType = CommandType.Text;
                        sqlCmd2.Parameters.AddWithValue("@code", txtQR.Text);
                        sqlCmd2.Parameters.AddWithValue("@tensanpham", txtTenhanghoa.Text);
                        sqlCmd2.Parameters.AddWithValue("@soluong", txtKhoiluong.Text);
                        sqlCmd2.Parameters.AddWithValue("@giaban", txtGiathanh.Text);
                        sqlCmd2.Parameters.AddWithValue("@thanhtien", txtThanhtien.Text);
                        sqlCmd2.Parameters.AddWithValue("@ngaymuahang", lblClock.Text);
                        sqlCmd2.ExecuteNonQuery();
                        tam1 = 0;
                    }
                }
            }
        }

        private void khoi_tao_bang()
        {
            dataGridView1.AutoGenerateColumns = false;
            const int NumberColumn = 7;
            dataGridView1.ColumnCount = NumberColumn;
            string[] list = new string[NumberColumn] { "Barcode", "Tenhanghoa", "Donvitinh", "Soluong", "Giaban", "Thanhtien", "Ngaygiomua" };
            string[] header_name = new string[NumberColumn] { "Barcode", "Tên hàng hóa", "Đơn vị tính", "Số lượng", "Giá bán", "Thành tiền", "Ngày giờ mua" };
            int[] width_col = new int[NumberColumn] { 150, 200, 150, 200, 200, 200, 250 };

            for (int i = 0; i < NumberColumn; i++)
            {
                dataGridView1.Columns[i].Name = list[i];
                dataGridView1.Columns[i].DataPropertyName = list[i];
                dataGridView1.Columns[i].HeaderText = header_name[i];
                dataGridView1.Columns[i].Width = width_col[i];
                dataGridView1.Columns[i].ValueType = typeof(String);
                dataGridView1.Columns[i].Visible = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            lblClock.Text = currentDateTime.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sum = 0;
            Tongkhoiluong = 0;
            Tongtienhang = 0;
            tam1 = 0;
            txtTenKH.Text = "";
            txtMaKH.Text = "";
            dataGridView1.Rows.Clear();
        }
        public void Add_dulieu()
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = txtQR.Text;
            row.Cells[1].Value = txtTenhanghoa.Text;
            row.Cells[2].Value = donvi_tam;
            row.Cells[3].Value = txtKhoiluong.Text;
            row.Cells[4].Value = txtGiathanh.Text;
            row.Cells[5].Value = txtThanhtien.Text;
            row.Cells[6].Value = lblClock.Text;
            dataGridView1.Rows.Add(row);
            tam1++;

        }
        ReportDataSource rs = new ReportDataSource();
        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            if(txtMaKH.Text.Length > 0 && txtTenKH.Text.Length >0)
            {
                TenKhachHang = txtTenKH.Text;
                UID_Khachhang = txtMaKH.Text;
                List<Dulieu1> list = new List<Dulieu1>();
                list.Clear();

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    Dulieu1 dulieu1 = new Dulieu1
                    {
                        Tenhanghoa = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                        Soluong = dataGridView1.Rows[i].Cells[3].Value.ToString(),
                        Thanhtien = dataGridView1.Rows[i].Cells[5].Value.ToString(),
                        Thoigianmua = dataGridView1.Rows[i].Cells[6].Value.ToString()
                    };
                    list.Add(dulieu1);
                }

                rs.Name = "DataSet1";
                rs.Value = list;
                frmInhoadon frm2 = new frmInhoadon(this);
                frm2.reportViewer1.LocalReport.DataSources.Clear();
                frm2.reportViewer1.LocalReport.DataSources.Add(rs);
                frm2.reportViewer1.LocalReport.ReportEmbeddedResource = "PBL3_Candientu1.Report1.rdlc";
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui long nhap ten KH", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
