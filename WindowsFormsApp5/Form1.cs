using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace WindowsFormsApp5
{
    public partial class cmbbox : Form
    {
        public cmbbox()
        {
            InitializeComponent();
        }

        public ComboBox.ObjectCollection Items => comboBox2.Items;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int so = int.Parse(txtSo.Text);
            for (int i = 1; i <= so; i++)
            {
                if ((so % i) == 0)
                {
                    dscUocso.Items.Add(i);
                }
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void txtCapnhat_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(txtSo.Text);
        }

        private void txtTonguocso_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i = 0; i < dscUocso.Items.Count; i++) ;
            
            }

        private void txtsoluonguschan_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < dscUocso.Items.Count; i++) ;
        }

        private void txtsoluongusnguyento_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < dscUocso.Items.Count; i++) ;
        }

        private void txtSo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
