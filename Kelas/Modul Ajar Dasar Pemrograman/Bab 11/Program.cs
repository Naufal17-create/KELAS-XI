using System;
using System.Collections.Generic; // Dibutuhkan jika menggunakan List

namespace LoopStudiKasusDanLatihan
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
                Console.WriteLine("        PERULANGAN (LOOPING) PADA C#       ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Modul Studi Kasus");
                Console.WriteLine("2. Modul Latihan");
                Console.WriteLine("3. Mini Project (Input Nama Siswa)");
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
                        MenuMiniProject();
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

        #region MODUL STUDI KASUS
        static void MenuStudiKasus()
        {
            bool berjalan = true;

            while (berjalan)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("          MODUL STUDI KASUS LOOP           ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Menampilkan Angka 1–100");
                Console.WriteLine("2. Menjumlahkan Bilangan 1–50");
                Console.WriteLine("3. Membuat Pola Segitiga Bintang");
                Console.WriteLine("4. Menampilkan Tabel Perkalian");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu (0-4): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        TampilkanAngka1Sampai100();
                        break;
                    case "2":
                        JumlahkanBilangan1Sampai50();
                        break;
                    case "3":
                        PolaSegitigaBintang();
                        break;
                    case "4":
                        TabelPerkalian();
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

        static void TampilkanAngka1Sampai100()
        {
            Console.Clear();
            Console.WriteLine("--- 1. MENAMPILKAN ANGKA 1-100 ---");

            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static void JumlahkanBilangan1Sampai50()
        {
            Console.Clear();
            Console.WriteLine("--- 2. MENJUMLAHKAN BILANGAN 1-50 ---");

            int total = 0;
            for (int i = 1; i <= 50; i++)
            {
                total += i;
            }

            Console.WriteLine($"Hasil penjumlahan dari 1 hingga 50 adalah: {total}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static void PolaSegitigaBintang()
        {
            Console.Clear();
            Console.WriteLine("--- 3. POLA SEGITIGA BINTANG ---");

            Console.Write("Masukkan tinggi segitiga: ");
            int tinggi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n-------------------------------------------");
            for (int i = 1; i <= tinggi; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static void TabelPerkalian()
        {
            Console.Clear();
            Console.WriteLine("--- 4. TABEL PERKALIAN ---");

            Console.Write("Masukkan angka perkalian (misal: 5): ");
            int angka = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nTabel Perkalian {angka}:");
            Console.WriteLine("-------------------------------------------");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{angka} x {i} = {angka * i}");
            }
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
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
                Console.WriteLine("             MODUL LATIHAN LOOP            ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Hitung Faktorial");
                Console.WriteLine("2. Cari Bilangan Genap 1–100");
                Console.WriteLine("3. Pola Persegi (Nested Loop)");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu (0-3): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        HitungFaktorial();
                        break;
                    case "2":
                        CariGenap1Sampai100();
                        break;
                    case "3":
                        PolaPersegi();
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

        static void HitungFaktorial()
        {
            Console.Clear();
            Console.WriteLine("--- 1. HITUNG FAKTORIAL ---");

            Console.Write("Masukkan angka bulat positif: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            long faktorial = 1;
            for (int i = 1; i <= angka; i++)
            {
                faktorial *= i;
            }

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Hasil dari {angka}! adalah: {faktorial}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static void CariGenap1Sampai100()
        {
            Console.Clear();
            Console.WriteLine("--- 2. BILANGAN GENAP 1-100 ---");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static void PolaPersegi()
        {
            Console.Clear();
            Console.WriteLine("--- 3. POLA PERSEGI (NESTED LOOP) ---");

            Console.Write("Masukkan ukuran sisi persegi: ");
            int sisi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n-------------------------------------------");
            for (int i = 1; i <= sisi; i++)
            {
                for (int j = 1; j <= sisi; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }
        #endregion

        #region MODUL MINI PROJECT
        static void MenuMiniProject()
        {
            bool berjalan = true;

            while (berjalan)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("              MINI PROJECT C#              ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Pendataan Nama Siswa");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu (0-1): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        InputNamaSiswa();
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

        static void InputNamaSiswa()
        {
            Console.Clear();
            Console.WriteLine("--- MINI PROJECT: INPUT NAMA SISWA ---");

            Console.Write("Masukkan jumlah siswa: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Menggunakan Array untuk menampung nama-nama siswa
            string[] daftarSiswa = new string[n];

            Console.WriteLine("\n-------------------------------------------");
            // Loop 1: Input Data
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nama siswa ke-{i + 1}: ");
                daftarSiswa[i] = Console.ReadLine();
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("\n--- DAFTAR SISWA YANG TERDAFTAR ---");

            // Loop 2: Menampilkan Data Kembali
            for (int i = 0; i < daftarSiswa.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {daftarSiswa[i]}");
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Pendataan siswa selesai!");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }
        #endregion
    }
}