namespace RouteExam02
{
    public class PracticalExamQuestion : Question
    {
        public PracticalExamQuestion(string header, string body, int mark, 
            Answer[] answers, Answer correctAnswer) : base(header, body, mark, answers, correctAnswer)
        {
            
        }

        // retrun true if the answer is correct
        public override bool IsCorrect(string answer)
        {
            return answer.ToLower() == CorrectAnswer.AnswerText.ToLower() ;
        }
    }
}
