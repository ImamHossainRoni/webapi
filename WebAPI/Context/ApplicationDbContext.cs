using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
namespace WebAPI.Context;

public class ApplicationDbContext :DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    public DbSet<Post> Posts { get; set; }
    
}