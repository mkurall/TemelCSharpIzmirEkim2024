Console.Write("1.Vize Notunu Girin:");
double v1 = Convert.ToDouble(Console.ReadLine());//klavyeden girilen veriler metinsel veridir

Console.Write("2.Vize Notunu Girin:");
double v2 = Convert.ToDouble(Console.ReadLine());//klavyeden girilen veriler metinsel veridir

Console.Write("Final Notunu Girin:");
double final = Convert.ToDouble(Console.ReadLine());//klavyeden girilen veriler metinsel veridir

double sonuc = v1 * 0.30 + v2 * 0.30 + final * 0.40; 

Console.WriteLine("Ortalama = " + sonuc);
Console.Write("Geçti Mi:" + (sonuc >= 70));