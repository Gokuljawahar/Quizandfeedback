namespace Quizandfeedback.dtos{
public class QuestionOptionDto
    {
        public Guid QuestionOptionId { get; set; }
        public Guid QuizQuestionId { get; set; }
        public string? Option { get; set; }
        public bool IsCorrect { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
