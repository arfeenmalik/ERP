using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace ERP.test
{
    public partial class GenreListFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "ERP.test.GenreListFormatter";

        public GenreListFormatterAttribute()
            : base(Key)
        {
        }
    }
}
