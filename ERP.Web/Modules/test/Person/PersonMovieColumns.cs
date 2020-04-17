
namespace ERP.test.Columns
{
    using Serenity.ComponentModel;
    using System;

    [ColumnsScript("test.PersonMovie")]    
    [BasedOnRow(typeof(Entities.MoviecastRow))]
    public class PersonMovieColumns
    {
        [Width(220)]
        public String MovieidTitle { get; set; }
        [Width(100)]
        public Int32 MovieidYear { get; set; }
        [Width(200)]
        public String Character { get; set; }
    }
}