
namespace ERP.test.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using ERP.Administration;

    [ConnectionKey("Default"), Module("test"), TableName("[MOV].[MOVIECAST]")]
    [DisplayName("Moviecast"), InstanceName("Moviecast")]
    [ReadPermission(PermissionKeys.MoviecastRead)]
    [InsertPermission(PermissionKeys.MoviecastInsert)]
    [UpdatePermission(PermissionKeys.MoviecastUpdate)]
    [DeletePermission(PermissionKeys.MoviecastDelete)]
	[LookupScript(nameof(MoviecastRow))]
    public sealed class MoviecastRow : Row, IIdRow, INameRow
    {
        [DisplayName("Moviecastid"), Column("MOVIECASTID"), Size(10), Identity]
        public Int32? Moviecastid
        {
            get { return Fields.Moviecastid[this]; }
            set { Fields.Moviecastid[this] = value; }
        }

        [DisplayName("Movieid"), Column("MOVIEID"), Size(10), NotNull, ForeignKey("[MOV].[MOVIE]", "MOVIEID"), LeftJoin("jMovieid"), TextualField("MovieidTitle")]
        public Int32? Movieid
        {
            get { return Fields.Movieid[this]; }
            set { Fields.Movieid[this] = value; }
        }


        //[DisplayName("Personid"), Column("PERSONID"), Size(10), NotNull, ForeignKey("[MOV].[PERSON]", "PERSONID"), LeftJoin("jPersonid"), TextualField("PersonidFirstname")]
        [DisplayName("Actor/Actress"), NotNull, ForeignKey("[mov].[Person]", "PersonId")]
        [LeftJoin("jPerson"), TextualField("PersonFirstname")]
        [LookupEditor(typeof(PersonRow))]
        public Int32? Personid
        {
            get { return Fields.Personid[this]; }
            set { Fields.Personid[this] = value; }
        }

        [DisplayName("Character"), Column("CHARACTER"), Size(50), QuickSearch]
        public String Character
        {
            get { return Fields.Character[this]; }
            set { Fields.Character[this] = value; }
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
        public string MovieidStoryline
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

        [DisplayName("Personid Firstname"), Expression("jPersonid.[FIRSTNAME]")]
        public String PersonidFirstname
        {
            get { return Fields.PersonidFirstname[this]; }
            set { Fields.PersonidFirstname[this] = value; }
        }

        [DisplayName("Personid Lastname"), Expression("jPersonid.[LASTNAME]")]
        public String PersonidLastname
        {
            get { return Fields.PersonidLastname[this]; }
            set { Fields.PersonidLastname[this] = value; }
        }

        [DisplayName("Actor/Actress"),
         Expression("(jPerson.Firstname || ' ' || jPerson.Lastname)")]
        public String PersonFullname
        {
            get { return Fields.PersonFullname[this]; }
            set { Fields.PersonFullname[this] = value; }
        }

        [DisplayName("Personid Birthdate"), Expression("jPersonid.[BIRTHDATE]")]
        public DateTime? PersonidBirthdate
        {
            get { return Fields.PersonidBirthdate[this]; }
            set { Fields.PersonidBirthdate[this] = value; }
        }

        [DisplayName("Personid Birthplace"), Expression("jPersonid.[BIRTHPLACE]")]
        public String PersonidBirthplace
        {
            get { return Fields.PersonidBirthplace[this]; }
            set { Fields.PersonidBirthplace[this] = value; }
        }

        [DisplayName("Personid Gender"), Expression("jPersonid.[GENDER]")]
        public Int32? PersonidGender
        {
            get { return Fields.PersonidGender[this]; }
            set { Fields.PersonidGender[this] = value; }
        }

        [DisplayName("Personid Height"), Expression("jPersonid.[HEIGHT]")]
        public Int32? PersonidHeight
        {
            get { return Fields.PersonidHeight[this]; }
            set { Fields.PersonidHeight[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Moviecastid; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Character; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MoviecastRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Moviecastid;
            public Int32Field Movieid;
            public Int32Field Personid;
            public StringField Character;

            public StringField MovieidTitle;
            public StringField MovieidDescription;
            public StringField MovieidStoryline;
            public Int32Field MovieidYear;
            public DateTimeField MovieidReleasedate;
            public Int32Field MovieidRuntime;
            public Int32Field MovieidKind;

            public StringField PersonidFirstname;
            public StringField PersonidLastname;
            public StringField PersonFullname;
            public DateTimeField PersonidBirthdate;
            public StringField PersonidBirthplace;
            public Int32Field PersonidGender;
            public Int32Field PersonidHeight;
        }
    }
}
