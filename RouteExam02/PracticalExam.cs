namespace RouteExam02
{
    public class PracticalExam : Exam
    {
        public PracticalExam(TimeSpan examTime, int numberOfQuestions, Question[] questions)
            : base(examTime, numberOfQuestions, questions)
        {

        }

        public override void StartExam()
        {
            Console.WriteLine("Practical Exam:");
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
