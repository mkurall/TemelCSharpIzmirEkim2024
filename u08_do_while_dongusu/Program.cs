ConsoleKeyInfo tus = new ConsoleKeyInfo();

do
{
    Console.WriteLine("BTK");
    //Console.ReadLine();//sonunda Enter basılması gerekir
    
    if(Console.KeyAvailable)
        tus = Console.ReadKey();

} while(/*ESC* basılıncaya kadar*/ tus.Key != ConsoleKey.Escape); 

Console.WriteLine("Döngü Sona Erdi");
