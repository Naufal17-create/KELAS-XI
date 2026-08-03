// Materi perulangan For, While, dan Foreach

for (int i = 1; i < 5; i++)
{
    Console.WriteLine("Perulangan ke - " + i);
}

// While Loop

int angka = 1;

while (angka <= 5)
{
    Console.WriteLine("Angka: " + angka);

    angka++;
}

// Foreach Loop

string[] namaBuah = { "Apel", "Pisang", "Mangga" };

foreach (string buah in namaBuah)
{
    Console.WriteLine(buah);
}