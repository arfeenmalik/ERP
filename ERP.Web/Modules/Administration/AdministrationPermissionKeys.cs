
using Serenity.Extensibility;
using System.ComponentModel;

namespace ERP.Administration
{
    [NestedPermissionKeys]
    [DisplayName("Administration")]
    public partial class PermissionKeys
    {
        [Description("User, Role Management and Permissions")]
        public const string Security = "Administration:Security";

        [Description("Languages and Translations")]
        public const string Translation = "Administration:Translation";
    }
}
