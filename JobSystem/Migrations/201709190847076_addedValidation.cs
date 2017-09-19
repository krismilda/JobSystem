namespace JobSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Jobs", "Work", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Jobs", "Field", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Jobs", "Locality", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Jobs", "Duration", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Jobs", "Duration", c => c.String());
            AlterColumn("dbo.Jobs", "Locality", c => c.String());
            AlterColumn("dbo.Jobs", "Field", c => c.String());
            AlterColumn("dbo.Jobs", "Work", c => c.String());
        }
    }
}
