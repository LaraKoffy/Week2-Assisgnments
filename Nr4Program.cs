namespace Nr4
{
    internal class Program
    {

        static double PerformOperation(double num1, double num2, char operation)
        {
            switch (operation)

            {
                case '+':
                    return num1 + num2;


                case '-':
                    return num1 - num2;

                case '*':
                    return num1 * num2;

                case '/':
                    return num1 / num2;
            }
        }

        static void Main(string[] args)
        { 
            Console.WriteLine("Enter the first number");
            double.TryParse(Console.ReadLine(), out double num1);

            Console.WriteLine("Enter the second numner");
            double.TryParse(Console.ReadLine(), out double num2);

            Console.WriteLine("Enter an operation");

            char operation = Console.ReadKey().KeyChar;

         double result = PerformOperation(num1, num2, operation);

        Console.WriteLine($"result: {num1} {operation} {num2} = {result}");

                
                
                
                
                
                
                
                
                
                
                }        
    }
}
