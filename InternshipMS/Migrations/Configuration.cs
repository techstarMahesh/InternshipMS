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
            context.users.AddOrUpdate(x => x.name, new Models.user
            {
                role = new Models.role
                {
                    name = "admin"
                },
                role_id = 1,
                name = "admin",
                email = "admin@admin.com",
                password = "admin",
                created_at = DateTime.Now

            });
        }
    }
}
