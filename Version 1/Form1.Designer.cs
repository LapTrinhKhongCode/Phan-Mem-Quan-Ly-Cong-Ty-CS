namespace Version_1
{
    partial class frmChinh
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
            this.groupThongTinChung = new System.Windows.Forms.GroupBox();
            this.groupThongTinRieng = new System.Windows.Forms.GroupBox();
            this.txtThongTinRieng = new System.Windows.Forms.TextBox();
            this.lblThongTinRieng = new System.Windows.Forms.Label();
            this.rdbManager = new System.Windows.Forms.RadioButton();
            this.rdbDesigner = new System.Windows.Forms.RadioButton();
            this.rdbTester = new System.Windows.Forms.RadioButton();
            this.rdbProgrammer = new System.Windows.Forms.RadioButton();
            this.txtLuongCanBan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.groupDanhSachNhanVien = new System.Windows.Forms.GroupBox();
            this.lstView = new System.Windows.Forms.ListView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupThongTinChung.SuspendLayout();
            this.groupThongTinRieng.SuspendLayout();
            this.groupDanhSachNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupThongTinChung
            // 
            this.groupThongTinChung.Controls.Add(this.groupThongTinRieng);
            this.groupThongTinChung.Controls.Add(this.rdbManager);
            this.groupThongTinChung.Controls.Add(this.rdbDesigner);
            this.groupThongTinChung.Controls.Add(this.rdbTester);
            this.groupThongTinChung.Controls.Add(this.rdbProgrammer);
            this.groupThongTinChung.Controls.Add(this.txtLuongCanBan);
            this.groupThongTinChung.Controls.Add(this.label6);
            this.groupThongTinChung.Controls.Add(this.txtHeSoLuong);
            this.groupThongTinChung.Controls.Add(this.label5);
            this.groupThongTinChung.Controls.Add(this.txtDiaChi);
            this.groupThongTinChung.Controls.Add(this.label4);
            this.groupThongTinChung.Controls.Add(this.dtpNgaySinh);
            this.groupThongTinChung.Controls.Add(this.label3);
            this.groupThongTinChung.Controls.Add(this.txtHoTen);
            this.groupThongTinChung.Controls.Add(this.label2);
            this.groupThongTinChung.Controls.Add(this.txtMaSo);
            this.groupThongTinChung.Controls.Add(this.label1);
            this.groupThongTinChung.Location = new System.Drawing.Point(24, 26);
            this.groupThongTinChung.Name = "groupThongTinChung";
            this.groupThongTinChung.Size = new System.Drawing.Size(1207, 329);
            this.groupThongTinChung.TabIndex = 0;
            this.groupThongTinChung.TabStop = false;
            this.groupThongTinChung.Text = "Thông Tin Chung";
            // 
            // groupThongTinRieng
            // 
            this.groupThongTinRieng.Controls.Add(this.txtThongTinRieng);
            this.groupThongTinRieng.Controls.Add(this.lblThongTinRieng);
            this.groupThongTinRieng.Location = new System.Drawing.Point(329, 189);
            this.groupThongTinRieng.Name = "groupThongTinRieng";
            this.groupThongTinRieng.Size = new System.Drawing.Size(550, 101);
            this.groupThongTinRieng.TabIndex = 1;
            this.groupThongTinRieng.TabStop = false;
            this.groupThongTinRieng.Text = "Thông Tin Riêng";
            this.groupThongTinRieng.Visible = false;
            // 
            // txtThongTinRieng
            // 
            this.txtThongTinRieng.Location = new System.Drawing.Point(237, 35);
            this.txtThongTinRieng.Name = "txtThongTinRieng";
            this.txtThongTinRieng.Size = new System.Drawing.Size(220, 22);
            this.txtThongTinRieng.TabIndex = 3;
            // 
            // lblThongTinRieng
            // 
            this.lblThongTinRieng.AutoSize = true;
            this.lblThongTinRieng.Location = new System.Drawing.Point(90, 40);
            this.lblThongTinRieng.Name = "lblThongTinRieng";
            this.lblThongTinRieng.Size = new System.Drawing.Size(114, 17);
            this.lblThongTinRieng.TabIndex = 2;
            this.lblThongTinRieng.Text = "Thông Tin Riêng";
            // 
            // rdbManager
            // 
            this.rdbManager.AutoSize = true;
            this.rdbManager.Location = new System.Drawing.Point(760, 141);
            this.rdbManager.Name = "rdbManager";
            this.rdbManager.Size = new System.Drawing.Size(85, 21);
            this.rdbManager.TabIndex = 15;
            this.rdbManager.TabStop = true;
            this.rdbManager.Text = "Manager";
            this.rdbManager.UseVisualStyleBackColor = true;
            this.rdbManager.Click += new System.EventHandler(this.rdbManager_Click);
            // 
            // rdbDesigner
            // 
            this.rdbDesigner.AutoSize = true;
            this.rdbDesigner.Location = new System.Drawing.Point(629, 143);
            this.rdbDesigner.Name = "rdbDesigner";
            this.rdbDesigner.Size = new System.Drawing.Size(86, 21);
            this.rdbDesigner.TabIndex = 14;
            this.rdbDesigner.TabStop = true;
            this.rdbDesigner.Text = "Designer";
            this.rdbDesigner.UseVisualStyleBackColor = true;
            this.rdbDesigner.Click += new System.EventHandler(this.rdbDesigner_Click);
            // 
            // rdbTester
            // 
            this.rdbTester.AutoSize = true;
            this.rdbTester.Location = new System.Drawing.Point(485, 143);
            this.rdbTester.Name = "rdbTester";
            this.rdbTester.Size = new System.Drawing.Size(70, 21);
            this.rdbTester.TabIndex = 13;
            this.rdbTester.TabStop = true;
            this.rdbTester.Text = "Tester";
            this.rdbTester.UseVisualStyleBackColor = true;
            this.rdbTester.Click += new System.EventHandler(this.rdbTester_Click);
            // 
            // rdbProgrammer
            // 
            this.rdbProgrammer.AutoSize = true;
            this.rdbProgrammer.Location = new System.Drawing.Point(329, 143);
            this.rdbProgrammer.Name = "rdbProgrammer";
            this.rdbProgrammer.Size = new System.Drawing.Size(107, 21);
            this.rdbProgrammer.TabIndex = 12;
            this.rdbProgrammer.TabStop = true;
            this.rdbProgrammer.Text = "Programmer";
            this.rdbProgrammer.UseVisualStyleBackColor = true;
            this.rdbProgrammer.Click += new System.EventHandler(this.rdbProgrammer_Click);
            // 
            // txtLuongCanBan
            // 
            this.txtLuongCanBan.Location = new System.Drawing.Point(957, 88);
            this.txtLuongCanBan.Name = "txtLuongCanBan";
            this.txtLuongCanBan.Size = new System.Drawing.Size(100, 22);
            this.txtLuongCanBan.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(829, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lương căn bản (*)";
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Location = new System.Drawing.Point(702, 86);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Size = new System.Drawing.Size(100, 22);
            this.txtHeSoLuong.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(593, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hệ số lương (*)";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(702, 31);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 22);
            this.txtDiaChi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ (*)";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(270, 86);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(277, 22);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh (*)";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(481, 33);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên (*)";
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(256, 33);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(100, 22);
            this.txtMaSo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số (*)";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(24, 392);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(193, 85);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(266, 392);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(182, 85);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(505, 392);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(141, 85);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.Location = new System.Drawing.Point(693, 392);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(176, 85);
            this.btnSapXep.TabIndex = 4;
            this.btnSapXep.Text = "Sắp Xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            // 
            // groupDanhSachNhanVien
            // 
            this.groupDanhSachNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDanhSachNhanVien.Controls.Add(this.lstView);
            this.groupDanhSachNhanVien.Location = new System.Drawing.Point(24, 579);
            this.groupDanhSachNhanVien.Name = "groupDanhSachNhanVien";
            this.groupDanhSachNhanVien.Size = new System.Drawing.Size(1271, 203);
            this.groupDanhSachNhanVien.TabIndex = 5;
            this.groupDanhSachNhanVien.TabStop = false;
            this.groupDanhSachNhanVien.Text = "Danh Sách Nhân Viên Trong Công Ty";
            // 
            // lstView
            // 
            this.lstView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstView.FullRowSelect = true;
            this.lstView.GridLines = true;
            this.lstView.Location = new System.Drawing.Point(3, 18);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(1265, 182);
            this.lstView.TabIndex = 0;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(921, 392);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(176, 85);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(27, 511);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(220, 22);
            this.txtTimKiem.TabIndex = 7;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 817);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupDanhSachNhanVien);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupThongTinChung);
            this.Name = "frmChinh";
            this.Text = "Phần Mềm Quản Lý";
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.groupThongTinChung.ResumeLayout(false);
            this.groupThongTinChung.PerformLayout();
            this.groupThongTinRieng.ResumeLayout(false);
            this.groupThongTinRieng.PerformLayout();
            this.groupDanhSachNhanVien.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupThongTinChung;
        private System.Windows.Forms.TextBox txtLuongCanBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbManager;
        private System.Windows.Forms.RadioButton rdbDesigner;
        private System.Windows.Forms.RadioButton rdbTester;
        private System.Windows.Forms.RadioButton rdbProgrammer;
        private System.Windows.Forms.GroupBox groupThongTinRieng;
        private System.Windows.Forms.TextBox txtThongTinRieng;
        private System.Windows.Forms.Label lblThongTinRieng;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.GroupBox groupDanhSachNhanVien;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}

