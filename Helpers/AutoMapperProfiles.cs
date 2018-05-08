using AccuGazer.API.Dtos;
using AccuGazer.API.Models;
using AutoMapper;

namespace AccuGazer.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Settings, SettingsDto>();
        }
    }
}