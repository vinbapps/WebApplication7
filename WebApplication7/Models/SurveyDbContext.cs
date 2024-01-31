using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WebApplication7
{
    public class SurveyDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<MultipleChoiceAnswers> MultipleChoiceAnswers { get; set; }
        public DbSet<UserResponses> UserResponses { get; set; }

    }
}