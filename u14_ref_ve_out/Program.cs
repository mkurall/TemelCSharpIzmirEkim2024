
void Degistir(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

void SayiOku(out int sayi)
{
    sayi = int.Parse(Console.ReadLine());
}

int x = 3, y = 5;

Console.WriteLine($"x değeri = {x}, y değeri = {y}");

Degistir(ref x, ref y);

Console.WriteLine($"yeni --> x değeri = {x}, y değeri = {y}");


Console.WriteLine("Bir sayı girin:");

int s;

SayiOku(out s);


Degistir(b:ref y, a:ref x);