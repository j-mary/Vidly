namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (2, 'Comedy')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (5, 'Adventure')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (6, 'Crime')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (7, 'Horror')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (8, 'Sci-Fi')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (9, 'Drama')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (10, 'Historical')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (11, 'Documentry')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (12, 'Thriller')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (13, 'Urban')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (14, 'Western')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (15, 'Animation')");
        }
        
        public override void Down()
        {
        }
    }
}
