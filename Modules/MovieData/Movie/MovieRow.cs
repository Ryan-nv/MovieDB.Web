using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace MovieDB.MovieData
{
    [ConnectionKey("Default"), Module("MovieData"), TableName("Movie")]
    [DisplayName("Movie"), InstanceName("Movie")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("MovieDB.MovieData")]
    public sealed class MovieRow : Row<MovieRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Movie Id"), Identity, IdProperty]
        public int? MovieId
        {
            get => fields.MovieId[this];
            set => fields.MovieId[this] = value;
        }

        [DisplayName("Title"), Size(200), NotNull, QuickSearch, NameProperty]
        public string Title
        {
            get => fields.Title[this];
            set => fields.Title[this] = value;
        }

        [DisplayName("Description"), Size(1000), QuickSearch]
        public string Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        [DisplayName("Storyline"), Size(1500), QuickSearch(SearchType.StartsWith)]
        public string Storyline
        {
            get => fields.Storyline[this];
            set => fields.Storyline[this] = value;
        }

        [DisplayName("Year"), QuickSearch(SearchType.Equals, numericOnly: 1)]
        public int? Year
        {
            get => fields.Year[this];
            set => fields.Year[this] = value;
        }

        [DisplayName("Release Date")]
        public DateTime? ReleaseDate
        {
            get => fields.ReleaseDate[this];
            set => fields.ReleaseDate[this] = value;
        }

        [DisplayName("Runtime")]
        public int? Runtime
        {
            get => fields.Runtime[this];
            set => fields.Runtime[this] = value;
        }

        [DisplayName("Kind"), NotNull, QuickSearch]
        public int? Kind
        {
            get => fields.Kind[this];
            set => fields.Kind[this] = value;
        }
        [DisplayName("Genres"), QuickFilter]
        [LookupEditor(typeof(GenreRow), Multiple = true, InplaceAdd = true), NotMapped]
        [LinkingSetRelation(typeof(MovieGenresRow), "MovieId", "GenreId")]
        public List<Int32> Genres
        {
            get => fields.Genres[this];
            set => fields.Genres[this] = value;
        }
        [MasterDetailRelation(foreignKey: "MovieId", IncludeColumns = "PersonFullName")]
        [DisplayName("Actor/Actress")]
        public List<MovieCastRow> CastList
        {
            get => fields.CastList[this];
            set => fields.CastList[this] = value;
        }
        [DisplayName("Primary image"), ImageUploadEditor(FilenameFormat = "Movie/PrimaryImage/~")]
        public string Primary_Image
        {
            get => fields.Primary_Image[this];
            set => fields.Primary_Image[this] = value;
        }
        [DisplayName("Gallery Image"), MultipleImageUploadEditor(FilenameFormat = "Movie/GalleryImage/~")]
        public string Galery_Image
        {
            get => fields.Galery_Image[this];
            set => fields.Galery_Image[this] = value;
        }

        public MovieRow()
            : base()
        {
        }

        public MovieRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MovieId;
            public StringField Title;
            public StringField Description;
            public StringField Storyline;
            public Int32Field Year;
            public DateTimeField ReleaseDate;
            public Int32Field Runtime;
            public Int32Field Kind;
            public ListField<Int32> Genres;
            public RowListField<MovieCastRow> CastList;
            public StringField Primary_Image;
            public StringField Galery_Image;
        }
    }
}
