using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calkulator_Sederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TambahBtn_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(TextBox1.Text);
            int angka2 = Convert.ToInt32(TextBox2.Text);

            int penjumlahan = angka1 + angka2;

            lblHasil.Text = "Hasil : " + penjumlahan.ToString();

        }

        private void KurangBtn_click(object sender, EventArgs e)
        {

            int angka1 = Convert.ToInt32(TextBox1.Text);
            int angka2 = Convert.ToInt32(TextBox2.Text);

            int pengurangan = angka1 - angka2;

            lblHasil.Text = pengurangan.ToString();

        }

        private void KaliBtn_click(object sender, EventArgs e)
        {

            int angka1 = Convert.ToInt32(TextBox1.Text);
            int angka2 = Convert.ToInt32(TextBox2.Text);

            int perkalian = angka1 * angka2;

            lblHasil.Text = perkalian.ToString();

        }

        private void BagiBtn_click(object sender, EventArgs e)
        {

            int angka1 = Convert.ToInt32(TextBox1.Text);
            int angka2 = Convert.ToInt32(TextBox2.Text);

            if (angka2 == 0)
            {
                MessageBox.Show("Tidak Bisa Membagi Dengan Angka 0!");
                return;
            }

            double pembagian = (double)angka1 / angka2;

            lblHasil.Text = pembagian.ToString();

        }

    }
}
