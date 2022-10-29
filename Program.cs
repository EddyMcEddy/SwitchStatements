using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Switch statements for number of the day of the week ");
            Console.WriteLine("_________________________");

            Console.WriteLine(GetDay(1));


        }
        static string GetDay(int dayNumber)
        {
            string dayName;


            switch (dayNumber)
            {
                case 0:
                    dayName = "Monday";
                    break;
                case 1:
                    dayName = "Tuesday";
                    break;
                case 2:
                    dayName = "Wednesday";
                    break;
                case 3:
                    dayName = "Thursday";
                    break;
                case 4:
                    dayName = "Friday";
                    break;
                case 5:
                    dayName = "Saturday";
                    break;
                case 6:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid day name";
                    break;
            }
            return dayName;
        }
    }
}
