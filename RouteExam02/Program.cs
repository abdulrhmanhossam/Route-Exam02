namespace RouteExam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Get Subject Details
            int subjectId = InputHelper.ReadInt("Enter Subject ID:");
            string subjectName = InputHelper.ReadString("Enter Subject Name:");
            Subject subject = new Subject(subjectId, subjectName);

            // Step 2: Choose Exam Type
            int examType = InputHelper.ReadInt("Choose Exam Type (1 for Final Exam, 2 for Practical Exam):");

            // Step 3: Set Exam Time (in minutes or hours)
            TimeSpan examTime = InputHelper.ReadTimeSpan("Enter exam duration in minutes (e.g., 60 for 1 hour, 120 for 2 hours):");

            // Step 4: Number of Questions
            int numberOfQuestions = InputHelper.ReadInt("Enter number of questions for the exam:");

            // Step 5: Create Questions
            Question[] questions = new Question[numberOfQuestions];
            for (int i = 0; i < numberOfQuestions; i++)
            {
                string header = InputHelper.ReadString($"Enter header for question {i + 1}:");
                string body = InputHelper.ReadString($"Enter body for question {i + 1}:");
                int mark = InputHelper.ReadInt($"Enter marks for question {i + 1}:");

                // Step 6: Choose Question Type (True/False or MCQ)
                int questionTypeInt = InputHelper.ReadInt($"Choose question type for question {i + 1} (1 for True/False, 2 for MCQ):");
                QuestionType questionType = (QuestionType)questionTypeInt;

                // Step 7: Create Answers
                int numberOfAnswers = InputHelper.ReadInt($"Enter number of answers for question {i + 1}:");
                Answer[] answers = new Answer[numberOfAnswers];
                for (int j = 0; j < numberOfAnswers; j++)
                {
                    string answerText = InputHelper.ReadString($"Enter answer {j + 1}:");
                    answers[j] = new Answer(j + 1, answerText);
                }

                // Step 8: Correct Answer
                int correctAnswerId = InputHelper.ReadInt($"Enter the ID of the correct answer for question {i + 1}:");
                Answer correctAnswer = answers[correctAnswerId - 1];

                // Step 9: Create FinalExamQuestion
                questions[i] = new FinalExamQuestion(header, body, mark, answers, correctAnswer, questionType);
            }

            // Step 10: Create Exam
            Exam exam = null;
            if (examType == 1) // Final Exam
            {
                exam = new FinalExam(examTime, numberOfQuestions, questions);
            }
            else if (examType == 2) // Practical Exam
            {
                exam = new PracticalExam(examTime, numberOfQuestions, questions);
            }

            // Step 11: Create and Show Exam for Subject
            subject.CreateExam(exam);
            subject.ShowExam();
        }
    }
}
