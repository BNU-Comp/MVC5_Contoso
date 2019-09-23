namespace MVC5_Contoso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnnotateEntities : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Title", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "Title", c => c.String());
        }
    }
}
