// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//tipedata namavariabel
int angka;
string instring;
//angka decimal
double tes = 1.566;
//char
char k = 's';
//boolean
bool bolean;

//Operator aritmatika
int angka1 = 5;
int angka2 = 6;

Console.WriteLine(angka1 + angka2);
Console.WriteLine(angka2 / angka1);
Console.WriteLine(angka1 * angka2);
Console.WriteLine(angka1 - angka2);
Console.WriteLine(angka2 % angka1);


bool boolean1 = true;
bool boolean2 = false;
Console.WriteLine(boolean2 && boolean1);
Console.WriteLine(boolean2 || boolean1);

//Operator kondisi
if (boolean2)
{
    Console.WriteLine("Kondisi benar");
}
else if (boolean1)
{
    Console.WriteLine("Kondisi 2 benar");
}
else
{
    Console.WriteLine("Kondisi salah");
}

//Tipe data List
List<string> Asprak = new List<string>();

Asprak.Add("Raka");
Asprak.Add("Sapta");
Asprak.Remove("Raka");

Console.WriteLine(Asprak[0]);


//Looping
angka = 0;

while (angka < 5)
{
    angka++;
    Console.WriteLine(angka);
}

//Looping for
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

//looping foreach
List<string> mahasiswa = new List<string>();
mahasiswa.Add("Adya");
mahasiswa.Add("Djo");
foreach (string siswa in mahasiswa)
{
    Console.WriteLine(siswa);
}

//fungsi
void Fungsi(string param1)
{
    Console.WriteLine(param1);
}

string Fungsistr()
{
    Console.WriteLine("Fungsi str");
    return "STr";
}

int Fungsiint()
{
    Console.WriteLine("Fungsi int");
    return 0;
}

Fungsi("Fungsi void");
string hasil = Fungsistr();
Console.WriteLine(hasil);
Fungsiint();
