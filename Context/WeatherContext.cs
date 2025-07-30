using ApiWeather.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiWeather.Context
{
    public class WeatherContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=DESKTOP-JVTLBLN; Initial Catalog=DbApiWeather; Integrated Security=True; TrustServerCertificate=True");
        }
        public DbSet<Cities> City { get; set; }
    }
}
