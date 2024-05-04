// using AutoMapper;
// using Microsoft.AspNetCore.Mvc;
// using Quizandfeedback.dtos;
// using Quizandfeedback.models;
// using Quizandfeedback.data;

// namespace Quizandfeedback.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class QuizController : ControllerBase
//     {
//         private readonly ILogger<QuizController> _logger;
//         private readonly AppDbContext _context;
//         private readonly IMapper _mapper; // Add AutoMapper for mapping between entities and DTOs

//         public QuizController(ILogger<QuizController> logger, AppDbContext context, IMapper mapper)
//         {
//             _logger = logger;
//             _context = context;
//             _mapper = mapper;
//         }

//         // GET: api/Quiz
//         [HttpGet]
//         public IEnumerable<QuizDto> GetQuizzes()
//         {
//             var quizzes = _context.Quizzes.ToList();
//             return _mapper.Map<List<QuizDto>>(quizzes);
//         }

//         // GET: api/Quiz/5
//         [HttpGet("{id}")]
//         public ActionResult<QuizDto> GetQuiz(Guid id)
//         {
//             var quiz = _context.Quizzes.Find(id);

//             if (quiz == null)
//             {
//                 return NotFound();
//             }

//             return _mapper.Map<QuizDto>(quiz);
//         }

//         // POST: api/Quiz
//         [HttpPost]
//         public ActionResult<QuizDto> PostQuiz(QuizDto quizDto)
//         {
//             var quiz = _mapper.Map<Quiz>(quizDto);

//             _context.Quizzes.Add(quiz);
//             _context.SaveChanges();

//             _logger.LogInformation($"Quiz created with ID: {quiz.QuizId}");

//             return CreatedAtAction(nameof(GetQuiz), new { id = quiz.QuizId }, _mapper.Map<QuizDto>(quiz));
//         }

//         // PUT: api/Quiz/5
//         [HttpPut("{id}")]
//         public IActionResult PutQuiz(Guid id, QuizDto quizDto)
//         {
//             if (id != quizDto.QuizId)
//             {
//                 return BadRequest();
//             }

//             var quiz = _mapper.Map<Quiz>(quizDto);
//             _context.Entry(quiz).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

//             try
//             {
//                 _context.SaveChanges();
//                 _logger.LogInformation($"Quiz updated with ID: {quiz.QuizId}");
//             }
//             catch (Exception)
//             {
//                 if (!_context.Quizzes.Any(q => q.QuizId == id))
//                 {
//                     return NotFound();
//                 }
//                 else
//                 {
//                     throw;
//                 }
//             }

//             return NoContent();
//         }

//         // DELETE: api/Quiz/5
//         [HttpDelete("{id}")]
//         public IActionResult DeleteQuiz(Guid id)
//         {
//             var quiz = _context.Quizzes.Find(id);
//             if (quiz == null)
//             {
//                 return NotFound();
//             }

//             _context.Quizzes.Remove(quiz);
//             _context.SaveChanges();

//             _logger.LogInformation($"Quiz deleted with ID: {id}");

//             return NoContent();
//         }
//     }
// }


// using AutoMapper;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using Quizandfeedback.dtos;
// using Quizandfeedback.models;
// using Quizandfeedback.data;

// namespace Quizandfeedback.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class QuizController : ControllerBase
//     {
//         private readonly ILogger<QuizController> _logger;
//         private readonly AppDbContext _context;
//         private readonly IMapper _mapper;

//         public QuizController(ILogger<QuizController> logger, AppDbContext context, IMapper mapper)
//         {
//             _logger = logger;
//             _context = context;
//             _mapper = mapper;
//         }

//         // GET: api/Quiz
//         [HttpGet]
//         public IEnumerable<QuizDto> GetQuizzes()
//         {
//             var quizzes = _context.Quizzes.ToList();
//             return _mapper.Map<List<QuizDto>>(quizzes);
//         }

//         // GET: api/Quiz/5
//         [HttpGet("{id}")]
//         public ActionResult<QuizDto> GetQuiz(Guid id)
//         {
//             var quiz = _context.Quizzes.Find(id);

//             if (quiz == null)
//             {
//                 return NotFound();
//             }

//             return _mapper.Map<QuizDto>(quiz);
//         }

//         // POST: api/Quiz
//         [HttpPost]
//         public ActionResult<QuizDto> PostQuiz(QuizDto quizDto)
//         {
//             var quiz = _mapper.Map<Quiz>(quizDto);

