// namespace Quizandfeedback.models{
//     public class UserAnswer
// {
//     public int UserAnswerId { get; set; }
//     public int UserAttemptId { get; set; }
//     public int QuizQuestionId { get; set; }
//     public int QuestionOptionId { get; set; }
//     public string GeneratedBy { get; set; }
//     public DateTime GeneratedAt { get; set; }
//     public string ModifiedBy { get; set; }
//     public DateTime ModifiedAt { get; set; }

//     // Navigation properties
//     public UserAttempt UserAttempt { get; set; }
//     public QuizQuestion QuizQuestion { get; set; }
//     public QuestionOption QuestionOption { get; set; }
// }
// }
using System.ComponentModel.DataAnnotations;

namespace Quizandfeedback.models
{
    public class UserAnswer
    {
        public UserAnswer()
        {
            GeneratedAt = DateTime.UtcNow;
            ModifiedAt = DateTime.UtcNow;
        }

        public Guid UserAnswerId { get; set; }
        public Guid UserAttemptId { get; set; }
        public Guid QuizQuestionId { get; set; }
        public Guid QuestionOptionId { get; set; }

        [Required]
        public string GeneratedBy { get; set; }

        public DateTime GeneratedAt { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }

        // Navigation properties
        public UserAttempt UserAttempt { get; set; }
        public QuizQuestion QuizQuestion { get; set; }
        public QuestionOption QuestionOption { get; set; }
    }
}
