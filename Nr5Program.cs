namespace Nr5
{
    internal class Program
    {
        static int FindMax(int num1, int num2, int num3)
        {
            if (num1 >= num2 && num1 >= num3)
                return num1;
            else if (num2 >= num1 && num2 >= num3)
                return num2;
            else
                return num3;
        }



        static void Main(string[] args)
            {
                Console.WriteLine("Enter the first number:");
                if (!int.TryParse(Console.ReadLine(), out int num1))
                {
                    Console.WriteLine("Invalid, Please enter another number.");
                    return;
                }

                Console.WriteLine("Enter the second number:");
                if (!int.TryParse(Console.ReadLine(), out int num2))
                {
                    Console.WriteLine("Invalid input. Please enter another number.");
                    return;
                }

                Console.WriteLine("Enter the third number:");
                if (!int.TryParse(Console.ReadLine(), out int num3))
                {
                    Console.WriteLine("Invalid input. Please enter another number.");
                    return;
                }

                int max = FindMax(num1, num2, num3);

                // Display the largest number
                Console.WriteLine($"The largest number among {num1}, {num2}, and {num3} is: {max}");
            }
        
    }
}

