using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab_01;

/// <summary>
/// Form chính của bài Lab 01 - Ứng dụng thông tin cá nhân.
/// Học phần: COMP1019 - Lập trình trên Windows
/// </summary>
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Xử lý sự kiện khi Form được tải lên.
    /// Khởi tạo danh sách các khoa/lớp trong ComboBox.
    /// </summary>
    private void Form1_Load(object sender, EventArgs e)
    {
        // Yêu cầu 4.1: ComboBox có sẵn ít nhất 3 lựa chọn
        cboKhoa.Items.Clear();
        cboKhoa.Items.Add("Công nghệ thông tin");
        cboKhoa.Items.Add("Kỹ thuật phần mềm");
        cboKhoa.Items.Add("Hệ thống thông tin");
        cboKhoa.Items.Add("Khoa học máy tính");
        cboKhoa.Items.Add("Quản trị kinh doanh");
        cboKhoa.Items.Add("Kế toán - Tài chính");

        // Chọn mặc định lựa chọn đầu tiên
        if (cboKhoa.Items.Count > 0)
        {
            cboKhoa.SelectedIndex = 0;
        }

        // Đặt con trỏ chuột vào ô nhập họ tên
        txtHoTen.Focus();
    }

    /// <summary>
    /// Xử lý sự kiện Click nút "Hiển thị".
    /// Kiểm tra hợp lệ dữ liệu và hiển thị kết quả tổng hợp.
    /// </summary>
    private void btnHienThi_Click(object sender, EventArgs e)
    {
        // 1. Kiểm tra Họ tên: không được để trống
        string hoTen = txtHoTen.Text.Trim();
        if (string.IsNullOrWhiteSpace(hoTen))
        {
            MessageBox.Show(
                "Vui lòng nhập họ tên sinh viên!",
                "Thông báo lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            txtHoTen.Focus();
            return;
        }

        // 2. Kiểm tra Năm sinh: không để trống, là số nguyên, từ 1900 đến năm hiện tại
        string namSinhStr = txtNamSinh.Text.Trim();
        if (string.IsNullOrWhiteSpace(namSinhStr))
        {
            MessageBox.Show(
                "Vui lòng nhập năm sinh!",
                "Thông báo lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            txtNamSinh.Focus();
            return;
        }

        if (!int.TryParse(namSinhStr, out int namSinh))
        {
            MessageBox.Show(
                "Năm sinh phải là số nguyên hợp lệ!",
                "Thông báo lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            txtNamSinh.SelectAll();
            txtNamSinh.Focus();
            return;
        }

        int currentYear = DateTime.Now.Year;
        if (namSinh < 1900 || namSinh > currentYear)
        {
            MessageBox.Show(
                $"Năm sinh phải nằm trong khoảng từ 1900 đến {currentYear}!",
                "Thông báo lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            txtNamSinh.SelectAll();
            txtNamSinh.Focus();
            return;
        }

        // 3. Kiểm tra Email: không được để trống, kiểm tra định dạng
        string email = txtEmail.Text.Trim();
        if (string.IsNullOrWhiteSpace(email))
        {
            MessageBox.Show(
                "Vui lòng nhập địa chỉ email!",
                "Thông báo lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            txtEmail.Focus();
            return;
        }

        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        if (!Regex.IsMatch(email, emailPattern))
        {
            MessageBox.Show(
                "Email không đúng định dạng! (Ví dụ: vana@example.com)",
                "Thông báo lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            txtEmail.SelectAll();
            txtEmail.Focus();
            return;
        }

        // 4. Kiểm tra Giới tính: bắt buộc phải chọn Nam hoặc Nữ
        if (!radNam.Checked && !radNu.Checked)
        {
            MessageBox.Show(
                "Vui lòng chọn giới tính!",
                "Thông báo lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }
        string gioiTinh = radNam.Checked ? "Nam" : "Nữ";

        // 5. Kiểm tra Khoa / Lớp: bắt buộc phải chọn
        if (cboKhoa.SelectedIndex < 0 || cboKhoa.SelectedItem == null)
        {
            MessageBox.Show(
                "Vui lòng chọn khoa hoặc lớp!",
                "Thông báo lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            cboKhoa.Focus();
            return;
        }
        string khoa = cboKhoa.SelectedItem.ToString() ?? "";

        // 6. Tính tuổi của sinh viên
        int tuoi = currentYear - namSinh;

        // 7. Tổng hợp kết quả theo định dạng yêu cầu của bài Lab
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("THÔNG TIN SINH VIÊN");
        sb.AppendLine($"Họ tên: {hoTen}");
        sb.AppendLine($"Tuổi: {tuoi}");
        sb.AppendLine($"Email: {email}");
        sb.AppendLine($"Giới tính: {gioiTinh}");
        sb.AppendLine($"Khoa/Lớp: {khoa}");

        string thongTinKetQua = sb.ToString();

        // Hiển thị kết quả lên Form (TextBox kết quả)
        txtKetQua.Text = thongTinKetQua;

        // Hiển thị thông báo MessageBox
        MessageBox.Show(
            thongTinKetQua,
            "Kết quả thông tin sinh viên",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }

    /// <summary>
    /// Xử lý sự kiện Click nút "Xóa".
    /// Đưa các trường dữ liệu về trạng thái rỗng hoặc mặc định ban đầu.
    /// </summary>
    private void btnXoa_Click(object sender, EventArgs e)
    {
        txtHoTen.Clear();
        txtNamSinh.Clear();
        txtEmail.Clear();
        radNam.Checked = false;
        radNu.Checked = false;

        if (cboKhoa.Items.Count > 0)
        {
            cboKhoa.SelectedIndex = 0;
        }
        else
        {
            cboKhoa.SelectedIndex = -1;
        }

        txtKetQua.Clear();
        txtHoTen.Focus();
    }

    /// <summary>
    /// Xử lý sự kiện Click nút "Thoát".
    /// Kích hoạt đóng Form (sẽ gọi sự kiện FormClosing để hỏi xác nhận).
    /// </summary>
    private void btnThoat_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    /// <summary>
    /// Bắt sự kiện trước khi đóng Form để hỏi xác nhận người dùng.
    /// </summary>
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn thoát chương trình?",
            "Xác nhận thoát",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result != DialogResult.Yes)
        {
            e.Cancel = true; // Hủy thao tác đóng form
        }
    }
}
