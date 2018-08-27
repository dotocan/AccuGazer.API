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

            CreateMap<UserRegisterDto, User>();
            
            CreateMap<GazePointDto, GazePoint>().ReverseMap();
            CreateMap<RectangleDto, Rectangle>().ReverseMap();
            CreateMap<MeasurementDto, Measurement>().ReverseMap();
            CreateMap<TestResultDto, TestResult>().ReverseMap();
            CreateMap<TestDto, Test>().ReverseMap();
        }
    }
}