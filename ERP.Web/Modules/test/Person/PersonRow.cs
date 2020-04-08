
namespace ERP.test.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using ERP.Administration;

    [ConnectionKey("Default"), Module("test"), TableName("[MOV].[PERSON]")]
    [DisplayName("Person"), InstanceName("Person")]
    [ReadPermission(PermissionKeys.PersonRead)]
    [InsertPermission(PermissionKeys.PersonInsert)]
    [UpdatePermission(PermissionKeys.PersonUpdate)]
    [DeletePermission(PermissionKeys.PersonDelete)]
	[LookupScript(nameof(PersonRow))]
    public sealed class PersonRow : Row, IIdRow, INameRow
    {
        [DisplayName("Personid"), Column("PERSONID"), Size(10), Identity]
        public Int32? Personid
        {
            get { return Fields.Personid[this]; }
            set { Fields.Personid[this] = value; }
        }

        [DisplayName("Firstname"), Column("FIRSTNAME"), Size(50), NotNull]
        public String Firstname
        {
            get { return Fields.Firstname[this]; }
            set { Fields.Firstname[this] = value; }
        }

        [DisplayName("Lastname"), Column("LASTNAME"), Size(50), NotNull]
        public String Lastname
        {
            get { return Fields.Lastname[this]; }
            set { Fields.Lastname[this] = value; }
        }

        [DisplayName("Full Name"), QuickSearch,
        Expression("CONCAT(T0.[Firstname], CONCAT(' ', T0.[Lastname]))")]

        public String Fullname
        {
            get { return Fields.Fullname[this]; }
            set { Fields.Fullname[this] = value; }
        }

        [DisplayName("Birthdate"), Column("BIRTHDATE"), Scale(4)]
        public DateTime? Birthdate
        {
            get { return Fields.Birthdate[this]; }
            set { Fields.Birthdate[this] = value; }
        }

        [DisplayName("Birthplace"), Column("BIRTHPLACE"), Size(100)]
        public String Birthplace
        {
            get { return Fields.Birthplace[this]; }
            set { Fields.Birthplace[this] = value; }
        }

        
        [DisplayName("Gender")]
        public Gender? Gender
        {
            get { return (Gender?)Fields.Gender[this]; }
            set { Fields.Gender[this] = (Int32?)value; }
        }

        [DisplayName("Height"), Column("HEIGHT"), Size(10)]
        public Int32? Height
        {
            get { return Fields.Height[this]; }
            set { Fields.Height[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Personid; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Fullname; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PersonRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Personid;
            public StringField Firstname;
            public StringField Lastname;
            public StringField Fullname;
            public DateTimeField Birthdate;
            public StringField Birthplace;
            public Int32Field Gender;
            public Int32Field Height;

        }
    }
}
