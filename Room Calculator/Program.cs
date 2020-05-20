using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Room Calculator Application!");
            bool gettingRoomStats = true;
            while (gettingRoomStats)
            {
                Console.WriteLine("");
                Console.WriteLine("Which option would you like to choose from the items below?");
                Console.WriteLine("");
                DisplayCalculatorOptionMenu();
                string decision = Console.ReadLine().ToLower().Trim();
                if (decision == "v")
                {
                    Console.WriteLine("");
                    double volume = GetRoomLength() * GetRoomWidth() * GetRoomHeight();
                    Console.WriteLine($"The VOLUME of your room is: {volume}");

                }
                else if (decision == "p")
                {
                    Console.WriteLine("");
                    double perimeter = (GetRoomLength() * 2) + (GetRoomWidth() * 2);
                    Console.WriteLine($"The PERIMETER of your room is {perimeter}");
                }
                else if (decision == "e")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Thank you for using our application! Have a great day!");
                    gettingRoomStats = false;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("I'm sorry, I didn't recognize that deicision. Please try again.");
                }
            }
            Environment.Exit(0);
        }
        static void DisplayCalculatorOptionMenu()
        {
            List<string> calculateOptions = new List<string>();
            calculateOptions.Add("For Room VOLUME: Press V + ENTER");
            calculateOptions.Add("For Room PERIMETER: Press P + ENTER");
            calculateOptions.Add("For Program EXIT: Press E + ENTER");

            foreach (string option in calculateOptions)
            {
                Console.WriteLine(option);
            }
        }
        static double GetRoomLength()
        {
            bool gettingLength = true;
            while (gettingLength)
            {
                Console.WriteLine("");
                Console.Write("Enter The Room's LENGTH: ");
                string userLength = Console.ReadLine();
                double length;
                bool isLength = double.TryParse(userLength, out length);
                if (!isLength)
                {
                    Console.WriteLine("I'm sorry, I did not recognize that as a number. Let's try again.");
                    gettingLength = true;
                }
                else if (0 >= length)
                {
                    Console.WriteLine("Impossible! Your room LENGTH may not be of a negative number or zero. Let's try again.");
                    gettingLength = true;
                }
                else if (isLength)
                {
                    return length;
                }
                else
                {
                    Console.WriteLine("Some other error occurred. Let's try again.");
                    gettingLength = true;
                }
            }
            return -1;
        }
        static double GetRoomWidth()
        {
            bool gettingWidth = true;
            while (gettingWidth)
            {
                Console.WriteLine("");
                Console.Write("Enter The Room's WIDTH: ");
                string userWidth = Console.ReadLine();
                double width;
                bool isWidth = double.TryParse(userWidth, out width);
                if (!isWidth)
                {
                    Console.WriteLine("I'm sorry, I did not recognize that as a number. Let's try again.");
                    gettingWidth = true;
                }
                else if (0 >= width)
                {
                    Console.WriteLine("Impossible! Your room WIDTH may not be of a negative number or zero. Let's try again.");
                    gettingWidth = true;
                }
                else if (isWidth)
                {
                    return width;
                }
                else
                {
                    Console.WriteLine("Some other error occurred. Let's try again.");
                    gettingWidth = true;
                }
            }
            return -1;

        }
        static double GetRoomHeight()
        {
            bool gettingHeight = true;
            while (gettingHeight)
            {
                Console.WriteLine("");
                Console.Write("Enter The Room's HEIGHT: ");
                string userHeight = Console.ReadLine();
                double height;
                bool isHeight = double.TryParse(userHeight, out height);
                if (!isHeight)
                {
                    Console.WriteLine("I'm sorry, I did not recognize that as a number. Let's try again.");
                    gettingHeight = true;
                }
                else if (0 >= height)
                {
                    Console.WriteLine("Impossible! Your room HEIGHT may not be of a negative number or zero. Let's try again.");
                    gettingHeight = true;
                }
                else if (isHeight)
                {
                    return height;
                }
                else
                {
                    Console.WriteLine("Some other error occurred. Let's try again.");
                    gettingHeight = true;
                }
            }
            return -1;
        }
    }
}