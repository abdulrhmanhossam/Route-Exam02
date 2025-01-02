namespace RouteExam02
{
    public class FinalExamQuestion : Question
    {
        public FinalExamQuestion(string header, string body, int mark,
            Answer[] answers, Answer correctAnswer, QuestionType type) : base(header, body, mark, answers, correctAnswer)
        {
            Type = type;
        }

        public QuestionType Type { get; set; }

        public override bool IsCorrect(string answer)
        {
            return answer.ToLower() == CorrectAnswer.AnswerText.ToLower();
        }
    }
}
