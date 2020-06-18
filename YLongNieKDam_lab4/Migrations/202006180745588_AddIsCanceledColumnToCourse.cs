namespace YLongNieKDam_lab4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsCanceledColumnToCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "IsCanceId", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "IsCanceId");
        }
    }
}
