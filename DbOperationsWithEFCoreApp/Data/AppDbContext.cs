using Microsoft.EntityFrameworkCore;
namespace DbOperationsWithEFCoreApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
    {        
    }
}

