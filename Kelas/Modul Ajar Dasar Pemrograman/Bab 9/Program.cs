using System;

namespace ProgramPembelajaranCsharp
{
    class Program
    {
        // ===================================================
        // MENU UTAMA (FIRST SCREEN/HALAMAN UTAMA)
        // ===================================================
        static void Main(string[] args)
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