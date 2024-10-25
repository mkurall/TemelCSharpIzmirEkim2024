Console.WriteLine("Bir Metin Girin:");
string metin = Console.ReadLine();
Console.WriteLine("\n\n");

int index=0;
foreach(char c in metin) // "BTK AKADEMİ"
{
    char c2 = c;

    if(index == 0)
     c2 = char.ToUpper(c);
    else if(metin[index-1] == ' ')
     c2 = char.ToUpper(c);

    Console.Write(c2 + " ");
    index++;
}