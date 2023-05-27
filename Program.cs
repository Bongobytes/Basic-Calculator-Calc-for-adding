using System;

class AdditionCalculator
{
    static void Main()
    {
        while (true)
        {
            int result = 0;
            bool exit = false;

            while (!exit)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Calc V0.0.1");
                    Console.WriteLine("Enter the number to add (or enter '=' to finish):");
                    string input = Console.ReadLine();

                    if (input == "=")
                    {
                        exit = true;
                    }
                    else
                    {
                        int number = int.Parse(input);
                        result += number;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred:");
                    Console.WriteLine("Exception details: " + ex.Message);
                }
            }
            Console.Clear();
            Console.WriteLine("Final Result: " + result);
            Console.WriteLine("Press 'Q' to quit or any other key to continue.");
            char quitKey = Console.ReadKey().KeyChar;
            if (quitKey == 'Q' || quitKey == 'q')
            {
                Environment.Exit(1);
            }
            else
            {
                Console.Clear();
            }
        }
    }
}
