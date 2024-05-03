using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Quizandfeedback.data;
using Quizandfeedback.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Quizandfeedback.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcelController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ExcelController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("ImportQuizData")]
        public IActionResult ImportQuizData(IFormFile file)
        {
            try
            {
                if (file == null || file.Length <= 0)
                    return BadRequest("File is empty.");

                using (var stream = new MemoryStream())
                {
                    file.CopyTo(stream);
                    stream.Position = 0;

                    using (ExcelPackage package = new ExcelPackage(stream))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();
                        if (worksheet == null)
                            return BadRequest("Worksheet not found.");

                        List<QuizQuestionViewModel> quizQuestions = new List<QuizQuestionViewModel>();
                        List<QuizQuestion> questionEntities = new List<QuizQuestion>(); // List to store question entities

                        for (int row = 3; row <= worksheet.Dimension.End.Row; row++)
                        {
                            string? type = worksheet.Cells[row, 2].Value?.ToString();

                            if (type == "MCQ" || type == "TF" || type == "MSQ")
                            {
                                QuizQuestionViewModel quizQuestion = new QuizQuestionViewModel
                                {
                                    QuestionType = type,
                                    QuestionNumber = Convert.ToInt32(worksheet.Cells[row, 1].Value),
                                    Question = worksheet.Cells[row, 3].Value.ToString(),
                                };

                                // Extracting options and correct options based on question type
                                if (type == "MCQ")
                                {
                                    quizQuestion.Options = ExtractOptions(worksheet, row, 4, 4);
                                    quizQuestion.CorrectOptions = ExtractOptions(worksheet, row, 12, 1);
                                }
                                else if (type == "TF")
                                {
                                    quizQuestion.Options = ExtractOptions(worksheet, row, 4, 2);
                                    quizQuestion.CorrectOptions = ExtractOptions(worksheet, row, 12, 1);
                                }
                                else if (type == "MSQ")
                                {
                                    quizQuestion.Options = ExtractOptions(worksheet, row, 4, 8);
                                    quizQuestion.CorrectOptions = ExtractOptions(worksheet, row, 12, 3);
                                }

                                quizQuestions.Add(quizQuestion);

                                QuizQuestion questionEntity = new QuizQuestion
                                {
                                    QuizId = Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                                    QuestionNo = quizQuestion.QuestionNumber,
                                    QuestionType = quizQuestion.QuestionType,
                                    Question = quizQuestion.Question,
                                    CreatedBy = "Admin",
                                    ModifiedBy = "Admin2"
                                };

                                questionEntities.Add(questionEntity); // Add questionEntity to the list

                            }
                        }

                        foreach (var questionEntity in questionEntities)
                        {
                            _context.QuizQuestions.Add(questionEntity); // Add each questionEntity to the DbSet individually
                        }

                        // Save changes to the database
                        _context.SaveChanges();

                        // Return questionEntities
                        return Ok(questionEntities);
                    }
                }
            }
            catch (Exception ex)
            {
                // Return an error response along with inner exception details
                return StatusCode(500, $"An error occurred while saving changes: {ex.Message}. Inner Exception: {ex.InnerException?.Message}");
            }
        }

        // Helper method to extract options from Excel worksheet
        private string[] ExtractOptions(ExcelWorksheet worksheet, int row, int startColumn, int count)
        {
            string[] options = new string[count];
            for (int i = 0; i < count; i++)
            {
                string? option = worksheet.Cells[row, startColumn + i].Value?.ToString();
                options[i] = option ?? "";
            }
            return options;
        }
    }

    public class QuizQuestionViewModel
    {
        public int QuestionNumber { get; set; }
        public string QuestionType { get; set; }
        public string Question { get; set; }
        public string[] Options { get; set; }
        public string[] CorrectOptions { get; set; }
    }
}