using System;

namespace csharpProj
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Koden viser en prompt i consoll vindu og venter til brukeren skriver inn navn (string) og trykker enter.
            Den lagrer string'en i en variabel "navn" og henter verdien av tiden vha DateTime.Now som har den lokale tiden.
            Den blir tildent variabelnavn "date". Verdiene blir vist i et nytt konsoll vindu. Til slutt vises det en melding
            i konsoll vindu og kaller på Console.ReadKey(Boolean) metoden for å vente på bruker input.
            
            NewLine er en platform-independent og language-independent måte for å representere en line break. Alt: \n for C# og
            vbCrLf i Visual Basic
            
            $ foran en string gir muligheten for å bruke expressions som variabel navn i curly braces i stringen.
            --> "Interpolated strings" */

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {date:d} at {date:t}!");
            Console.Write($"{Environment.NewLine} Press any key to exit...");
            Console.ReadKey(true);

        }
    }
}
