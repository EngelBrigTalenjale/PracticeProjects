using System;


namespace improvecalculator
{
    class Calculator
    {
        public static int PerformOperation(int val1, int val2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return val1 + val2;
                case '-':
                    return val1 - val2;
                case '*':
                    return val1 * val2;
                case '/':
                    if (val2 != 0)
                        return val1 / val2;
                    else
                        throw new DivideByZeroException("Cannot divide by zero.");
                default:
                    throw new ArgumentException("Invalid operation.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator\n");
            char operation;

            do
            {
                Console.WriteLine("\n\nSelect Operation");
                Console.WriteLine("(+) Addition");
                Console.WriteLine("(-) Subtraction");
                Console.WriteLine("(*) Multiplication");
                Console.WriteLine("(/) Division");
                Console.WriteLine("(x) Exit\n");

                Console.Write("User: ");
                operation = Console.ReadKey().KeyChar;

                if (operation == 'x')
                    break;

                Console.Write("\nEnter two numbers separated by spaces: ");
                string input = Console.ReadLine();
                string[] nums = input.Split(' ');

                if (nums.Length == 2 && int.TryParse(nums[0], out int val1) && int.TryParse(nums[1], out int val2))
                {
                    try
                    {
                        int result = Calculator.PerformOperation(val1, val2, operation);
                        Console.WriteLine($"Result: {result}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter two valid numbers separated by spaces.");
                }

                Console.WriteLine("\nDo you want to perform another operation? (y/n): \n");
            }
            while (Console.ReadKey().KeyChar == 'y');
        }
    }
}
