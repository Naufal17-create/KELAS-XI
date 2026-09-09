using System;
using System.Runtime.CompilerServices;
namespace Matematika
{
    class Home
    {
       static void Main(String[] args)
        {
            Console.WriteLine("Belajar BPO");

            Kalkulator kal = new Kalkulator();
            BangunDatar bdatar = new BangunDatar();
            BangunRuang bruang = new BangunRuang();

            kal.penjumlahan();
            BangunDatar.luaslingkaran();
            bruang.volumetabung();
        }
    }

    class Kalkulator
    {
        public void penjumlahan()
        {
            Console.WriteLine("Penjumlahan");
        }
        public void pengurangan()
        {
            Console.WriteLine("Pengurangan");
        }
        public void perkalian()
        {
            Console.WriteLine("Perkalian");
        }
        public void pembagian()
        {
            Console.WriteLine("Pembagian");
        }
    }

    class BangunDatar
    {
        public static void kelilingpersegipanjang()
        {
            Console.WriteLine("keliling Persegi Panjang");
        }
        public static void kelilinglingkaran()
        {
            Console.WriteLine("keliling Lingkaran");
        }
        public static void luaspersegipanjang()
        {
            Console.WriteLine("luas Persegi Panjang");
        }
        public static void luaslingkaran()
        {
            Console.WriteLine("luas Lingkaran");
        }
    }

    class BangunRuang
    {
        public void volumebalok()
        {
            Console.WriteLine("volume Balok");
        }
        public void volumetabung()
        {
            Console.WriteLine("volume Tabung");
        }
        public void volumepiramida()
        {
            Console.WriteLine("volume Piramida");
        }
    }
}