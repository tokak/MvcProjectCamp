namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_deleteDraftClass : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Drafts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Drafts",
                c => new
                    {
                        DraftID = c.Int(nullable: false, identity: true),
                        SenderMail = c.String(maxLength: 100),
                        ReceiverMail = c.String(maxLength: 100),
                        Subject = c.String(maxLength: 250),
                        MessageContent = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DraftID);
            
        }
    }
}
