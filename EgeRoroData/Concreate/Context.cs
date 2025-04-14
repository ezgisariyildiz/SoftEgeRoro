using EgeRoro.Entity.Concreate;
using EgeRoro.Entity.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EgeRoroData.Concreate
{
    public class Context : IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            option.UseSqlServer("Server=DESKTOP-KCGB4G6\\SQLEXPRESS;Database=EgeRoro;Trusted_Connection=True;");
            //option.UseSqlServer("Server=10.20.103.28,1433;Database=EgeRoro;User ID=SA;Password=Softito1882;Trusted_Connection=False;Encrypt=False;");
        }

        public DbSet<Crew> Crews { get; set; }
        public DbSet<Fleet> Fleets { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }

}