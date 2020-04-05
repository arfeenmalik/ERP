
namespace ERP.test.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("test.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow), CheckNames = true)]
    public class MovieColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Movieid { get; set; }
        [EditLink]
        public String Title { get; set; }
        public String Description { get; set; }
        public Stream Storyline { get; set; }
        public Int32 Year { get; set; }
        public Stream Releasedate { get; set; }
        public Int32 Runtime { get; set; }

        public MovieKind Kind { get; set; }
    }
}