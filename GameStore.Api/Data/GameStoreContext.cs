using GameStore.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options)
  : DbContext(options)
{
  public DbSet<Game> Games => Set<Game>();

  public DbSet<Genre> Genres => Set<Genre>();

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Genre>().HasData(
      new { Id = 1, Name = "Fighting" },
      new { Id = 2, Name = "Roleplaying" },
      new { Id = 3, Name = "Sports" },
      new { Id = 4, Name = "Racing" },
      new { Id = 5, Name = "Idle" },
      new { Id = 6, Name = "Education" },
      new { Id = 7, Name = "Arcade" },
      new { Id = 8, Name = "Puzzle" },
      new { Id = 9, Name = "Strategy" },
      new { Id = 10, Name = "Shooter" }
    );
  }
}