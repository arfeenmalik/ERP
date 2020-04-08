
namespace ERP.test.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("test.Moviecast")]
    [BasedOnRow(typeof(Entities.MoviecastRow), CheckNames = true)]
    public class MoviecastForm
    {
        public Int32 Personid { get; set; }
        public String Character { get; set; }
    }
}