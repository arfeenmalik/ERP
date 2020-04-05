
namespace ERP.test.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using ERP.Administration;

    [ConnectionKey("Default"), Module("test"), TableName("[MOV].[GENRE]")]
    [DisplayName("Genre"), InstanceName("Genre")]
    [ReadPermission(PermissionKeys.GenreRead)]
    [InsertPermission(PermissionKeys.GenreInsert)]
    [UpdatePermission(PermissionKeys.GenreUpdate)]
    [DeletePermission(PermissionKeys.GenreDelete)]
	//[LookupScript(nameof(GenreRow))]
    [LookupScript("test.Genre")]

    public sealed class GenreRow : Row, IIdRow, INameRow
    {
        [DisplayName("Genreid"), Column("GENREID"), Size(10), PrimaryKey]
        public Int32? Genreid
        {
            get { return Fields.Genreid[this]; }
            set { Fields.Genreid[this] = value; }
        }

        [DisplayName("Name"), Column("NAME"), Size(100), NotNull, QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Genreid; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public GenreRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Genreid;
            public StringField Name;
        }
    }
}
