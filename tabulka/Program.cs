using System;

namespace tabulka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vožte počet řádků: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Vložte počet buňek: ");
            int b = int.Parse(Console.ReadLine());
            int c = 0;
            for (int i = 0; i < r; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    c++;
                    for (int e = 0; e < b; e++)
                    {
                        Console.Write("+");
                    }
                    if (c != 3)
                    {

                       for (int g = 0; g < b; g++)
                        {
                            Console.Write("-");
                        }
                    }
                     
                    
                }
                c = 0;
                Console.WriteLine("");

            }















        }
    }
}
