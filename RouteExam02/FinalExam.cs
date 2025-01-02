namespace RouteExam02
{
    public class FinalExam : Exam
    {
        public FinalExam(TimeSpan examTime, int numberOfQuestions, Question[] questions)
            : base(examTime, numberOfQuestions, questions)
        {

        }

        public override void StartExam()
        {
            Console.WriteLine("Final Exam:");
            foreach (var question in Questions)
            {
                Console.WriteLine($"Q: {question.Header}");
                Console.WriteLine(question.Body);
                foreach (var answer in question.Answers)
                {
                    Console.WriteLine($"- {answer.AnswerText}");
                }
            }
        }
    }
}
