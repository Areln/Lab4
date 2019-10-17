using System;

namespace Lab4
{
    class Program
    {
        static int sides;
        static int diceValue1;
        static int diceValue2;
        static int counter = 0;
        static string welcomeMessage = "Welcome to the Grand Circus Casino!";
        static string runAgain = "y";
        static Random rand = new Random();
        static void Main(string[] args)
        {
            PrintInColor(welcomeMessage);

            Console.WriteLine("How many sides should each die have?");
            sides = int.Parse(Console.ReadLine()) + 1;

            while (runAgain != "n")
            {
                counter++;
                RollDice();
                Console.WriteLine("Roll again? (y/n)");
                runAgain = Console.ReadLine();
            }
        }
        static void RollDice() 
        {
            diceValue1 = rand.Next(1, sides);
            diceValue2 = rand.Next(1, sides);
            
            //Console.WriteLine($"Roll {counter}: {diceValue1} and {diceValue2}");
            
            //prints the output in color
            PrintInColor($"Roll {counter}: {diceValue1} and {diceValue2}");
        }
        static void PrintInColor(string message) 
        {
            foreach (char letter in message)
            {
                Console.ForegroundColor = GetRandomConsoleColor();
                Console.Write(letter);
            }
            Console.ResetColor();
            Console.Write("\n");
        }
        static ConsoleColor GetRandomConsoleColor() 
        {
            int x = 0;
            //ignore certain colors
            while (x == 0 || x == 1 || x == 3 || x == 8 || x == 2 || x == 5 || x == 4 || x == 15 || x == 7)
            {
                x = rand.Next(0, 16);
            }
            return Enum.Parse<ConsoleColor>(Enum.GetName(typeof(ConsoleColor), x));
        }
    }
}
