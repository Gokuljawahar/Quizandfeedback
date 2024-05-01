﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Quizandfeedback.data;

#nullable disable

namespace Quizandfeedback.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240501055034_initialcreate")]
    partial class initialcreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Quizandfeedback.models.FeedbackQuestion", b =>
                {
                    b.Property<Guid>("FeedbackQuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FeedbackType")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("QuestionNo")
                        .HasColumnType("int");

                    b.Property<string>("QuestionType")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<Guid>("TopicId")
                        .HasColumnType("char(36)");

                    b.HasKey("FeedbackQuestionId");

                    b.ToTable("FeedbackQuestions");
                });

            modelBuilder.Entity("Quizandfeedback.models.FeedbackQuestionOption", b =>
                {
                    b.Property<Guid>("FeedbackQuestionOptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("FeedbackQuestionId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Option")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("FeedbackQuestionOptionId");

                    b.HasIndex("FeedbackQuestionId");

                    b.ToTable("FeedbackQuestionsOptions");
                });

            modelBuilder.Entity("Quizandfeedback.models.FeedbackResponse", b =>
                {
                    b.Property<Guid>("FeedbackResponseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("FeedbackQuestionId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("GeneratedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("GeneratedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OptionId")
                        .HasColumnType("int");

                    b.Property<Guid>("QuestionOptionFeedbackQuestionOptionId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Response")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("FeedbackResponseId");

                    b.HasIndex("FeedbackQuestionId");

                    b.HasIndex("QuestionOptionFeedbackQuestionOptionId");

                    b.ToTable("FeedbackResponses");
                });

            modelBuilder.Entity("Quizandfeedback.models.QuestionOption", b =>
                {
                    b.Property<Guid>("QuestionOptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Option")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("QuizQuestionId")
                        .HasColumnType("char(36)");

                    b.HasKey("QuestionOptionId");

                    b.HasIndex("QuizQuestionId");

                    b.ToTable("QuestionOptions");
                });

            modelBuilder.Entity("Quizandfeedback.models.Quiz", b =>
                {
                    b.Property<Guid>("QuizId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NameOfQuiz")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PassMark")
                        .HasColumnType("int");

                    b.Property<Guid>("TopicId")
                        .HasColumnType("char(36)");

                    b.HasKey("QuizId");

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("Quizandfeedback.models.QuizQuestion", b =>
                {
                    b.Property<Guid>("QuizQuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("QuestionNo")
                        .HasColumnType("int");

                    b.Property<Guid>("QuizId")
                        .HasColumnType("char(36)");

                    b.HasKey("QuizQuestionId");

                    b.HasIndex("QuizId");

                    b.ToTable("QuizQuestions");
                });

            modelBuilder.Entity("Quizandfeedback.models.UserAnswer", b =>
                {
                    b.Property<Guid>("UserAnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("GeneratedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("GeneratedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("QuestionOptionId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("QuizQuestionId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserAttemptId")
                        .HasColumnType("char(36)");

                    b.HasKey("UserAnswerId");

                    b.HasIndex("QuestionOptionId");

                    b.HasIndex("QuizQuestionId");

                    b.HasIndex("UserAttemptId");

                    b.ToTable("UserAnswers");
                });

            modelBuilder.Entity("Quizandfeedback.models.UserAttempt", b =>
                {
                    b.Property<Guid>("UserAttemptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("AttemptCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("GeneratedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("GeneratedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("QuizId")
                        .HasColumnType("char(36)");

                    b.Property<float>("Score")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("UserAttemptId");

                    b.HasIndex("QuizId");

                    b.ToTable("UserAttempts");
                });

            modelBuilder.Entity("Quizandfeedback.models.FeedbackQuestionOption", b =>
                {
                    b.HasOne("Quizandfeedback.models.FeedbackQuestion", "FeedbackQuestion")
                        .WithMany("FeedbackQuestionsOptions")
                        .HasForeignKey("FeedbackQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FeedbackQuestion");
                });

            modelBuilder.Entity("Quizandfeedback.models.FeedbackResponse", b =>
                {
                    b.HasOne("Quizandfeedback.models.FeedbackQuestion", "FeedbackQuestion")
                        .WithMany("FeedbackResponses")
                        .HasForeignKey("FeedbackQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Quizandfeedback.models.FeedbackQuestionOption", "QuestionOption")
                        .WithMany()
                        .HasForeignKey("QuestionOptionFeedbackQuestionOptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FeedbackQuestion");

                    b.Navigation("QuestionOption");
                });

            modelBuilder.Entity("Quizandfeedback.models.QuestionOption", b =>
                {
                    b.HasOne("Quizandfeedback.models.QuizQuestion", "QuizQuestion")
                        .WithMany("QuestionOptions")
                        .HasForeignKey("QuizQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuizQuestion");
                });

            modelBuilder.Entity("Quizandfeedback.models.QuizQuestion", b =>
                {
                    b.HasOne("Quizandfeedback.models.Quiz", "Quiz")
                        .WithMany("QuizQuestions")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("Quizandfeedback.models.UserAnswer", b =>
                {
                    b.HasOne("Quizandfeedback.models.QuestionOption", "QuestionOption")
                        .WithMany()
                        .HasForeignKey("QuestionOptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Quizandfeedback.models.QuizQuestion", "QuizQuestion")
                        .WithMany()
                        .HasForeignKey("QuizQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Quizandfeedback.models.UserAttempt", "UserAttempt")
                        .WithMany("UserAnswers")
                        .HasForeignKey("UserAttemptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuestionOption");

                    b.Navigation("QuizQuestion");

                    b.Navigation("UserAttempt");
                });

            modelBuilder.Entity("Quizandfeedback.models.UserAttempt", b =>
                {
                    b.HasOne("Quizandfeedback.models.Quiz", "Quiz")
                        .WithMany()
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("Quizandfeedback.models.FeedbackQuestion", b =>
                {
                    b.Navigation("FeedbackQuestionsOptions");

                    b.Navigation("FeedbackResponses");
                });

            modelBuilder.Entity("Quizandfeedback.models.Quiz", b =>
                {
                    b.Navigation("QuizQuestions");
                });

            modelBuilder.Entity("Quizandfeedback.models.QuizQuestion", b =>
                {
                    b.Navigation("QuestionOptions");
                });

            modelBuilder.Entity("Quizandfeedback.models.UserAttempt", b =>
                {
                    b.Navigation("UserAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
