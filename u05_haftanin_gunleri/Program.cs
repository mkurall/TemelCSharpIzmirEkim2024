Console.WriteLine("Haftanın kaçıncı günü?");
int gun = Convert.ToInt32(Console.ReadLine());


switch (gun)
{
    case 0: Console.WriteLine("PAZAR"); break;
    case 1: Console.WriteLine("PAZARTESİ"); break;
    case 2: Console.WriteLine("SALI"); break;
    case 3: Console.WriteLine("ÇARŞAMBA"); break;
    case 4: Console.WriteLine("PERŞEMBE"); break;
    case 5: Console.WriteLine("CUMA"); break;
    case 6: Console.WriteLine("CUMARTESİ"); break;
    default: Console.WriteLine("HATALI GÜN!"); break;
}

switch (gun)
{
    case 0:
    case 1:
    case 2:
    case 3: Console.WriteLine("HAFTANIN 1. YARISI");break;
    case 4:
    case 5:
    case 6:Console.WriteLine("HAFTANIN 2. YARISI");break;
    default: Console.WriteLine("HATALI GÜN!"); break;
}