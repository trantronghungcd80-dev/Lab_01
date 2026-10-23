namespace Lab_01;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblTitle = new Label();
        grpThongTin = new GroupBox();
        lblHoTen = new Label();
        txtHoTen = new TextBox();
        lblNamSinh = new Label();
        txtNamSinh = new TextBox();
        lblEmail = new Label();
        txtEmail = new TextBox();
        grpGioiTinh = new GroupBox();
        radNam = new RadioButton();
        radNu = new RadioButton();
        lblKhoa = new Label();
        cboKhoa = new ComboBox();
        btnHienThi = new Button();
        btnXoa = new Button();
        btnThoat = new Button();
        grpKetQua = new GroupBox();
        txtKetQua = new TextBox();
        grpThongTin.SuspendLayout();
        grpGioiTinh.SuspendLayout();
        grpKetQua.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Dock = DockStyle.Top;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitle.ForeColor = Color.FromArgb(24, 76, 120);
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(624, 55);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "ỨNG DỤNG THÔNG TIN CÁ NHÂN";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // grpThongTin
        // 
        grpThongTin.Controls.Add(lblHoTen);
        grpThongTin.Controls.Add(txtHoTen);
        grpThongTin.Controls.Add(lblNamSinh);
        grpThongTin.Controls.Add(txtNamSinh);
        grpThongTin.Controls.Add(lblEmail);
        grpThongTin.Controls.Add(txtEmail);
        grpThongTin.Controls.Add(grpGioiTinh);
        grpThongTin.Controls.Add(lblKhoa);
        grpThongTin.Controls.Add(cboKhoa);
        grpThongTin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        grpThongTin.Location = new Point(25, 60);
        grpThongTin.Name = "grpThongTin";
        grpThongTin.Size = new Size(574, 280);
        grpThongTin.TabIndex = 1;
        grpThongTin.TabStop = false;
        grpThongTin.Text = "Thông tin chi tiết";
        // 
        // lblHoTen
        // 
        lblHoTen.AutoSize = true;
        lblHoTen.Location = new Point(25, 35);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Size = new Size(72, 19);
        lblHoTen.TabIndex = 0;
        lblHoTen.Text = "Họ và tên:";
        // 
        // txtHoTen
        // 
        txtHoTen.Location = new Point(130, 32);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.PlaceholderText = "Nhập họ tên sinh viên (ví dụ: Nguyễn Văn A)";
        txtHoTen.Size = new Size(415, 25);
        txtHoTen.TabIndex = 1;
        // 
        // lblNamSinh
        // 
        lblNamSinh.AutoSize = true;
        lblNamSinh.Location = new Point(25, 75);
        lblNamSinh.Name = "lblNamSinh";
        lblNamSinh.Size = new Size(70, 19);
        lblNamSinh.TabIndex = 2;
        lblNamSinh.Text = "Năm sinh:";
        // 
        // txtNamSinh
        // 
        txtNamSinh.Location = new Point(130, 72);
        txtNamSinh.Name = "txtNamSinh";
        txtNamSinh.PlaceholderText = "Nhập năm sinh (ví dụ: 2005)";
        txtNamSinh.Size = new Size(415, 25);
        txtNamSinh.TabIndex = 3;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Location = new Point(25, 115);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(44, 19);
        lblEmail.TabIndex = 4;
        lblEmail.Text = "Email:";
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(130, 112);
        txtEmail.Name = "txtEmail";
        txtEmail.PlaceholderText = "Nhập địa chỉ email (ví dụ: vana@example.com)";
        txtEmail.Size = new Size(415, 25);
        txtEmail.TabIndex = 5;
        // 
        // grpGioiTinh
        // 
        grpGioiTinh.Controls.Add(radNam);
        grpGioiTinh.Controls.Add(radNu);
        grpGioiTinh.Location = new Point(25, 150);
        grpGioiTinh.Name = "grpGioiTinh";
        grpGioiTinh.Size = new Size(520, 58);
        grpGioiTinh.TabIndex = 6;
        grpGioiTinh.TabStop = false;
        grpGioiTinh.Text = "Giới tính";
        // 
        // radNam
        // 
        radNam.AutoSize = true;
        radNam.Location = new Point(105, 24);
        radNam.Name = "radNam";
        radNam.Size = new Size(56, 23);
        radNam.TabIndex = 0;
        radNam.TabStop = true;
        radNam.Text = "Nam";
        radNam.UseVisualStyleBackColor = true;
        // 
        // radNu
        // 
        radNu.AutoSize = true;
        radNu.Location = new Point(250, 24);
        radNu.Name = "radNu";
        radNu.Size = new Size(45, 23);
        radNu.TabIndex = 1;
        radNu.TabStop = true;
        radNu.Text = "Nữ";
        radNu.UseVisualStyleBackColor = true;
        // 
        // lblKhoa
        // 
        lblKhoa.AutoSize = true;
        lblKhoa.Location = new Point(25, 230);
        lblKhoa.Name = "lblKhoa";
        lblKhoa.Size = new Size(76, 19);
        lblKhoa.TabIndex = 7;
        lblKhoa.Text = "Khoa / Lớp:";
        // 
        // cboKhoa
        // 
        cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
        cboKhoa.FormattingEnabled = true;
        cboKhoa.Location = new Point(130, 226);
        cboKhoa.Name = "cboKhoa";
        cboKhoa.Size = new Size(415, 25);
        cboKhoa.TabIndex = 8;
        // 
        // btnHienThi
        // 
        btnHienThi.BackColor = Color.FromArgb(13, 110, 253);
        btnHienThi.Cursor = Cursors.Hand;
        btnHienThi.FlatStyle = FlatStyle.System;
        btnHienThi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        btnHienThi.ForeColor = Color.White;
        btnHienThi.Location = new Point(95, 355);
        btnHienThi.Name = "btnHienThi";
        btnHienThi.Size = new Size(125, 38);
        btnHienThi.TabIndex = 2;
        btnHienThi.Text = "&Hiển thị";
        btnHienThi.UseVisualStyleBackColor = true;
        btnHienThi.Click += btnHienThi_Click;
        // 
        // btnXoa
        // 
        btnXoa.Cursor = Cursors.Hand;
        btnXoa.FlatStyle = FlatStyle.System;
        btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        btnXoa.Location = new Point(250, 355);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(125, 38);
        btnXoa.TabIndex = 3;
        btnXoa.Text = "&Xóa";
        btnXoa.UseVisualStyleBackColor = true;
        btnXoa.Click += btnXoa_Click;
        // 
        // btnThoat
        // 
        btnThoat.Cursor = Cursors.Hand;
        btnThoat.FlatStyle = FlatStyle.System;
        btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        btnThoat.Location = new Point(405, 355);
        btnThoat.Name = "btnThoat";
        btnThoat.Size = new Size(125, 38);
        btnThoat.TabIndex = 4;
        btnThoat.Text = "&Thoát";
        btnThoat.UseVisualStyleBackColor = true;
        btnThoat.Click += btnThoat_Click;
        // 
        // grpKetQua
        // 
        grpKetQua.Controls.Add(txtKetQua);
        grpKetQua.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        grpKetQua.Location = new Point(25, 410);
        grpKetQua.Name = "grpKetQua";
        grpKetQua.Size = new Size(574, 185);
        grpKetQua.TabIndex = 5;
        grpKetQua.TabStop = false;
        grpKetQua.Text = "Kết quả tổng hợp";
        // 
        // txtKetQua
        // 
        txtKetQua.BackColor = Color.White;
        txtKetQua.Font = new Font("Consolas", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        txtKetQua.Location = new Point(20, 25);
        txtKetQua.Multiline = true;
        txtKetQua.Name = "txtKetQua";
        txtKetQua.ReadOnly = true;
        txtKetQua.ScrollBars = ScrollBars.Vertical;
        txtKetQua.Size = new Size(534, 145);
        txtKetQua.TabIndex = 0;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Window;
        ClientSize = new Size(624, 615);
        Controls.Add(grpKetQua);
        Controls.Add(btnThoat);
        Controls.Add(btnXoa);
        Controls.Add(btnHienThi);
        Controls.Add(grpThongTin);
        Controls.Add(lblTitle);
        Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "COMP1019 - Bài Lab 01: Ứng dụng thông tin cá nhân";
        FormClosing += Form1_FormClosing;
        Load += Form1_Load;
        grpThongTin.ResumeLayout(false);
        grpThongTin.PerformLayout();
        grpGioiTinh.ResumeLayout(false);
        grpGioiTinh.PerformLayout();
        grpKetQua.ResumeLayout(false);
        grpKetQua.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label lblTitle;
    private GroupBox grpThongTin;
    private Label lblHoTen;
    private TextBox txtHoTen;
    private Label lblNamSinh;
    private TextBox txtNamSinh;
    private Label lblEmail;
    private TextBox txtEmail;
    private GroupBox grpGioiTinh;
    private RadioButton radNam;
    private RadioButton radNu;
    private Label lblKhoa;
    private ComboBox cboKhoa;
    private Button btnHienThi;
    private Button btnXoa;
    private Button btnThoat;
    private GroupBox grpKetQua;
    private TextBox txtKetQua;
}
