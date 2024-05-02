// namespace Quizandfeedback.models{
//     public class QuizQuestion
// {
//     public int QuizQuestionId { get; set; }
//     public int QuizId { get; set; }
//     public int QuestionNo { get; set; }
//     public string Question { get; set; }
//     public string CreatedBy { get; set; }
//     public DateTime CreatedAt { get; set; }
//     public string ModifiedBy { get; set; }
//     public DateTime ModifiedAt { get; set; }

//     // Navigation properties
//     public Quiz Quiz { get; set; }
//     public ICollection<QuestionOption> QuestionOptions { get; set; }
// }
// }
using System.ComponentModel.DataAnnotations;

namespace Quizandfeedback.models
{
    public class QuizQuestion
    {
        public QuizQuestion()
        {
            CreatedAt = DateTime.UtcNow;
            ModifiedAt = DateTime.UtcNow;
            QuestionOptions = new List<QuestionOption>();
        }

        public Guid QuizQuestionId { get; set; }
        public Guid QuizId { get; set; }
        public int QuestionNo { get; set; }
        
        [StringLength(30)]
        public string QuestionType { get; set; } 

        [Required]
        public string Question { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }

        // Navigation properties
        public Quiz Quiz { get; set; }
        public ICollection<QuestionOption> QuestionOptions { get; set; }
    }
}
