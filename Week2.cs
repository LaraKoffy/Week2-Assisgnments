namespace Nr3

{
    internal class Program
    {
        static void CheckNumber(int number)
        {


            if (number == 0)
            {
                Console.WriteLine("the number is 0");
            }
            else if (number > 0)
            {
                Console.WriteLine("the number is positive");
            }
            else
            {
                Console.WriteLine("the number is negative");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a number");
           string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                CheckNumber(number);
            }

        }





    }
}









