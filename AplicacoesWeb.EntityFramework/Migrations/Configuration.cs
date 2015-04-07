namespace AplicacoesWeb.Migrations
{
    using AplicacoesWeb.People;
    using AplicacoesWeb.Tasks;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AplicacoesWeb.EntityFramework.AplicacoesWebDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AplicacoesWeb";
        }

        protected override void Seed(AplicacoesWeb.EntityFramework.AplicacoesWebDbContext context)
        {
            context.People.AddOrUpdate(
                        p => p.Name,
                        new Person { Name = "Isaac Asimov" },
                        new Person { Name = "Thomas More" },
                        new Person { Name = "George Orwell" },
                        new Person { Name = "Douglas Adams" }
                        );
        }
    }
}
