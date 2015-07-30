using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mmmkay
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string input;
            
            while(true)
            {
                Console.Clear();
                SplashScreen();
                Menu();
                Console.Write("Enter Text: ");
                input = Console.ReadLine();
                Console.Clear();
                SplashScreen();
                if (input.Equals("-h"))
                {
                    input = "Drugs are bad, so, if you do drugs, you're bad, because drugs are bad. They can hurt your body, cause drugs are bad.";
                    Console.WriteLine("Example input: " + input + "\n\n");
                    System.Threading.Thread.Sleep(3000);
                }
                if (input.Equals("-q"))
                    break;
                Mkay mkay = new Mkay(input);
                mkay.computeString();
                Console.ReadLine();
            }
            Console.Clear();
            SplashScreen();
            Console.WriteLine("Have a good day you awesome individual!");
            Console.WriteLine("© 2015 Alex L'Esperance");
            System.Threading.Thread.Sleep(5000);
        }

        static void Menu()
        {
            Console.WriteLine("Welcome to the Mr. Mackey-a-fied Text Translator.  Enter your text below and let Mr. Mackey show you how it's done mmm'kay?\n");
            Console.WriteLine("Type -h for an example");
            Console.WriteLine("Type -q to quit\n");
        }

        static void SplashScreen()
        {
            Console.WriteLine("   _     _     _     _     _     '     _     _     _     _     _     _   ");
            Console.WriteLine("  (c).-.(c)   (c).-.(c)   (c).-.(c)   (c).-.(c)   (c).-.(c)   (c).-.(c)  ");
            Console.WriteLine("   / ._. \\     / ._. \\     / ._. \\     / ._. \\     / ._. \\     / ._. \\   ");
            Console.WriteLine(" __\\( Y )/__ __\\( Y )/__ __\\( Y )/__ __\\( Y )/__ __\\( Y )/__ __\\( Y )/__ ");
            Console.WriteLine("(_.-/'-'\\-._(_.-/'-'\\-._(_.-/'-'\\-._(_.-/'-'\\-._(_.-/'-'\\-._(_.-/'-'\\-._)");
            Console.WriteLine("   || M ||     || M ||     || M ||     || K ||     || A ||     || Y ||   ");
            Console.WriteLine(" _.' `-' '._ _.' `-' '._ _.' `-' '._ _.' `-' '._ _.' `-' '._ _.' `-' '._ ");
            Console.WriteLine("(.-./`-'\\.-.(.-./`-'\\.-.(.-./`-'\\.-.(.-./`-'\\.-.(.-./`-'\\.-.(.-./`-'\\.-.)");
            Console.WriteLine(" `-'     `-' `-'     `-' `-'     `-' `-'     `-' `-'     `-' `-'     `-' ");
            Console.WriteLine("");
        }
    }
}
