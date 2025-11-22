using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. KHUÔN MẪU DỮ LIỆU (MODEL)
        // Tạo class SinhVien ngay trong Form để tiện quản lý (hoặc tách file riêng cũng được)
        public class SinhVien
        {
            // Các thuộc tính (Properties)
            public string MaSo { get; set; }
            public string TenSinhVien { get; set; }
            public string Khoa { get; set; }
            public float DiemTB { get; set; }

            // Hàm khởi tạo (Constructor) để tạo nhanh đối tượng
            public SinhVien(string maSo, string ten, string khoa, float diem)
            {
                MaSo = maSo;
                TenSinhVien = ten;
                Khoa = khoa;
                DiemTB = diem;
            }
        }

        // 2. DANH SÁCH LƯU TRỮ DỮ LIỆU
        // List này đóng vai trò như một "cơ sở dữ liệu" tạm thời trên RAM
        private List<SinhVien> listSinhVien = new List<SinhVien>();


        private void Form1_Load(object sender, EventArgs e)
        {
            // Có thể thêm vài sinh viên mẫu ở đây để test nếu muốn
            // ThemSinhVien("1", "Nguyen Van A", "CNTT", 8.5f);
        }

        // 3. HÀM PUBLIC ĐỂ FORM 2 GỌI
        // Hàm này phải là 'public' để Form2 có thể nhìn thấy và gọi được
        public void ThemSinhVien(string ma, string ten, string khoa, float diem)
        {
            // Tạo đối tượng sinh viên mới từ thông tin nhận được
            SinhVien svMoi = new SinhVien(ma, ten, khoa, diem);

            // Thêm vào danh sách gốc (List)
            listSinhVien.Add(svMoi);

            // Gọi hàm vẽ lại bảng DataGridView
            HienThiLenGrid(listSinhVien);
        }

        // 4. HÀM HIỂN THỊ DỮ LIỆU (View)
        // Hàm này chịu trách nhiệm đổ dữ liệu từ List lên DataGridView
        private void HienThiLenGrid(List<SinhVien> listHienThi)
        {
            dgvSinhVien.Rows.Clear(); // Xóa sạch các dòng cũ trên bảng để tránh bị trùng lặp

            for (int i = 0; i < listHienThi.Count; i++)
            {
                SinhVien sv = listHienThi[i];
                dgvSinhVien.Rows.Add(i + 1, sv.MaSo, sv.TenSinhVien, sv.Khoa, sv.DiemTB);
            }
        }

        // 5. MỞ FORM NHẬP LIỆU
        // Sự kiện khi bấm nút Thêm Mới (trên ToolStrip)
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // Khởi tạo Form2 và truyền 'this' (chính là Form1 hiện tại) sang
            // Để Form2 biết nó cần gửi dữ liệu về cho ai
            Form2 frm = new Form2(this);

            // ShowDialog: Mở Form và bắt buộc người dùng xử lý xong Form2 mới được quay lại Form1
            frm.ShowDialog();
        }

        // Sự kiện khi bấm Menu Thêm Mới (Gọi lại hàm trên cho đỡ viết lại code)
        private void menuThemMoi_Click(object sender, EventArgs e)
        {
            btnThemMoi_Click(sender, e);
        }

        // 6. CHỨC NĂNG TÌM KIẾM
        // Sự kiện TextChanged: Chạy ngay khi người dùng gõ phím vào ô tìm kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.ToLower(); // Chuyển từ khóa về chữ thường để tìm không phân biệt hoa/thường

            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                // Trường hợp 1: Ô tìm kiếm rỗng -> Hiển thị lại toàn bộ danh sách gốc
                HienThiLenGrid(listSinhVien);
            }
            else
            {
                // Trường hợp 2: Có từ khóa -> Lọc dữ liệu
                // Sử dụng LINQ để tìm những sinh viên có Tên chứa từ khóa
                List<SinhVien> listKetQua = listSinhVien
                    .Where(sv => sv.TenSinhVien.ToLower().Contains(tuKhoa))
                    .ToList();

                // Chỉ hiển thị danh sách kết quả tìm được
                HienThiLenGrid(listKetQua);
            }
        }

        // 7. THOÁT CHƯƠNG TRÌNH
        private void menuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}