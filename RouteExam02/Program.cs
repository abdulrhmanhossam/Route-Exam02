namespace RouteExam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "Programming");

            Helper inputHelper = new Helper();

            Exam exam = new Exam(subject);
            int examDuration = inputHelper.ReadInt("Enter the exam duration in minutes:");
            int numberOfQuestions = inputHelper.ReadInt("Enter the number of questions:");

            for (int i = 0; i < numberOfQuestions; i++)
            {
                string header = inputHelper.ReadString("Enter question header:");
                string body = inputHelper.ReadString("Enter question body:");
                int mark = inputHelper.ReadInt("Enter the mark for this question:");

                string questionTypeStr = inputHelper.ReadString("Enter question type (TrueFalse, MCQ):");

                QuestionType questionType;
                while (!Enum.TryParse(questionTypeStr, out questionType))
                {
                    Console.WriteLine("Invalid input! Please enter 'TrueFalse' or 'MCQ'.");
                    questionTypeStr = inputHelper.ReadString("Enter question type (TrueFalse, MCQ):");
                }

                Answer[] answers = new Answer[0]; 

                Answer correctAnswer = null;

                if (questionType == QuestionType.TrueFalse)
                {
                    string correctTrueFalseAnswer = inputHelper.ReadTrueFalseAnswer("Enter the correct answer (True or False):");
                    correctAnswer = new Answer(1, correctTrueFalseAnswer);
                }
                else if (questionType == QuestionType.MCQ)
                {
                    answers = inputHelper.ReadMCQAnswers("Enter the answers for this question:");
                    correctAnswer = new Answer(1, "Correct answer"); 
                }

                if (questionType == QuestionType.TrueFalse)
                {
                    exam.Questions.Add(new FinalExamQuestion(header, body, mark, answers, correctAnswer, questionType));
                }
                else
                {
                    exam.Questions.Add(new PracticalExamQuestion(header, body, mark, answers, correctAnswer));
                }
            }

            exam.ShowExam();
        }
    }

}
