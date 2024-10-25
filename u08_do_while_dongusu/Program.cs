ConsoleKeyInfo tus = new ConsoleKeyInfo();
int s = 0;
do
{
    Console.WriteLine("BTK" + s);
    //Console.ReadLine();//sonunda Enter basılması gerekir
    
    if(Console.KeyAvailable)
        tus = Console.ReadKey(false);//döngüyü bloklar

    s++;

} while(/*ESC* basılıncaya kadar*/ tus.Key != ConsoleKey.Escape); 

Console.WriteLine("Döngü Sona Erdi");
