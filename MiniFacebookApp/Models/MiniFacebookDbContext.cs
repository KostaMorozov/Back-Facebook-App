using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MiniFacebookApp.Models
{
    public class MiniFacebookDbContext : IdentityDbContext<FacebookUser>
    {
        public MiniFacebookDbContext(DbContextOptions<MiniFacebookDbContext> options)
        :base(options)
        {
            
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Like> Likes { get; set; }  
    }
}
