using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace MovieDB.MovieData.Forms
{
    [FormScript("MovieData.MovieCast")]
    [BasedOnRow(typeof(MovieCastRow), CheckNames = true)]
    public class MovieCastForm
    {
        public Int32 MovieId { get; set; }
        public Int32 PersonId { get; set; }
        public string Character { get; set; }
    }
}