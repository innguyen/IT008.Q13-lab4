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
    public partial class Form2 : Form
    {
        // Hàm khởi tạo mặc định
        public Form2()
        {
            InitializeComponent();
        }

        // Biến lưu tham chiếu tới Form cha (Form1) để truyền dữ liệu về
        private Form1 parentForm;

        // Hàm khởi tạo có tham số: Nhận Form1 truyền vào khi mở form
        public Form2(Form1 parent)
        {
            InitializeComponent();
            this.parentForm = parent; // Lưu lại Form1 vào biến local

            // Chọn mặc định phần tử đầu tiên trong ComboBox Khoa (tránh bị rỗng)
            cmbKhoa.SelectedIndex = 0;
        }

        // Sự kiện click nút Thêm Mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra dữ liệu đầu vào (Validation): Không được để trống ô nào
                if (txtMSSV.Text == "" || txtTenSV.Text == "" || txtDiemTB.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return; // Dừng lại, không thực hiện tiếp
                }

                // 2. Lấy dữ liệu từ các ô nhập liệu trên giao diện
                string maSo = txtMSSV.Text;
                string ten = txtTenSV.Text;
                string khoa = cmbKhoa.Text;

                // Ép kiểu từ chuỗi sang số thực (float) cho Điểm TB
                // Dùng float.Parse sẽ lỗi nếu người dùng nhập chữ, nên cần đặt trong try-catch
                float diem = float.Parse(txtDiemTB.Text);

                // 3. Gọi hàm public bên Form1 để thêm dữ liệu vào danh sách/lưới
                parentForm.ThemSinhVien(maSo, ten, khoa, diem);

                MessageBox.Show("Thêm mới thành công!");

                // 4. Xóa trắng các ô nhập liệu để tiện nhập người tiếp theo
                txtMSSV.Text = "";
                txtTenSV.Text = "";
                txtDiemTB.Text = "";

                // Đưa con trỏ chuột quay lại ô Mã Số SV
                txtMSSV.Focus();
            }
            catch (Exception ex)
            {
                // Bắt lỗi nhập liệu (ví dụ nhập chữ vào ô điểm) và thông báo
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ (Điểm phải là số). \nLỗi: " + ex.Message);
            }
        }

        // Sự kiện click nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form hiện tại
        }
    }
}