using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieDB.MovieData.PersonRow>;
using MyRow = MovieDB.MovieData.PersonRow;

namespace MovieDB.MovieData
{
    public interface IPersonListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class PersonListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPersonListHandler
    {
        public PersonListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}