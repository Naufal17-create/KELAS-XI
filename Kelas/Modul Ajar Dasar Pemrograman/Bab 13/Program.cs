using System;

namespace MethodStudiKasusDanLatihan
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