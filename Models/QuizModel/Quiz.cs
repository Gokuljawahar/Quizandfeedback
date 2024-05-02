// namespace Quizandfeedback.models{
//     public class Quiz
// {
//     public int QuizId { get; set; }
//     public int CourseId { get; set; }
//     public int TopicId { get; set; }
//     public string NameOfQuiz { get; set; }
//     public int Duration { get; set; }
//     public int PassMark { get; set; }
//     public string CreatedBy { get; set; }
//     public DateTime CreatedAt { get; set; }
//     public string ModifiedBy { get; set; }
//     public DateTime ModifiedAt { get; set; }

//     // Navigation properties
//     public ICollection<QuizQuestion> QuizQuestions { get; set; }
// }
// }
using System.ComponentModel.DataAnnotations;

namespace Quizandfeedback.models
{
    public class Quiz
    {
        public Quiz()
        {
            CreatedAt = DateTime.UtcNow;
            ModifiedAt = DateTime.UtcNow;
            QuizQuestions = new List<QuizQuestion>();
        }

        public Guid QuizId { get; set; }
        public Guid CourseId { get; set; }
        public Guid TopicId { get; set; }

        [Required]
        public string NameOfQuiz { get; set; }

        public int Duration { get; set; }
        public int PassMark { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }

        public ICollection<QuizQuestion> QuizQuestions { get; set; }
    }
}
