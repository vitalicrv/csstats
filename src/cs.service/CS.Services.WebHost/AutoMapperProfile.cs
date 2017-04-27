using AutoMapper;

namespace CS.Service.WebHost
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Data.Statistics, Models.StatisticsEntry>();
            CreateMap<Models.StatisticsEntry, Data.Statistics>();
        }
    }
}