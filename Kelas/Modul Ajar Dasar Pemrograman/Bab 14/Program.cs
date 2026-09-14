using System;

namespace OopStudiKasusDanLatihan
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
        static void Main(string[] args)
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