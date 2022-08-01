namespace VideoUploadInMVC_UsingJQueryAlso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VideoFiles", "FileName", c => c.String());
            DropColumn("dbo.VideoFiles", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VideoFiles", "Name", c => c.String());
            DropColumn("dbo.VideoFiles", "FileName");
        }
    }
}
