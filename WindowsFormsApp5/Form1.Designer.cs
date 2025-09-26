namespace WindowsFormsApp5
{
    partial class cmbbox
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dscUocso = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCapnhat = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtTonguocso = new System.Windows.Forms.Button();
            this.txtsoluonguschan = new System.Windows.Forms.Button();
            this.txtsoluongusnguyento = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dscUocso
            // 
            this.dscUocso.FormattingEnabled = true;
            this.dscUocso.ItemHeight = 16;
            this.dscUocso.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.dscUocso.Location = new System.Drawing.Point(23, 22);
            this.dscUocso.Name = "dscUocso";
            this.dscUocso.Size = new System.Drawing.Size(203, 132);
            this.dscUocso.TabIndex = 0;
            this.dscUocso.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dscUocso);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(437, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 170);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các ước số";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCapnhat);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.txtSo);
            this.groupBox2.Location = new System.Drawing.Point(53, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập số";
            // 
            // txtCapnhat
            // 
            this.txtCapnhat.Location = new System.Drawing.Point(131, 28);
            this.txtCapnhat.Name = "txtCapnhat";
            this.txtCapnhat.Size = new System.Drawing.Size(98, 23);
            this.txtCapnhat.TabIndex = 6;
            this.txtCapnhat.Text = "&Cập nhật";
            this.txtCapnhat.UseVisualStyleBackColor = true;
            this.txtCapnhat.Click += new System.EventHandler(this.txtCapnhat_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(27, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(147, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(6, 28);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(100, 22);
            this.txtSo.TabIndex = 0;
            this.txtSo.TextChanged += new System.EventHandler(this.txtSo_TextChanged);
            // 
            // txtTonguocso
            // 
            this.txtTonguocso.Location = new System.Drawing.Point(437, 298);
            this.txtTonguocso.Name = "txtTonguocso";
            this.txtTonguocso.Size = new System.Drawing.Size(262, 26);
            this.txtTonguocso.TabIndex = 5;
            this.txtTonguocso.Text = "&Tổng các ước số";
            this.txtTonguocso.UseVisualStyleBackColor = true;
            this.txtTonguocso.Click += new System.EventHandler(this.txtTonguocso_Click);
            // 
            // txtsoluonguschan
            // 
            this.txtsoluonguschan.Location = new System.Drawing.Point(437, 330);
            this.txtsoluonguschan.Name = "txtsoluonguschan";
            this.txtsoluonguschan.Size = new System.Drawing.Size(262, 23);
            this.txtsoluonguschan.TabIndex = 6;
            this.txtsoluonguschan.Text = "&Số lượng các ước số chẵn";
            this.txtsoluonguschan.UseVisualStyleBackColor = true;
            this.txtsoluonguschan.Click += new System.EventHandler(this.txtsoluonguschan_Click);
            // 
            // txtsoluongusnguyento
            // 
            this.txtsoluongusnguyento.Location = new System.Drawing.Point(437, 359);
            this.txtsoluongusnguyento.Name = "txtsoluongusnguyento";
            this.txtsoluongusnguyento.Size = new System.Drawing.Size(262, 23);
            this.txtsoluongusnguyento.TabIndex = 7;
            this.txtsoluongusnguyento.Text = "Số lượng các ước số &nguyên tố";
            this.txtsoluongusnguyento.UseVisualStyleBackColor = true;
            this.txtsoluongusnguyento.Click += new System.EventHandler(this.txtsoluongusnguyento_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(241, 359);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtsoluongusnguyento);
            this.Controls.Add(this.txtsoluonguschan);
            this.Controls.Add(this.txtTonguocso);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "cmbbox";
            this.Text = "Combobox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox dscUocso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button txtCapnhat;
        private System.Windows.Forms.Button txtTonguocso;
        private System.Windows.Forms.Button txtsoluonguschan;
        private System.Windows.Forms.Button txtsoluongusnguyento;
        private System.Windows.Forms.Button btnThoat;
    }
}

