﻿//Pedro Garcia
//COMP003A
//Johnathan Cruz
//Lecture Activity 3-1
namespace COMP003A.LectureActivity3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Selection Statements Demo");

            // Prompt to put in hour
            Console.Write("Enter the current hour (0-23): ");
            int hour = int.Parse(Console.ReadLine());

            // Determines time of day
            /*
            * Condition 1: From 5 to 11
            * Condition 2: From 12 to 17 
            * Condition 3: From 18 to 20
            * Condition 4: From 21 to 4 
            */
            if (hour >= 5 && hour <= 11)
            {
            Console.WriteLine("Good Morning");
            }
            else if (hour >= 12 && hour <= 17)
            {
            Console.WriteLine("Good Afternoon");
            }
            else if (hour >= 18 && hour <= 20)
            {
            Console.WriteLine("Good Evening");
            }
            else
            {
            Console.WriteLine("Good Night");
            }

            // Day of the week
            Console.Write("Enter day of the week: ");
            string day = Console.ReadLine();


            /*
             * Determine the message for the day
             * Condition 1: Monday
             * Condition 2: Friday
             * Condition 3: Sunday
             * Default: Just another day
             */
            switch (day.ToLower())
            {
                case "monday":
                    Console.WriteLine("Start of the work week");
                    break;
                case "friday":
                    Console.WriteLine("Almost the weekend");
                    break;
                case "sunday":
                    Console.WriteLine("Relax, it's Sunday");
                    break;
                default:
                    Console.WriteLine("Just another day");
                    break;
            }
        }
    }
}
