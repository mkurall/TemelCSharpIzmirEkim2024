string girilenPinKodu="";
int deneme=1;
do
{
    Console.WriteLine($"PİN Kodunu Girin({deneme}.deneme):");
    girilenPinKodu = Console.ReadLine();
    deneme++;
} while (girilenPinKodu != "1234");

