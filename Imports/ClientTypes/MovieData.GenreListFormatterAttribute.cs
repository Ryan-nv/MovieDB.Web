using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace MovieDB.MovieData
{
    public partial class GenreListFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "MovieDB.MovieData.GenreListFormatter";

        public GenreListFormatterAttribute()
            : base(Key)
        {
        }
    }
}
