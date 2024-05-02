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
                            QuizQuestionViewModel quizQuestion = new QuizQuestionViewModel
                            {
                                Question = worksheet.Cells[row, 1].Value.ToString(),
                                Options = new List<string>
                                {
                                    worksheet.Cells[row, 2].Value.ToString(),
                                    worksheet.Cells[row, 3].Value.ToString(),
                                    worksheet.Cells[row, 4].Value.ToString(),
                                    worksheet.Cells[row, 5].Value.ToString()
                                    
                                },
                                UserAnswer = worksheet.Cells[row, 6].Value.ToString()
                            };

                            quizQuestions.Add(quizQuestion);
                        }

                        return Ok(quizQuestions); // Return fetched data in the response body
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
        public string Question { get; set; }
        public List<string> Options { get; set; }
        public string UserAnswer { get; set; }
    }
}