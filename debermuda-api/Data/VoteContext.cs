

using DeBermudaApi.Models;
using Microsoft.EntityFrameworkCore; //ORM

namespace DeBermudaApi.Data
{
    public class VoteContext : DbContext
    {
        public DbSet<Vote> Votes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=tcp:debermuda-dbsrv01.database.windows.net,1433;Initial Catalog=db01;Persist Security Info=False;User ID=dbadmin;Password=s3nh4Segur@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}