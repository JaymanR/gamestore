using System;
using Gamestore.Api.Data;
using Gamestore.Api.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Gamestore.Api.Endpoints;

public static class GenresEndpoints
{
    public static void MapGenresEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/genres");

        group.MapGet("/", async (GameStoreContext dbContext) => 
            await dbContext.Genres
                .Select(genre => new GenreDto(
                    genre.Id,
                    genre.Name
                ))
                .AsNoTracking()
                .ToListAsync()
        );
    }
}
