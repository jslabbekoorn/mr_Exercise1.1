using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr_Exercise1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij versie v0.1 van deze Applicatie");
            Console.WriteLine("We gaan 2 getallen bij elkaar op te tellen.");

            Console.WriteLine("Voer het eerste getal in:");
            string userInput1 = Console.ReadLine();

            int userNumber1;
            userNumber1 = Convert.ToInt32(userInput1);

            Console.WriteLine("Voer het tweede getal in:");
            string userInput2 = Console.ReadLine();

            int userNumber2;
            userNumber2 = Convert.ToInt32(userInput2);

            int uitKomst = userNumber1 + userNumber2;

            Console.WriteLine("De uitkomt van de berekening is " + uitKomst);
            Console.ReadLine();
        }
    }
}
