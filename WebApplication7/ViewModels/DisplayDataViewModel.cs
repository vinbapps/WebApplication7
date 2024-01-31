using System.Collections.Generic;

namespace WebApplication7.ViewModels
{
    public class DisplayDataViewModel
    {
        public List<Users> Users { get; set; }
        public List<QuestionWithAnswersViewModel> Questions { get; set; }
    }

    public class QuestionWithAnswersViewModel
    {
        public string QuestionText { get; set; }
        public List<string> AnswerTexts { get; set; }
    }
}
