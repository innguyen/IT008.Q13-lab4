using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện khi Form vừa mở lên
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start(); // Bắt đầu chạy đồng hồ
            updateTime();   // Hiển thị giờ ngay lập tức (không chờ 1 giây delay)
        }

        // Hàm lấy giờ hệ thống và gán vào Label
        private void updateTime()
        {
            DateTime d = DateTime.Now;
            // Định dạng chuỗi: Thứ, Tháng Ngày, Năm Giờ:Phút:Giây AM/PM
            label1.Text = d.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt");
        }

        // Sự kiện lặp lại sau mỗi khoảng thời gian (Interval)
        private void timer1_Tick(object sender, EventArgs e)
        {
            updateTime();
        }
    }
}