using System.ComponentModel;
using Serenity.ComponentModel;

namespace MovieDB.MovieData
{
    [EnumKey("MovieDB.MovieKind")]
    public enum MovieKind
    {
        [Description("Film")] Film = 1,
        [Description("TV Series")] TVSeries = 2,
        [Description("Mini Series")] MiniSeries = 3
    }
}
