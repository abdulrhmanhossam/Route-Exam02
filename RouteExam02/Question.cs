namespace RouteExam02
{
    public abstract class Question : ICloneable, IComparable
    {
        public Question(string header, string body, int mark, Answer[] answers, Answer correctAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }

        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] Answers { get; set; }
        public Answer CorrectAnswer { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone(); // create a shallow copy from the current object
        }

        public int CompareTo(object? obj)
        {
            if (obj == null) 
                return 1;

            Question? otherQuestion = obj as Question;

            return otherQuestion != null ? 
                Mark.CompareTo(otherQuestion.Mark) : 0;  // compare the marks of the questions
        }

        public abstract bool IsCorrect(string answer);


        public override string ToString()
        {
            return $"{Header}\n{Body}\nMarks: {Mark}";
        }
    }
}
