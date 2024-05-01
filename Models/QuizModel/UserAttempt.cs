// namespace Quizandfeedback.models{
//     public class UserAttempt
// {
//     public int UserAttemptId { get; set; }
//     public int UserId { get; set; }
//     public int QuizId { get; set; }
//     public int AttemptCount { get; set; }
//     public DateTime StartTime { get; set; }
//     public DateTime EndTime { get; set; }
//     public float Score { get; set; }
//     public string GeneratedBy { get; set; }
//     public DateTime GeneratedAt { get; set; }
//     public string ModifiedBy { get; set; }
//     public DateTime ModifiedAt { get; set; }

//     // Navigation properties
//     public Quiz Quiz { get; set; }
//     public ICollection<UserAnswer> UserAnswers { get; set; }
// }
// }
using System.ComponentModel.DataAnnotations;

namespace Quizandfeedback.models
{
    public class UserAttempt
    {
        public UserAttempt()
        {
            GeneratedAt = DateTime.UtcNow;
            ModifiedAt = DateTime.UtcNow;
            UserAnswers = new List<UserAnswer>();
        }

        public Guid UserAttemptId { get; set; }
        public Guid UserId { get; set; }
        public Guid QuizId { get; set; }
        public int AttemptCount { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        public float Score { get; set; }

        [Required]
        public string GeneratedBy { get; set; }

        public DateTime GeneratedAt { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }

        // Navigation properties
        public Quiz Quiz { get; set; }
        public ICollection<UserAnswer> UserAnswers { get; set; }
    }
}
