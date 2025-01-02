namespace RouteExam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "MATH101");

            int examDuration = ReadInt("Enter the exam duration in minutes:");

            string examType = ReadString("Enter the exam type (Final, Practical):");

            Exam exam = new Exam(subject);

            for (int i = 0; i < 2; i++) 
            {
                string header = ReadString("Enter question header:");
                string body = ReadString("Enter question body:");
                int mark = ReadInt("Enter the mark for this question:");

                Answer[] answers = exam.ReadMCQAnswers("Enter the answers for this question:");

                Answer correctAnswer = new Answer(1, "Correct answer");

                if (examType.ToLower() == "final")
                {
                    QuestionType questionType = (QuestionType)Enum.Parse(typeof(QuestionType), ReadString("Enter question type (TrueFalse, MCQ):"));
                    exam.Questions.Add(new FinalExamQuestion(header, body, mark, answers, correctAnswer, questionType));
                }
                else
                {
                    exam.Questions.Add(new PracticalExamQuestion(header, body, mark, answers, correctAnswer));
                }
            }

            exam.ShowExam();
            }

        private static int ReadInt(string prompt)
        {
            Console.WriteLine(prompt);
            return int.Parse(Console.ReadLine());
        }

        // دالة لقراءة البيانات النصية من المستخدم
        private static string ReadString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }

}
