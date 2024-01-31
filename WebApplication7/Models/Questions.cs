using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;



namespace WebApplication7
{
    public class Questions
    {
        [Key]
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }

        public virtual ICollection<MultipleChoiceAnswers> MultipleChoiceAnswers { get; set; }

    }
}