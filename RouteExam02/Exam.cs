namespace RouteExam02
{
    public class Exam
    {
        public Subject Subject { get; set; }
        public List<Question> Questions { get; set; }
        public int Duration { get; set; } // مدة الامتحان بالدقائق

        public Exam(Subject subject)
        {
            Subject = subject;
            Questions = new List<Question>();
        }

        // دالة لعرض الأسئلة وطلب الإجابات
        public void ShowExam()
        {
            int score = 0;
            Console.WriteLine($"Starting the {Subject.SubjectName} exam...");

            // عرض الأسئلة واحدة تلو الأخرى
            foreach (var question in Questions)
            {
                Console.WriteLine($"\nQuestion: {question.Header}");
                Console.WriteLine($"{question.Body}");

                if (question is FinalExamQuestion finalExamQuestion)
                {
                    string userAnswer = ReadString("Enter your answer:");
                    if (finalExamQuestion.IsCorrect(userAnswer))
                    {
                        score += finalExamQuestion.Mark;
                        Console.WriteLine("Correct answer!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect answer.");
                    }
                }
                else if (question is PracticalExamQuestion practicalExamQuestion)
                {
                    string userAnswer = ReadString("Enter your answer:");
                    if (practicalExamQuestion.IsCorrect(userAnswer))
                    {
                        score += practicalExamQuestion.Mark;
                        Console.WriteLine("Correct answer!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect answer.");
                    }

                    // عرض الإجابة الصحيحة بعد الانتهاء من كل سؤال
                    Console.WriteLine($"Correct Answer: {practicalExamQuestion.CorrectAnswer.AnswerText}");
                }
            }

            Console.WriteLine($"\nExam finished. Your total score: {score}/{Questions.Sum(q => q.Mark)}");
        }

        // دالة لقراءة البيانات النصية من المستخدم
        private string ReadString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        // دالة لقراءة عدد صحيح من المستخدم
        private int ReadInt(string prompt)
        {
            Console.WriteLine(prompt);
            return int.Parse(Console.ReadLine());
        }

        // دالة لقراءة الإجابات لأسئلة MCQ مع التحقق من عدد الإجابات
        public Answer[] ReadMCQAnswers(string prompt, int minAnswers = 2)
        {
            Console.WriteLine(prompt);
            int numberOfAnswers = ReadInt($"Enter number of answers (minimum {minAnswers} answers):");

            // تحقق من أن العدد المدخل هو 2 أو أكثر
            while (numberOfAnswers < minAnswers)
            {
                Console.WriteLine($"You must enter at least {minAnswers} answers.");
                numberOfAnswers = ReadInt($"Enter number of answers (minimum {minAnswers} answers):");
            }

            Answer[] answers = new Answer[numberOfAnswers];
            for (int i = 0; i < numberOfAnswers; i++)
            {
                string answerText = ReadString($"Enter answer {i + 1}:");
                answers[i] = new Answer(i + 1, answerText);
            }

            return answers;
        }
    }

}
