using System;

namespace HelloWorldReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World!" tagurpidi

            string twoWords = "Hello, World!";

            for (int i = twoWords.Length -1; i >= 0; i--)
            {
                Console.Write(twoWords[i]);
            }
        }
    }
}
