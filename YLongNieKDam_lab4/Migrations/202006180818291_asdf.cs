namespace YLongNieKDam_lab4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "IsCanceled", c => c.Boolean(nullable: false));
            DropColumn("dbo.Courses", "IsCanceId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "IsCanceId", c => c.Boolean(nullable: false));
            DropColumn("dbo.Courses", "IsCanceled");
        }
    }
}
