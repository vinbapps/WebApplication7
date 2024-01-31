using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.ViewModels
{
    public class UserResponsesViewModel

    {
        public Questions Question { get; set; }
        public IEnumerable<MultipleChoiceAnswers> Answers { get; set; }
        public int AnswerId { get; set; }
        public int UserResponseId { get; set; }
       

        public int UserId { get; set; }
        public int QuestionId { get; set; }

        public UserViewModel User { get; set; } 

    }
    public class UserViewModel
    {
        public int Id { get; set; }
    }

}