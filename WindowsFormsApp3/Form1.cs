using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Tên đăng nhập là: ";
            thongbao += this.txtUser.Text;
            thongbao += "\n\rMật khẩu là: ";
            thongbao += this.txtPass.Text;
            if (this.chKNho.Checked == true)

            { thongbao += "\n\rBạn có ghi nhớ."; }
            MessageBox.Show(thongbao, "Thông báo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtUser.Clear(); this.txtPass.Clear(); this.txtUser.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
