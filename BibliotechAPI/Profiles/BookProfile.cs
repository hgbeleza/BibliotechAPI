using AutoMapper;
using BibliotechAPI.Data.Dto;
using BibliotechAPI.Models;

namespace BibliotechAPI.Profiles;

public class BookProfile : Profile
{
    public BookProfile()
    {
        CreateMap<CreateBookDto, Book>();
        CreateMap<UpdateBookDto, Book>();
    }
}
