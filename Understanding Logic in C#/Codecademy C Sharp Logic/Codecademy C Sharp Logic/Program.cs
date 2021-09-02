using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codecademy_C_Sharp_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean Data Types
            Console.WriteLine("Boolean Data Types:");
            bool answerOne = true;
            bool answerTwo = false;
            Console.WriteLine($"True or False: The number 500 is greater than 24. {answerOne}");
            Console.WriteLine($"True or False: “Coffee” contains the letter “a”. {answerTwo}\n");

            // Comparison Operators
            Console.WriteLine("Comparison Operators:");
            double timeToDinner = 4;
            double distance = 95;
            double rate = 30;
            double tripDuration = distance / rate;
            bool answer = tripDuration <= timeToDinner;
            Console.WriteLine($"You are driving to your family’s house for a holiday and want to see if you’ll get there before dinner. Dinner will begin at 6:00 PM and the house is 95 miles away. If you leave at 2:00PM and drive an average of 30 miles per hour, will you get there early (before 6:00pm)? {answer}\n");

            // Logical Operators
            Console.WriteLine("Logical Operators:");
            bool beach = true;
            bool hiking = false;
            bool city = true;
            bool yourNeeds = beach && city;
            bool friendNeeds = beach && hiking;
            bool tripDecision = yourNeeds && friendNeeds;
            Console.WriteLine($"Will you agree on Barcelona? {tripDecision}");

            Console.ReadKey();
        }
    }
}
