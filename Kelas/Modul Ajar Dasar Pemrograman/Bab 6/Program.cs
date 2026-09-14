using System;

namespace LatihanOutputDanInput
{
    class Program
    {
        static void Main(string[] args)
        {
            bool berjalan = true;

            while (berjalan)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("       LATIHAN INPUT & OUTPUT C#           ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Tampilkan Nama Sekolah");
                Console.WriteLine("2. Sapaan Nama Pengguna (Input/Output)");
                Console.WriteLine("3. Tampilkan 3 Baris Informasi");
                Console.WriteLine("0. Keluar");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu (0-3): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        MenuNamaSekolah();
                        break;
                    case "2":
                        MenuSapaanPengguna();
                        break;
                    case "3":
                        MenuTigaBarisInformasi();
                        break;
                    case "0":
                        berjalan = false;
                        Console.WriteLine("Terima kasih telah latihan!");
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid! Tekan Enter...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        // ===================================================
        // 1. PROGRAM MENAMPILKAN NAMA SEKOLAH
        // ===================================================
        static void MenuNamaSekolah()
        {
            Console.Clear();
            Console.WriteLine("--- 1. MENAMPILKAN NAMA SEKOLAH ---");

            // Menampilkan nama sekolah langsung ke layar
            Console.WriteLine("Sekolah: SMKN 2 Buduran");

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }

        // ===================================================
        // 2. PROGRAM SAPAAN NAMA PENGGUNA
        // ===================================================
        static void MenuSapaanPengguna()
        {
            Console.Clear();
            Console.WriteLine("--- 2. PROGRAM SAPAAN PENGGUNA ---");

            // Meminta input nama dari pengguna
            Console.Write("Masukkan nama Anda: ");
            string nama = Console.ReadLine();

            // Menampilkan sapaan menggunakan nama yang dimasukkan
            Console.WriteLine($"\nHallo, {nama}! Selamat belajar pemrograman C#.");

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }

        // ===================================================
        // 3. PROGRAM 3 BARIS INFORMASI
        // ===================================================
        static void MenuTigaBarisInformasi()
        {
            Console.Clear();
            Console.WriteLine("--- 3. MENAMPILKAN 3 BARIS INFORMASI ---");

            // Menggunakan 3 baris Console.WriteLine() terpisah
            Console.WriteLine("Informasi 1: Bahasa C# dikembangkan oleh Microsoft.");
            Console.WriteLine("Informasi 2: C# merupakan bahasa pemrograman berorientasi objek (OOP).");
            Console.WriteLine("Informasi 3: C# banyak digunakan untuk membuat aplikasi Desktop, Web, dan Game.");

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }
    }
}