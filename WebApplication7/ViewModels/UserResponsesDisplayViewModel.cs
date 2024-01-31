// UserResponsesViewModels.cs
using System.Collections.Generic;

namespace WebApplication7.ViewModels
{
    public class UserResponsesDisplayViewModel
    {
        public string UserName { get; set; }
        public List<UserResponseViewModel> Responses { get; set; }
    }

    public class UserResponseViewModel
    {
        public string QuestionText { get; set; }
        public string AnswerText { get; set; }
        // Additional properties as needed
    }
}
