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
        //[MovieCastEditor] public List<MovieCastRow> CastList { get; set; }

        /// <summary>
        /// The commented line abouve supposed to show in memory detail editor of cast list of movie cast table
        /// but on this version of serene template doesn't work as supposed in the older version of serene templates
        /// So I changed the in memory detail editor with normal form of cast list. 
        /// </summary>
        [TextAreaEditor(Rows = 8)] public string Storyline { get; set; }
        public int Year { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Runtime { get; set; }
        public List<Int32> Genres { get; set; }
        public MovieKind Kind { get; set; }
    }
}