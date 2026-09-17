using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace LibrarySystem.Infrastructure.Data;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = 
            new DbContextOptionsBuilder<AppDbContext>();

        optionsBuilder.UseSqlServer("Ser");

        return new AppDbContext(optionsBuilder.Options);
    }
}