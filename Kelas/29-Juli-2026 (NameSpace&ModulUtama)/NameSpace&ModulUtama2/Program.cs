using System;

class Program
{
    static void Main(string[] args)
    {
        bool berjalan = true;
        while (berjalan)
        {
            Console.Clear();
            Console.WriteLine("=====================");
            Console.WriteLine("     PILIH MENU     ");
            Console.WriteLine("=====================");
            Console.WriteLine("1. Kalkulator Sederhana (+, -, *, /)");
            Console.WriteLine("2. Bangun Datar (Luas & Keliling)");
            Console.WriteLine("3. Bangun Ruang (Volume)");
            Console.WriteLine("4. Cek Zodiak");
            Console.WriteLine("5. Keluar");
            Console.WriteLine("=====================");
            Console.Write("Pilih menu (1-5): ");

            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    MenuKalkulator();
                    break;
                case "2":
                    MenuBangunDatar();
                    break;
                case "3":
                    MenuBangunRuang();
                    break;
                case "4":
                    MenuZodiak();
                    break;
                case "5":
                    berjalan = false;
                    Console.WriteLine("\nTerima kasih telah menggunakan program ini!");
                    break;
                default:
                    Console.WriteLine("\nPilihan tidak valid! Tekan Enter untuk mencoba lagi.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    // 1. KALKULATOR SEDERHANA
    static void MenuKalkulator()
    {
        Console.Clear();
        Console.WriteLine("--- KALKULATOR SEDERHANA ---");
        Console.Write("Masukkan angka pertama : ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masukkan operator (+, -, *, /) : ");
        char op = Convert.ToChar(Console.ReadLine());

        Console.Write("Masukkan angka kedua   : ");
        double b = Convert.ToDouble(Console.ReadLine());

        double hasil = 0;
        bool valid = true;

        switch (op)
        {
            case '+': hasil = a + b; break;
            case '-': hasil = a - b; break;
            case '*': hasil = a * b; break;
            case '/':
                if (b != 0) hasil = a / b;
                else
                {
                    Console.WriteLine("\nError: Pembagian dengan nol tidak diperbolehkan!");
                    valid = false;
                }
                break;
            default:
                Console.WriteLine("\nOperator tidak dikenali!");
                valid = false;
                break;
        }

        if (valid)
        {
            Console.WriteLine($"\nHasil: {a} {op} {b} = {hasil}");
        }

        TungguEnter();
    }

    // 2. BANGUN DATAR (LUAS & KELILING)
    static void MenuBangunDatar()
    {
        Console.Clear();
        Console.WriteLine("--- BANGUN DATAR ---");
        Console.WriteLine("1. Persegi");
        Console.WriteLine("2. Persegi Panjang");
        Console.WriteLine("3. Lingkaran");
        Console.Write("Pilih bangun datar (1-3): ");
        string subPilihan = Console.ReadLine();

        switch (subPilihan)
        {
            case "1":
                Console.Write("Masukkan panjang sisi: ");
                double s = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Luas Persegi     = {s * s}");
                Console.WriteLine($"Keliling Persegi = {4 * s}");
                break;

            case "2":
                Console.Write("Masukkan panjang : ");
                double p = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan lebar   : ");
                double l = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Luas Persegi Panjang     = {p * l}");
                Console.WriteLine($"Keliling Persegi Panjang = {2 * (p + l)}");
                break;

            case "3":
                Console.Write("Masukkan jari-jari (r): ");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Luas Lingkaran     = {Math.PI * r * r:F2}");
                Console.WriteLine($"Keliling Lingkaran = {2 * Math.PI * r:F2}");
                break;

            default:
                Console.WriteLine("Pilihan tidak valid!");
                break;
        }

        TungguEnter();
    }

    // 3. BANGUN RUANG (VOLUME)
    static void MenuBangunRuang()
    {
        Console.Clear();
        Console.WriteLine("--- BANGUN RUANG (VOLUME) ---");
        Console.WriteLine("1. Kubus");
        Console.WriteLine("2. Balok");
        Console.WriteLine("3. Tabung");
        Console.Write("Pilih bangun ruang (1-3): ");
        string subPilihan = Console.ReadLine();

        switch (subPilihan)
        {
            case "1":
                Console.Write("Masukkan panjang sisi/rusuk: ");
                double s = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Volume Kubus = {Math.Pow(s, 3)}");
                break;

            case "2":
                Console.Write("Masukkan panjang : ");
                double p = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan lebar   : ");
                double l = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan tinggi  : ");
                double t = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Volume Balok = {p * l * t}");
                break;

            case "3":
                Console.Write("Masukkan jari-jari alas (r): ");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan tinggi tabung     : ");
                double tt = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Volume Tabung = {Math.PI * r * r * tt:F2}");
                break;

            default:
                Console.WriteLine("Pilihan tidak valid!");
                break;
        }

        TungguEnter();
    }

    // 4. PENENTU ZODIAK
    static void MenuZodiak()
    {
        Console.Clear();
        Console.WriteLine("--- PENENTU ZODIAK ---");
        Console.Write("Masukkan Tanggal Lahir (1-31): ");
        int tgl = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan Bulan Lahir (1-12)  : ");
        int bln = Convert.ToInt32(Console.ReadLine());

        string zodiak = "";

        if ((bln == 3 && tgl >= 21) || (bln == 4 && tgl <= 19)) zodiak = "Aries";
        else if ((bln == 4 && tgl >= 20) || (bln == 5 && tgl <= 20)) zodiak = "Taurus";
        else if ((bln == 5 && tgl >= 21) || (bln == 6 && tgl <= 20)) zodiak = "Gemini";
        else if ((bln == 6 && tgl >= 21) || (bln == 7 && tgl <= 22)) zodiak = "Cancer";
        else if ((bln == 7 && tgl >= 23) || (bln == 8 && tgl <= 22)) zodiak = "Leo";
        else if ((bln == 8 && tgl >= 23) || (bln == 9 && tgl <= 22)) zodiak = "Virgo";
        else if ((bln == 9 && tgl >= 23) || (bln == 10 && tgl <= 22)) zodiak = "Libra";
        else if ((bln == 10 && tgl >= 23) || (bln == 11 && tgl <= 21)) zodiak = "Scorpio";
        else if ((bln == 11 && tgl >= 22) || (bln == 12 && tgl <= 21)) zodiak = "Sagittarius";
        else if ((bln == 12 && tgl >= 22) || (bln == 1 && tgl <= 19)) zodiak = "Capricorn";
        else if ((bln == 1 && tgl >= 20) || (bln == 2 && tgl <= 18)) zodiak = "Aquarius";
        else if ((bln == 2 && tgl >= 19) || (bln == 3 && tgl <= 20)) zodiak = "Pisces";
        else zodiak = "Tanggal/Bulan tidak valid!";

        Console.WriteLine($"\nZodiak Anda adalah: {zodiak}");
        TungguEnter();
    }

    static void TungguEnter()
    {
        Console.WriteLine("\nTekan Enter untuk kembali ke menu utama...");
        Console.ReadLine();
    }
}