using Serenity.ComponentModel;
using System.ComponentModel;

namespace ERP.test
{
    [EnumKey("test.Gender")]
    public enum Gender
    {
        [Description("Male")]
        Male = 1,
        [Description("Female")]
        Female = 2
    }
}