Console.Write("Boyunuz(cm)?");
double boy = double.Parse(Console.ReadLine());

Console.Write("Kilonuz(kg)?");
double kilo = Convert.ToDouble(Console.ReadLine());

//vki = kilo kg / (boy m) karesi

double boy2 = boy/100;//metre cinsine çevirdik
double vki = kilo / (boy2 * boy2);

Console.WriteLine($"Vki Değeri = {vki:f2}"); //string interpolation

if(vki<18.5)
    Console.WriteLine("ZAYIF");
else if(vki>=18.5 && vki<25)
    Console.WriteLine("NORMAL");
else if(vki>=25 && vki<30)
    Console.WriteLine("KİLOLU");
else if(vki>=30)
    Console.WriteLine("AŞIRI KİLOLU");
