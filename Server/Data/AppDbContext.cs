using FormulaOne.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace FormulaOne.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Driver> Drivers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Driver[] drivers =
            [
                new() {Id = 1, Name = "Michael Schumacher", RacingNb = "3", Team = "Mercedes"},
                new() {Id = 2, Name = "Nico Rosberg", RacingNb = "6", Team = "Mercedes"},
                new() {Id = 3, Name = "Lewis Hamilton", RacingNb = "44", Team = "Mercedes"},
                new() {Id = 4, Name = "Valtteri Bottas", RacingNb = "77", Team = "Mercedes"},
                new() {Id = 5, Name = "George Russell", RacingNb = "63", Team = "Mercedes"},

                new() {Id = 6, Name = "Michael Schumacher", RacingNb = "1", Team = "Ferrari"},
                new() {Id = 7, Name = "Felipe Massa", RacingNb = "6", Team = "Ferrari"},
                new() {Id = 8, Name = "Kimi Räikkönen", RacingNb = "7", Team = "Ferrari"},
                new() {Id = 9, Name = "Fernando Alonso", RacingNb = "14", Team = "Ferrari"},
                new() {Id = 10, Name = "Sebastian Vettel", RacingNb = "5", Team = "Ferrari"},
                new() {Id = 11, Name = "Charles Leclerc", RacingNb = "16", Team = "Ferrari"},
                new() {Id = 12, Name = "Carlos Sainz", RacingNb = "55", Team = "Ferrari"}
            ];

            modelBuilder.Entity<Driver>().HasData(drivers);
        }
    }
}
