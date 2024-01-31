namespace WebApplication7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MultipleChoiceAnswers",
                c => new
                    {
                        AnswerId = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(nullable: false),
                        AnswerText = c.String(),
                    })
                .PrimaryKey(t => t.AnswerId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QuestionId = c.Int(nullable: false, identity: true),
                        QuestionText = c.String(),
                    })
                .PrimaryKey(t => t.QuestionId);
            
            CreateTable(
                "dbo.UserResponses",
                c => new
                    {
                        ResponseId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        QuestionId = c.Int(nullable: false),
                        AnswerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ResponseId)
                .ForeignKey("dbo.MultipleChoiceAnswers", t => t.AnswerId, cascadeDelete: true)
                .ForeignKey("dbo.Questions", t => t.QuestionId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.QuestionId)
                .Index(t => t.AnswerId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Email = c.String(),
                        LevelOfApprenticeship = c.String(),
                        JobRole = c.String(),
                        Organisation = c.String(),
                        AccessRequirements = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserResponses", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserResponses", "QuestionId", "dbo.Questions");
            DropForeignKey("dbo.UserResponses", "AnswerId", "dbo.MultipleChoiceAnswers");
            DropIndex("dbo.UserResponses", new[] { "AnswerId" });
            DropIndex("dbo.UserResponses", new[] { "QuestionId" });
            DropIndex("dbo.UserResponses", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.UserResponses");
            DropTable("dbo.Questions");
            DropTable("dbo.MultipleChoiceAnswers");
        }
    }
}
