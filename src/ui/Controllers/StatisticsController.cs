using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StatsParser;

namespace ui.Controllers
{
    [Route("api/[controller]")]
    public class StatisticsController : Controller
    {
        public IConfiguration Configuration { get; set; }
        public StatisticsController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet("[action]")]
        public IEnumerable<StatsEntry> PlayerStatistics()
        {
            var filePath = Configuration["StatsFilePath"];
            var entries = StatsFile.ReadEntries(filePath);
            return entries;
        }
    }
}
