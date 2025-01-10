namespace Nr6
{
    internal class Program
    {
        static string GetGrade(int score)
        {
            if (score >= 90 && score <= 100)
                return "A";
            else if (score >= 80 && score <= 89)
                return "B";
            else if (score >= 70 && score <= 79)
                return "C";
            else if (score >= 60 && score <= 69)
                return "D";
            else if (score >= 0 && score <= 59)
                return "F";
            else
                return "Invalid score";
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter your score (0-100):");
            if (int.TryParse(Console.ReadLine(), out int score))
            {
                string grade = GetGrade(score);


                if (grade == "Invalid score")
                {
                    Console.WriteLine("Error: Please enter a score between 0 and 100.");
                }
                else
                {
                    Console.WriteLine($"Your grade is: {grade}");
                }
            }
        }
    }
}

