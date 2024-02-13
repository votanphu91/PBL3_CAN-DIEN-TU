namespace PBL3_Candientu1
{
    partial class frmScaner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblClock = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnInhoadon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKhoiluong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenhanghoa = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.txtGiathanh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTongkhoiluong = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.txtTonghoadon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongtienhang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1503, 480);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblClock);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnInhoadon);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtTongkhoiluong);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cboDevice);
            this.groupBox1.Controls.Add(this.txtTonghoadon);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtQR);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTongtienhang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1503, 480);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn bán lẻ";
            // 
            // lblClock
            // 
            this.lblClock.Location = new System.Drawing.Point(348, 33);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(210, 33);
            this.lblClock.TabIndex = 58;
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(1229, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::PBL3_Candientu1.Properties.Resources.icon_renew_32;
            this.btnXoa.Location = new System.Drawing.Point(642, 309);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 62);
            this.btnXoa.TabIndex = 50;
            this.btnXoa.Text = "Renew";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnInhoadon
            // 
            this.btnInhoadon.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhoadon.Image = global::PBL3_Candientu1.Properties.Resources.icons8_print_32;
            this.btnInhoadon.Location = new System.Drawing.Point(857, 309);
            this.btnInhoadon.Name = "btnInhoadon";
            this.btnInhoadon.Size = new System.Drawing.Size(131, 58);
            this.btnInhoadon.TabIndex = 25;
            this.btnInhoadon.Text = "Print Bill";
            this.btnInhoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInhoadon.UseVisualStyleBackColor = true;
            this.btnInhoadon.Click += new System.EventHandler(this.btnInhoadon_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKhoiluong);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTenhanghoa);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtThanhtien);
            this.groupBox2.Controls.Add(this.txtGiathanh);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(57, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 239);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // txtKhoiluong
            // 
            this.txtKhoiluong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKhoiluong.Location = new System.Drawing.Point(173, 97);
            this.txtKhoiluong.Multiline = true;
            this.txtKhoiluong.Name = "txtKhoiluong";
            this.txtKhoiluong.ReadOnly = true;
            this.txtKhoiluong.Size = new System.Drawing.Size(199, 25);
            this.txtKhoiluong.TabIndex = 6;
            this.txtKhoiluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tên hàng hóa:";
            // 
            // txtTenhanghoa
            // 
            this.txtTenhanghoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTenhanghoa.Location = new System.Drawing.Point(173, 46);
            this.txtTenhanghoa.Multiline = true;
            this.txtTenhanghoa.Name = "txtTenhanghoa";
            this.txtTenhanghoa.ReadOnly = true;
            this.txtTenhanghoa.Size = new System.Drawing.Size(199, 25);
            this.txtTenhanghoa.TabIndex = 6;
            this.txtTenhanghoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(43, 199);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Thành tiền:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Giá thành:";
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtThanhtien.Location = new System.Drawing.Point(173, 199);
            this.txtThanhtien.Multiline = true;
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.ReadOnly = true;
            this.txtThanhtien.Size = new System.Drawing.Size(199, 25);
            this.txtThanhtien.TabIndex = 6;
            this.txtThanhtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGiathanh
            // 
            this.txtGiathanh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGiathanh.Location = new System.Drawing.Point(173, 150);
            this.txtGiathanh.Multiline = true;
            this.txtGiathanh.Name = "txtGiathanh";
            this.txtGiathanh.ReadOnly = true;
            this.txtGiathanh.Size = new System.Drawing.Size(199, 25);
            this.txtGiathanh.TabIndex = 6;
            this.txtGiathanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Khối lượng :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkOrange;
            this.label18.Location = new System.Drawing.Point(390, 207);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "VND";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkOrange;
            this.label14.Location = new System.Drawing.Point(390, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "VND";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkOrange;
            this.label12.Location = new System.Drawing.Point(390, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "KG";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Image = global::PBL3_Candientu1.Properties.Resources.icons8_usb_connected_32;
            this.btnConnect.Location = new System.Drawing.Point(1196, 309);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(123, 58);
            this.btnConnect.TabIndex = 56;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkOrange;
            this.label15.Location = new System.Drawing.Point(1014, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 17);
            this.label15.TabIndex = 40;
            this.label15.Text = "VND";
            // 
            // txtTongkhoiluong
            // 
            this.txtTongkhoiluong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTongkhoiluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongkhoiluong.Location = new System.Drawing.Point(769, 133);
            this.txtTongkhoiluong.Multiline = true;
            this.txtTongkhoiluong.Name = "txtTongkhoiluong";
            this.txtTongkhoiluong.ReadOnly = true;
            this.txtTongkhoiluong.Size = new System.Drawing.Size(219, 25);
            this.txtTongkhoiluong.TabIndex = 44;
            this.txtTongkhoiluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkOrange;
            this.label16.Location = new System.Drawing.Point(1014, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 17);
            this.label16.TabIndex = 41;
            this.label16.Text = "VND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(639, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Tổng khối lượng:";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Image = global::PBL3_Candientu1.Properties.Resources.icons8_usb_disconnected_32;
            this.btnDisconnect.Location = new System.Drawing.Point(1364, 309);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(127, 58);
            this.btnDisconnect.TabIndex = 57;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkOrange;
            this.label13.Location = new System.Drawing.Point(1014, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "KG";
            // 
            // cboDevice
            // 
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(1287, 12);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(204, 28);
            this.cboDevice.TabIndex = 54;
            // 
            // txtTonghoadon
            // 
            this.txtTonghoadon.BackColor = System.Drawing.Color.Gold;
            this.txtTonghoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTonghoadon.Location = new System.Drawing.Point(769, 226);
            this.txtTonghoadon.Multiline = true;
            this.txtTonghoadon.Name = "txtTonghoadon";
            this.txtTonghoadon.ReadOnly = true;
            this.txtTonghoadon.Size = new System.Drawing.Size(219, 43);
            this.txtTonghoadon.TabIndex = 46;
            this.txtTonghoadon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(639, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Tổng hóa đơn:";
            // 
            // txtQR
            // 
            this.txtQR.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQR.Location = new System.Drawing.Point(119, 33);
            this.txtQR.Multiline = true;
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(199, 33);
            this.txtQR.TabIndex = 47;
            this.txtQR.TextChanged += new System.EventHandler(this.txtQR_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1207, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Camera:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Mã Vạch:";
            // 
            // txtTongtienhang
            // 
            this.txtTongtienhang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTongtienhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongtienhang.Location = new System.Drawing.Point(769, 182);
            this.txtTongtienhang.Multiline = true;
            this.txtTongtienhang.Name = "txtTongtienhang";
            this.txtTongtienhang.ReadOnly = true;
            this.txtTongtienhang.Size = new System.Drawing.Size(219, 25);
            this.txtTongtienhang.TabIndex = 48;
            this.txtTongtienhang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(639, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Tỏng tiền hàng:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(769, 82);
            this.txtMaKH.Multiline = true;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(219, 25);
            this.txtMaKH.TabIndex = 49;
            this.txtMaKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(639, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Mã khách hàng:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(769, 30);
            this.txtTenKH.Multiline = true;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(219, 25);
            this.txtTenKH.TabIndex = 45;
            this.txtTenKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(639, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tên khách hàng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 480);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1503, 146);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1503, 146);
            this.dataGridView1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // frmScaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 626);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmScaner";
            this.Text = "frmScaner";
            this.Load += new System.EventHandler(this.frmScaner_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnInhoadon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKhoiluong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenhanghoa;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.TextBox txtGiathanh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTongkhoiluong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.TextBox txtTonghoadon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongtienhang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblClock;
    }
}