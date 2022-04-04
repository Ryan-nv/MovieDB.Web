using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace MovieDB.MovieData.Columns
{
    [ColumnsScript("MovieData.Movie")]
    [BasedOnRow(typeof(MovieRow), CheckNames = true)]
    public class MovieColumns
    {
        //this script manages collumn view in MovieData page
        [EditLink, DisplayName("Db.Shared.RecordId"), Width(15), AlignCenter]
        public int MovieId { get; set; }
        [EditLink, AlignCenter]
        public string Title { get; set; }
        [EditLink, Width(250)]
        public string Description { get; set; }
        [EditLink, Width(300)]
        public string Storyline { get; set; }
        public int Year { get; set; }
        public DateTime ReleaseDate { get; set; }
        [EditLink, DisplayName("Runtime in Minutes"), Width(150), AlignCenter]
        public int Runtime { get; set; }
        [EditLink, Width(200), GenreListFormatter]
        public List<Int32> Genres { get; set; }
        [EditLink, Width(100)]
        public MovieKind Kind { get; set; }
    }
}