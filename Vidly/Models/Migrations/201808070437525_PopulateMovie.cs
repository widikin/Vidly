namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovie : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name,ReleaseDate,DateAdded,NumberInStock,GenreId) VALUES ('Hangover','2015/12/01','2018/07/13',12,4)");
            Sql("INSERT INTO Movies (Name,ReleaseDate,DateAdded,NumberInStock,GenreId) VALUES ('Die Hard','2010/07/04','2018/07/13',3,2)");
            Sql("INSERT INTO Movies (Name,ReleaseDate,DateAdded,NumberInStock,GenreId) VALUES ('The Terminator','2003/03/04','2018/07/13',5,2)");
            Sql("INSERT INTO Movies (Name,ReleaseDate,DateAdded,NumberInStock,GenreId) VALUES ('Toy Story','2009/09/06','2018/07/13',8,4)");
            Sql("INSERT INTO Movies (Name,ReleaseDate,DateAdded,NumberInStock,GenreId) VALUES ('Titanic','1997/09/08','2018/07/13',2,3)");
        }
        
        public override void Down()
        {
        }
    }
}
