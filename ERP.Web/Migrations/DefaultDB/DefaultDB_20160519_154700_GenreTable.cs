using FluentMigrator;
using System;

namespace ERP.Migrations.DefaultDB
{
    [Migration(20160519154700)]
    public class DefaultDB_20160519_154700_GenreTable : Migration
    {
        public override void Up()
        {
            this.CreateTableWithId32("Genre", "GenreId", s => s
               .WithColumn("Name").AsString(100).NotNullable());

           
            Alter.Table("Movie").InSchema("mov")
                .AddColumn("GenreId").AsInt32().Nullable()
                    .ForeignKey("FK_Movie_GenreId", "mov", "Genre", "GenreId");
        }

        public override void Down()
        {
        }
    }
}