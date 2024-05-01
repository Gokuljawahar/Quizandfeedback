// namespace Quizandfeedback.models
// {
//     public class FeedbackResponse
//     {
//         public int FeedbackResponseId { get; set; } // Primary key
//         public int FeedbackQuestionId { get; set; }
//         public int UserId { get; set; }
//         public string Response { get; set; }
//         public int OptionId { get; set; }
//         public string GeneratedBy { get; set; }
//         public DateTime GeneratedAt { get; set; }
//         public string ModifiedBy { get; set; }
//         public DateTime ModifiedAt { get; set; }

//         // Navigation properties
//         public FeedbackQuestion FeedbackQuestion { get; set; }
//         public FeedbackQuestionOption QuestionOption { get; set; }
//     }
// }
using System.ComponentModel.DataAnnotations;
namespace Quizandfeedback.models
{
    public class FeedbackResponse
    {
        public FeedbackResponse()
        {
            GeneratedAt = DateTime.UtcNow;
            ModifiedAt = DateTime.UtcNow;
        }

        public Guid FeedbackResponseId { get; set; } // Primary key
        public Guid FeedbackQuestionId { get; set; }
        public int UserId { get; set; }

        [Required]
        public string Response { get; set; }

        public int OptionId { get; set; }

        [Required]
        public string GeneratedBy { get; set; }

        public DateTime GeneratedAt { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }

        // Navigation properties
        public FeedbackQuestion FeedbackQuestion { get; set; }
        public FeedbackQuestionOption QuestionOption { get; set; }
    }
}
