namespace Bai06
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaoChep = new System.Windows.Forms.Button();
            this.btnChonDich = new System.Windows.Forms.Button();
            this.btnChonNguon = new System.Windows.Forms.Button();
            this.txtDich = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNguon = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaoChep);
            this.groupBox1.Controls.Add(this.btnChonDich);
            this.groupBox1.Controls.Add(this.btnChonNguon);
            this.groupBox1.Controls.Add(this.txtDich);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNguon);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(87, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sao chép tập tin";
            // 
            // btnSaoChep
            // 
            this.btnSaoChep.ForeColor = System.Drawing.Color.Black;
            this.btnSaoChep.Location = new System.Drawing.Point(253, 162);
            this.btnSaoChep.Name = "btnSaoChep";
            this.btnSaoChep.Size = new System.Drawing.Size(187, 40);
            this.btnSaoChep.TabIndex = 6;
            this.btnSaoChep.Text = "Sao chép";
            this.btnSaoChep.UseVisualStyleBackColor = true;
            this.btnSaoChep.Click += new System.EventHandler(this.btnSaoChep_Click);
            // 
            // btnChonDich
            // 
            this.btnChonDich.Font = new System.Drawing.Font("Microsoft Himalaya", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonDich.ForeColor = System.Drawing.Color.Blue;
            this.btnChonDich.Location = new System.Drawing.Point(526, 90);
            this.btnChonDich.Name = "btnChonDich";
            this.btnChonDich.Size = new System.Drawing.Size(49, 35);
            this.btnChonDich.TabIndex = 5;
            this.btnChonDich.Text = "...";
            this.btnChonDich.UseVisualStyleBackColor = true;
            this.btnChonDich.Click += new System.EventHandler(this.btnChonDich_Click);
            // 
            // btnChonNguon
            // 
            this.btnChonNguon.Font = new System.Drawing.Font("Microsoft Himalaya", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonNguon.ForeColor = System.Drawing.Color.Blue;
            this.btnChonNguon.Location = new System.Drawing.Point(526, 41);
            this.btnChonNguon.Name = "btnChonNguon";
            this.btnChonNguon.Size = new System.Drawing.Size(49, 32);
            this.btnChonNguon.TabIndex = 4;
            this.btnChonNguon.Text = "...";
            this.btnChonNguon.UseVisualStyleBackColor = true;
            this.btnChonNguon.Click += new System.EventHandler(this.btnChonNguon_Click);
            // 
            // txtDich
            // 
            this.txtDich.Location = new System.Drawing.Point(253, 94);
            this.txtDich.Multiline = true;
            this.txtDich.Name = "txtDich";
            this.txtDich.Size = new System.Drawing.Size(267, 32);
            this.txtDich.TabIndex = 3;
            this.txtDich.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đường dẫn thư mục đích";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đường dẫn thư mục nguồn";
            // 
            // txtNguon
            // 
            this.txtNguon.Location = new System.Drawing.Point(253, 41);
            this.txtNguon.Multiline = true;
            this.txtNguon.Name = "txtNguon";
            this.txtNguon.Size = new System.Drawing.Size(267, 32);
            this.txtNguon.TabIndex = 0;
            this.txtNguon.WordWrap = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(87, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 102);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiến trình sao chép";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(56, 39);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(519, 37);
            this.progressBar1.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Location = new System.Drawing.Point(0, 427);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(800, 23);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Đang sao chép";
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
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNguon;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSaoChep;
        private System.Windows.Forms.Button btnChonDich;
        private System.Windows.Forms.Button btnChonNguon;
        private System.Windows.Forms.TextBox txtDich;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

