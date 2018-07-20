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
            CreateMap<GazePointDto, GazePoint>();
            CreateMap<RectangleDto, Rectangle>();
            CreateMap<MeasurementDto, Measurement>();
            CreateMap<TestResultDto, TestResult>();
            CreateMap<TestForSaveDto, Test>();
        }
    }
}