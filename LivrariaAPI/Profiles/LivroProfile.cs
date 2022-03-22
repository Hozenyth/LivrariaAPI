using LivrariaAPI.Data.Dtos;
using AutoMapper;
using LivrariaAPI.Models;

namespace LivrariaAPI.Profiles
{
    public class LivroProfile :Profile
    {
        public LivroProfile() 
        {
            CreateMap<CreateLivroDto, Livro>();
            CreateMap<Livro, ReadLivroDto>();
            CreateMap<UpdateLivroDto, Livro>();
        }
    }
}
