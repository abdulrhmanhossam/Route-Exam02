namespace RouteExam02
{
    public class Answer
    {
        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public override string ToString()
        {
            return AnswerText;
        }
    }
}
