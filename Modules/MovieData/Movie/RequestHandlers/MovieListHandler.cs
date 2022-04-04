using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieDB.MovieData.MovieRow>;
using MyRow = MovieDB.MovieData.MovieRow;

namespace MovieDB.MovieData
{
    public interface IMovieListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieListHandler
    {
        public MovieListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}