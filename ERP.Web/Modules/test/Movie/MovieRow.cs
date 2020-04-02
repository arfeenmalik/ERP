
namespace ERP.test.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using ERP.Administration;

    [ConnectionKey("Default"), Module("test"), TableName("[MOV].[MOVIE]")]
    [DisplayName("Movie"), InstanceName("Movie")]
    [ReadPermission(PermissionKeys.MovieRead)]
    [InsertPermission(PermissionKeys.MovieInsert)]
    [UpdatePermission(PermissionKeys.MovieUpdate)]
    [DeletePermission(PermissionKeys.MovieDelete)]
	[LookupScript(nameof(MovieRow))]
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        [DisplayName("Movieid"), Column("MOVIEID"), Size(10), NotNull]
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
        }
    }
}
