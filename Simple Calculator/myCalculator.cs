using System;

namespace calculator
{
    class Calculator
    {
        public void Add()
        {
            string str = Console.ReadLine();

            string[] nums = str.Split(' ');

            if (nums.Length == 2)
            {
                if (int.TryParse(nums[0], out int val1) && int.TryParse(nums[1], out int val2))
                {
                    int result = val1 + val2;
                    Console.WriteLine($"Result: {result}");
                }
            }
        }
        public void Sub()
        {
            string str = Console.ReadLine();

            string[] nums = str.Split(' ');

            if (nums.Length == 2)
            {
                if (int.TryParse(nums[0], out int val1) && int.TryParse(nums[1], out int val2))
                {
                    int result = val1 - val2;
                    Console.WriteLine($"Result: {result}");
                }
            }
        }
        public void Mul()
        {
            string str = Console.ReadLine();

            string[] nums = str.Split(' ');

            if (nums.Length == 2)
            {
                if (int.TryParse(nums[0], out int val1) && int.TryParse(nums[1], out int val2))
                {
                    int result = val1 * val2;
                    Console.WriteLine($"Result: {result}");
                }
            }
        }
        public void Div()
        {
            string str = Console.ReadLine();

            string[] nums = str.Split(' ');

            if (nums.Length == 2)
            {
                if (int.TryParse(nums[0], out int val1) && int.TryParse(nums[1], out int val2))
                {
                    int result = val1 / val2;
                    Console.WriteLine($"Result: {result}");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator \n");
            Console.WriteLine("Select Operation\n(1) Addition\n(2) Subtraction\n(3) Multiplication\n(4) Division\n(5) Exit\n");
            Console.Write("User: "); int Int = Convert.ToInt32(Console.ReadLine());

            Calculator calculator = new Calculator();

            switch (Int)
            {
                case 1:
                    Console.Write("Enter two numbers separated by spaces: ");
                    calculator.Add();
                    break;
                case 2:
                    Console.Write("Enter two numbers separated by spaces: ");
                    calculator.Sub();
                    break;
                case 3:
                    Console.Write("Enter two numbers separated by spaces: ");
                    calculator.Sub();
                    break;
                case 4:
                    Console.Write("Enter two numbers separated by spaces: ");
                    calculator.Sub();
                    break;
                case 5: return;
                default: Console.WriteLine("Invalid Input"); break;
            }
        }
    }
}
