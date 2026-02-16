using Gamestore.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

namespace Gamestore.Api.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options) 
: DbContext(options)
{
    public DbSet<Game> Games => Set<Game>();
}
