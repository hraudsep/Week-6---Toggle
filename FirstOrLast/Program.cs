using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanimed;
            //programm kontrollib andmete pikkust eraldi 
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi

            Console.WriteLine("Palun sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Palun sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

           

            {
                int firstNameLength = firstName.Length;
                int lastNameLength = lastName.Length;

                if (firstName.Length > lastName.Length)
                {
                    Console.WriteLine($"Sinu eesnimi on {firstNameLength} sümbolit ja seega pikem kui su perekonnanimi.");
                }

                else if (lastName.Length > firstName.Length)
                {
                    Console.WriteLine($"Sinu perekonnanimi on {lastNameLength} sümbolit ja seega pikem kui su eesnimi.");
                }
                else
                {
                    Console.WriteLine("Sinu ees- ja perekonnanimi on sama pikad!");
                }
            }
        }
    }
}
