using FluentMigrator;
using Serenity.Extensions;

namespace MovieDB.Migrations.DefaultDB
{
    [Migration(20220404_173556)]
    public class DefaultDB_20220404_173556_MovieKind : Migration
    {
        public override void Up()
        {
            Alter.Table("Movie")
            .AddColumn("Kind").AsInt32().NotNullable().WithDefaultValue(1);
        }
        public override void Down() {}
    }
}  