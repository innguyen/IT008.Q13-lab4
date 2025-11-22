using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 1. Sự kiện khi Form load: Cài đặt ToolTip
        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnChonNguon, "Chọn tập tin cần sao chép");
            toolTip1.SetToolTip(btnChonDich, "Chọn nơi lưu tập tin");
            toolTip1.SetToolTip(btnSaoChep, "Bắt đầu tiến trình sao chép");
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }

        // 2. Chọn file nguồn
        private void btnChonNguon_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Chọn tập tin nguồn";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtNguon.Text = dlg.FileName;
            }
        }

        // 3. Chọn nơi lưu (file đích)
        private void btnChonDich_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Chọn nơi lưu tập tin";
            dlg.Filter = "All Files (*.*)|*.*";

            // Gợi ý tên file giống file nguồn
            if (!string.IsNullOrEmpty(txtNguon.Text))
            {
                dlg.FileName = Path.GetFileName(txtNguon.Text);
            }

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtDich.Text = dlg.FileName;
            }
        }

        // 4. Xử lý Sao Chép (Logic quan trọng nhất)
        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            string srcPath = txtNguon.Text;
            string destPath = txtDich.Text;

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(srcPath) || string.IsNullOrEmpty(destPath))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ đường dẫn nguồn và đích!");
                return;
            }

            if (!File.Exists(srcPath))
            {
                MessageBox.Show("File nguồn không tồn tại!");
                return;
            }

            try
            {
                // Gọi hàm copy tùy chỉnh
                CopyFileWithProgress(srcPath, destPath);
                MessageBox.Show("Sao chép thành công!");
                lblStatus.Text = "Đang Sao Chép : Hoàn tất.";
                progressBar1.Value = 0; // Reset
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sao chép: " + ex.Message);
            }
        }

        // HÀM PHỤ: Copy file theo luồng (Stream) để tính %
        private void CopyFileWithProgress(string source, string destination)
        {
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
            {
                long totalLength = fsRead.Length;
                long totalRead = 0;
                byte[] buffer = new byte[1024 * 1024]; // 1MB Buffer
                int readBytes;

                while ((readBytes = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsWrite.Write(buffer, 0, readBytes);

                    totalRead += readBytes;
                    int percentage = (int)((double)totalRead / totalLength * 100);

                    // --- CẬP NHẬT GIAO DIỆN ---
                    progressBar1.Value = percentage;

                    // Nội dung hiển thị trên Label (Tên file ngắn gọn)
                    string shortMessage = $"Đang Sao Chép : {Path.GetFileName(source)} ({percentage}%)";
                    lblStatus.Text = shortMessage;

                    // Gán nội dung vào ToolTip của Label
                    toolTip1.SetToolTip(lblStatus, $"Đang sao chép từ: {source}");

                    Application.DoEvents();
                }
            }
        }
    }
}
