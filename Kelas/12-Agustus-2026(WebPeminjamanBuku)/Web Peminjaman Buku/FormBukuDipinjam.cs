using System;
using System.Data;
using System.Windows.Forms;

namespace Web_Peminjaman_Buku
{
    public partial class FormBukuDipinjam : Form
    {
        // Variabel penampung data statis
        public static DataTable DataPeminjaman = new DataTable();

        public FormBukuDipinjam()
        {
            InitializeComponent();
            InisialisasiStrukturTabel();
        }

        // Method statis untuk menyiapkan kolom DataTable satu kali saja
        public static void InisialisasiStrukturTabel()
        {
            if (DataPeminjaman.Columns.Count == 0)
            {
                DataPeminjaman.Columns.Add("Judul Buku");
                DataPeminjaman.Columns.Add("Tgl. Pinjam");
                DataPeminjaman.Columns.Add("No. Buku (ISBN)");
                DataPeminjaman.Columns.Add("Tgl. Kembali");
                DataPeminjaman.Columns.Add("Status");
                DataPeminjaman.Columns.Add("Nama Anggota");
            }
        }

        private void FormBukuDipinjam_Load(object sender, EventArgs e)
        {
            TampilkanData();
        }

        // Method publik untuk menyegarkan tampilan DataGridView tanpa membuat kolom ganda
        public void TampilkanData()
        {
            // Matikan pembuatan kolom otomatis agar tidak membentuk kolom baru di sebelah kanan
            dataGridView1.AutoGenerateColumns = false;

            // Hubungkan kolom visual di Designer ke nama kolom di DataTable
            if (dataGridView1.Columns.Count >= 5)
            {
                dataGridView1.Columns[0].DataPropertyName = "Judul Buku";
                dataGridView1.Columns[1].DataPropertyName = "Tgl. Pinjam";
                dataGridView1.Columns[2].DataPropertyName = "No. Buku (ISBN)";
                dataGridView1.Columns[3].DataPropertyName = "Tgl. Kembali";
                dataGridView1.Columns[4].DataPropertyName = "Status";
            }

            dataGridView1.DataSource = null; // Reset binding
            dataGridView1.DataSource = DataPeminjaman; // Bind data terbaru
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label14_Click(object sender, EventArgs e) { }

        // Tombol Kembali ke Form1 (button2)
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 formUtama = (Form1)Application.OpenForms["Form1"];

            if (formUtama == null)
            {
                formUtama = new Form1();
                formUtama.Show();
            }
            else
            {
                formUtama.Show();
                formUtama.BringToFront();
            }

            this.Hide();
        }
    }
}