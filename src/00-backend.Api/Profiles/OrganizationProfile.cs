using AutoMapper;
using backend.Api.Models;
using backend.Domain.Entities;

namespace backend.Api.Profiles
{
    public class OrganizationProfile : Profile
    {
        public OrganizationProfile()
        {
            CreateMap<PersonModel, Person>();
            CreateMap<PersonCreateModel, Person>();
            CreateMap<Person, PersonModel>();
        }   
    }
}