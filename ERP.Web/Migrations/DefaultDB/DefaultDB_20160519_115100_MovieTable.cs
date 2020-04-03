using FluentMigrator;
using System;

namespace ERP.Migrations.DefaultDB
{
    [Migration(20160519115117)]
    public class DefaultDB_20160519_115100_MovieTable : Migration
    {
        public override void Up()
        {
            this.CreateTableWithId32("Movie", "MovieId", s => s
               .WithColumn("Title").AsString(200).NotNullable()
               .WithColumn("Description").AsString(1000).Nullable()
               .WithColumn("Storyline").AsString(Int32.MaxValue).Nullable()
               .WithColumn("Year").AsInt32().Nullable()
               .WithColumn("ReleaseDate").AsDateTime().Nullable()
               .WithColumn("Runtime").AsInt32().Nullable());
        }

        public override void Down()
        {
        }
    }



}