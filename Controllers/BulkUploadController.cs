using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Quizandfeedback.models;

namespace Quizandfeedback.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcelController : ControllerBase
    {
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

                        for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                        {
                            string type = worksheet.Cells[row, 2].Value.ToString();

                            if (type == "MCQ")
                            {
                                QuizQuestionViewModel quizQuestion = new QuizQuestionViewModel
                                {
                                    QuestionType = type,
                                    QuestionNumber = worksheet.Cells[row, 1].Value.ToString(),
                                    Question = worksheet.Cells[row, 3].Value.ToString(),
                                    CorrectOptions = new string[3],
                                    Options = new string[8]

                                };

                                for (int i = 0; i < 1; i++)
                                {
                                    string? correctoption = worksheet.Cells[row, 12].Value?.ToString();
                                    if (correctoption != null)
                                    {
                                        quizQuestion.CorrectOptions[i] = correctoption;
                                    }
                                }
                                int j = 4;
                                for (int i = 0; i < 4; i++)
                                {
                                    string? option = worksheet.Cells[row, j].Value?.ToString();
                                    if (option != null)
                                    {
                                        quizQuestion.Options[i] = option;
                                    }
                                    j=j + 1;
                                }

                                quizQuestions.Add(quizQuestion);
                            }

                            else if (type == "TF")
                            {
                                QuizQuestionViewModel quizQuestion = new QuizQuestionViewModel
                                {
                                    QuestionType = type,
                                    QuestionNumber = worksheet.Cells[row, 1].Value.ToString(),
                                    Question = worksheet.Cells[row, 3].Value.ToString(),
                                    CorrectOptions = new string[3],
                                    Options = new string[8]
                                };

                                for (int i = 0; i < 1; i++)
                                {
                                    string? correctoption = worksheet.Cells[row, 12].Value?.ToString();
                                    if (correctoption != null)
                                    {
                                        quizQuestion.CorrectOptions[i] = correctoption;
                                    }
                                }

                                int j = 4;
                                for (int i = 0; i < 4; i++)
                                {
                                    string? option = worksheet.Cells[row, j].Value?.ToString();
                                    if (option != null)
                                    {
                                        quizQuestion.Options[i] = option;
                                    }

                                    j = j + 1;
                                }

                                quizQuestions.Add(quizQuestion);
                            }

                            else if (type == "MSQ")
                            {
                                QuizQuestionViewModel quizQuestion = new QuizQuestionViewModel
                                {
                                    QuestionType = type,
                                    QuestionNumber = worksheet.Cells[row, 1].Value.ToString(),
                                    Question = worksheet.Cells[row, 3].Value.ToString(),
                                    CorrectOptions = new string[3],
                                    Options = new string[8]
                                };
                                int j = 12;
                                for (int i = 0; i < 3; i++)
                                {
                                    string? correctoption = worksheet.Cells[row, j].Value?.ToString();
                                    if (correctoption != null)
                                    {
                                        quizQuestion.CorrectOptions[i] = correctoption;
                                    }
                                    j = j + 1;
                                }

                                int k = 4;
                                for (int i = 0; i < 12; i++)
                                {
                                    string? option = worksheet.Cells[row, k].Value?.ToString();
                                    if (option != null)
                                    {
                                        quizQuestion.Options[i] = option;
                                    }
                                    k = k + 1;
                                }

                                quizQuestions.Add(quizQuestion);
                            }
                        }
                        return Ok(quizQuestions);
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }

    public class QuizQuestionViewModel
    {
        public string QuestionNumber { get; set; }
        public string QuestionType { get; set; }
        public string Question { get; set; }
        public string[] Options { get; set; }
        public string[] CorrectOptions { get; set; }
    }
}