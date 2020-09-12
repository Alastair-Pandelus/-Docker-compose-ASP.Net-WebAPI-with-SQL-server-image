using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyDocker.Domain;
using System;
using System.Diagnostics;

namespace MyDocker.Data
{
    public class WeatherForecastContext : DbContext
    {
        private IConfiguration _configuration;

        public WeatherForecastContext(IConfiguration configuration)
            : base()
        {
            this._configuration = configuration;
        }

        public WeatherForecastContext()
        {
        }

        public void EnsureCreated()
        {
            this.Database.EnsureCreated();
        }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            for(int i=1; i <= 10; i++)
            {
                modelBuilder.Entity<WeatherForecast>().HasData(new WeatherForecast { Id = i, Date = DateTime.Now.AddDays(i).Date, Summary = $"forecast {i}" });
            }
        }
    }
}
