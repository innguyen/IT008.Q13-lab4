using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start(); // Bắt đầu chạy đồng hồ
            // Hiển thị ngày giờ ngay khi mở form
            toolStripStatusLabel1.Text = "Hôm nay là ngày" + DateTime.Now.ToString(" dd/MM/yyyy") + " - Bây giờ là " + DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // Đặt chu kỳ 1 giây (1000ms)
            // Cập nhật lại giờ sau mỗi giây
            toolStripStatusLabel1.Text = "Hôm nay là ngày" + DateTime.Now.ToString(" dd/MM/yyyy") + " - Bây giờ là " + DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lọc các loại file nhạc/video
            openFileDialog1.Filter = "Media Files|*.avi;*.mpeg;*.wav;*.midi;*.mp4;*.mp3|All Files|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Gán đường dẫn file vào Media Player để phát
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); // Thoát chương trình
        }
    }
}