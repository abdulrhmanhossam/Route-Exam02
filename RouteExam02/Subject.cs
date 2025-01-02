namespace RouteExam02
{
    public class Subject
    {
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        // take any thing type of exam
        public void CreateExam(Exam exam)
        {
            Exam = exam;
        }

        public void ShowExam()
        {
            Exam.StartExam();
        }
    }
}
