
using Microsoft.EntityFrameworkCore;
using Quizandfeedback.models;

namespace Quizandfeedback.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //Quiz
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<QuizQuestion> QuizQuestions { get; set; }
        public DbSet<QuestionOption> QuestionOptions { get; set; }
        public DbSet<UserAttempt> UserAttempts { get; set; }
        public DbSet<UserAnswer> UserAnswers { get; set; }
        public DbSet<FeedbackQuestion> FeedbackQuestions { get; set; }
        public DbSet<FeedbackResponse> FeedbackResponses { get; set; }
        public DbSet<FeedbackQuestionOption> FeedbackQuestionsOptions { get; set; }

    }

}