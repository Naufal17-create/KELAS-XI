// Materi Array dan list Dasar

string[] namaBuah = { "Apel", "Mangga", "Jeruk" };

// Console.WriteLine(namaBuah[0]);
// Console.WriteLine(namaBuah[2]);

foreach (string buah in namaBuah)
{
    Console.WriteLine(buah);
}

List<string> namaSiswa = new List<string>();

namaSiswa.Add("Budi");
namaSiswa.Add("Anton");
namaSiswa.Add("Siti");

foreach (string siswa in namaSiswa)
{
    Console.WriteLine(siswa);
}