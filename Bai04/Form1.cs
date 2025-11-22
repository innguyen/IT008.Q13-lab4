using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text; // Thư viện xử lý Font
using System.IO;           // Thư viện xử lý tập tin
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        // Biến toàn cục lưu đường dẫn file hiện tại
        private string currentFilePath = null;

        public Form1()
        {
            InitializeComponent();
        }

        // --- 1. KHỞI TẠO VÀ CẤU HÌNH ---

        private void Form1_Load(object sender, EventArgs e)
        {
            // Lấy danh sách Font hệ thống đưa vào ComboBox
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (FontFamily family in fonts.Families)
            {
                font.Items.Add(family.Name);
            }

            // Tạo danh sách kích thước chữ (Size)
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int size in sizes)
            {
                fontsize.Items.Add(size);
            }

            // Thiết lập giá trị mặc định ban đầu
            font.SelectedItem = "Tahoma";
            fontsize.SelectedItem = 14;
            SetFontForRichTextBox("Tahoma", 14);
        }

        // Hàm hỗ trợ gán Font nhanh cho RichTextBox
        private void SetFontForRichTextBox(string fontName, float fontSize)
        {
            richTextBox1.Font = new Font(fontName, fontSize);
        }

        // --- 2. XỬ LÝ MENU HỆ THỐNG (TẠO MỚI, MỞ, THOÁT) ---

        // Chức năng: Tạo văn bản mới (Reset toàn bộ)
        private void tạoVănBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Xóa nội dung cũ
            richTextBox1.Clear();

            // Reset các cấu hình về mặc định
            font.SelectedItem = "Tahoma";
            fontsize.SelectedItem = 14;
            SetFontForRichTextBox("Tahoma", 14);

            // Đặt lại đường dẫn file là null (chưa lưu)
            currentFilePath = null;

            // Reset logic cho nút Tạo mới trên Toolbar (nếu dùng chung sự kiện này)
            toolStripButton1_Click(sender, e);
        }

        // Sự kiện nút Tạo mới trên Toolbar
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Logic giống hệt menu Tạo mới, nên gọi lại hàm trên hoặc viết lại
            richTextBox1.Clear();
            font.SelectedItem = "Tahoma";
            fontsize.SelectedItem = 14;
            SetFontForRichTextBox("Tahoma", 14);
            currentFilePath = null;
        }

        // Chức năng: Mở tập tin
        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Bộ lọc cho phép chọn cả file .txt và .rtf
            openFileDialog.Filter = "Tất cả văn bản|*.rtf;*.txt|Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                try
                {
                    string ext = Path.GetExtension(currentFilePath).ToLower();

                    // Kiểm tra đuôi file để dùng chế độ đọc phù hợp
                    if (ext == ".rtf")
                        richTextBox1.LoadFile(currentFilePath, RichTextBoxStreamType.RichText); // Đọc có định dạng
                    else
                        richTextBox1.LoadFile(currentFilePath, RichTextBoxStreamType.PlainText); // Đọc văn bản thường
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đọc file: " + ex.Message);
                }
            }
        }

        // Chức năng: Thoát ứng dụng
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // --- 3. XỬ LÝ LƯU FILE (Logic quan trọng) ---
        private void SaveFileByType(string path)
        {
            string ext = Path.GetExtension(path).ToLower();

            // Nếu là file .txt -> Lưu dạng Text thường
            if (ext == ".txt")
            {
                richTextBox1.SaveFile(path, RichTextBoxStreamType.PlainText);
            }
            // Ngược lại (.rtf) -> Lưu dạng RichText (giữ màu sắc, font chữ)
            else
            {
                richTextBox1.SaveFile(path, RichTextBoxStreamType.RichText);
            }
        }

        // Xử lý chung cho nút Lưu (Dùng cho cả Menu và Toolbar)
        private void XuLyLuu()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                // Trường hợp 1: File mới tinh, chưa có tên -> Mở hộp thoại Save As
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";
                saveFileDialog.DefaultExt = "rtf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                    SaveFileByType(currentFilePath); // Gọi hàm lưu
                    MessageBox.Show("Đã lưu file thành công!");
                }
            }
            else
            {
                // Trường hợp 2: File đã có tên -> Lưu đè lên file cũ
                SaveFileByType(currentFilePath); // Gọi hàm lưu
                MessageBox.Show("Lưu văn bản thành công!");
            }
        }

        // Sự kiện Click Menu Lưu
        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XuLyLuu();
        }

        // Sự kiện Click Nút Lưu trên Toolbar
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            XuLyLuu();
        }

        // --- 4. XỬ LÝ ĐỊNH DẠNG (FONT, SIZE, STYLE) ---

        // Thay đổi Font hoặc Size khi người dùng chọn ComboBox
        private void ChangeFontStyle()
        {
            if (richTextBox1.SelectionFont == null) return; // Tránh lỗi nếu vùng chọn hỗn hợp font

            string fontName = font.Text;
            float fontSize = 14;
            if (!float.TryParse(fontsize.Text, out fontSize)) fontSize = 14;

            // Giữ nguyên Style hiện tại (đậm/nghiêng), chỉ đổi Font và Size
            FontStyle currentStyle = richTextBox1.SelectionFont.Style;
            richTextBox1.SelectionFont = new Font(fontName, fontSize, currentStyle);
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        // Mở hộp thoại Font Dialog của Windows
        private void đinhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;

            if (richTextBox1.SelectionFont != null)
                fontDialog.Font = richTextBox1.SelectionFont;

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
                richTextBox1.SelectionColor = fontDialog.Color;
            }
        }

        // Bật/Tắt chữ Đậm (Bold)
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newStyle;

                if (currentFont.Bold)
                    newStyle = currentFont.Style & ~FontStyle.Bold; // Bỏ đậm
                else
                    newStyle = currentFont.Style | FontStyle.Bold;  // Thêm đậm

                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }

        // Bật/Tắt chữ Nghiêng (Italic)
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newStyle;

                if (currentFont.Italic)
                    newStyle = currentFont.Style & ~FontStyle.Italic; // Bỏ nghiêng
                else
                    newStyle = currentFont.Style | FontStyle.Italic;  // Thêm nghiêng

                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }

        // Bật/Tắt chữ Gạch chân (Underline)
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newStyle;

                if (currentFont.Underline)
                    newStyle = currentFont.Style & ~FontStyle.Underline; // Bỏ gạch chân
                else
                    newStyle = currentFont.Style | FontStyle.Underline;  // Thêm gạch chân

                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }
    }
}