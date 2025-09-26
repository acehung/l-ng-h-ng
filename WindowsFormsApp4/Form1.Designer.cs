namespace WindowsFormsApp4
{
    partial class Frmbai2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKetqua = new System.Windows.Forms.Button();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ và tên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(283, 119);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(331, 30);
            this.txtHoTen.TabIndex = 1;
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad1.Location = new System.Drawing.Point(19, 29);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(119, 26);
            this.rad1.TabIndex = 3;
            this.rad1.TabStop = true;
            this.rad1.Text = "chữ thường";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad2);
            this.groupBox1.Controls.Add(this.rad1);
            this.groupBox1.Location = new System.Drawing.Point(144, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 135);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chọn kiểu chữ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Location = new System.Drawing.Point(19, 79);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(152, 27);
            this.rad2.TabIndex = 5;
            this.rad2.TabStop = true;
            this.rad2.Text = "CHỮ IN HOA";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(613, 218);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 121);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKetqua
            // 
            this.btnKetqua.Location = new System.Drawing.Point(163, 378);
            this.btnKetqua.Name = "btnKetqua";
            this.btnKetqua.Size = new System.Drawing.Size(100, 38);
            this.btnKetqua.TabIndex = 6;
            this.btnKetqua.Text = "Kết quả";
            this.btnKetqua.UseVisualStyleBackColor = true;
            this.btnKetqua.Click += new System.EventHandler(this.btnKetqua_Click);
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(269, 378);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(355, 30);
            this.txtKq.TabIndex = 7;
            this.txtKq.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Frmbai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 647);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.btnKetqua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frmbai2";
            this.Text = "Đổi kiểu chữ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKetqua;
        private System.Windows.Forms.TextBox txtKq;
    }
}

