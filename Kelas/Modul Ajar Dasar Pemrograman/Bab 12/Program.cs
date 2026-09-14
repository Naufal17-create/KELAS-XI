using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayAndListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool berjalanUtama = true;

            while (berjalanUtama)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("      ARRAY DAN KOLEKSI DASAR PADA C#      ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Modul Studi Kasus");
                Console.WriteLine("2. Modul Latihan");
                Console.WriteLine("3. Mini Project (Hitung Rata-Rata Nilai)");
                Console.WriteLine("0. Keluar Aplikasi");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu utama (0-3): ");

                string pilihanUtama = Console.ReadLine();

                switch (pilihanUtama)
                {
                    case "1":
                        MenuStudiKasus();
                        break;
                    case "2":
                        MenuLatihan();
                        break;
                    case "3":
                        MiniProject();
                        break;
                    case "0":
                        berjalanUtama = false;
                        Console.WriteLine("\nTerima kasih telah menggunakan aplikasi ini!");
                        break;
                    default:
                        Console.WriteLine("\nPilihan tidak valid! Tekan Enter...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        #region MINI PROJECT
        static void MiniProject()
        {
            Console.Clear();
            Console.WriteLine("--- MINI PROJECT: HITUNG RATA-RATA NILAI ---");

            int[] nilai = { 75, 80, 90, 85, 70 };
            int total = 0;

            Console.WriteLine("Elemen array nilai: " + string.Join(", ", nilai));

            foreach (int n in nilai)
            {
                total += n;
            }

            double rataRata = (double)total / nilai.Length;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Total Nilai : {total}");
            Console.WriteLine($"Rata-rata   = {rataRata}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu utama...");
            Console.ReadLine();
        }
        #endregion

        #region MODUL STUDI KASUS
        static void MenuStudiKasus()
        {
            bool berjalan = true;

            while (berjalan)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("        MODUL STUDI KASUS ARRAY & LIST     ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Menyimpan Nilai 10 Siswa (Array)");
                Console.WriteLine("2. Menghitung Nilai Tertinggi & Rata-rata");
                Console.WriteLine("3. Mengelola Daftar Nama (List)");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu (0-3): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        SimpanNilai10Siswa();
                        break;
                    case "2":
                        HitungTertinggiDanRataRata();
                        break;
                    case "3":
                        KelolaDaftarNamaList();
                        break;
                    case "0":
                        berjalan = false;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid! Tekan Enter...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void SimpanNilai10Siswa()
        {
            Console.Clear();
            Console.WriteLine("--- 1. MENYIMPAN NILAI 10 SISWA ---");

            double[] nilaiSiswa = new double[10];

            for (int i = 0; i < nilaiSiswa.Length; i++)
            {
                Console.Write($"Masukkan nilai siswa ke-{i + 1}: ");
                nilaiSiswa[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("Daftar Nilai Siswa yang Tersimpan:");
            for (int i = 0; i < nilaiSiswa.Length; i++)
            {
                Console.WriteLine($"Siswa ke-{i + 1}: {nilaiSiswa[i]}");
            }
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static void HitungTertinggiDanRataRata()
        {
            Console.Clear();
            Console.WriteLine("--- 2. NILAI TERTINGGI & RATA-RATA ---");

            double[] nilai = new double[10];
            double total = 0;

            for (int i = 0; i < nilai.Length; i++)
            {
                Console.Write($"Masukkan nilai siswa ke-{i + 1}: ");
                nilai[i] = Convert.ToDouble(Console.ReadLine());
                total += nilai[i];
            }

            double tertinggi = nilai[0];
            for (int i = 1; i < nilai.Length; i++)
            {
                if (nilai[i] > tertinggi)
                {
                    tertinggi = nilai[i];
                }
            }

            double rataRata = total / nilai.Length;

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Nilai Tertinggi : {tertinggi}");
            Console.WriteLine($"Rata-rata Nilai : {rataRata:F2}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static void KelolaDaftarNamaList()
        {
            List<string> daftarNama = new List<string>();
            bool lanjut = true;

            while (lanjut)
            {
                Console.Clear();
                Console.WriteLine("--- 3. MENGELOLA DAFTAR NAMA (LIST) ---");
                Console.WriteLine("1. Tambah Nama");
                Console.WriteLine("2. Lihat Daftar Nama");
                Console.WriteLine("3. Hapus Nama");
                Console.WriteLine("0. Kembali ke Menu Studi Kasus");
                Console.WriteLine("-------------------------------------------");
                Console.Write("Pilih opsi (0-3): ");

                string subPilihan = Console.ReadLine();

                switch (subPilihan)
                {
                    case "1":
                        Console.Write("Masukkan nama baru: ");
                        string namaBaru = Console.ReadLine();
                        daftarNama.Add(namaBaru);
                        Console.WriteLine($"Nama '{namaBaru}' berhasil ditambahkan!");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("\nDaftar Nama:");
                        if (daftarNama.Count == 0)
                        {
                            Console.WriteLine("(Belum ada nama tersimpan)");
                        }
                        else
                        {
                            for (int i = 0; i < daftarNama.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {daftarNama[i]}");
                            }
                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Write("Masukkan nama yang ingin dihapus: ");
                        string namaHapus = Console.ReadLine();
                        if (daftarNama.Remove(namaHapus))
                        {
                            Console.WriteLine($"Nama '{namaHapus}' berhasil dihapus!");
                        }
                        else
                        {
                            Console.WriteLine($"Nama '{namaHapus}' tidak ditemukan.");
                        }
                        Console.ReadLine();
                        break;
                    case "0":
                        lanjut = false;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        Console.ReadLine();
                        break;
                }
            }
        }
        #endregion

        #region MODUL LATIHAN
        static void MenuLatihan()
        {
            bool berjalan = true;

            while (berjalan)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("            MODUL LATIHAN ARRAY & LIST     ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Cari Nilai Terbesar dalam Array");
                Console.WriteLine("2. Hitung Jumlah Bilangan Genap dalam Array");
                Console.WriteLine("3. Aplikasi Daftar Nama Menggunakan List");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu (0-3): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        CariNilaiTerbesar();
                        break;
                    case "2":
                        HitungJumlahGenap();
                        break;
                    case "3":
                        AplikasiDaftarNama();
                        break;
                    case "0":
                        berjalan = false;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid! Tekan Enter...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void CariNilaiTerbesar()
        {
            Console.Clear();
            Console.WriteLine("--- 1. CARI NILAI TERBESAR DALAM ARRAY ---");

            Console.Write("Masukkan jumlah elemen array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] angka = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Masukkan angka ke-{i + 1}: ");
                angka[i] = Convert.ToInt32(Console.ReadLine());
            }

            int terbesar = angka[0];
            for (int i = 1; i < n; i++)
            {
                if (angka[i] > terbesar)
                {
                    terbesar = angka[i];
                }
            }

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Nilai terbesar dalam array adalah: {terbesar}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static void HitungJumlahGenap()
        {
            Console.Clear();
            Console.WriteLine("--- 2. HITUNG JUMLAH BILANGAN GENAP ---");

            Console.Write("Masukkan jumlah data array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] data = new int[n];
            int jumlahGenap = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Masukkan data ke-{i + 1}: ");
                data[i] = Convert.ToInt32(Console.ReadLine());

                if (data[i] % 2 == 0)
                {
                    jumlahGenap++;
                }
            }

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Jumlah bilangan genap dalam array: {jumlahGenap} angka");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static void AplikasiDaftarNama()
        {
            List<string> namaSiswa = new List<string>();
            bool berjalan = true;

            while (berjalan)
            {
                Console.Clear();
                Console.WriteLine("--- 3. APLIKASI DAFTAR NAMA (LIST) ---");
                Console.WriteLine("1. Input Nama Baru");
                Console.WriteLine("2. Tampilkan Semua Nama");
                Console.WriteLine("3. Cari Nama");
                Console.WriteLine("0. Kembali ke Menu Latihan");
                Console.WriteLine("-------------------------------------------");
                Console.Write("Pilih menu (0-3): ");

                string pil = Console.ReadLine();

                switch (pil)
                {
                    case "1":
                        Console.Write("Masukkan Nama: ");
                        string nama = Console.ReadLine();
                        namaSiswa.Add(nama);
                        Console.WriteLine("Nama berhasil tersimpan!");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("\n=== DAFTAR NAMA TERSIMPAN ===");
                        if (namaSiswa.Count == 0)
                        {
                            Console.WriteLine("Daftar nama masih kosong.");
                        }
                        else
                        {
                            int no = 1;
                            foreach (var item in namaSiswa)
                            {
                                Console.WriteLine($"{no++}. {item}");
                            }
                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Write("Masukkan nama yang dicari: ");
                        string cari = Console.ReadLine();
                        if (namaSiswa.Contains(cari))
                        {
                            Console.WriteLine($"Status: '{cari}' DITEMUKAN di dalam daftar.");
                        }
                        else
                        {
                            Console.WriteLine($"Status: '{cari}' TIDAK DITEMUKAN.");
                        }
                        Console.ReadLine();
                        break;
                    case "0":
                        berjalan = false;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        Console.ReadLine();
                        break;
                }
            }
        }
        #endregion
    }
}