using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.ViewModels;

namespace WebApplication7.Controllers
{
    public class MultipleChoiceAnswersController : Controller
    {
        // GET: MultipleChoiceAnswers
        public ActionResult YourAction()
        {
            using (var dbContext = new SurveyDbContext())
            {
                // Logic to retrieve or create a Questions object
                var question = dbContext.Questions.FirstOrDefault();

                // Logic to get a collection of MultipleChoiceAnswers
                var answers = dbContext.MultipleChoiceAnswers.ToList();

                // Create the UserResponsesViewModel and populate properties
                var viewModel = new UserResponsesViewModel
                {
                    Question = question,
                    Answers = answers
                };

                return View(viewModel);
            }
        }
    }
}