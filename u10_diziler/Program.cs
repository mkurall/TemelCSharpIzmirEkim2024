int[] sayilar = { 5, 8, 3, 9, 12 };

Console.WriteLine("dizinin elemanları:");

foreach(int s in sayilar)
{
    Console.Write($"{s},");
}

int[] sayilar2 = new int[5];//new bellekten yer ayırmak için kullanılır

sayilar2[0] = 3;
Console.WriteLine("\n\n2.Dizinin 1.indeksteki elemanı kaç olsun?");
sayilar2[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n2.dizinin \\elemanları:");// (\) escape karakteri

foreach(int s in sayilar2)
{
    Console.Write($"{s},");
}