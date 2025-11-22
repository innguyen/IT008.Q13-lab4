namespace Bai04
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoVănBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởTậpTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuNộiDungVănBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đinhDạngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newfile = new System.Windows.Forms.ToolStripButton();
            this.savefile = new System.Windows.Forms.ToolStripButton();
            this.font = new System.Windows.Forms.ToolStripComboBox();
            this.fontsize = new System.Windows.Forms.ToolStripComboBox();
            this.Bold = new System.Windows.Forms.ToolStripButton();
            this.Italic = new System.Windows.Forms.ToolStripButton();
            this.Underline = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.đinhDạngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoVănBanToolStripMenuItem,
            this.mởTậpTinToolStripMenuItem,
            this.lưuNộiDungVănBảnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(103, 32);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // tạoVănBanToolStripMenuItem
            // 
            this.tạoVănBanToolStripMenuItem.Name = "tạoVănBanToolStripMenuItem";
            this.tạoVănBanToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.tạoVănBanToolStripMenuItem.Text = "Tạo văn bản mới";
            this.tạoVănBanToolStripMenuItem.Click += new System.EventHandler(this.tạoVănBanToolStripMenuItem_Click);
            // 
            // mởTậpTinToolStripMenuItem
            // 
            this.mởTậpTinToolStripMenuItem.Name = "mởTậpTinToolStripMenuItem";
            this.mởTậpTinToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.mởTậpTinToolStripMenuItem.Text = "Mở tập tin";
            this.mởTậpTinToolStripMenuItem.Click += new System.EventHandler(this.mởTậpTinToolStripMenuItem_Click);
            // 
            // lưuNộiDungVănBảnToolStripMenuItem
            // 
            this.lưuNộiDungVănBảnToolStripMenuItem.Name = "lưuNộiDungVănBảnToolStripMenuItem";
            this.lưuNộiDungVănBảnToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.lưuNộiDungVănBảnToolStripMenuItem.Text = "Lưu nội dung văn bản";
            this.lưuNộiDungVănBảnToolStripMenuItem.Click += new System.EventHandler(this.lưuNộiDungVănBảnToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // đinhDạngToolStripMenuItem
            // 
            this.đinhDạngToolStripMenuItem.Name = "đinhDạngToolStripMenuItem";
            this.đinhDạngToolStripMenuItem.Size = new System.Drawing.Size(111, 32);
            this.đinhDạngToolStripMenuItem.Text = "Đinh dạng";
            this.đinhDạngToolStripMenuItem.Click += new System.EventHandler(this.đinhDạngToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newfile,
            this.savefile,
            this.font,
            this.fontsize,
            this.Bold,
            this.Italic,
            this.Underline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newfile
            // 
            this.newfile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newfile.Image = ((System.Drawing.Image)(resources.GetObject("newfile.Image")));
            this.newfile.ImageTransparentColor = System.Drawing.Color.White;
            this.newfile.Name = "newfile";
            this.newfile.Size = new System.Drawing.Size(34, 28);
            this.newfile.Text = "toolStripButton1";
            this.newfile.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // savefile
            // 
            this.savefile.BackColor = System.Drawing.Color.White;
            this.savefile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.savefile.Image = ((System.Drawing.Image)(resources.GetObject("savefile.Image")));
            this.savefile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(34, 33);
            this.savefile.Text = "toolStripButton2";
            this.savefile.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // font
            // 
            this.font.AutoSize = false;
            this.font.BackColor = System.Drawing.SystemColors.HighlightText;
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(200, 33);
            this.font.SelectedIndexChanged += new System.EventHandler(this.cmbFont_SelectedIndexChanged);
            // 
            // fontsize
            // 
            this.fontsize.Name = "fontsize";
            this.fontsize.Size = new System.Drawing.Size(121, 38);
            this.fontsize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            // 
            // Bold
            // 
            this.Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bold.Image = ((System.Drawing.Image)(resources.GetObject("Bold.Image")));
            this.Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(34, 33);
            this.Bold.Text = "toolStripButton3";
            this.Bold.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // Italic
            // 
            this.Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Italic.Image = ((System.Drawing.Image)(resources.GetObject("Italic.Image")));
            this.Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(34, 33);
            this.Italic.Text = "toolStripButton4";
            this.Italic.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // Underline
            // 
            this.Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Underline.Image = ((System.Drawing.Image)(resources.GetObject("Underline.Image")));
            this.Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(34, 33);
            this.Underline.Text = "toolStripButton5";
            this.Underline.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 384);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoVănBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởTậpTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuNộiDungVănBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đinhDạngToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newfile;
        private System.Windows.Forms.ToolStripButton savefile;
        private System.Windows.Forms.ToolStripComboBox font;
        private System.Windows.Forms.ToolStripComboBox fontsize;
        private System.Windows.Forms.ToolStripButton Bold;
        private System.Windows.Forms.ToolStripButton Italic;
        private System.Windows.Forms.ToolStripButton Underline;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

