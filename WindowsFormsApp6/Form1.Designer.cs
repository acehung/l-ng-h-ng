namespace WindowsFormsApp6
{
    partial class frmTinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTinh));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad4 = new System.Windows.Forms.RadioButton();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtSo1
            // 
            resources.ApplyResources(this.txtSo1, "txtSo1");
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.TextChanged += new System.EventHandler(this.txtSo1_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSo2
            // 
            resources.ApplyResources(this.txtSo2, "txtSo2");
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.TextChanged += new System.EventHandler(this.txtSo2_TextChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.rad4);
            this.groupBox1.Controls.Add(this.rad3);
            this.groupBox1.Controls.Add(this.rad2);
            this.groupBox1.Controls.Add(this.rad1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rad4
            // 
            resources.ApplyResources(this.rad4, "rad4");
            this.rad4.Name = "rad4";
            this.rad4.TabStop = true;
            this.rad4.UseVisualStyleBackColor = true;
            this.rad4.CheckedChanged += new System.EventHandler(this.rad4_CheckedChanged);
            // 
            // rad3
            // 
            resources.ApplyResources(this.rad3, "rad3");
            this.rad3.Name = "rad3";
            this.rad3.TabStop = true;
            this.rad3.UseVisualStyleBackColor = true;
            this.rad3.CheckedChanged += new System.EventHandler(this.rad3_CheckedChanged);
            // 
            // rad2
            // 
            resources.ApplyResources(this.rad2, "rad2");
            this.rad2.Name = "rad2";
            this.rad2.TabStop = true;
            this.rad2.UseVisualStyleBackColor = true;
            this.rad2.CheckedChanged += new System.EventHandler(this.rad2_CheckedChanged);
            // 
            // rad1
            // 
            resources.ApplyResources(this.rad1, "rad1");
            this.rad1.Name = "rad1";
            this.rad1.TabStop = true;
            this.rad1.UseVisualStyleBackColor = true;
            this.rad1.CheckedChanged += new System.EventHandler(this.rad1_CheckedChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtKetqua
            // 
            resources.ApplyResources(this.txtKetqua, "txtKetqua");
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.ReadOnly = true;
            this.txtKetqua.TextChanged += new System.EventHandler(this.txtKetqua_TextChanged_1);
            // 
            // frmTinh
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "frmTinh";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad3;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.RadioButton rad4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetqua;
    }
}

