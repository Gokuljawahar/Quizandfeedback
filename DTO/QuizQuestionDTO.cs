namespace Quizandfeedback.dtos{
public class QuizQuestionDto
    {
        public Guid QuizQuestionId { get; set; }
        public Guid QuizId { get; set; }
        public int QuestionNo { get; set; }
        public string? QuestionType { get; set; }
        public string? Question { get; set; } 
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        
    }
}