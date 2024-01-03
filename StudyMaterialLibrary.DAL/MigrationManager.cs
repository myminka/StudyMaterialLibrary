using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyLibrary.DataAccess;

public static class MigrationManager
{
    public static async Task MigrateDatabaseAsync<TContext>(this IServiceProvider serviceProvider,
        CancellationToken token)
        where TContext : DbContext
    {
        await using var scope = serviceProvider.CreateAsyncScope();
        var context = scope.ServiceProvider.GetRequiredService<TContext>();

        try
        {
            await context.Database.MigrateAsync(token);
            // Add seeds
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
