using Microsoft.AspNetCore.Mvc;
using StatsParser;

namespace cs.shell.Controllers
{
    public class HomeController : Controller
    {
        const string Filename = "D:\\projects\\csstats\\data\\csstats.dat";

        public IActionResult Index()
        {
            var entries = StatsFile.ReadEntries(Filename);
            return View(entries);
        }
    }
}
