using System;

namespace GCLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Wlcome to Grand Circus' room detail Generator");
                Console.Write("Please write the length of your Room: ");
                decimal length = decimal.Parse(Console.ReadLine());
                Console.Write("Please write the width of your Room: ");
                decimal width = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the height of the room in feet.");
                decimal height = decimal.Parse(Console.ReadLine());

                decimal area = length * width;
                decimal perimeter = 2 * (width + length);
                decimal volume = (length) * (width) * (height);


                Console.WriteLine("The area of your Room is: {0}", area);
                Console.WriteLine("the perimeter of your room is: {0}", perimeter);
                Console.WriteLine("Volume: {0} feet cubed", volume);
                Console.WriteLine();

                while (true)
                {
                    Console.WriteLine("Would you like to continue? (y/n)");
                    string userInput = Console.ReadLine().ToLower();

                    if (userInput == "y")
                    {
                        break;
                    }
                    if (userInput == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        run = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please try again.");




                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
        
    

