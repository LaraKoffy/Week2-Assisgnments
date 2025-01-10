namespace Nr8
{
    internal class Program
    {
        static string GetDayOfWeek(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1: return "Monday";
                
                case 2: return "Tuesday";
                
                case 3: return "Wednesday";
                
                case 4: return "Thursday";
                
                case 5: return "Friday";
                
                case 6: return "Saturday";
                
                case 7: return "Sunday";
                default: return "Invalid"; 

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 7 to get the corresponding day of the week:");

            
            if (int.TryParse(Console.ReadLine(), out int dayNumber))
            {
                if (dayNumber >= 1 && dayNumber <= 7)
                {
                    string dayOfWeek = GetDayOfWeek(dayNumber);
                    Console.WriteLine($"The day corresponding to number {dayNumber} is: {dayOfWeek}");
                }
                else
                {
                    Console.WriteLine("Error: The number must be between 1 and 7.");
                }
            }
        }
    }
}
