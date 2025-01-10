namespace Nr2

{
    internal class Program

    {
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static void Main(string[] args)
        { 
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();



            if (int.TryParse(input, out int number))
            {

                if (IsEven(number))
                {
                    Console.WriteLine("The number is even");
                }


                else
                {
                    Console.WriteLine("The number is uneven");
                }


            }









        }
    }
}
