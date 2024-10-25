double OrtalamaHesapla(params int[] sayilar)
{
    /*
    int toplam = 0;
    foreach(int s in sayilar)
    {
        toplam+=s;
    }

    return toplam / (double)sayilar.Length; //int/int sonuç yine int  (6+5)/2 = 5
    */
 

    return sayilar.Average();

}


double sonuc = OrtalamaHesapla(3,4,8,9,10,11,12,13);

Console.WriteLine($"Ortalama Sonucu = {sonuc}");
