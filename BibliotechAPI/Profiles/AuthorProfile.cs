using AutoMapper;
using BibliotechAPI.Models;

namespace BibliotechAPI.Profiles;

public class AuthorProfile : Profile
{
    public AuthorProfile()
    {
        CreateMap<CreateAuthorDto, Author>();
        CreateMap<UpdateAuthorDto, Author>();
    }
}