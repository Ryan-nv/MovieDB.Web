using Serenity.ComponentModel;
using System.ComponentModel;

namespace MovieDB.MovieData {
    [EnumKey("MovieData.Gender")]
    public enum Gender {
        [Description("Male")] Male = 1,
        [Description("Female")] Female = 2
        
    }
}