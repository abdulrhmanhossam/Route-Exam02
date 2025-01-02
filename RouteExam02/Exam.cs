namespace RouteExam02
{
    public class Exam
    {
        public Subject Subject { get; set; }
        public List<Question> Questions { get; set; }
        public int Duration { get; set; } 

        public Exam(Subject subject)
        {
            Subject = subject;
            Questions = new List<Question>();
        }

        public Helper inputHelper = new Helper();

        public void ShowExam()
        {
            int score = 0;
            Console.WriteLine($"Starting the {Subject.SubjectName} exam...");

            foreach (var question in Questions)
            {
                Console.WriteLine($"\nQuestion: {question.Header}");
                Console.WriteLine($"{question.Body}");

                if (question is FinalExamQuestion finalExamQuestion)
                {
                    string userAnswer = inputHelper.ReadString("Enter your answer:");
                    if (finalExamQuestion.IsCorrect(userAnswer))
                    {
                        score += finalExamQuestion.Mark;
                        Console.WriteLine("Correct answer!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect answer.");
                    }
                }
                else if (question is PracticalExamQuestion practicalExamQuestion)
                {
                    string userAnswer = inputHelper.ReadString("Enter your answer:");
                    if (practicalExamQuestion.IsCorrect(userAnswer))
                    {
                        score += practicalExamQuestion.Mark;
                        Console.WriteLine("Correct answer!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect answer.");
                    }

                    Console.WriteLine($"Correct Answer: {practicalExamQuestion.CorrectAnswer.AnswerText}");
                }
            }

            Console.WriteLine($"\nExam finished. Your total score: {score}/{Questions.Sum(q => q.Mark)}");
        }

       
    }

}
