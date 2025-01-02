namespace RouteExam02
{
    public class FinalExamQuestion : Question
    {
        public FinalExamQuestion(QuestionType type, string header, string body, int mark,
            Answer[] answers, Answer correctAnswer) : base(header, body, mark, answers, correctAnswer)
        {
            Type = type;
        }

        public QuestionType Type { get; set; }

        public override bool IsCorrect(string answer)
        {
            return answer == CorrectAnswer.AnswerText;
        }
    }
}
