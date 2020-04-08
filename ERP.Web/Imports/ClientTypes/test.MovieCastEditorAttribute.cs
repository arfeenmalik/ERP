using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace ERP.test
{
    public partial class MovieCastEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "ERP.test.MovieCastEditor";

        public MovieCastEditorAttribute()
            : base(Key)
        {
        }
    }
}
