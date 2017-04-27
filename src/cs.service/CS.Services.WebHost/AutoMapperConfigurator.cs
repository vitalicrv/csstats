using AutoMapper;
using AutoMapper.Configuration;

namespace CS.Service.WebHost
{
    public class AutoMapperConfigurator
    {
        public IMapper Initialize()
        {
            var config = ConfigureAutomapper();
            return config.CreateMapper();
        }

        private IConfigurationProvider ConfigureAutomapper()
        {
            var cfg = new MapperConfigurationExpression();
            cfg.AddProfiles(AssemblyScanner.GetServiceAssemblies());

            return new MapperConfiguration(cfg);
        }
    }
}