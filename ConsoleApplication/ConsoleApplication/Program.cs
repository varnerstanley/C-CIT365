using System;

namespace ConsoleApplication
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string name = "Stanley";
            string location = "Utah";
            string todayDate = DateTime.Now.ToString("MM/dd/yyyy");

            //print out name, location and date
            Console.WriteLine($"My name is {name} I am from {location}.");
            Console.WriteLine($"Date: {todayDate}.");

            //Calculate days until xmas
            DateTime thisDay = DateTime.Today;
            DateTime dec25 = new DateTime(2019, 12, 25);

            //check if it's more than a year
            if (dec25 < thisDay)
            {
                thisDay = dec25.AddYears(1);
            }
            int numDays = (dec25 - thisDay).Days;
            //Print out answer
            Console.WriteLine($"There are {numDays} days remaining until Christmas.");

            //Code from the book 2.1
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Enter in width.");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Enter in Height.");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine($"The length of the wood is {woodLength} feet");
            Console.WriteLine($"The area of the glass is {glassArea} square metres");

            //program pauses for a mac computer, I didn't have to add anything
            Console.ReadKey();
        }
    }
}
