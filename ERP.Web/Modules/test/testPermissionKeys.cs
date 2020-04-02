using Serenity.Extensibility;
using System.ComponentModel;

namespace ERP.Administration
{
    public partial class PermissionKeys
    {
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