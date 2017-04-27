using System.ComponentModel.DataAnnotations;

namespace CS.Service.WebHost.Models
{
    public class StatisticsEntry
    {
        [Required]
        public string PlayerName { get; set; }

        [Required]
        public string PlayerIp { get; set; }

    }
}