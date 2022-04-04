using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace MovieDB.MovieData.Forms
{
    [FormScript("MovieData.Movie")]
    [BasedOnRow(typeof(MovieRow), CheckNames = true)]
    public class MovieForm
    {
        public string Title { get; set; }
        //configure textarea row
        [TextAreaEditor(Rows = 3)] public string Description { get; set; }
        [TextAreaEditor(Rows = 8)] public string Storyline { get; set; }
        public int Year { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Runtime { get; set; }
        public List<Int32> Genres { get; set; }
        public MovieKind Kind { get; set; }
    }
}