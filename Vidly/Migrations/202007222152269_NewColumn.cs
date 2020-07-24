namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewColumn : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name='Pay As You go' WHERE Id=1");
            Sql("UPDATE MembershipTypes SET Name='daily' WHERE Id=2");
            Sql("UPDATE MembershipTypes SET Name='Monthly' WHERE Id=3");
            Sql("UPDATE MembershipTypes SET Name='Weekly' WHERE Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
