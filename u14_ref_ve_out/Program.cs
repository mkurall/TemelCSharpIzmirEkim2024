
void Degistir(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

int x = 3, y = 5;

Console.WriteLine($"x değeri = {x}, y değeri = {y}");

Degistir(ref x, ref y);

Console.WriteLine($"yeni --> x değeri = {x}, y değeri = {y}");
