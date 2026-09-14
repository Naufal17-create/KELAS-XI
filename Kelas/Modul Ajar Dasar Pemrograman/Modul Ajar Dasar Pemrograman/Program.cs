using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        bool berjalan = true;

        while (berjalan)
        {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("         MENU UTAMA PEMBELAJARAN C#        ");
            Console.WriteLine("===========================================");
            Console.WriteLine("1.  Bab 1");
            Console.WriteLine("2.  Bab 2");
            Console.WriteLine("3.  Bab 3");
            Console.WriteLine("4.  Bab 4");
            Console.WriteLine("5.  Bab 5");
            Console.WriteLine("6.  Bab 6");
            Console.WriteLine("7.  Bab 7");
            Console.WriteLine("8.  Bab 8");
            Console.WriteLine("9.  Bab 9");
            Console.WriteLine("10. Bab 10");
            Console.WriteLine("11. Bab 11");
            Console.WriteLine("12. Bab 12");
            Console.WriteLine("13. Bab 13");
            Console.WriteLine("14. Bab 14");
            Console.WriteLine("0.  Keluar");
            Console.WriteLine("===========================================");
            Console.Write("Pilih Bab (0-14): ");

            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();
                    Bab1Code.Program.Run();
                    Console.WriteLine("\nTekan Enter untuk kembali ke menu utama...");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    Bab2Code.Program.Run();
                    break;
                case "3": BabKosong(3); break;
                case "4": BabKosong(4); break;
                case "5":
                    Console.Clear();
                    Bab5Code.Program.Run();
                    break;
                case "6":
                    Console.Clear();
                    Bab6Code.Program.Run();
                    break;
                case "7": BabKosong(7); break;
                case "8":
                    Console.Clear();
                    Bab8Code.Program.Run();
                    break;
                case "9":
                    Console.Clear();
                    Bab9Code.Program.Run();
                    break;
                case "10":
                    Console.Clear();
                    Bab10Code.Program.Run();
                    break;
                case "11":
                    Console.Clear();
                    Bab11Code.Program.Run();
                    break;
                case "12":
                    Console.Clear();
                    Bab12Code.Program.Run();
                    break;
                case "13":
                    Console.Clear();
                    Bab13Code.Program.Run();
                    break;
                case "14":
                    Console.Clear();
                    Bab14Code.Program.Run();
                    break;
                case "0": berjalan = false; break;
                default:
                    Console.WriteLine("\nPilihan tidak valid! Tekan Enter...");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void BabKosong(int nomorBab)
    {
        Console.Clear();
        Console.WriteLine($"Bab {nomorBab} tidak memiliki isi.");
        Console.WriteLine("\nTekan Enter untuk kembali ke menu utama...");
        Console.ReadLine();
    }
}


namespace Bab1Code
{
    class Program
    {
        public static void Run()
        {
            Console.WriteLine("Hello World");
        }
    }
}

