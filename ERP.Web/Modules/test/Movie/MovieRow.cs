
namespace ERP.test.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using ERP.Administration;
    using System.Collections.Generic;

    [ConnectionKey("Default"), Module("test"), TableName("[MOV].[MOVIE]")]
    [DisplayName("Movie"), InstanceName("Movie")]
    [ReadPermission(PermissionKeys.MovieRead)]
    [InsertPermission(PermissionKeys.MovieInsert)]
    [UpdatePermission(PermissionKeys.MovieUpdate)]
    [DeletePermission(PermissionKeys.MovieDelete)]
	[LookupScript(nameof(MovieRow))]

    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        [DisplayName("Movieid"), Column("MOVIEID"), Size(10), PrimaryKey]
        public Int32? Movieid
        {
            get { return Fields.Movieid[this]; }
            set { Fields.Movieid[this] = value; }
        }

        [DisplayName("Title"), Column("TITLE"), Size(200), NotNull, QuickSearch]
        public String Title
        {
            get { return Fields.Title[this]; }
            set { Fields.Title[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(1000),QuickSearch]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Storyline"), Column("STORYLINE"),QuickSearch]
        public String Storyline
        {
            get { return Fields.Storyline[this]; }
            set { Fields.Storyline[this] = value; }
        }

        [DisplayName("Year"), Column("YEAR"), Size(10),QuickSearch(SearchType.Equals,numericOnly:1)]
        public Int32? Year
        {
            get { return Fields.Year[this]; }
            set { Fields.Year[this] = value; }
        }

        [DisplayName("Releasedate"), Column("RELEASEDATE"), Scale(4)]
        public DateTime? Releasedate
        {
            get { return Fields.Releasedate[this]; }
            set { Fields.Releasedate[this] = value; }
        }

        [DisplayName("Runtime"), Column("RUNTIME"), Size(10)]
        public Int32? Runtime
        {
            get { return Fields.Runtime[this]; }
            set { Fields.Runtime[this] = value; }
        }

        [DisplayName("Kind"), Column("KIND"),DefaultValue(MovieKind.Film)]
        public MovieKind? Kind
        {
            get { return (MovieKind?)Fields.Kind[this]; }
            set { Fields.Kind[this] = (Int32?)value; }
        }
        [DisplayName("Genres")]
        [LookupEditor(typeof(GenreRow), Multiple = true), NotMapped]
        [LinkingSetRelation(typeof(MoviegenresRow), "MovieId", "GenreId")]
        public List<Int32> GenreList
        {
            get { return Fields.GenreList[this]; }
            set { Fields.GenreList[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Movieid; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Title; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MovieRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Movieid;
            public StringField Title;
            public StringField Description;
            public StringField Storyline;
            public Int32Field Year;
            public DateTimeField Releasedate;
            public Int32Field Runtime;
            public Int32Field Kind;
            public ListField<Int32> GenreList;



        }
    }
}
