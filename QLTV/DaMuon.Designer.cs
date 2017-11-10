namespace QLTV
{
    partial class DaMuon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataSinhVien = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InBC = new System.Windows.Forms.Button();
            this.bntXem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDen = new System.Windows.Forms.DateTimePicker();
            this.dateTu = new System.Windows.Forms.DateTimePicker();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuTrach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSinhVien)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataSinhVien);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Sinh Viên Đã Mượn Sách";
            // 
            // dataSinhVien
            // 
            this.dataSinhVien.AllowUserToAddRows = false;
            this.dataSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ID,
            this.HoTen,
            this.MaMuon,
            this.SoLuong,
            this.NgayMuon,
            this.NgayHen,
            this.PhuTrach});
            this.dataSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSinhVien.Location = new System.Drawing.Point(3, 19);
            this.dataSinhVien.Name = "dataSinhVien";
            this.dataSinhVien.RowHeadersVisible = false;
            this.dataSinhVien.Size = new System.Drawing.Size(729, 231);
            this.dataSinhVien.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 253);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InBC);
            this.panel1.Controls.Add(this.bntXem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateDen);
            this.panel1.Controls.Add(this.dateTu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 57);
            this.panel1.TabIndex = 2;
            // 
            // InBC
            // 
            this.InBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InBC.Location = new System.Drawing.Point(570, 15);
            this.InBC.Name = "InBC";
            this.InBC.Size = new System.Drawing.Size(103, 26);
            this.InBC.TabIndex = 11;
            this.InBC.Text = "In Báo Cáo";
            this.InBC.UseVisualStyleBackColor = true;
            this.InBC.Click += new System.EventHandler(this.InBC_Click);
            // 
            // bntXem
            // 
            this.bntXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntXem.Location = new System.Drawing.Point(457, 15);
            this.bntXem.Name = "bntXem";
            this.bntXem.Size = new System.Drawing.Size(75, 26);
            this.bntXem.TabIndex = 10;
            this.bntXem.Text = "Xem";
            this.bntXem.UseVisualStyleBackColor = true;
            this.bntXem.Click += new System.EventHandler(this.bntXem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đến Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Từ Ngày";
            // 
            // dateDen
            // 
            this.dateDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDen.Location = new System.Drawing.Point(333, 16);
            this.dateDen.Name = "dateDen";
            this.dateDen.Size = new System.Drawing.Size(105, 23);
            this.dateDen.TabIndex = 7;
            // 
            // dateTu
            // 
            this.dateTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTu.Location = new System.Drawing.Point(118, 16);
            this.dateTu.Name = "dateTu";
            this.dateTu.Size = new System.Drawing.Size(105, 23);
            this.dateTu.TabIndex = 6;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 40;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 60;
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 75;
            // 
            // MaMuon
            // 
            this.MaMuon.DataPropertyName = "MaMuon";
            this.MaMuon.HeaderText = "Mã Mượn";
            this.MaMuon.Name = "MaMuon";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // NgayMuon
            // 
            this.NgayMuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.MinimumWidth = 110;
            this.NgayMuon.Name = "NgayMuon";
            // 
            // NgayHen
            // 
            this.NgayHen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayHen.DataPropertyName = "NgayHon";
            this.NgayHen.HeaderText = "Ngày hẹn";
            this.NgayHen.MinimumWidth = 100;
            this.NgayHen.Name = "NgayHen";
            // 
            // PhuTrach
            // 
            this.PhuTrach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhuTrach.DataPropertyName = "PhuTrach";
            this.PhuTrach.HeaderText = "Phụ trách";
            this.PhuTrach.MinimumWidth = 100;
            this.PhuTrach.Name = "PhuTrach";
            // 
            // DaMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DaMuon";
            this.Size = new System.Drawing.Size(735, 310);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSinhVien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataSinhVien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button InBC;
        private System.Windows.Forms.Button bntXem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDen;
        private System.Windows.Forms.DateTimePicker dateTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHen;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuTrach;
    }
}
