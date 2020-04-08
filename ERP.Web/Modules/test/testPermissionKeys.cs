using Serenity.Extensibility;
using System.ComponentModel;

namespace ERP.Administration
{
    public partial class PermissionKeys
    {
            [Description("Read")]
            public const string PersonRead = "test:Person:PersonRead";
            [Description("Insert")]
            public const string PersonInsert = "test:Person:PersonInsert";
            [Description("Update")]
            public const string PersonUpdate = "test:Person:PersonUpdate";
            [Description("Delete")]
            public const string PersonDelete = "test:Person:PersonDelete";
            [Description("Read")]
            public const string MoviegenresRead = "test:Moviegenres:MoviegenresRead";
            [Description("Insert")]
            public const string MoviegenresInsert = "test:Moviegenres:MoviegenresInsert";
            [Description("Update")]
            public const string MoviegenresUpdate = "test:Moviegenres:MoviegenresUpdate";
            [Description("Delete")]
            public const string MoviegenresDelete = "test:Moviegenres:MoviegenresDelete";
            [Description("Read")]
            public const string GenreRead = "test:Genre:GenreRead";
            [Description("Insert")]
            public const string GenreInsert = "test:Genre:GenreInsert";
            [Description("Update")]
            public const string GenreUpdate = "test:Genre:GenreUpdate";
            [Description("Delete")]
            public const string GenreDelete = "test:Genre:GenreDelete";
            [Description("Read")]
            public const string MovieRead = "test:Movie:MovieRead";
            [Description("Insert")]
            public const string MovieInsert = "test:Movie:MovieInsert";
            [Description("Update")]
            public const string MovieUpdate = "test:Movie:MovieUpdate";
            [Description("Delete")]
            public const string MovieDelete = "test:Movie:MovieDelete";
    }
}