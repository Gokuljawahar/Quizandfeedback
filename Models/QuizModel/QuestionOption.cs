// namespace Quizandfeedback.models{
//     public class QuestionOption
// {
//     public int QuestionOptionId { get; set; }
//     public int QuizQuestionId { get; set; }
//     public string Option { get; set; }
//     public bool IsCorrect { get; set; }
//     public string CreatedBy { get; set; }
//     public DateTime CreatedAt { get; set; }
//     public string ModifiedBy { get; set; }
//     public DateTime ModifiedAt { get; set; }

//     // Navigation properties
//     public QuizQuestion QuizQuestion { get; set; }
// }
// }
using System.ComponentModel.DataAnnotations;

namespace Quizandfeedback.models
{
    public class QuestionOption
    {
        public QuestionOption()
        {
            CreatedAt = DateTime.UtcNow;
            ModifiedAt = DateTime.UtcNow;
        }

        public Guid QuestionOptionId { get; set; }
        public Guid QuizQuestionId { get; set; }

        [Required]
        public string Option { get; set; }

        public bool IsCorrect { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }

        // Navigation properties
        public QuizQuestion QuizQuestion { get; set; }
    }

}