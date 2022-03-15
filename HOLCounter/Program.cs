using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!";

            Console.WriteLine("Sisesta sõnapaar: Hello World!");
            string holCounter = Console.ReadLine().ToLower();

            int hCounter = 0;

            for(int i = 0; i < holCounter.Length; i++)
            {
                if(holCounter[i] == 'h')
                { 
                    hCounter++; 
                }
                    
            }

            int oCounter = 0;

            for (int i = 0; i < holCounter.Length; i++)
            {
                if (holCounter[i] == 'o')
                {
                    oCounter++;
                }
                    
            }

            int lCounter = 0;

            for (int i = 0 ; i < holCounter.Length; i++)
            {
                if (holCounter[i] == 'l')
                {
                    lCounter++;
                }
                    
            }

            Console.WriteLine($"Sinu lauses on {hCounter} 'h' tähte, {oCounter} 'o' tähte ja {lCounter} 'l' tähte.");
        }
    }
}
