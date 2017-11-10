namespace QLTV
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bntDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.bntDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.bntThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bntSach = new System.Windows.Forms.ToolStripMenuItem();
            this.bntSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.bntTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnTrảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bntMuonSach = new System.Windows.Forms.ToolStripMenuItem();
            this.bntTraSach = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bntDaMuon = new System.Windows.Forms.ToolStripMenuItem();
            this.bntTreHen = new System.Windows.Forms.ToolStripMenuItem();
            this.bntDaTra = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(735, 28);
            this.panelTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(209, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHẦN MỀN QUẢN LÝ THƯ VIỆN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelMain);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 337);
            this.panel1.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 27);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(735, 310);
            this.panelMain.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.bntTimKiem,
            this.mượnTrảSáchToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heToolStripMenuItem
            // 
            this.heToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bntDangNhap,
            this.bntDoiMatKhau,
            this.bntThoat});
            this.heToolStripMenuItem.Name = "heToolStripMenuItem";
            this.heToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.heToolStripMenuItem.Text = "&Hệ Thống";
            // 
            // bntDangNhap
            // 
            this.bntDangNhap.Name = "bntDangNhap";
            this.bntDangNhap.Size = new System.Drawing.Size(176, 24);
            this.bntDangNhap.Text = "&Đăng Nhập Lại";
            this.bntDangNhap.Click += new System.EventHandler(this.bntDangNhap_Click);
            // 
            // bntDoiMatKhau
            // 
            this.bntDoiMatKhau.Name = "bntDoiMatKhau";
            this.bntDoiMatKhau.Size = new System.Drawing.Size(176, 24);
            this.bntDoiMatKhau.Text = "&Đổi Mật Khẩu";
            this.bntDoiMatKhau.Click += new System.EventHandler(this.bntDoiMatKhau_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(176, 24);
            this.bntThoat.Text = "&Thoát";
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bntSach,
            this.bntSinhVien});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.quảnLýToolStripMenuItem.Text = "&Quản Lý";
            // 
            // bntSach
            // 
            this.bntSach.Name = "bntSach";
            this.bntSach.Size = new System.Drawing.Size(139, 24);
            this.bntSach.Text = "&Sách";
            this.bntSach.Click += new System.EventHandler(this.bntSach_Click);
            // 
            // bntSinhVien
            // 
            this.bntSinhVien.Name = "bntSinhVien";
            this.bntSinhVien.Size = new System.Drawing.Size(139, 24);
            this.bntSinhVien.Text = "&Sinh Viên";
            this.bntSinhVien.Click += new System.EventHandler(this.bntSinhVien_Click);
            // 
            // bntTimKiem
            // 
            this.bntTimKiem.Name = "bntTimKiem";
            this.bntTimKiem.Size = new System.Drawing.Size(84, 23);
            this.bntTimKiem.Text = "&Tìm Kiếm";
            this.bntTimKiem.Click += new System.EventHandler(this.bntTimKiem_Click);
            // 
            // mượnTrảSáchToolStripMenuItem
            // 
            this.mượnTrảSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bntMuonSach,
            this.bntTraSach});
            this.mượnTrảSáchToolStripMenuItem.Name = "mượnTrảSáchToolStripMenuItem";
            this.mượnTrảSáchToolStripMenuItem.Size = new System.Drawing.Size(120, 23);
            this.mượnTrảSáchToolStripMenuItem.Text = "&Mượn Trả Sách";
            // 
            // bntMuonSach
            // 
            this.bntMuonSach.Name = "bntMuonSach";
            this.bntMuonSach.Size = new System.Drawing.Size(152, 24);
            this.bntMuonSach.Text = "&Mượn Sách";
            this.bntMuonSach.Click += new System.EventHandler(this.bntMuonSach_Click);
            // 
            // bntTraSach
            // 
            this.bntTraSach.Name = "bntTraSach";
            this.bntTraSach.Size = new System.Drawing.Size(152, 24);
            this.bntTraSach.Text = "&Trả Sách";
            this.bntTraSach.Click += new System.EventHandler(this.bntTraSach_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bntDaMuon,
            this.bntTreHen,
            this.bntDaTra});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.thốngKêToolStripMenuItem.Text = "&Thống Kê";
            // 
            // bntDaMuon
            // 
            this.bntDaMuon.Name = "bntDaMuon";
            this.bntDaMuon.Size = new System.Drawing.Size(214, 24);
            this.bntDaMuon.Text = "&Sách Đã Mượn";
            this.bntDaMuon.Click += new System.EventHandler(this.bntDaMuon_Click);
            // 
            // bntTreHen
            // 
            this.bntTreHen.Name = "bntTreHen";
            this.bntTreHen.Size = new System.Drawing.Size(214, 24);
            this.bntTreHen.Text = "&Sách Đã Trể Hẹn";
            this.bntTreHen.Click += new System.EventHandler(this.bntTreHen_Click);
            // 
            // bntDaTra
            // 
            this.bntDaTra.Name = "bntDaTra";
            this.bntDaTra.Size = new System.Drawing.Size(214, 24);
            this.bntDaTra.Text = "&Sách Trong Thư Viện";
            this.bntDaTra.Click += new System.EventHandler(this.bntDaTra_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 365);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bntDangNhap;
        private System.Windows.Forms.ToolStripMenuItem bntDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem bntThoat;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bntSach;
        private System.Windows.Forms.ToolStripMenuItem bntSinhVien;
        private System.Windows.Forms.ToolStripMenuItem bntTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mượnTrảSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bntMuonSach;
        private System.Windows.Forms.ToolStripMenuItem bntTraSach;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bntDaMuon;
        private System.Windows.Forms.ToolStripMenuItem bntDaTra;
        private System.Windows.Forms.ToolStripMenuItem bntTreHen;

    }
}

