using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RFI.FRI.Api.Domain.Modal;
using System.Configuration;
using System.Threading.Tasks;

namespace RFI.FRI.Application.Common
{
    public class FRIdbContext :DbContext
    {
        public DbSet<User> Users { get; set; }
        public FRIdbContext(IConfiguration configuration)
        {
            configuration = configuration;
        }

        public FRIdbContext(DbContextOptions<FRIdbContext> options) : base(options)
        {
        }

       /* protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
          options.UseNpgsql(Configuration.GetConnectionstring)
        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure model if needed
        }

        public override Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
