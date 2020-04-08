
namespace ERP.test.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("test.Moviecast")]
    [BasedOnRow(typeof(Entities.MoviecastRow), CheckNames = true)]
    public class MoviecastColumns
    {
        //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        //public Int32 Moviecastid { get; set; }
        ///public String MovieidTitle { get; set; }
        ///
        [EditLink]
        public String PersonFullname { get; set; }
        [EditLink]
        public String Character { get; set; }
    }
}