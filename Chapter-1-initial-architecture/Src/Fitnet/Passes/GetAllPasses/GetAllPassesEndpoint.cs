namespace EvolutionaryArchitecture.Fitnet.Passes.GetAllPasses;

using Passes;
using Data.Database;
using Microsoft.EntityFrameworkCore;

internal static class GetAllPassesEndpoint
{
    internal static void MapGetAllPasses(this IEndpointRouteBuilder app) =>
        app.MapGet(PassesApiPaths.GetAll, async (PassesPersistence persistence, CancellationToken cancellationToken) =>
        {
            var passes = await persistence.Passes
                .AsNoTracking()
                .Select(passes => PassDto.From(passes))
                .ToListAsync(cancellationToken);
            var response = GetAllPassesResponse.Create(passes);
            
            return Results.Ok(response);
        });
}