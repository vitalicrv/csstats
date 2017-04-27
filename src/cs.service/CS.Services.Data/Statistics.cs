using System.ComponentModel.DataAnnotations;

namespace CS.Service.Data
{
    public class Statistics
    {
        [Key]
        public int StatisticId { get; set; }
        public string PlayerName { get; set; }
        public string PlayerIp { get; set; }
    }
}
