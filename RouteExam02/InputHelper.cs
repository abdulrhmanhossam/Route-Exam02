using System.Runtime.CompilerServices;

namespace RouteExam02
{
    public static class InputHelper
    {
        // this method will read an integer from the console
        public static int ReadInt(string prompt)
        {
            int result;
            while (true)
            {
                Console.WriteLine(prompt);
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        // this method will read a string from the console
        public static string ReadString(string prompt)
        {
            string result;
            while (true)
            {
                Console.WriteLine(prompt);
                result = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(result))
                {
                    return result;
                }
                Console.WriteLine("Input cannot be empty.");
            }
        }

        // this method will read a DateTime from the console
        public static TimeSpan ReadTimeSpan(string prompt)
        {
            Console.WriteLine(prompt);
            int input = int.Parse(Console.ReadLine());


            if (input < 60)
            {
                return TimeSpan.FromMinutes(input);
            }
            else
            {
                return TimeSpan.FromHours(input);
            }
        }

        public static string ReadTrueFalseAnswer(string prompt)
        {
            string answer;
            while (true)
            {
                Console.WriteLine(prompt);
                answer = Console.ReadLine().ToLower();
                if (answer == "true" || answer == "false")
                {
                    break;
                }
                Console.WriteLine("Please enter 'True' or 'False' only.");
            }
            return answer;
        }
    }
}
