// namespace Quizandfeedback.models{
//       public enum QuestionType
//     {
//         MCQ, // Multiple Choice Question
//         OpenEnded // Open-Ended Question
//     }
 
//     public enum FeedbackType
//     {
//         TopicFeedback,
//         QuizFeedback
//     }


//     public class FeedbackQuestion
// {
//     public int FeedbackQuestionId { get; set; }
//     public int TopicId { get; set; }
//     public int QuestionNo { get; set; }
//     public string Question { get; set; }
//      public QuestionType QuestionType { get; set; } 
//      public FeedbackType FeedbackType { get; set; } 
//     public string CreatedBy { get; set; }
//     public DateTime CreatedAt { get; set; }
//     public string ModifiedBy { get; set; }
//     public DateTime ModifiedAt { get; set; }

//     // Navigation properties
//     public ICollection<FeedbackQuestionOption> FeedbackQuestionsOptions { get; set; }
//     public ICollection<FeedbackResponse> FeedbackResponses { get; set; }
// }

// }.
// using System.ComponentModel.DataAnnotations;
// namespace Quizandfeedback.models
// {
    
//     public class FeedbackQuestion
//     {
//         public FeedbackQuestion()
//         {
//             CreatedAt = DateTime.UtcNow;
//             ModifiedAt = DateTime.UtcNow;
//             FeedbackQuestionsOptions = new List<FeedbackQuestionOption>();
//             FeedbackResponses = new List<FeedbackResponse>();
//         }

//         public int FeedbackQuestionId { get; set; }
//         public int TopicId { get; set; }
//         public int QuestionNo { get; set; }

//         [Required]
//         public string Question { get; set; }

//         public string QuestionType { get; set; } 
//         public string FeedbackType { get; set; } 

//         [Required]
//         public string CreatedBy { get; set; }

//         public DateTime CreatedAt { get; set; }

//         public string ModifiedBy { get; set; }
//         public DateTime ModifiedAt { get; set; }

//         // Navigation properties
//         public ICollection<FeedbackQuestionOption> FeedbackQuestionsOptions { get; set; }
//         public ICollection<FeedbackResponse> FeedbackResponses { get; set; }
//     }
// }

using System.ComponentModel.DataAnnotations;

namespace Quizandfeedback.models
{
    public class FeedbackQuestion
    {
        public FeedbackQuestion()
        {
            CreatedAt = DateTime.UtcNow;
            ModifiedAt = DateTime.UtcNow;
            FeedbackQuestionsOptions = new List<FeedbackQuestionOption>();
            FeedbackResponses = new List<FeedbackResponse>();
        }

        public Guid FeedbackQuestionId { get; set; }
        public Guid TopicId { get; set; }
        public int QuestionNo { get; set; }

        [Required]
        public string Question { get; set; }

        [StringLength(30)]
        public string QuestionType { get; set; } 

        [StringLength(30)]
        public string FeedbackType { get; set; } 

        [Required]
        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }

        // Navigation properties
        public ICollection<FeedbackQuestionOption> FeedbackQuestionsOptions { get; set; }
        public ICollection<FeedbackResponse> FeedbackResponses { get; set; }
    }
}
