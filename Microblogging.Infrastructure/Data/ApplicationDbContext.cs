

namespace MicrobloggingApp.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<UserMaster, IdentityRole<int>, int>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Post> Posts { get; set; }
    public DbSet<UserMaster> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}


