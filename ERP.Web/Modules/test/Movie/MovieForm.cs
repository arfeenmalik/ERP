
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
        [MovieCastEditor,IgnoreName]
        public List<Entities.MoviecastRow> CastList { get; set; }

        public String Storyline { get; set; }
        public Int32 Year { get; set; }
        public DateTime Releasedate { get; set; }
        public MovieKind Kind { get; set; }
        public List<Int32> GenreList { get; set; }


        public Int32 Runtime { get; set; }
    }
}