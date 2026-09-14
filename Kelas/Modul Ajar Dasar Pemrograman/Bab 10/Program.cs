using System;

namespace ProgramGabunganCsharp
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