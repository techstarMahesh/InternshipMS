namespace InternshipMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CaptizeTheFirstLetter : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Interns", new[] { "user_id" });
            DropIndex("dbo.Interns", new[] { "guide_id" });
            DropIndex("dbo.Queries", new[] { "intern_id" });
            DropIndex("dbo.Queries", new[] { "guide_id" });
            DropIndex("dbo.Queries", new[] { "task_id" });
            DropIndex("dbo.Replies", new[] { "query_id" });
            DropIndex("dbo.Replies", new[] { "guide_id" });
            DropIndex("dbo.Users", new[] { "role_id" });
            DropIndex("dbo.Remarks", new[] { "submission_id" });
            DropIndex("dbo.Remarks", new[] { "guide_id" });
            DropIndex("dbo.Submissions", new[] { "intern_id" });
            DropIndex("dbo.Submissions", new[] { "task_id" });
            DropIndex("dbo.Tasks", new[] { "guide_id" });
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Interns", "User_id");
            CreateIndex("dbo.Interns", "Guide_id");
            CreateIndex("dbo.Queries", "Intern_id");
            CreateIndex("dbo.Queries", "Guide_id");
            CreateIndex("dbo.Queries", "Task_id");
            CreateIndex("dbo.Replies", "Query_id");
            CreateIndex("dbo.Replies", "Guide_id");
            CreateIndex("dbo.Users", "Role_id");
            CreateIndex("dbo.Remarks", "Submission_id");
            CreateIndex("dbo.Remarks", "Guide_id");
            CreateIndex("dbo.Submissions", "Intern_id");
            CreateIndex("dbo.Submissions", "Task_id");
            CreateIndex("dbo.Tasks", "Guide_id");
            DropTable("dbo.roles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.roles",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            DropIndex("dbo.Tasks", new[] { "Guide_id" });
            DropIndex("dbo.Submissions", new[] { "Task_id" });
            DropIndex("dbo.Submissions", new[] { "Intern_id" });
            DropIndex("dbo.Remarks", new[] { "Guide_id" });
            DropIndex("dbo.Remarks", new[] { "Submission_id" });
            DropIndex("dbo.Users", new[] { "Role_id" });
            DropIndex("dbo.Replies", new[] { "Guide_id" });
            DropIndex("dbo.Replies", new[] { "Query_id" });
            DropIndex("dbo.Queries", new[] { "Task_id" });
            DropIndex("dbo.Queries", new[] { "Guide_id" });
            DropIndex("dbo.Queries", new[] { "Intern_id" });
            DropIndex("dbo.Interns", new[] { "Guide_id" });
            DropIndex("dbo.Interns", new[] { "User_id" });
            DropTable("dbo.Roles");
            CreateIndex("dbo.Tasks", "guide_id");
            CreateIndex("dbo.Submissions", "task_id");
            CreateIndex("dbo.Submissions", "intern_id");
            CreateIndex("dbo.Remarks", "guide_id");
            CreateIndex("dbo.Remarks", "submission_id");
            CreateIndex("dbo.Users", "role_id");
            CreateIndex("dbo.Replies", "guide_id");
            CreateIndex("dbo.Replies", "query_id");
            CreateIndex("dbo.Queries", "task_id");
            CreateIndex("dbo.Queries", "guide_id");
            CreateIndex("dbo.Queries", "intern_id");
            CreateIndex("dbo.Interns", "guide_id");
            CreateIndex("dbo.Interns", "user_id");
        }
    }
}
