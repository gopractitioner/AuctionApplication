
using AuctionService.Models;
using Microsoft.EntityFrameworkCore;

namespace AuctionService;

public class DbInitializer
{
    public static void InitDb(WebApplication webapp)
    {
        using var scope = webapp.Services.CreateScope();

        var context = scope.ServiceProvider.GetRequiredService<AuctionDbContext>();

        SeedData(context);
    }

    private static void SeedData(AuctionDbContext context)
    {

    }
}