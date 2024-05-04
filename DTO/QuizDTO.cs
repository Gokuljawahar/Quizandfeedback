namespace Quizandfeedback.dtos
{
    public class QuizDto
    {
        public Guid QuizId { get; set; }
        public Guid CourseId { get; set; }
        public Guid TopicId { get; set; }
        public string? NameOfQuiz { get; set; }
        public int Duration { get; set; }
        public int PassMark { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}


    

    