
namespace ERP.test.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("test.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow), CheckNames = true)]
    public class MovieForm
    {
        public String Title { get; set; }
        public String Description { get; set; }
        public Stream Storyline { get; set; }
        public Int32 Year { get; set; }
        public Stream Releasedate { get; set; }
        public Int32 Runtime { get; set; }
    }
}