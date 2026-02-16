using Gamestore.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gamestore.Api.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options) 
: DbContext(options)
{
    public DbSet<Game> Games => Set<Game>();
}
