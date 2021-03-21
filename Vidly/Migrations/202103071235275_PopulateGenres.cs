namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT Genres VALUES ('Action'), ('Thriller'), ('Family'), ('Romance'), ('Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
