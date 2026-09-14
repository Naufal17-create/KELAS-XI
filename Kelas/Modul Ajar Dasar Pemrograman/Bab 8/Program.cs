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