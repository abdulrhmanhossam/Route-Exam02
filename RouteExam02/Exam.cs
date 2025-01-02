namespace RouteExam02
{
    public abstract class Exam
    {
        protected Exam(DateTime examTime, int numberOfQuestions, Question[] questions)
        {
            ExamTime = examTime;
            NumberOfQuestions = numberOfQuestions;
            Questions = questions;
        }

        public DateTime ExamTime { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        public abstract void StartExam();

    }
}
