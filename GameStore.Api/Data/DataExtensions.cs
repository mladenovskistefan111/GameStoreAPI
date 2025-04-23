using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Data
{
    public static class DataExtensions
    {
        public static async Task MigrateDbAsync(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetService<GameStoreContext>();
            await dbContext.Database.MigrateAsync();
        }
    }
}