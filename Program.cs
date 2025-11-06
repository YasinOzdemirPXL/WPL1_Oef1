using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPL1_Oef1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string user = "Admin", password = "P@sswoord123";
            int tries = 0;

            while (tries < 3)
            { 
                Console.Write("Geef je naam: ");
                string inputUser = Console.ReadLine();
                Console.Write("Wachtwoord: ");
                string inputPassword = Console.ReadLine();

                if (inputUser == user && inputPassword == password)
                {
                    return;
                }
            }
            Console.WriteLine("Te veel pogingen. Toegang geweigerd.");
        }
    }
}
