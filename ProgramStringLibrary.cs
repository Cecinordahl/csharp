/*
Programmet ber brukeren om å legge inn en streng. Det indikerer om strengen starter med et stort tegn.
Hvis brukeren trykker på enter-tasten uten å legge inn en streng, avsluttes applikasjonen, og konsollvinduet lukkes.
Koden bruker radvariabelen for å opprettholde en telling av antall datarader som er skrevet til konsollvinduet.
Når den er større enn eller lik 25, tømmer koden konsollvinduet og viser en melding til brukeren.
 */

using System;
using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        int row = 0;

        do
        {
            if (row == 0 || row >= 25)
                ResetConsole();

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            Console.WriteLine($"Input: {input} {"Begins with uppercase? ",30}: " +
                              $"{(input.StartsWithUpper() ? "Yes" : "No")}{Environment.NewLine}");
            row += 3;
        } while (true);
        return;

        // Declare a ResetConsole local method
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine($"{Environment.NewLine}Press <Enter> only to exit; otherwise, enter a string and press <Enter>:{Environment.NewLine}");
            row = 3;
        }
    }
}