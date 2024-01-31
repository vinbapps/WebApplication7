using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication7.ViewModels;


namespace WebApplication7.Controllers
{
    public class ResultsController : Controller
    {
        private readonly SurveyDbContext _dbContext;

        // Constructor with dependency injection
        public ResultsController(SurveyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ActionResult DisplayData()
        {
            var users = _dbContext.Users.ToList();

            var questionsWithAnswers = _dbContext.Questions
                .Include(q => q.MultipleChoiceAnswers)
                .ToList();

            var viewModel = new DisplayDataViewModel
            {
                Users = users,
                Questions = questionsWithAnswers.Select(q => new QuestionWithAnswersViewModel
                {
                    QuestionText = q.QuestionText,
                    AnswerTexts = q.MultipleChoiceAnswers.Select(a => a.AnswerText).ToList()
                }).ToList()
            };

            return View(viewModel);
        }
        [HttpPost]
        public IActionResult DisplayData(UserResponsesViewModel viewModel)
        {
           
            return RedirectToAction("ThankYou");
        }
    }
}