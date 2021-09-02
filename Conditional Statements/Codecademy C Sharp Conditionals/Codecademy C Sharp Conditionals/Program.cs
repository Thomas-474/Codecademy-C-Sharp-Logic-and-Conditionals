using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codecademy_C_Sharp_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            #region If Statements
                Console.WriteLine("If Statements:");

                Console.WriteLine("Enter number of pairs of socks: ");
                string socksString = Console.ReadLine();
                int socksInt = Convert.ToInt32(socksString);

                // string centsAsString = Console.ReadLine();
                // double centsAsDouble = Convert.ToDouble(centsAsString);

                if (socksInt <= 3)
                {
                    Console.WriteLine("Time to do laundry!");
                }

                if (socksInt > 3)
                {
                    Console.WriteLine("Don't do laundry yet.");
                }

                Console.ReadLine();
            #endregion

            #region If...Else... Statements
                Console.WriteLine("\nIf...Else... Statements:");

                // int people = 10;
                // string weather = "nice";

                int people = 12;
                string weather = "bad";

                if (people <= 10 && weather == "nice")
                {
                    Console.WriteLine("SaladMart");
                }

                else
                {
                    Console.WriteLine("Soup N Sandwich");
                }
            #endregion

            #region Else If Statements
                Console.WriteLine("\nElse If Statements:");

                int guests = 7;

                if (guests >= 4)
                {
                    Console.WriteLine("Catan");
                }

                else if (guests >= 1)
                {
                    Console.WriteLine("Innovation");
                }

                else
                {
                    Console.WriteLine("Solitaire");
                }
            #endregion

            #region Switch Statements
                Console.WriteLine("\nSwitch Statements:");

                Console.WriteLine("Pick a genre: ");
                string genre = Console.ReadLine();

                switch (genre)
                {
                    case "Drama":
                        Console.WriteLine("Citizen Kane");
                        break;
                    case "Comedy":
                        Console.WriteLine("Duck Soup");
                        break;
                    case "Adventure":
                        Console.WriteLine("King Kong");
                        break;
                    case "Horror":
                        Console.WriteLine("Psycho");
                        break;
                    case "Science Fiction":
                        Console.WriteLine("2001: A Space Odyssey");
                        break;
                    default:
                        Console.WriteLine("No movie found");
                        break;
                }
            #endregion

            #region Ternary Operators
                Console.WriteLine("\nTernary Operators:");

                int pepperLength = 4;
                string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";

                Console.WriteLine(message);

                // string color = "blue";
                // string result = (color == "blue") ? "blue" : "NOT blue";

                // Console.WriteLine(result);
            #endregion

            Console.ReadKey();
        }
    }
}
