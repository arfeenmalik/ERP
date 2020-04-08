
namespace ERP.test.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("test.Person")]
    [BasedOnRow(typeof(Entities.PersonRow), CheckNames = true)]
    public class PersonColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Personid { get; set; }
        [EditLink]
        public string Fullname { get; set; }
        public DateTime Birthdate { get; set; }
        public String Birthplace { get; set; }
        public Int32 Gender { get; set; }
        public Int32 Height { get; set; }
    }
}