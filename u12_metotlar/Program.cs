namespace Uygulama
{
    class u12
    {
            static int Topla(int a, int b)
            {
                return a+b;  
            }

            static int Topla(int a, int b, int c)
            {
                return a + b + c;
            }

        static void Main(string[] args)
        {

            int toplam1 = Topla(3, 5);
            int toplam2 = Topla(4,7,9);

            Console.WriteLine(toplam1);
            Console.WriteLine();
            Console.WriteLine(toplam2);
        }
    }
}