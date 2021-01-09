using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, location, widthString, heightString;
            DateTime now, xmas;
            int year;
            TimeSpan difference;
            double width, height, woodLength, glassArea;

            name = "Garrett";
            location = "Idaho";
            now = DateTime.Now;
            year = Int32.Parse(now.ToString("yyyy"));
            xmas = new DateTime(year, 12, 25);
            difference = xmas - now;
            Console.WriteLine("My name is " + name + ", I am from " + location + "." 
                + Environment.NewLine +
            now.ToString("MM-dd-yyyy")
                + Environment.NewLine +
            "It will be " + difference.ToString("%d") + " days until Christmas");

            Console.WriteLine("Enter width in feet:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Enter height in feet:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " + woodLength + " feet.");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            Console.WriteLine("Press <Esc> to exit...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }

        }
    }
}
