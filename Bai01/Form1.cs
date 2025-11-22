using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Khởi tạo các thành phần giao diện
        }

        // PHẦN 1: XỬ LÝ SỰ KIỆN CHUỘT (MOUSE)
        // Sự kiện này xảy ra khi người dùng Click chuột vào vùng trống trên Form
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // e.Location: Lấy tọa độ {X, Y} nơi con trỏ chuột đang đứng
            string s = e.Location.ToString();

            // e.Button: Lấy tên nút chuột vừa bấm (Left, Right, Middle...)
            string l = e.Button.ToString();

            // Kiểm tra và dịch tên nút sang tiếng Việt
            if (l == "Left")
            {
                l = "Trái";
            }
            else
            {
                // Tạm thời quy định: Nếu không phải Trái thì coi như là Phải
                l = "Phải";
            }

            // Hiện hộp thoại thông báo kết quả
            MessageBox.Show("Bạn vừa bấm Chuột " + l + " tại tọa độ " + s);
        }

        // PHẦN 2: XỬ LÝ SỰ KIỆN BÀN PHÍM (KEYBOARD)
        // Sự kiện này xảy ra khi một phím ký tự được nhấn xuống
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e.KeyChar: Lấy ký tự vừa được nhấn (ví dụ: 'a', 'B', '1')
            char kytu = e.KeyChar;

            // Ép kiểu ký tự (char) sang số nguyên (int) để lấy mã ASCII
            int maASCII = (int)kytu;

            // Hiện hộp thoại thông báo ký tự và mã ASCII tương ứng
            MessageBox.Show("Ký tự vừa nhấn: " + kytu + " - Mã ASCII: " + maASCII);
        }
    }
}