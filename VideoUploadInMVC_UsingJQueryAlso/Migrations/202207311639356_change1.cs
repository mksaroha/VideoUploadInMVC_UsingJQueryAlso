namespace VideoUploadInMVC_UsingJQueryAlso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.VideoFiles", "FileSize", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.VideoFiles", "FileSize", c => c.Byte(nullable: false));
        }
    }
}
