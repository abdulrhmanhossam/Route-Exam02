namespace RouteExam02
{
    public class PracticalExam : Exam
    {
        public PracticalExam(DateTime examTime, int numberOfQuestions, Question[] questions)
            : base(examTime, numberOfQuestions, questions)
        {

        }

        public override void StartExam()
        {
            foreach (var question in Questions)
            {
                Console.WriteLine(question);
            }
            
            Console.WriteLine("\nThe right answers are shown after the exam.");
        }
    }
}
