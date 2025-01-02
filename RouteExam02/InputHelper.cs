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
    }
}
