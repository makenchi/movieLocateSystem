using Microsoft.EntityFrameworkCore;

namespace movieLocateAPI.Infra
{
  public sealed class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            optionsBuilder.UseMySQL("server=db;database=movie-locate;user=movie-locate-api;password=dev123!");
        }

    }
}