using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Peminjaman_Buku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // --- METHOD PENYELAMAT DESIGNER (Jangan Dihapus) ---
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        // Event handler untuk Tombol "Proses Peminjaman" (button1 / btnProses)
        private void button1_Click(object sender, EventArgs e)
        {
            ProsesPeminjaman();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            ProsesPeminjaman();
        }

        // Logika Utama Penyimpanan Data dan Navigasi
        private void ProsesPeminjaman()
        {
            // 1. Validasi Input Kelengkapan Data
            if (string.IsNullOrWhiteSpace(txtNamaAnggota.Text) ||
                string.IsNullOrWhiteSpace(txtNoBuku.Text) ||
                string.IsNullOrWhiteSpace(txtJudulBuku.Text))
            {
                MessageBox.Show("Harap isi semua bidang input terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validasi Tanggal
            if (dtpKembali.Value.Date < dtpPinjaman.Value.Date)
            {
                MessageBox.Show("Tanggal kembali tidak boleh lebih awal dari tanggal pinjam!", "Kesalahan Tanggal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Pastikan Kolom DataTable di FormBukuDipinjam Sudah Diinisialisasi
            FormBukuDipinjam.InisialisasiStrukturTabel();

            // 4. Simpan Data ke DataTable Global (Urutan disesuaikan dengan kolom Designer FormBukuDipinjam)
            FormBukuDipinjam.DataPeminjaman.Rows.Add(
                txtJudulBuku.Text.Trim(),                    // Judul Buku
                dtpPinjaman.Value.ToString("dd/MM/yyyy"),     // Tgl. Pinjam
                txtNoBuku.Text.Trim(),                       // No. Buku (ISBN)
                dtpKembali.Value.ToString("dd/MM/yyyy"),      // Tgl. Kembali
                "Sedang Dipinjam",                            // Status
                txtNamaAnggota.Text.Trim()                    // Nama Anggota
            );

            // 5. Menampilkan Notifikasi Sukses
            string pesan = $"Peminjaman Berhasil Diproses!\n\n" +
                           $"Nama Anggota: {txtNamaAnggota.Text}\n" +
                           $"Nomor Buku: {txtNoBuku.Text}\n" +
                           $"Judul Buku: {txtJudulBuku.Text}\n" +
                           $"Tanggal Pinjam: {dtpPinjaman.Value.ToString("dd MMMM yyyy")}\n" +
                           $"Tanggal Kembali: {dtpKembali.Value.ToString("dd MMMM yyyy")}";

            MessageBox.Show(pesan, "Informasi Peminjaman", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 6. Reset Form Input & Pindah Tampilan ke FormBukuDipinjam
            ResetForm();
            BukaFormBukuDipinjam();
        }

        // Event handler untuk Tombol "Batal" (button2)
        private void button2_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Helper: Reset Inputan Form
        private void ResetForm()
        {
            txtNamaAnggota.Clear();
            txtNoBuku.Clear();
            txtJudulBuku.Clear();
            dtpPinjaman.Value = DateTime.Now;
            dtpKembali.Value = DateTime.Now.AddDays(7);
        }

        // Helper: Pindah Halaman ke FormBukuDipinjam & Segarkan DataGridView
        private void BukaFormBukuDipinjam()
        {
            FormBukuDipinjam formTabel = (FormBukuDipinjam)Application.OpenForms["FormBukuDipinjam"];

            if (formTabel == null)
            {
                formTabel = new FormBukuDipinjam();
            }

            formTabel.TampilkanData(); // Refresh DataGridView agar data yang baru diinput langsung muncul
            formTabel.Show();
            formTabel.BringToFront();

            this.Hide();
        }
    }
}