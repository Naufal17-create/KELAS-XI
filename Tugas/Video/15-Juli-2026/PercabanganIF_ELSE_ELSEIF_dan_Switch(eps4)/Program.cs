// Materi Percabangan

int umur = 18;

// IF

if (umur >= 17)
{
    Console.WriteLine("Membuat KTP");
} else // else dijalankan jika kondisi false
       // else digunakan sebagai alternatif ketika kondisi if tidak terpenuhi
{
    Console.WriteLine("Belum Boleh Membuat KTP");
}

// Else IF

int nilai = 85;

if (nilai >= 90)
{
    Console.WriteLine("Grade A");
}
else if (nilai >= 75)
{
    Console.WriteLine("Grade B");
}
else
{
    Console.WriteLine("Grade C");
}

// Switch 
// Digunakan untuk memilih kondisi berdasarkan nilai tertentu
string hari = "Senin";

switch (hari)
{
    case "Senin";
        Console.WriteLine("Hari pertama");
        break;

    case "Minggu";
        Console.WriteLine("Hari ketujuh");
        break;

    default:
        Console.WriteLine("Hari lain");
        break;
}