namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Movies(Name, GenreId) Values('John Wick Chapter 1',2)");
            Sql("Insert into Movies(Name, GenreId) Values('John Wick Chapter 2',2)");
            Sql("Insert into Movies(Name, GenreId) Values('John Wick Chapter 3',2)");
            Sql("Insert into Movies(Name, GenreId) Values('Shrek',1)");
            Sql("Insert into Movies(Name, GenreId) Values('Toy Story',3)");
            Sql("Insert into Movies(Name, GenreId) Values('Titanic',4)");

        }
        
        public override void Down()
        {
        }
    }
}
