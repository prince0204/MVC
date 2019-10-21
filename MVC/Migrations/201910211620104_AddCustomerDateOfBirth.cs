namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerDateOfBirth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DateOfBirth", c => c.DateTime());
            Sql("Update Customers set DateOfBirth =" + DateTime.Parse("1997-04-20") + " where Id = 1");
            Sql("Update Customers set DateOfBirth ="  + DateTime.Parse("1997-08-20") + " where Id = 2");
            Sql("Update Customers set DateOfBirth =" + DateTime.Parse("1997-10-02") + " where Id = 3");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "DateOfBirth");
        }
    }
}
