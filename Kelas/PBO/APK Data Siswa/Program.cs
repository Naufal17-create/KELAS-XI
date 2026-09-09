using System;

namespace APKDataSiswa
{
    class Home
    {
        static void Main(String[] args)
        {
            IdentitasSiswa identitas = new IdentitasSiswa();
            MataPelajaran mapel = new MataPelajaran();
            Absensi absensi = new Absensi();
            Nilai nilai = new Nilai();

            bool lanjut = true;

            while (lanjut)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("         APK DATA SISWA          ");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Identitas Siswa");
                Console.WriteLine("2. Identitas Wali");
                Console.WriteLine("3. Identitas Sekolah");
                Console.WriteLine("4. Data Mata Pelajaran");
                Console.WriteLine("5. Data Absensi Siswa");
                Console.WriteLine("6. Data Nilai Siswa");
                Console.WriteLine("0. Keluar");
                Console.WriteLine("=================================");
                Console.Write("Pilih Menu (0-6): ");
                string pilih = Console.ReadLine();

                Console.WriteLine();

                switch (pilih)
                {
                    case "1":
                        identitas.siswa();
                        break;
                    case "2":
                        identitas.wali();
                        break;
                    case "3":
                        identitas.sekolah();
                        break;
                    case "4":
                        mapel.tampilMapel();
                        break;
                    case "5":
                        absensi.tampilAbsensi();
                        break;
                    case "6":
                        nilai.tampilNilai();
                        break;
                    case "0":
                        lanjut = false;
                        Console.WriteLine("Terima kasih telah menggunakan aplikasi!");
                        continue;
                    default:
                        Console.WriteLine("Pilihan menu tidak valid!");
                        break;
                }

                if (lanjut)
                {
                    Console.WriteLine("\nTekan ENTER untuk kembali ke menu utama...");
                    Console.ReadLine();
                }
            }
        }
    }

    class IdentitasSiswa
    {
        public void siswa()
        {
            Console.WriteLine("-- Data Identitas Diri --");
            Console.WriteLine("NISN          : 0095222230");
            Console.WriteLine("Nama          : Maulana Naufal Fatihus Sururi");
            Console.WriteLine("Kelas         : XI Rekayasa Perangkat Lunak");
            Console.WriteLine("Jenis Kelamin : Laki Laki");
            Console.WriteLine("No Telp       : 087883939554");
            Console.WriteLine("Alamat        : Sidoarjo, Jawa Timur");
        }

        public void wali()
        {
            Console.WriteLine("-- DATA IDENTITAS WALI --");
            Console.WriteLine("Nama Wali     : Budi Santoso");
            Console.WriteLine("Hubungan      : Orang Tua (Ayah)");
            Console.WriteLine("No Telp Wali  : 081234567890");
            Console.WriteLine("Alamat Wali   : Sidoarjo, Jawa Timur");
        }

        public void sekolah()
        {
            Console.WriteLine("-- DATA IDENTITAS SEKOLAH --");
            Console.WriteLine("Nama Sekolah   : SMK Negeri 2 Buduran");
            Console.WriteLine("NPSN           : 20500001");
            Console.WriteLine("Jurusan        : Rekayasa Perangkat Lunak (RPL)");
            Console.WriteLine("Status         : Negeri");
        }
    }

    class MataPelajaran
    {
        public void tampilMapel()
        {
            Console.WriteLine("--- DAFTAR MATA PELAJARAN ---");
            Console.WriteLine("\n[ MATA PELAJARAN PRODUKTIF ]");
            Console.WriteLine("1. PPLG (Pengembangan Perangkat Lunak & Gim)");
            Console.WriteLine("2. PKWU (Prakarya & Kewirausahaan)");

            Console.WriteLine("\n[ MATA PELAJARAN NON-PRODUKTIF / UMUM ]");
            Console.WriteLine("1. Matematika");
            Console.WriteLine("2. Bahasa Indonesia");
            Console.WriteLine("3. Bahasa Inggris");
            Console.WriteLine("4. PAI (Pendidikan Agama Islam)");
            Console.WriteLine("5. PPKN");
            Console.WriteLine("6. Sejarah");
            Console.WriteLine("7. PJOK");
            Console.WriteLine("8. Bahasa Jepang");
            Console.WriteLine("9. Bahasa Jerman");
            Console.WriteLine("10. Bahasa Jawa");
            Console.WriteLine("11. BK (Bimbingan Konseling)");
        }
    }

    class Absensi
    {
        public void tampilAbsensi()
        {
            Console.WriteLine("--- DATA ABSENSI SISWA (JANUARI - DESEMBER) ---");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Bulan\t\t/ Hadir\t/ Sakit\t/ Izin\t/ Alpha\t/ Presentase Kehadiran");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Januari\t\t/ 20\t/ 1\t/ 0\t/ 0\t/ 95%");
            Console.WriteLine("Februari\t/ 19\t/ 0\t/ 1\t/ 0\t/ 95%");
            Console.WriteLine("Maret\t\t/ 21\t/ 0\t/ 0\t/ 0\t/ 100%");
            Console.WriteLine("April\t\t/ 18\t/ 2\t/ 0\t/ 0\t/ 90%");
            Console.WriteLine("Mei\t\t/ 20\t/ 0\t/ 0\t/ 0\t/ 100%");
            Console.WriteLine("Juni\t\t/ 12\t/ 0\t/ 0\t/ 0\t/ 100%");
            Console.WriteLine("Juli\t\t/ 20\t/ 0\t/ 0\t/ 0\t/ 100%");
            Console.WriteLine("Agustus\t\t/ 19\t/ 0\t/ 1\t/ 0\t/ 95%");
            Console.WriteLine("September\t/ 20\t/ 1\t/ 0\t/ 0\t/ 95%");
            Console.WriteLine("Oktober\t\t/ 21\t/ 0\t/ 0\t/ 0\t/ 100%");
            Console.WriteLine("November\t/ 18\t/ 0\t/ 2\t/ 0\t/ 90%");
            Console.WriteLine("Desember\t/ 10\t/ 0\t/ 0\t/ 0\t/ 100%");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Total / Rata\t/ 218\t/ 4\t/ 4\t/ 0\t/ 96.6%");
        }
    }

    class Nilai
    {
        public void tampilNilai()
        {
            Console.WriteLine("--- DATA NILAI SISWA ---");

            Console.WriteLine("\n[ PRODUKTIF ]");
            Console.WriteLine("1. PPLG             : 90 (A)");
            Console.WriteLine("2. PKWU             : 92 (A)");

            Console.WriteLine("\n[ NON-PRODUKTIF / UMUM ]");
            Console.WriteLine("1. Matematika       : 84 (B+)");
            Console.WriteLine("2. Bahasa Indonesia : 85 (B+)");
            Console.WriteLine("3. Bahasa Inggris   : 88 (A-)");
            Console.WriteLine("4. PAI              : 89 (A-)");
            Console.WriteLine("5. PPKN             : 86 (B+)");
            Console.WriteLine("6. Sejarah          : 85 (B+)");
            Console.WriteLine("7. PJOK             : 86 (B+)");
            Console.WriteLine("8. Bahasa Jepang    : 88 (A-)");
            Console.WriteLine("9. Bahasa Jerman    : 87 (A-)");
            Console.WriteLine("10. Bahasa Jawa     : 85 (B+)");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Rata-rata Nilai     : 87.0");
        }
    }
}