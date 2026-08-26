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
    public partial class Form2Register : Form
    {
        public Form2Register()
        {
            InitializeComponent();
        }
        private void Daftar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Berhasil Daftar, Silahkan Login");
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Close();
            login.Show();
        }
    }
}
