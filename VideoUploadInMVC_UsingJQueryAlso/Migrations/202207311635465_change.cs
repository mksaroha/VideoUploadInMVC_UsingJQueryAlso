namespace VideoUploadInMVC_UsingJQueryAlso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.VideoFiles", "FileSize", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.VideoFiles", "FileSize", c => c.Int());
        }
    }
}
