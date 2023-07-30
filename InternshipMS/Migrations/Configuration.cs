namespace InternshipMS.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InternshipMS.Models.IntershipContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(InternshipMS.Models.IntershipContext context)
        {
            context.Users.AddOrUpdate(x => x.Name, new Models.User
            {
                Role = new Models.Role
                {
                    Name = "admin"
                },
                Role_id = 1,
                Name = "admin",
                Email = "admin@admin.com",
                Password = "admin",
                Created_at = DateTime.Now

            });
        }
    }
}
