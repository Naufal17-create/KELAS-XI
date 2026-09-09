using System;

namespace JadwalPelajaran
{
    class Home
    {
        static void Main(String[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("        JADWAL PELAJARAN         ");
            Console.WriteLine("=================================\n");

            Senin sen = new Senin();
            Selasa sel = new Selasa();
            Rabu rab = new Rabu();

            Console.WriteLine("--- SENIN ---");
            Console.WriteLine("[Sesi 1]");
            sen.sesiSatu();
            Console.WriteLine("\n \n [Sesi 2]");
            sen.sesidua();
            Console.WriteLine("\n[Sesi 3]");
            sen.sesitiga();
            Console.WriteLine("\n \n \n");

            Console.WriteLine("--- SELASA ---");
            Console.WriteLine("[Sesi 1]");
            sel.sesisatu();
            Console.WriteLine("\n[Sesi 2]");
            sel.sesidua();
            Console.WriteLine("\n[Sesi 3]");
            sel.sesitiga();
            Console.WriteLine("\n---------------------------------\n");

            Console.WriteLine("--- RABU ---");
            Console.WriteLine("[Sesi 1]");
            rab.sesisatu();
            Console.WriteLine("\n[Sesi 2]");
            rab.sesidua();
            Console.WriteLine("\n[Sesi 3]");
            rab.sesitiga();
            Console.WriteLine("\n---------------------------------\n");

            Console.WriteLine("--- KAMIS ---");
            Console.WriteLine("[Sesi 1]");
            Kamis.sesisatu();
            Console.WriteLine("\n[Sesi 2]");
            Kamis.sesidua();
            Console.WriteLine("\n[Sesi 3]");
            Kamis.sesitiga();
            Console.WriteLine("\n---------------------------------\n");

            Console.WriteLine("--- JUMAT ---");
            Console.WriteLine("[Sesi 1]");
            Jumat.sesisatu();
            Console.WriteLine("\n[Sesi 2]");
            Jumat.sesidua();
            Console.WriteLine("\n=================================");

            Console.ReadLine();
        }
    }

    class Senin
    {
        public void sesiSatu()
        {
            Console.WriteLine("0.Upacara (07:00 - 07:35)");
            Console.WriteLine("1.Bahasa Jepang (07:35 - 08:10)");
            Console.WriteLine("1.Bahasa Jepang (08:10 - 08:45)");
            Console.WriteLine("2.Bahasa Inggris (08:45 - 09:20)");
            Console.WriteLine("2.Bahasa Inggris (09:20 - 09:55)");
        }
        public void sesidua()
        {
            Console.WriteLine("3.Matematika (10:10 - 10:40)");
            Console.WriteLine("3.Matematika (10:40 - 11:10)");
            Console.WriteLine("3.Matematika (11:10 - 11:40)");
        }
        public void sesitiga()
        {
            Console.WriteLine("4.PPLG (12:30 - 13:00)");
            Console.WriteLine("4.PPLG (13:00 - 13:30)");
            Console.WriteLine("4.PPLG (13:30 - 14:00)");
            Console.WriteLine("4.PPLG (14:00 - 14:30)");
            Console.WriteLine("4.PPLG (14:30 - 15:00)");
        }
    }

    class Selasa
    {
        public void sesisatu()
        {
            Console.WriteLine("1.PKWU (07:00 - 07:35)");
            Console.WriteLine("1.PKWU (07:35 - 08:10)");
            Console.WriteLine("2.PJOK (08:10 - 08:45)");
            Console.WriteLine("2.PJOK (08:45 - 09:20)");
        }
        public void sesidua()
        {
            Console.WriteLine("3.Bahasa Indonesia (09:30 - 10:05)");
            Console.WriteLine("3.Bahasa Indonesia (10:05 - 10:35)");
            Console.WriteLine("3.Bahasa Indonesia (10:35 - 11:05)");
            Console.WriteLine("3.Bahasa Indonesia (11:05 - 11:35)");
        }
        public void sesitiga()
        {
            Console.WriteLine("4.PPLG (12:35 - 13:00)");
            Console.WriteLine("4.PPLG (13:00 - 13:30)");
            Console.WriteLine("4.PPLG (13:30 - 14:00)");
            Console.WriteLine("4.PPLG (14:00 - 14:30)");
        }
    }

    class Rabu
    {
        public void sesisatu()
        {
            Console.WriteLine("1.PPLG (07:00 - 07:35)");
            Console.WriteLine("1.PPLG (07:35 - 08:10)");
            Console.WriteLine("2.PPLG (08:10 - 08:45)");
            Console.WriteLine("2.PPLG (08:45 - 09:20)");
        }
        public void sesidua()
        {
            Console.WriteLine("2.PPLG (09:30 - 10:05)");
            Console.WriteLine("2.PPLG (10:05 - 10:35)");
            Console.WriteLine("2.PPLG (10:35 - 11:05)");
            Console.WriteLine("2.PPLG (11:05 - 11:35)");
        }
        public void sesitiga()
        {
            Console.WriteLine("2.PPLG (12:35 - 13:00)");
            Console.WriteLine("2.PPLG (13:00 - 13:30)");
            Console.WriteLine("3.BK (13:30 - 14:00)");
        }
    }

    class Kamis
    {
        public static void sesisatu()
        {
            Console.WriteLine("1.Bahasa Jerman (07:00 - 07:35)");
            Console.WriteLine("1.Bahasa Jerman (07:35 - 08:10)");
            Console.WriteLine("2.Bahasa Jawa (08:10 - 08:45)");
            Console.WriteLine("2.Bahasa Jawa (08:45 - 09:20)");
        }
        public static void sesidua()
        {
            Console.WriteLine("3.PKWU (09:30 - 10:05)");
            Console.WriteLine("3.PKWU (10:05 - 10:35)");
            Console.WriteLine("3.PKWU (10:35 - 11:05)");
            Console.WriteLine("4.PAI (11:05 - 11:35)");
        }
        public static void sesitiga()
        {
            Console.WriteLine("4.PAI (12:35 - 13:00)");
            Console.WriteLine("4.PAI (13:00 - 13:30)");
        }
    }

    class Jumat
    {
        public static void sesisatu()
        {
            Console.WriteLine("0.Acara Sekolah (Kebersihan/Senam/Istingosah) (06:30 - 08:00)");
            Console.WriteLine("1.Bahasa Inggris (08:00 - 08:30)");
            Console.WriteLine("1.Bahasa Inggris (08:30 - 09:00)");
            Console.WriteLine("2.Sejarah (09:00 - 09:30)");
        }
        public static void sesidua()
        {
            Console.WriteLine("2.Sejarah (09:45 - 10:15)");
            Console.WriteLine("3.PPKN (10:15 - 10:45)");
            Console.WriteLine("3.PPKN (10:45 - 11:15)");
        }
    }
}