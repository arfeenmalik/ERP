
namespace ERP.test.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("test.Person")]
    [BasedOnRow(typeof(Entities.PersonRow), CheckNames = true)]
    public class PersonForm
    {
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public String Birthplace { get; set; }
        public Int32 Gender { get; set; }
        public Int32 Height { get; set; }
    }
}