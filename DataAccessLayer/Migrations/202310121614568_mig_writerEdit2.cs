namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writerEdit2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 250));
            AlterColumn("dbo.Writers", "About", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "About", c => c.String(maxLength: 200));
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 150));
        }
    }
}
