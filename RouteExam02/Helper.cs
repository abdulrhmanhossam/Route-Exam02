using System.Runtime.CompilerServices;

namespace RouteExam02
{
    public  class Helper
    {
        public string ReadString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public int ReadInt(string prompt)
        {
            Console.WriteLine(prompt);
            return int.Parse(Console.ReadLine());
        }

        public Answer[] ReadMCQAnswers(string prompt, int minAnswers = 2)
        {
            Console.WriteLine(prompt);
            int numberOfAnswers = ReadInt($"Enter number of answers (minimum {minAnswers} answers):");

            while (numberOfAnswers < minAnswers)
            {
                Console.WriteLine($"You must enter at least {minAnswers} answers.");
                numberOfAnswers = ReadInt($"Enter number of answers (minimum {minAnswers} answers):");
            }

            Answer[] answers = new Answer[numberOfAnswers];
            for (int i = 0; i < numberOfAnswers; i++)
            {
                string answerText = ReadString($"Enter answer {i + 1}:");
                answers[i] = new Answer(i + 1, answerText);
            }

            return answers;
        }

        public string ReadTrueFalseAnswer(string prompt)
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
