using System.ComponentModel.DataAnnotations;

namespace ApiWeather.Entities
{
    public class Cities
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string Country { get; set; }
        public decimal Temp { get; set; }
        public string Details { get; set; }

    }
}
