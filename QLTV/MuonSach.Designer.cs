namespace QLTV
{
    partial class MuonSach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dateNgayHen = new System.Windows.Forms.DateTimePicker();
            this.dateNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNguoiMuon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaMuon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntluu = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataSach = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMaSach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.dateNgayHen);
            this.groupBox1.Controls.Add(this.dateNgayMuon);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNguoiMuon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaMuon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Người Mượn";
            // 
            // txtID
            // 
            this.txtID.FormattingEnabled = true;
            this.txtID.Location = new System.Drawing.Point(140, 91);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 24);
            this.txtID.TabIndex = 50;
            this.txtID.SelectedIndexChanged += new System.EventHandler(this.txtID_SelectedIndexChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(625, 29);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.Size = new System.Drawing.Size(100, 23);
            this.txtSoLuong.TabIndex = 49;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateNgayHen
            // 
            this.dateNgayHen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayHen.Location = new System.Drawing.Point(399, 58);
            this.dateNgayHen.Name = "dateNgayHen";
            this.dateNgayHen.Size = new System.Drawing.Size(145, 23);
            this.dateNgayHen.TabIndex = 4;
            // 
            // dateNgayMuon
            // 
            this.dateNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayMuon.Location = new System.Drawing.Point(140, 59);
            this.dateNgayMuon.Name = "dateNgayMuon";
            this.dateNgayMuon.Size = new System.Drawing.Size(121, 23);
            this.dateNgayMuon.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(550, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Số Lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(276, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Ngày Hẹn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Họ Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ngày Mượn";
            // 
            // txtNguoiMuon
            // 
            this.txtNguoiMuon.Location = new System.Drawing.Point(399, 85);
            this.txtNguoiMuon.Name = "txtNguoiMuon";
            this.txtNguoiMuon.Size = new System.Drawing.Size(145, 23);
            this.txtNguoiMuon.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "ID Người Mượn";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(399, 29);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(145, 23);
            this.txtHoTen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Người Phụ trách";
            // 
            // txtMaMuon
            // 
            this.txtMaMuon.Location = new System.Drawing.Point(140, 32);
            this.txtMaMuon.Name = "txtMaMuon";
            this.txtMaMuon.Size = new System.Drawing.Size(121, 23);
            this.txtMaMuon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã Mượn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bntluu);
            this.panel1.Controls.Add(this.bntThem);
            this.panel1.Controls.Add(this.bntXoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 25);
            this.panel1.TabIndex = 4;
            // 
            // bntluu
            // 
            this.bntluu.Location = new System.Drawing.Point(569, -1);
            this.bntluu.Name = "bntluu";
            this.bntluu.Size = new System.Drawing.Size(75, 26);
            this.bntluu.TabIndex = 46;
            this.bntluu.Text = "Lưu";
            this.bntluu.UseVisualStyleBackColor = true;
            this.bntluu.Click += new System.EventHandler(this.bntluu_Click);
            // 
            // bntThem
            // 
            this.bntThem.Location = new System.Drawing.Point(488, -1);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(75, 26);
            this.bntThem.TabIndex = 45;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.Location = new System.Drawing.Point(650, -1);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(75, 26);
            this.bntXoa.TabIndex = 47;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 159);
            this.panel2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataSach);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 159);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sách";
            // 
            // dataSach
            // 
            this.dataSach.AllowUserToAddRows = false;
            this.dataSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.cmbMaSach,
            this.TenSach,
            this.TacGia,
            this.NXB,
            this.SoTrang,
            this.Gia,
            this.Loai});
            this.dataSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSach.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataSach.Location = new System.Drawing.Point(3, 19);
            this.dataSach.Name = "dataSach";
            this.dataSach.RowHeadersVisible = false;
            this.dataSach.Size = new System.Drawing.Size(729, 137);
            this.dataSach.TabIndex = 2;
            this.dataSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSach_CellClick);
            this.dataSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSach_CellContentClick);
            this.dataSach.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSach_CellValueChanged);
            this.dataSach.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataSach_EditingControlShowing);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 40;
            // 
            // cmbMaSach
            // 
            this.cmbMaSach.HeaderText = "Mã";
            this.cmbMaSach.Name = "cmbMaSach";
            this.cmbMaSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbMaSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TenSach
            // 
            this.TenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 100;
            this.TenSach.Name = "TenSach";
            // 
            // TacGia
            // 
            this.TacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.FillWeight = 80F;
            this.TacGia.HeaderText = "Tác Giả";
            this.TacGia.MinimumWidth = 100;
            this.TacGia.Name = "TacGia";
            // 
            // NXB
            // 
            this.NXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NXB.DataPropertyName = "NXB";
            this.NXB.HeaderText = "NXB";
            this.NXB.MinimumWidth = 120;
            this.NXB.Name = "NXB";
            // 
            // SoTrang
            // 
            this.SoTrang.DataPropertyName = "SoTrang";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SoTrang.DefaultCellStyle = dataGridViewCellStyle1;
            this.SoTrang.HeaderText = "Số Trang";
            this.SoTrang.Name = "SoTrang";
            this.SoTrang.Width = 90;
            // 
            // Gia
            // 
            this.Gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia.DataPropertyName = "Gia";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Gia.DefaultCellStyle = dataGridViewCellStyle2;
            this.Gia.FillWeight = 80F;
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 90;
            this.Gia.Name = "Gia";
            // 
            // Loai
            // 
            this.Loai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Loai.DataPropertyName = "Loai";
            this.Loai.HeaderText = "Loại";
            this.Loai.MinimumWidth = 80;
            this.Loai.Name = "Loai";
            // 
            // MuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MuonSach";
            this.Size = new System.Drawing.Size(735, 310);
            this.Load += new System.EventHandler(this.MuonSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateNgayMuon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNguoiMuon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaMuon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateNgayHen;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button bntluu;
        private System.Windows.Forms.DataGridView dataSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.ComboBox txtID;
    }
}
