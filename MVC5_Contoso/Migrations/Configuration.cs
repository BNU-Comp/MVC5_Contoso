namespace MVC5_Contoso.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC5_Contoso.Data.UniversityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MVC5_Contoso.Data.UniversityContext";
        }

        protected override void Seed(MVC5_Contoso.Data.UniversityContext context)
        {

        }
    }
}
