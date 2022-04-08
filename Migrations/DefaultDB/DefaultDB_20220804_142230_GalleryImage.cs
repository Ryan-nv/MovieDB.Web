using FluentMigrator;
using System; 
using FluentMigrator.Oracle;
using Serenity.Extensions;

namespace MovieDB.Migrations.DefaultDB
{
    [Migration(20220804_142230)]
    public class DefaultDB_20220804_142230_GalleryImage : Migration
    {
        public override void Up()
        {
            Alter.Table("Person")
            .AddColumn("Primary_Image").AsString(100).Nullable()
            .AddColumn("Galery_Image").AsString(int.MaxValue).Nullable();

            Alter.Table("Movie")
            .AddColumn("Primary_Image").AsString(100).Nullable()
            .AddColumn("Galery_Image").AsString(int.MaxValue).Nullable(); 
        }
        public override void Down() {}
    }
}  