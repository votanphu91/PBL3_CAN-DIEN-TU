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
using Microsoft.ReportingServices.Diagnostics.Internal;

namespace PBL3_Candientu1
{
    public partial class frmAddProduct : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string sqlConn = @"Data Source=DESKTOP-3TT8640\WINCC;Initial Catalog=test;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();                  // day toàn bộ dữ liệu từ SQL xuong table
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            connection= new SqlConnection(sqlConn);
            connection.Open();
            khoitaobang();
        }
        private void khoitaobang()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from BAI62";
            adapter.SelectCommand= command;
            table.Clear();
            adapter.Fill(table);
            dataGridView.DataSource= table;
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[0].Width = 150;
            dataGridView.Columns[1].Width = 260;
            dataGridView.Columns[2].Width = 250;
            dataGridView.Columns[3].Width = 260;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Insert into BAI62 values(@barcode, @tenhanghoa, @donvitinh, @giathanh)";
            command.Parameters.AddWithValue("@barcode", txtBarcode.Text);
            command.Parameters.AddWithValue("@tenhanghoa", txtTenhanghoa.Text);
            command.Parameters.AddWithValue("@donvitinh", txtDonvitinh.Text);
            command.Parameters.AddWithValue("@giathanh", txtGiathanh.Text);
            command.ExecuteNonQuery();
            khoitaobang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE BAI62 SET Barcode = '"+txtBarcode.Text+"',Tenhanghoa = N'"+txtTenhanghoa.Text+"',Donvitinh = '"+txtDonvitinh.Text+"',Giathanh = '"+txtGiathanh.Text+"' where Barcode = '"+txtBarcode.Text+"'";

            command.ExecuteNonQuery();
            khoitaobang();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from BAI62  where Barcode=(@barcode)";
            command.Parameters.AddWithValue("@barcode", txtBarcode.Text);
            command.ExecuteNonQuery();
            khoitaobang();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarcode.ReadOnly = true;
            int i;
            i = dataGridView.CurrentRow.Index;
            txtBarcode.Text = dataGridView.Rows[i].Cells[0].Value.ToString();
            txtTenhanghoa.Text = dataGridView.Rows[i].Cells[1].Value.ToString();
            txtDonvitinh.Text = dataGridView.Rows[i].Cells[2].Value.ToString();
            txtGiathanh.Text = dataGridView.Rows[i].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from BAI62 where Tenhanghoa LIKE '%' + @tenhanghoa + '%'";
            command.Parameters.AddWithValue("@tenhanghoa", txtTen_S.Text);
            command.ExecuteNonQuery();
            SqlDataReader dapter1 = command.ExecuteReader();
            DataTable table1 = new DataTable();
            table1.Load(dapter1);
            dataGridView.DataSource= table1;
        }
    }
}
 