using FluentMigrator;
using FluentMigrator.Oracle;
using Serenity.Extensions;

namespace MovieDB.Migrations.DefaultDB
{
    [Migration(20220404_233450)]
    public class DefaultDB_20220404_233450_MovieGenres : Migration
    {
        public override void Up()
        {
            Create.Table("MovieGenres")
                .WithColumn("MovieGenreId").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("MovieId").AsInt32().NotNullable()
                    .ForeignKey("FK_MovieGenres_MovieId", "Movie", "MovieId")
                .WithColumn("GenreId").AsInt32().NotNullable()
                    .ForeignKey("FK_MovieGenres_GenreId", "Genre", "GenreId");

            Execute.Sql(
            @"INSERT INTO MovieGenres (MovieId, GenreId) 
                    SELECT m.MovieId, m.Genre
                    FROM Movie m 
                    WHERE m.Genre IS NOT NULL");

            Delete.ForeignKey("FK_Movie_GenreId").OnTable("Movie");
            Delete.Column("Genre").FromTable("Movie");
        }
        public override void Down() {}
    }
}  