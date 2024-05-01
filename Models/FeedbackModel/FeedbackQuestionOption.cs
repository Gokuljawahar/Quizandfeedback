// namespace Quizandfeedback.models
// {
//     public class FeedbackQuestionOption
//     {
//         public int FeedbackQuestionOptionId { get; set; } // Primary key
//         public int FeedbackQuestionId { get; set; }
//         public string Option { get; set; }
//         public string CreatedBy { get; set; }
//         public DateTime CreatedAt { get; set; }
//         public string ModifiedBy { get; set; }
//         public DateTime ModifiedAt { get; set; }

//         // Navigation properties
//         public FeedbackQuestion FeedbackQuestion { get; set; }
//     }
// }
using System.ComponentModel.DataAnnotations;
namespace Quizandfeedback.models
{
    public class FeedbackQuestionOption
    {
        public FeedbackQuestionOption()
        {
            CreatedAt = DateTime.UtcNow;
            ModifiedAt = DateTime.UtcNow;
        }

        public Guid FeedbackQuestionOptionId { get; set; } // Primary key
        public Guid  FeedbackQuestionId { get; set; }

        [Required]
        public string Option { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }

        // Navigation properties
        public FeedbackQuestion FeedbackQuestion { get; set; }
    }
}