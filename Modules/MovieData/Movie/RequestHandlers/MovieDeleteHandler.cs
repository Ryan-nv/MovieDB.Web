﻿using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MovieDB.MovieData.MovieRow;

namespace MovieDB.MovieData
{
    public interface IMovieDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMovieDeleteHandler
    {
        public MovieDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}