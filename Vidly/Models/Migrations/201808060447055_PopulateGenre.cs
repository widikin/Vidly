namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Name) VALUES('Comedy')");
            Sql("INSERT INTO Genres(Name) VALUES('Action')");
            Sql("INSERT INTO Genres(Name) VALUES('Romance')");
            Sql("INSERT INTO Genres(Name) VALUES('Kids')");
        }
        
        public override void Down()
        {
        }
    }
}
