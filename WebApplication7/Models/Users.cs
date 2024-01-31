using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication7
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string LevelOfApprenticeship { get; set; }
        public string JobRole { get; set; }
        public string Organisation { get; set; }
        public string AccessRequirements { get; set; }


    }
}