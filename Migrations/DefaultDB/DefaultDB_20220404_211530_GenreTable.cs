using FluentMigrator;
using FluentMigrator.Oracle;
using Serenity.Extensions;

namespace MovieDB.Migrations.DefaultDB
{
    [Migration(20220404_211530)]
    public class DefaultDB_20220404_211530_GenreTable : Migration
    {
        public override void Up()
        {
            Create.Table("Genre")
            .WithColumn("GenreId").AsInt32().NotNullable().PrimaryKey().Identity()
            .WithColumn("Name").AsString(50).NotNullable();

            Alter.Table("Movie")
            .AddColumn("Genre").AsInt32().Nullable()
            .ForeignKey("FK_Movie_GenreId","Genre","GenreId");
        }
        public override void Down() {}
    }
}  