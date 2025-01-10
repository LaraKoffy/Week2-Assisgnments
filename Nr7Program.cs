namespace Nr7
{
    internal class Program
    {
        static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                
                return true;
            
            return false;
        }
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a year to check if it is a leap year:");

            if (int.TryParse(Console.ReadLine(), out int year))
            {
                bool isLeap = IsLeapYear(year);

                
                if (isLeap)
                
                {
                    
                    Console.WriteLine($"{year} is a leap year.");
                }
                else
                {
                    
                    Console.WriteLine($"{year} is not a leap year.");
                }
            }
        }
    }
}
