using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don´t panic" nulliga - 0
            //programm asendab kõik 'a' tähed samas lauses 4-ga.

            string dontPanic = "Don´t panic!";

            dontPanic = dontPanic.Replace('o', '0');
            dontPanic = dontPanic.Replace('a', '4');

            Console.WriteLine(dontPanic);

        }
    }
}
