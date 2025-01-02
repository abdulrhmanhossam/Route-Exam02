namespace RouteExam02
{
    public class FinalExam : Exam
    {
        public FinalExam(DateTime examTime, int numberOfQuestions, Question[] questions)
            : base(examTime, numberOfQuestions, questions)
        {

        }

        public override void StartExam()
        {
            foreach (var question in Questions)
            {
                Console.WriteLine(question);
            }
            // using linq and lambda expression to calculate the total mark
            Console.WriteLine("\nGrade: " + Questions.Sum(q => q.Mark));
        }
    }
}
