using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class Form5_Master_Maskapai : Form
    {
        public Form5_Master_Maskapai()
        {
            InitializeComponent();
        }

        private void Form5_Master_Maskapai_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3Dashboard form3 = new Form3Dashboard();
            this.Close();
            form3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3Dashboard form3 = new Form3Dashboard();
            this.Close();
            form3.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form4Bandara form4 = new Form4Bandara();
            this.Close();
            form4.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4Bandara form4 = new Form4Bandara();
            this.Close();
            form4.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form5_Master_Maskapai form5 = new Form5_Master_Maskapai();
            this.Close();
            form5.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5_Master_Maskapai form5 = new Form5_Master_Maskapai();
            this.Close();
            form5.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form6MasterJadwalPenerbangan form6 = new Form6MasterJadwalPenerbangan();
            this.Close();
            form6.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form6MasterJadwalPenerbangan form6 = new Form6MasterJadwalPenerbangan();
            this.Close();
            form6.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form7MasterKodePromo form7 = new Form7MasterKodePromo();
            this.Close();
            form7.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form7MasterKodePromo form7 = new Form7MasterKodePromo();
            this.Close();
            form7.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form8UbahStatusPenerbangan form8 = new Form8UbahStatusPenerbangan();
            this.Close();
            form8.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form8UbahStatusPenerbangan form8 = new Form8UbahStatusPenerbangan();
            this.Close();
            form8.Show();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Close();
            login.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Close();
            login.Show();
        }
    }
}