//             _context.Quizzes.Add(quiz);
//             _context.SaveChanges();

//             _logger.LogInformation($"Quiz created with ID: {quiz.QuizId}");

//             return CreatedAtAction(nameof(GetQuiz), new { id = quiz.QuizId }, _mapper.Map<QuizDto>(quiz));
//         }

//         // PUT: api/Quiz/5
//         [HttpPut("{id}")]
//         public IActionResult PutQuiz(Guid id, QuizDto quizDto)
//         {
//             if (id != quizDto.QuizId)
//             {
//                 return BadRequest();
//             }

//             var quiz = _mapper.Map<Quiz>(quizDto);
//             _context.Entry(quiz).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

//             try
//             {
//                 _context.SaveChanges();
//                 _logger.LogInformation($"Quiz updated with ID: {quiz.QuizId}");
//             }
//             catch (Exception)
//             {
//                 if (!_context.Quizzes.Any(q => q.QuizId == id))
//                 {
//                     return NotFound();
//                 }
//                 else
//                 {
//                     throw;
//                 }
//             }

//             return NoContent();
//         }

//         // DELETE: api/Quiz/5
//         [HttpDelete("{id}")]
//         public IActionResult DeleteQuiz(Guid id)
//         {
//             var quiz = _context.Quizzes.Find(id);
//             if (quiz == null)
//             {
//                 return NotFound();
//             }

//             _context.Quizzes.Remove(quiz);
//             _context.SaveChanges();

//             _logger.LogInformation($"Quiz deleted with ID: {id}");

//             return NoContent();
//         }
//     }
// }


using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Quizandfeedback.data;
using Quizandfeedback.dtos;
using Quizandfeedback.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quizandfeedback.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly AppDbContext _context;

        public QuizController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Quiz
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuizDto>>> GetQuizzes()
        {
            var quizzes = await _context.Quizzes.ToListAsync();
            return Ok(quizzes.Select(q => MapToDto(q)));
        }

        // GET: api/Quiz/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QuizDto>> GetQuiz(Guid id)
        {
            var quiz = await _context.Quizzes.FindAsync(id);

            if (quiz == null)
            {
                return NotFound();
            }

            return MapToDto(quiz);
        }

        // PUT: api/Quiz/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuiz(Guid id, QuizDto quizDto)
        {
            if (id != quizDto.QuizId)
            {
                return BadRequest();
            }

            var quiz = MapToEntity(quizDto);

            _context.Entry(quiz).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuizExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Quiz
        [HttpPost]
        public async Task<ActionResult<QuizDto>> PostQuiz(QuizDto quizDto)
        {
            var quiz = MapToEntity(quizDto);

            _context.Quizzes.Add(quiz);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetQuiz), new { id = quiz.QuizId }, MapToDto(quiz));
        }

        // DELETE: api/Quiz/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuiz(Guid id)
        {
            var quiz = await _context.Quizzes.FindAsync(id);
            if (quiz == null)
            {
                return NotFound();
            }

            _context.Quizzes.Remove(quiz);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool QuizExists(Guid id)
        {
            return _context.Quizzes.Any(e => e.QuizId == id);
        }

        private QuizDto MapToDto(Quiz quiz)
        {
            return new QuizDto
            {
                // QuizId = quiz.QuizId,
                QuizId = Guid.NewGuid(),
                CourseId = quiz.CourseId,
                TopicId = quiz.TopicId,
                NameOfQuiz = quiz.NameOfQuiz,
                Duration = quiz.Duration,
                PassMark = quiz.PassMark,
                CreatedBy = quiz.CreatedBy,
                CreatedAt = quiz.CreatedAt,
                ModifiedBy = quiz.ModifiedBy,
                ModifiedAt = quiz.ModifiedAt
            };
        }

        private Quiz MapToEntity(QuizDto quizDto)
        {
            return new Quiz
            {
                 QuizId  = Guid.NewGuid(),
                //  = quizDto.QuizId,
                CourseId = quizDto.CourseId,
                TopicId = quizDto.TopicId,
                NameOfQuiz = quizDto.NameOfQuiz,
                Duration = quizDto.Duration,
                PassMark = quizDto.PassMark,
                CreatedBy = quizDto.CreatedBy,
                CreatedAt = quizDto.CreatedAt,
                ModifiedBy = quizDto.ModifiedBy,
                ModifiedAt = quizDto.ModifiedAt
            };
        }
    }
}
