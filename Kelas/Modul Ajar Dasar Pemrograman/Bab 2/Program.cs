


using System;

namespace ModulPembelajaranCsharp
{
    class Program
    {
        // ===================================================
        // MENU UTAMA (FIRST SCREEN)
        // ===================================================
        static void Main(string[] args)
        {
            bool programBerjalan = true;

            while (programBerjalan)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("        ALGORITMA DALAM PEMROGRAMAN        ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Studi Kasus");
                Console.WriteLine("2. Latihan");
                Console.WriteLine("0. Keluar dari Aplikasi");
                Console.WriteLine("===========================================");
                Console.Write("Pilih kategori (0-2): ");

                string pilihanUtama = Console.ReadLine();

                switch (pilihanUtama)
                {
                    case "1":
                        SubMenuStudiKasus();
                        break;
                    case "2":
                        SubMenuLatihan();
                        break;
                    case "0":
                        programBerjalan = false;
                        Console.WriteLine("\nTerima kasih telah menggunakan program ini!");
                        break;
                    default:
                        Console.WriteLine("\nPilihan tidak valid! Tekan Enter untuk mencoba lagi...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        // ===================================================
        // KATEGORI 1: STUDI KASUS
        // ===================================================
        static void SubMenuStudiKasus()
        {
            bool diStudiKasus = true;

            while (diStudiKasus)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("               STUDI KASUS                 ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Algoritma Login Sederhana");
                Console.WriteLine("2. Algoritma Menghitung Rata-Rata 3 Nilai");
                Console.WriteLine("3. Algoritma Menentukan Bilangan Ganjil/Genap");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu (0-3): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        MenuLoginSederhana();
                        break;
                    case "2":
                        MenuHitungRataRata();
                        break;
                    case "3":
                        MenuGanjilGenap();
                        break;
                    case "0":
                        diStudiKasus = false;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid! Tekan Enter...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void MenuLoginSederhana()
        {
            Console.Clear();
            Console.WriteLine("--- 1. PROGRAM LOGIN SEDERHANA ---");

            string usernameBenar = "admin";
            string passwordBenar = "12345";

            Console.Write("Masukkan Username: ");
            string usernameInput = Console.ReadLine();

            Console.Write("Masukkan Password: ");
            string passwordInput = Console.ReadLine();

            if (usernameInput == usernameBenar && passwordInput == passwordBenar)
            {
                Console.WriteLine("\n[BERHASIL] Login sukses! Selamat datang, " + usernameInput + ".");
            }
            else
            {
                Console.WriteLine("\n[GAGAL] Username atau password salah!");
            }

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }

        static void MenuHitungRataRata()
        {
            Console.Clear();
            Console.WriteLine("--- 2. PROGRAM MENGHITUNG RATA-RATA 3 NILAI ---");

            Console.Write("Masukkan Nilai ke-1: ");
            double nilai1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Nilai ke-2: ");
            double nilai2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Nilai ke-3: ");
            double nilai3 = Convert.ToDouble(Console.ReadLine());

            double total = nilai1 + nilai2 + nilai3;
            double rataRata = total / 3.0;

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("Total Nilai : " + total);
            Console.WriteLine("Rata-Rata   : " + rataRata.ToString("F2"));
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }

        static void MenuGanjilGenap()
        {
            Console.Clear();
            Console.WriteLine("--- 3. PROGRAM BILANGAN GANJIL / GENAP ---");

            Console.Write("Masukkan sebuah bilangan bulat: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            if (angka % 2 == 0)
            {
                Console.WriteLine("\n[HASIL] Bilangan " + angka + " adalah GENAP.");
            }
            else
            {
                Console.WriteLine("\n[HASIL] Bilangan " + angka + " adalah GANJIL.");
            }

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }

        // ===================================================
        // KATEGORI 2: LATIHAN
        // ===================================================
        static void SubMenuLatihan()
        {
            bool diLatihan = true;

            while (diLatihan)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("                 LATIHAN                   ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Algoritma Membuat Teh");
                Console.WriteLine("2. Algoritma Menarik Uang di ATM");
                Console.WriteLine("3. Algoritma Menghitung Luas Segitiga");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu (0-3): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        MenuMembuatTeh();
                        break;
                    case "2":
                        MenuTarikUangATM();
                        break;
                    case "3":
                        MenuHitungLuasSegitiga();
                        break;
                    case "0":
                        diLatihan = false;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid! Tekan Enter...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void MenuMembuatTeh()
        {
            Console.Clear();
            Console.WriteLine("--- 1. SIMULASI MEMBUAT TEH MANIS ---");

            Console.Write("Apakah air sudah mendidih? (ya/tidak): ");
            string airMendidih = Console.ReadLine().ToLower();

            if (airMendidih != "ya")
            {
                Console.WriteLine("-> Rebus air terlebih dahulu hingga mendidih.");
            }

            Console.WriteLine("-> Masukkan kantong teh ke dalam gelas.");

            Console.Write("Berapa sendok gula yang diinginkan? ");
            int sendokGula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-> Tuangkan air panas ke dalam gelas.");
            Console.WriteLine($"-> Masukkan {sendokGula} sendok gula.");
            Console.WriteLine("-> Aduk hingga gula larut dan warna air berubah.");
            Console.WriteLine("[SELESAI] Teh manis siap dinikmati!");

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }

        static void MenuTarikUangATM()
        {
            Console.Clear();
            Console.WriteLine("--- 2. SIMULASI TARIK UANG DI ATM ---");

            string pinBenar = "123456";
            double saldo = 500000;

            Console.WriteLine("-> Masukkan kartu ATM.");
            Console.Write("Masukkan 6-digit PIN ATM: ");
            string pinInput = Console.ReadLine();

            if (pinInput == pinBenar)
            {
                Console.WriteLine($"\nSaldo Anda saat ini: Rp {saldo:N0}");
                Console.Write("Masukkan nominal uang yang ingin ditarik: Rp ");
                double nominalTarik = Convert.ToDouble(Console.ReadLine());

                if (nominalTarik <= 0)
                {
                    Console.WriteLine("[GAGAL] Nominal penarikan tidak valid.");
                }
                else if (nominalTarik > saldo)
                {
                    Console.WriteLine("[GAGAL] Saldo Anda tidak mencukupi.");
                }
                else
                {
                    saldo -= nominalTarik;
                    Console.WriteLine("\n-> Silakan ambil uang Anda.");
                    Console.WriteLine($"[BERHASIL] Sisa saldo Anda: Rp {saldo:N0}");
                }
            }
            else
            {
                Console.WriteLine("\n[GAGAL] PIN Anda salah! Transaksi dibatalkan.");
            }

            Console.WriteLine("-> Ambil kembali kartu ATM Anda.");
            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }

        static void MenuHitungLuasSegitiga()
        {
            Console.Clear();
            Console.WriteLine("--- 3. MENGHITUNG LUAS SEGITIGA ---");

            Console.Write("Masukkan alas segitiga (cm): ");
            double alas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan tinggi segitiga (cm): ");
            double tinggi = Convert.ToDouble(Console.ReadLine());

            double luas = 0.5 * alas * tinggi;

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Rumus : 1/2 * {alas} * {tinggi}");
            Console.WriteLine($"Luas Segitiga : {luas} cm²");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }
    }
}