namespace Bab2Code
{
    class Program
    {
        // ===================================================
        // MENU UTAMA (FIRST SCREEN)
        // ===================================================
        public static void Run()
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

namespace Bab5Code
{
    class Program
    {
        public static void Run()
        {
            Console.WriteLine("Maulana Naufal Fatihus Sururi");
            Console.WriteLine("\nTekan Enter untuk kembali ke menu BAB...");
            Console.ReadLine();
        }
    }
}

namespace Bab6Code
{
    class Program
    {
        public static void Run()
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

namespace Bab8Code
{
    class Program
    {
        // ===================================================
        // MENU UTAMA (FIRST SCREEN)
        // ===================================================
        public static void Run()
        {
            bool programBerjalan = true;

            while (programBerjalan)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("            OPERATOR DALAM C#              ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Studi Kasus Operator & IF");
                Console.WriteLine("2. Latihan Pemrograman Dasar");
                Console.WriteLine("3. Mini Project");
                Console.WriteLine("0. Keluar dari Aplikasi");
                Console.WriteLine("===========================================");
                Console.Write("Pilih kategori (0-3): ");

                string pilihanUtama = Console.ReadLine();

                switch (pilihanUtama)
                {
                    case "1":
                        SubMenuStudiKasus();
                        break;
                    case "2":
                        SubMenuLatihan();
                        break;
                    case "3":
                        SubMenuMiniProject();
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
        // KATEGORI 1: STUDI KASUS OPERATOR & IF
        // ===================================================
        static void SubMenuStudiKasus()
        {
            bool diStudiKasus = true;

            while (diStudiKasus)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("        STUDI KASUS OPERATOR & IF C#       ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Hitung Total Belanja 3 Barang");
                Console.WriteLine("2. Cek Kelulusan Siswa (Berdasarkan Nilai)");
                Console.WriteLine("3. Hitung Sisa Pembagian (Modulus)");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu (0-3): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        MenuHitungBelanja();
                        break;
                    case "2":
                        MenuCekKelulusan();
                        break;
                    case "3":
                        MenuHitungModulus();
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

        static void MenuHitungBelanja()
        {
            Console.Clear();
            Console.WriteLine("--- 1. HITUNG TOTAL BELANJA 3 BARANG ---");

            Console.Write("Masukkan harga barang ke-1: Rp ");
            double barang1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan harga barang ke-2: Rp ");
            double barang2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan harga barang ke-3: Rp ");
            double barang3 = Convert.ToDouble(Console.ReadLine());

            double totalBelanja = barang1 + barang2 + barang3;

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Total Belanjaan : Rp {totalBelanja:N0}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }

        static void MenuCekKelulusan()
        {
            Console.Clear();
            Console.WriteLine("--- 2. CEK KELULUSAN SISWA ---");

            double kkm = 75;

            Console.Write("Masukkan nilai siswa (0-100): ");
            double nilai = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nStandar Kelulusan (KKM): {kkm}");

            if (nilai >= kkm)
            {
                Console.WriteLine("[HASIL] Selamat! Siswa dinyatakan LULUS.");
            }
            else
            {
                Console.WriteLine("[HASIL] Siswa dinyatakan TIDAK LULUS (Harus Remedial).");
            }

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }

        static void MenuHitungModulus()
        {
            Console.Clear();
            Console.WriteLine("--- 3. HITUNG SISA PEMBAGIAN (MODULUS %) ---");

            Console.Write("Masukkan angka yang dibagi (Pembilang): ");
            int angka1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan angka pembagi (Penyebut): ");
            int angka2 = Convert.ToInt32(Console.ReadLine());

            int hasilBagi = angka1 / angka2;
            int sisaBagi = angka1 % angka2;

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"{angka1} dibagi {angka2} = {hasilBagi} (sisa {sisaBagi})");
            Console.WriteLine($"Sisa pembagian ({angka1} % {angka2}) adalah: {sisaBagi}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }

        // ===================================================
        // KATEGORI 2: LATIHAN PEMROGRAMAN DASAR
        // ===================================================
        static void SubMenuLatihan()
        {
            bool diLatihan = true;

            while (diLatihan)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("        LATIHAN PEMROGRAMAN DASAR C#       ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Hitung Luas Persegi Panjang");
                Console.WriteLine("2. Hitung Rata-Rata 3 Nilai");
                Console.WriteLine("3. Menentukan Bilangan Genap atau Ganjil");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu (0-3): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        MenuHitungLuasPersegiPanjang();
                        break;
                    case "2":
                        MenuHitungRataRata();
                        break;
                    case "3":
                        MenuCekGenapGanjil();
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

        static void MenuHitungLuasPersegiPanjang()
        {
            Console.Clear();
            Console.WriteLine("--- 1. HITUNG LUAS PERSEGI PANJANG ---");

            Console.Write("Masukkan panjang (cm): ");
            double panjang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan lebar (cm): ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            double luas = panjang * lebar;

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Rumus        : {panjang} x {lebar}");
            Console.WriteLine($"Luas Persegi : {luas} cm²");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }

        static void MenuHitungRataRata()
        {
            Console.Clear();
            Console.WriteLine("--- 2. HITUNG RATA-RATA 3 NILAI ---");

            Console.Write("Masukkan Nilai ke-1: ");
            double nilai1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Nilai ke-2: ");
            double nilai2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Nilai ke-3: ");
            double nilai3 = Convert.ToDouble(Console.ReadLine());

            double total = nilai1 + nilai2 + nilai3;
            double rataRata = total / 3.0;

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Total Nilai : {total}");
            Console.WriteLine($"Rata-Rata   : {rataRata:F2}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }

        static void MenuCekGenapGanjil()
        {
            Console.Clear();
            Console.WriteLine("--- 3. CEK BILANGAN GENAP ATAU GANJIL ---");

            Console.Write("Masukkan sebuah bilangan bulat: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            if (angka % 2 == 0)
            {
                Console.WriteLine($"\n[HASIL] Angka {angka} adalah bilangan GENAP.");
            }
            else
            {
                Console.WriteLine($"\n[HASIL] Angka {angka} adalah bilangan GANJIL.");
            }

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }

        // ===================================================
        // KATEGORI 3: MINI PROJECT
        // ===================================================
        static void SubMenuMiniProject()
        {
            bool diMiniProject = true;

            while (diMiniProject)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("              MINI PROJECT C#              ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Kasir Sederhana (Harga x Jumlah)");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu (0-1): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        ProjectKasirSederhana();
                        break;
                    case "0":
                        diMiniProject = false;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid! Tekan Enter...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void ProjectKasirSederhana()
        {
            Console.Clear();
            Console.WriteLine("--- KASIR SEDERHANA ---");

            Console.Write("Harga Barang : Rp ");
            double harga = Convert.ToDouble(Console.ReadLine());

            Console.Write("Jumlah       : ");
            int jumlah = Convert.ToInt32(Console.ReadLine());

            double total = harga * jumlah;

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Total Harga  : Rp {total:N0}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }
    }
}

namespace Bab9Code
{
    class Program
    {
        // ===================================================
        // MENU UTAMA (FIRST SCREEN/HALAMAN UTAMA)
        // ===================================================
        public static void Run()
        {
            bool programBerjalan = true;

            while (programBerjalan)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("         INPUT DAN OUTPUT PADA C#          ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Modul Studi Kasus");
                Console.WriteLine("2. Modul Latihan");
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
        // KATEGORI 1: SUB-MENU STUDI KASUS
        // ===================================================
        static void SubMenuStudiKasus()
        {
            bool diStudiKasus = true;

            while (diStudiKasus)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("        STUDI KASUS PEMROGRAMAN C#         ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Input Biodata Siswa");
                Console.WriteLine("2. Hitung Luas Persegi Panjang");
                Console.WriteLine("3. Hitung Rata-Rata Tiga Nilai");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu (0-3): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        InputBiodataSiswa();
                        break;
                    case "2":
                        HitungLuasPersegiPanjang();
                        break;
                    case "3":
                        HitungRataRataTigaNilai();
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

        // 1. Program Input Biodata Siswa (Dengan Alamat)
        static void InputBiodataSiswa()
        {
            Console.Clear();
            Console.WriteLine("--- 1. INPUT BIODATA SISWA ---");

            Console.Write("Masukkan Nama Lengkap : ");
            string nama = Console.ReadLine();

            Console.Write("Masukkan NISN         : ");
            string nisn = Console.ReadLine();

            Console.Write("Masukkan Kelas        : ");
            string kelas = Console.ReadLine();

            Console.Write("Masukkan Jurusan      : ");
            string jurusan = Console.ReadLine();

            Console.Write("Masukkan Alamat       : ");
            string alamat = Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("               BIODATA SISWA               ");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Nama    : {nama}");
            Console.WriteLine($"NISN    : {nisn}");
            Console.WriteLine($"Kelas   : {kelas}");
            Console.WriteLine($"Jurusan : {jurusan}");
            Console.WriteLine($"Alamat  : {alamat}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }

        // 2. Program Menghitung Luas Persegi Panjang
        static void HitungLuasPersegiPanjang()
        {
            Console.Clear();
            Console.WriteLine("--- 2. HITUNG LUAS PERSEGI PANJANG ---");

            Console.Write("Masukkan panjang (cm) : ");
            double panjang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan lebar (cm)   : ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            double luas = panjang * lebar;

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Rumus  : Panjang x Lebar ({panjang} cm x {lebar} cm)");
            Console.WriteLine($"Luas   : {luas} cm²");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }

        // 3. Program Menghitung Rata-Rata Tiga Nilai
        static void HitungRataRataTigaNilai()
        {
            Console.Clear();
            Console.WriteLine("--- 3. HITUNG RATA-RATA TIGA NILAI ---");

            Console.Write("Masukkan Nilai ke-1 : ");
            double nilai1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Nilai ke-2 : ");
            double nilai2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Nilai ke-3 : ");
            double nilai3 = Convert.ToDouble(Console.ReadLine());

            double total = nilai1 + nilai2 + nilai3;
            double rataRata = total / 3.0;

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Total Nilai : {total}");
            Console.WriteLine($"Rata-Rata   : {rataRata:F2}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }

        // ===================================================
        // KATEGORI 2: SUB-MENU LATIHAN
        // ===================================================
        static void SubMenuLatihan()
        {
            bool diLatihan = true;

            while (diLatihan)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("       LATIHAN PEMROGRAMAN DASAR C#        ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Penjelasan & Demo Write vs WriteLine");
                Console.WriteLine("2. Program Sapaan Nama");
                Console.WriteLine("3. Program Hitung Umur dari Tahun Lahir");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu (0-3): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        PenjelasanDanDemoWriteVsWriteLine();
                        break;
                    case "2":
                        ProgramSapaanNama();
                        break;
                    case "3":
                        ProgramHitungUmur();
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

        // 1. Penjelasan Teori & Demo Praktik Write vs WriteLine
        static void PenjelasanDanDemoWriteVsWriteLine()
        {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("   PENJELASAN WRITE() VS WRITELINE()       ");
            Console.WriteLine("===========================================");
            Console.WriteLine("1. Console.Write():");
            Console.WriteLine("   - Menampilkan teks TANPA berpindah baris baru.");
            Console.WriteLine("   - Kursor tetap berada di sebelah kanan teks.");
            Console.WriteLine("   - Cocok untuk teks petunjuk input (prompt).");
            Console.WriteLine();
            Console.WriteLine("2. Console.WriteLine():");
            Console.WriteLine("   - Menampilkan teks DAN berpindah ke baris baru (enter).");
            Console.WriteLine("   - Kursor langsung pindah ke baris di bawahnya.");
            Console.WriteLine("   - Cocok untuk judul, garis pembatas, atau baris teks terpisah.");
            Console.WriteLine("===========================================");
            Console.WriteLine("                 DEMO KODE                 ");
            Console.WriteLine("===========================================");

            // Demo Console.WriteLine()
            Console.WriteLine("[Contoh Console.WriteLine()]");
            Console.WriteLine("Baris Pertama");
            Console.WriteLine("Baris Kedua");

            Console.WriteLine(); // Baris kosong

            // Demo Console.Write()
            Console.WriteLine("[Contoh Console.Write()]");
            Console.Write("Teks A - ");
            Console.Write("Teks B - ");
            Console.Write("Teks C");
            Console.WriteLine(); // Berpindah baris setelah selesai

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }

        // 2. Program meminta nama dan menampilkan sapaan
        static void ProgramSapaanNama()
        {
            Console.Clear();
            Console.WriteLine("--- 2. PROGRAM SAPAAN NAMA ---");

            Console.Write("Masukkan nama Anda: ");
            string nama = Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Halo, {nama}! Selamat belajar pemrograman C#.");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }

        // 3. Program menghitung umur dari tahun lahir
        static void ProgramHitungUmur()
        {
            Console.Clear();
            Console.WriteLine("--- 3. HITUNG UMUR DARI TAHUN LAHIR ---");

            Console.Write("Masukkan tahun lahir Anda: ");
            int tahunLahir = Convert.ToInt32(Console.ReadLine());

            int tahunSekarang = DateTime.Now.Year;
            int umur = tahunSekarang - tahunLahir;

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Tahun Lahir   : {tahunLahir}");
            Console.WriteLine($"Tahun Sekarang: {tahunSekarang}");
            Console.WriteLine($"Umur Anda     : {umur} tahun");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali...");
            Console.ReadLine();
        }
    }
}

namespace Bab10Code
{
    class Program
    {
        public static void Run()
        {
            bool berjalanUtama = true;

            while (berjalanUtama)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("      PERCABANGAN (SELECTION) PADA C#      ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Studi Kasus Percabangan (If-Else)");
                Console.WriteLine("2. Latihan Pemrograman (If & Switch)");
                Console.WriteLine("3. Mini Project (Pengecekan Syarat KTP)");
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

        #region MENU SUB 1: STUDI KASUS
        static void MenuStudiKasus()
        {
            bool berjalan = true;

            while (berjalan)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("    STUDI KASUS PERCABANGAN (IF-ELSE) C#   ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Cek Bilangan Ganjil / Genap");
                Console.WriteLine("2. Hitung Diskon Belanja");
                Console.WriteLine("3. Tentukan Kategori Nilai Siswa");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu (0-3): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        CekGanjilGenap();
                        break;
                    case "2":
                        HitungDiskon();
                        break;
                    case "3":
                        TentukanKategoriNilai();
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

        static void CekGanjilGenap()
        {
            Console.Clear();
            Console.WriteLine("--- 1. CEK BILANGAN GANJIL / GENAP ---");

            Console.Write("Masukkan sebuah bilangan bulat: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n-------------------------------------------");
            if (angka % 2 == 0)
            {
                Console.WriteLine($"Hasil: Angka {angka} adalah bilangan GENAP.");
            }
            else
            {
                Console.WriteLine($"Hasil: Angka {angka} adalah bilangan GANJIL.");
            }
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static void HitungDiskon()
        {
            Console.Clear();
            Console.WriteLine("--- 2. HITUNG DISKON BELANJA ---");

            Console.Write("Masukkan Total Belanja (Rp): ");
            double totalBelanja = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPilih Metode Diskon:");
            Console.WriteLine("1. Hitung Diskon Otomatis (Sesuai Ketentuan)");
            Console.WriteLine("2. Input Persentase Diskon Manual");
            Console.Write("Pilih metode (1-2): ");
            string metode = Console.ReadLine();

            double persentaseDiskon = 0;

            if (metode == "2")
            {
                Console.Write("Masukkan Persentase Diskon (%): ");
                persentaseDiskon = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                if (totalBelanja >= 500000)
                {
                    persentaseDiskon = 20;
                }
                else if (totalBelanja >= 250000)
                {
                    persentaseDiskon = 10;
                }
                else if (totalBelanja >= 100000)
                {
                    persentaseDiskon = 5;
                }
                else
                {
                    persentaseDiskon = 0;
                }
            }

            double jumlahDiskon = totalBelanja * (persentaseDiskon / 100);
            double totalBayar = totalBelanja - jumlahDiskon;

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Total Belanja : Rp {totalBelanja:N0}");
            Console.WriteLine($"Diskon ({persentaseDiskon}%)   : Rp {jumlahDiskon:N0}");
            Console.WriteLine($"Total Bayar   : Rp {totalBayar:N0}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static void TentukanKategoriNilai()
        {
            Console.Clear();
            Console.WriteLine("--- 3. KATEGORI NILAI SISWA ---");

            Console.Write("Masukkan Nilai Siswa (0-100): ");
            double nilai = Convert.ToDouble(Console.ReadLine());

            string predikat = "";
            string keterangan = "";

            if (nilai >= 90 && nilai <= 100)
            {
                predikat = "A";
                keterangan = "Sangat Baik";
            }
            else if (nilai >= 80 && nilai < 90)
            {
                predikat = "B";
                keterangan = "Baik";
            }
            else if (nilai >= 70 && nilai < 80)
            {
                predikat = "C";
                keterangan = "Cukup";
            }
            else if (nilai >= 60 && nilai < 70)
            {
                predikat = "D";
                keterangan = "Kurang";
            }
            else if (nilai >= 0 && nilai < 60)
            {
                predikat = "E";
                keterangan = "Sangat Kurang";
            }
            else
            {
                predikat = "-";
                keterangan = "Nilai di luar jangkauan (0-100)";
            }

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Nilai Angka : {nilai}");
            Console.WriteLine($"Predikat    : {predikat}");
            Console.WriteLine($"Keterangan  : {keterangan}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }
        #endregion

        #region MENU SUB 2: LATIHAN
        static void MenuLatihan()
        {
            bool berjalan = true;

            while (berjalan)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("   LATIHAN PEMROGRAMAN C# (IF & SWITCH)    ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Program Login Sederhana");
                Console.WriteLine("2. Menentukan Hari (Switch Case)");
                Console.WriteLine("3. Menentukan Predikat Nilai (A, B, C, D)");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu (0-3): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        ProgramLogin();
                        break;
                    case "2":
                        TentukanHari();
                        break;
                    case "3":
                        TentukanPredikatNilai();
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

        static void ProgramLogin()
        {
            Console.Clear();
            Console.WriteLine("--- 1. LOGIN SEDERHANA ---");

            string userBenar = "admin";
            string passBenar = "12345";

            Console.Write("Masukkan Username : ");
            string username = Console.ReadLine();

            Console.Write("Masukkan Password : ");
            string password = Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------");
            if (username == userBenar && password == passBenar)
            {
                Console.WriteLine("Login BERHASIL! Selamat datang, " + username + ".");
            }
            else
            {
                Console.WriteLine("Login GAGAL! Username atau Password salah.");
            }
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static void TentukanHari()
        {
            Console.Clear();
            Console.WriteLine("--- 2. TENTUKAN HARI (1-7) ---");

            Console.Write("Masukkan nomor hari (1-7): ");
            int noHari = Convert.ToInt32(Console.ReadLine());

            string namaHari;

            switch (noHari)
            {
                case 1:
                    namaHari = "Senin";
                    break;
                case 2:
                    namaHari = "Selasa";
                    break;
                case 3:
                    namaHari = "Rabu";
                    break;
                case 4:
                    namaHari = "Kamis";
                    break;
                case 5:
                    namaHari = "Jumat";
                    break;
                case 6:
                    namaHari = "Sabtu";
                    break;
                case 7:
                    namaHari = "Minggu";
                    break;
                default:
                    namaHari = "Nomor tidak valid! Harap masukkan angka 1 sampai 7.";
                    break;
            }

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Hasil : {namaHari}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static void TentukanPredikatNilai()
        {
            Console.Clear();
            Console.WriteLine("--- 3. TENTUKAN PREDIKAT NILAI ---");

            Console.Write("Masukkan Nilai Siswa (0-100): ");
            double nilai = Convert.ToDouble(Console.ReadLine());

            char predikat;

            if (nilai >= 85 && nilai <= 100)
            {
                predikat = 'A';
            }
            else if (nilai >= 75 && nilai < 85)
            {
                predikat = 'B';
            }
            else if (nilai >= 60 && nilai < 75)
            {
                predikat = 'C';
            }
            else if (nilai >= 50 && nilai < 60)
            {
                predikat = 'D';
            }
            else if (nilai >= 0 && nilai < 50)
            {
                predikat = 'E';
            }
            else
            {
                predikat = '-';
            }

            Console.WriteLine("\n-------------------------------------------");
            if (predikat != '-')
            {
                Console.WriteLine($"Nilai Angka : {nilai}");
                Console.WriteLine($"Predikat    : {predikat}");
            }
            else
            {
                Console.WriteLine("Nilai tidak valid! Masukkan angka antara 0 - 100.");
            }
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }
        #endregion

        #region MENU SUB 3: MINI PROJECT
        static void MenuMiniProject()
        {
            bool berjalan = true;

            while (berjalan)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("              MINI PROJECT C#              ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Cek Kelayakan Pembuatan KTP");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu (0-1): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        CekKtp();
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

        static void CekKtp()
        {
            Console.Clear();
            Console.WriteLine("--- MINI PROJECT: CEK SYARAT KTP ---");

            Console.Write("Masukkan Umur: ");
            int umur = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n-------------------------------------------");
            if (umur >= 17)
            {
                Console.WriteLine("Boleh membuat KTP");
            }
            else
            {
                Console.WriteLine("Belum memenuhi syarat");
            }
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }
        #endregion
    }
}

namespace Bab11Code
{
    class Program
    {
        public static void Run()
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

namespace Bab12Code
{
    class Program
    {
        public static void Run()
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

namespace Bab13Code
{
    class Program
    {
        public static void Run()
        {
            bool berjalanUtama = true;

            while (berjalanUtama)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("          METHOD (FUNGSI) PADA C#          ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Modul Studi Kasus");
                Console.WriteLine("2. Modul Latihan");
                Console.WriteLine("3. Mini Project (Hitung Rata-Rata)");
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
                        ProgramMiniProject();
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
                Console.WriteLine("          MODUL STUDI KASUS METHOD         ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Hitung Luas Persegi Panjang");
                Console.WriteLine("2. Hitung Luas Lingkaran");
                Console.WriteLine("3. Cek Bilangan Ganjil / Genap");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu (0-3): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        ProgramLuasPersegiPanjang();
                        break;
                    case "2":
                        ProgramLuasLingkaran();
                        break;
                    case "3":
                        ProgramCekGanjilGenap();
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

        static double HitungLuasPersegiPanjang(double panjang, double lebar)
        {
            return panjang * lebar;
        }

        static void ProgramLuasPersegiPanjang()
        {
            Console.Clear();
            Console.WriteLine("--- 1. HITUNG LUAS PERSEGI PANJANG ---");

            Console.Write("Masukkan Panjang : ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Lebar   : ");
            double l = Convert.ToDouble(Console.ReadLine());

            double luas = HitungLuasPersegiPanjang(p, l);

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Luas Persegi Panjang : {luas}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static double HitungLuasLingkaran(double jariJari)
        {
            return Math.PI * jariJari * jariJari;
        }

        static void ProgramLuasLingkaran()
        {
            Console.Clear();
            Console.WriteLine("--- 2. HITUNG LUAS LINGKARAN ---");

            Console.Write("Masukkan Jari-jari (r) : ");
            double r = Convert.ToDouble(Console.ReadLine());

            double luas = HitungLuasLingkaran(r);

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Luas Lingkaran : {luas:F2}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static bool IsGenap(int angka)
        {
            return angka % 2 == 0;
        }

        static void ProgramCekGanjilGenap()
        {
            Console.Clear();
            Console.WriteLine("--- 3. CEK BILANGAN GANJIL / GENAP ---");

            Console.Write("Masukkan sebuah bilangan bulat: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n-------------------------------------------");
            if (IsGenap(angka))
            {
                Console.WriteLine($"Hasil: Angka {angka} adalah bilangan GENAP.");
            }
            else
            {
                Console.WriteLine($"Hasil: Angka {angka} adalah bilangan GANJIL.");
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
                Console.WriteLine("             MODUL LATIHAN METHOD          ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Hitung Keliling Persegi");
                Console.WriteLine("2. Hitung Faktorial");
                Console.WriteLine("3. Hitung Pangkat Bilangan");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu (0-3): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        ProgramKelilingPersegi();
                        break;
                    case "2":
                        ProgramFaktorial();
                        break;
                    case "3":
                        ProgramPangkat();
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

        static double HitungKelilingPersegi(double sisi)
        {
            return 4 * sisi;
        }

        static void ProgramKelilingPersegi()
        {
            Console.Clear();
            Console.WriteLine("--- 1. HITUNG KELILING PERSEGI ---");

            Console.Write("Masukkan panjang sisi : ");
            double s = Convert.ToDouble(Console.ReadLine());

            double keliling = HitungKelilingPersegi(s);

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Keliling Persegi : {keliling}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static long HitungFaktorial(int n)
        {
            long hasil = 1;
            for (int i = 1; i <= n; i++)
            {
                hasil *= i;
            }
            return hasil;
        }

        static void ProgramFaktorial()
        {
            Console.Clear();
            Console.WriteLine("--- 2. HITUNG FAKTORIAL ---");

            Console.Write("Masukkan angka bulat positif: ");
            int n = Convert.ToInt32(Console.ReadLine());

            long hasil = HitungFaktorial(n);

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Hasil dari {n}! adalah : {hasil}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static double HitungPangkat(double basis, int pangkat)
        {
            return Math.Pow(basis, pangkat);
        }

        static void ProgramPangkat()
        {
            Console.Clear();
            Console.WriteLine("--- 3. HITUNG PANGKAT BILANGAN ---");

            Console.Write("Masukkan angka basis   : ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan nilai pangkat : ");
            int p = Convert.ToInt32(Console.ReadLine());

            double hasil = HitungPangkat(b, p);

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Hasil {b}^{p} adalah : {hasil}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }
        #endregion

        #region MINI PROJECT
        static double HitungRata(int a, int b, int c)
        {
            return (a + b + c) / 3.0;
        }

        static void ProgramMiniProject()
        {
            Console.Clear();
            Console.WriteLine("--- MINI PROJECT: HITUNG RATA-RATA ---");

            Console.Write("Masukkan Nilai Pertama : ");
            int nil1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Nilai Kedua   : ");
            int nil2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Nilai Ketiga  : ");
            int nil3 = Convert.ToInt32(Console.ReadLine());

            double rataRata = HitungRata(nil1, nil2, nil3);

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Nilai Rata-rata : {rataRata:F2}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu utama...");
            Console.ReadLine();
        }
        #endregion
    }

}

namespace Bab14Code
{
    // ==========================================
    // CLASS UNTUK MINI PROJECT
    // ==========================================
    class Mobil
    {
        public string Merk { get; set; }

        public void Jalan()
        {
            Console.WriteLine($"{Merk} sedang berjalan.");
        }
    }

    // ==========================================
    // CLASS UNTUK STUDI KASUS
    // ==========================================
    class Siswa
    {
        public string Nama { get; set; }
        public double Nilai { get; set; }

        public void TampilkanInfo()
        {
            Console.WriteLine($"Nama Siswa : {Nama}");
            Console.WriteLine($"Nilai      : {Nilai}");
        }
    }

    class PersegiPanjang
    {
        public double Panjang { get; set; }
        public double Lebar { get; set; }

        public double HitungLuas()
        {
            return Panjang * Lebar;
        }
    }

    class Rekening
    {
        private double saldo;

        public Rekening(double saldoAwal)
        {
            saldo = saldoAwal;
        }

        public void Setor(double jumlah)
        {
            if (jumlah > 0)
            {
                saldo += jumlah;
                Console.WriteLine($"Berhasil menyetor Rp {jumlah:N0}");
            }
            else
            {
                Console.WriteLine("Jumlah setoran harus lebih dari 0!");
            }
        }

        public void LihatSaldo()
        {
            Console.WriteLine($"Saldo Anda Saat Ini: Rp {saldo:N0}");
        }
    }

    // ==========================================
    // CLASS UNTUK LATIHAN
    // ==========================================
    class Buku
    {
        public string Judul { get; set; }
        public string Penulis { get; set; }

        public Buku(string judul, string penulis)
        {
            Judul = judul;
            Penulis = penulis;
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"Judul Buku : {Judul}");
            Console.WriteLine($"Penulis    : {Penulis}");
        }
    }

    class Mahasiswa
    {
        public string Nama { get; set; }
        public string NIM { get; set; }

        public Mahasiswa(string nama, string nim)
        {
            Nama = nama;
            NIM = nim;
        }

        public void TampilData()
        {
            Console.WriteLine($"Nama Mahasiswa : {Nama}");
            Console.WriteLine($"NIM            : {NIM}");
        }
    }

    // ==========================================
    // PROGRAM UTAMA & NAVIGASI MENU
    // ==========================================
    class Program
    {
        public static void Run()
        {
            bool berjalanUtama = true;

            while (berjalanUtama)
            {
                Console.Clear();
                Console.WriteLine("========================================================");
                Console.WriteLine("   PENGENALAN OBJECT-ORIENTED PROGRAMMING (OOP) PADA C#  ");
                Console.WriteLine("========================================================");
                Console.WriteLine("1. Modul Studi Kasus");
                Console.WriteLine("2. Modul Latihan");
                Console.WriteLine("3. Mini Project (Class Mobil)");
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
                        ProgramMiniProject();
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
                Console.WriteLine("            MODUL STUDI KASUS OOP           ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Class Siswa (Nama & Nilai)");
                Console.WriteLine("2. Class Persegi Panjang (Hitung Luas)");
                Console.WriteLine("3. Class Rekening (Setor & Lihat Saldo)");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu (0-3): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        ProgramSiswa();
                        break;
                    case "2":
                        ProgramPersegiPanjang();
                        break;
                    case "3":
                        ProgramRekening();
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

        static void ProgramSiswa()
        {
            Console.Clear();
            Console.WriteLine("--- 1. CLASS SISWA ---");

            Siswa s = new Siswa();

            Console.Write("Masukkan Nama Siswa : ");
            s.Nama = Console.ReadLine();

            Console.Write("Masukkan Nilai Siswa: ");
            s.Nilai = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n-------------------------------------------");
            s.TampilkanInfo();
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static void ProgramPersegiPanjang()
        {
            Console.Clear();
            Console.WriteLine("--- 2. CLASS PERSEGI PANJANG ---");

            PersegiPanjang pp = new PersegiPanjang();

            Console.Write("Masukkan Panjang : ");
            pp.Panjang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Lebar   : ");
            pp.Lebar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Luas Persegi Panjang : {pp.HitungLuas()}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static void ProgramRekening()
        {
            Console.Clear();
            Console.WriteLine("--- 3. CLASS REKENING BANK ---");

            Console.Write("Masukkan Saldo Awal (Rp): ");
            double saldoAwal = Convert.ToDouble(Console.ReadLine());

            Rekening rek = new Rekening(saldoAwal);
            bool subBerjalan = true;

            while (subBerjalan)
            {
                Console.Clear();
                Console.WriteLine("--- KELOLA REKENING ---");
                Console.WriteLine("1. Lihat Saldo");
                Console.WriteLine("2. Setor Uang");
                Console.WriteLine("0. Kembali ke Menu Studi Kasus");
                Console.WriteLine("-------------------------------------------");
                Console.Write("Pilih transaksi (0-2): ");

                string subPilihan = Console.ReadLine();

                switch (subPilihan)
                {
                    case "1":
                        Console.WriteLine();
                        rek.LihatSaldo();
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Write("\nMasukkan jumlah setoran (Rp): ");
                        double jumlah = Convert.ToDouble(Console.ReadLine());
                        rek.Setor(jumlah);
                        Console.ReadLine();
                        break;
                    case "0":
                        subBerjalan = false;
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
                Console.WriteLine("              MODUL LATIHAN OOP             ");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Class Buku (Judul & Penulis - 2 Param)");
                Console.WriteLine("2. Class Mahasiswa (Method TampilData - 2 Param)");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.WriteLine("===========================================");
                Console.Write("Pilih menu (0-2): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        ProgramBuku();
                        break;
                    case "2":
                        ProgramMahasiswa();
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

        static void ProgramBuku()
        {
            Console.Clear();
            Console.WriteLine("--- 1. CLASS BUKU (CONSTRUCTOR 2 PARAMETER) ---");

            Console.Write("Masukkan Judul Buku : ");
            string judul = Console.ReadLine();

            Console.Write("Masukkan Penulis    : ");
            string penulis = Console.ReadLine();

            Buku b = new Buku(judul, penulis);

            Console.WriteLine("\n-------------------------------------------");
            b.TampilkanInfo();
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static void ProgramMahasiswa()
        {
            Console.Clear();
            Console.WriteLine("--- 2. CLASS MAHASISWA (METHOD TAMPILDATA) ---");

            Console.Write("Masukkan Nama Mahasiswa : ");
            string nama = Console.ReadLine();

            Console.Write("Masukkan NIM            : ");
            string nim = Console.ReadLine();

            Mahasiswa mhs = new Mahasiswa(nama, nim);

            Console.WriteLine("\n-------------------------------------------");
            mhs.TampilData();
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }
        #endregion

        #region MINI PROJECT
        static void ProgramMiniProject()
        {
            Console.Clear();
            Console.WriteLine("--- MINI PROJECT: SIMULASI CLASS MOBIL ---");

            Mobil m = new Mobil();

            Console.Write("Masukkan Merk Mobil : ");
            m.Merk = Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------");
            m.Jalan();
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nTekan Enter untuk kembali ke menu utama...");
            Console.ReadLine();
        }
        #endregion
    }

}
