using BlogRa.Mapping;
using Microsoft.EntityFrameworkCore;

namespace BlogRa
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
