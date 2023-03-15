using AutoMapper;
using MyWebApiNetCore6.Data;
using MyWebApiNetCore6.Models;

namespace MyWebApiNetCore6.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Book,BookModel>().ReverseMap();
        }
    }
}
