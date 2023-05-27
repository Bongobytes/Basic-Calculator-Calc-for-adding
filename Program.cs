using System;

class AdditionCalculator
{
    static void Main()
    {
        Console.WriteLine("Calc V0.0.1");

        while (true)
        {
            try
            {
                Console.WriteLine("Enter the first number to add:");
                string input1 = Console.ReadLine();
                int number1 = int.Parse(input1);
                Console.Clear();
                Console.WriteLine("Current Problem:" + number1);
                Console.WriteLine("Enter the second number to add:");
                string input2 = Console.ReadLine();
                int number2 = int.Parse(input2);
                Console.Clear();
                int presult = number1 + number2;
                Console.WriteLine("Current Problem:" + number1 + "+" + number2 + "=" + presult);
                Console.WriteLine("Enter the third number to add:");
                string input3 = Console.ReadLine();
                int number3 = int.Parse(input3);
                Console.Clear();

                int result = number1 + number2 + number3;

                Console.WriteLine("Last Problems answer: " + number1 + " + " + number2 + " + " + number3 + " = " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred:");
                Console.WriteLine("Exception details: " + ex.Message);
            }
        }
    }
}
