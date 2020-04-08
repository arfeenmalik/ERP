
namespace ERP.test.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using ERP.Administration;

    [ConnectionKey("Default"), Module("test"), TableName("[MOV].[MOVIEGENRES]")]
    [DisplayName("Moviegenres"), InstanceName("Moviegenres")]
    [ReadPermission(PermissionKeys.MoviegenresRead)]
    [InsertPermission(PermissionKeys.MoviegenresInsert)]
    [UpdatePermission(PermissionKeys.MoviegenresUpdate)]
    [DeletePermission(PermissionKeys.MoviegenresDelete)]
	[LookupScript(nameof(MoviegenresRow))]
    public sealed class MoviegenresRow : Row, IIdRow
    {
        [DisplayName("Moviegenreid"), Column("MOVIEGENREID"), Size(10),Identity]
        public Int32? Moviegenreid
        {
            get { return Fields.Moviegenreid[this]; }
            set { Fields.Moviegenreid[this] = value; }
        }

        [DisplayName("Movieid"), Column("MOVIEID"), Size(10), NotNull, ForeignKey("[MOV].[MOVIE]", "MOVIEID"), LeftJoin("jMovieid"), TextualField("MovieidTitle")]
        public Int32? Movieid
        {
            get { return Fields.Movieid[this]; }
            set { Fields.Movieid[this] = value; }
        }

        [DisplayName("Genreid"), Column("GENREID"), Size(10), NotNull, ForeignKey("[MOV].[GENRE]", "GENREID"), LeftJoin("jGenreid"), TextualField("GenreidName")]
        public Int32? Genreid
        {
            get { return Fields.Genreid[this]; }
            set { Fields.Genreid[this] = value; }
        }

        [DisplayName("Movieid Title"), Expression("jMovieid.[TITLE]")]
        public String MovieidTitle
        {
            get { return Fields.MovieidTitle[this]; }
            set { Fields.MovieidTitle[this] = value; }
        }

        [DisplayName("Movieid Description"), Expression("jMovieid.[DESCRIPTION]")]
        public String MovieidDescription
        {
            get { return Fields.MovieidDescription[this]; }
            set { Fields.MovieidDescription[this] = value; }
        }

        [DisplayName("Movieid Storyline"), Expression("jMovieid.[STORYLINE]")]
        public String MovieidStoryline
        {
            get { return Fields.MovieidStoryline[this]; }
            set { Fields.MovieidStoryline[this] = value; }
        }

        [DisplayName("Movieid Year"), Expression("jMovieid.[YEAR]")]
        public Int32? MovieidYear
        {
            get { return Fields.MovieidYear[this]; }
            set { Fields.MovieidYear[this] = value; }
        }

        [DisplayName("Movieid Releasedate"), Expression("jMovieid.[RELEASEDATE]")]
        public DateTime? MovieidReleasedate
        {
            get { return Fields.MovieidReleasedate[this]; }
            set { Fields.MovieidReleasedate[this] = value; }
        }

        [DisplayName("Movieid Runtime"), Expression("jMovieid.[RUNTIME]")]
        public Int32? MovieidRuntime
        {
            get { return Fields.MovieidRuntime[this]; }
            set { Fields.MovieidRuntime[this] = value; }
        }

        [DisplayName("Movieid Kind"), Expression("jMovieid.[KIND]")]
        public Int32? MovieidKind
        {
            get { return Fields.MovieidKind[this]; }
            set { Fields.MovieidKind[this] = value; }
        }

        [DisplayName("Genreid Name"), Expression("jGenreid.[NAME]")]
        public String GenreidName
        {
            get { return Fields.GenreidName[this]; }
            set { Fields.GenreidName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Moviegenreid; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MoviegenresRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Moviegenreid;
            public Int32Field Movieid;
            public Int32Field Genreid;

            public StringField MovieidTitle;
            public StringField MovieidDescription;
            public StringField MovieidStoryline;
            public Int32Field MovieidYear;
            public DateTimeField MovieidReleasedate;
            public Int32Field MovieidRuntime;
            public Int32Field MovieidKind;

            public StringField GenreidName;
        }
    }
}
