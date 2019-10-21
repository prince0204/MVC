namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false, maxLength: 255));
            Sql("UPDATE MembershipTypes SET Name = 'Pay as You Go' where Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' where Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly' where Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Yearly' where Id = 4");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
