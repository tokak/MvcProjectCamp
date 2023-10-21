namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_AddPropWriterImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterImage2", c => c.String(maxLength: 550));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WriterImage2");
        }
    }
}
