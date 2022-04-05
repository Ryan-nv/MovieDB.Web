using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace MovieDB.MovieData.Columns
{
    [ColumnsScript("MovieData.MovieCast")]
    [BasedOnRow(typeof(MovieCastRow))]
    public class MovieCastColumns
    {
        //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight] public int MovieCastId { get; set; }
        //public String MovieTitle { get; set; }
        [EditLink, Width(200), AlignRight] public String PersonFullName { get; set; }
        [EditLink, Width(200), AlignRight] string Character { get; set; }
    }
}