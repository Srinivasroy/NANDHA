using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class WebApplication1Context : DbContext
    {
        public WebApplication1Context()
        {
        }

        public WebApplication1Context(DbContextOptions<WebApplication1Context> options)
            : base(options)
        {
        }


        public virtual DbSet<Employee> Employee { get; set; }

    }
}
