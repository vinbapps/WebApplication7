using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication7
{
    public class UserResponses
    {
        [Key]
        public int ResponseId { get; set; }

        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }

        public Users User { get; set; }
        public Questions Question { get; set; }
        public MultipleChoiceAnswers Answer { get; set; }
    }
}