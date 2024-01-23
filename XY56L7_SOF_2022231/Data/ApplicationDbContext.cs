using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Drawing2D;
using System.Reflection.Emit;
using XY56L7_SOF_2022231.Models;

namespace XY56L7_SOF_2022231.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Motorcycle> Motorcycles { get; set; }
        public DbSet<SiteUser> Users { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            string[] firstNames = { "Alex", "Elena", "Victor", "Sophia", "Oliver", "Isabella", "Max", "Emma", "Leo", "Ava", "Liam", "Mia", "Gabriel", "Luna", "Sebastian", "Zoe", "Lucas", "Chloe", "Mateo", "Nora" };
            string[] lastNames = { "Anderson", "Martinez", "Smith", "Garcia", "Johnson", "Rodriguez", "Brown", "Lee", "Davis", "Hernandez", "Taylor", "Clark", "Lewis", "Walker", "Hall", "Young", "Hill", "Cooper", "Baker", "Ward" };
            string[] carModels = { "Spectra", "Phoenix", "Nebula", "Quantum", "Infinity", "Pegasus", "Aurora", "Raptor", "Zenith", "Vortex" };

            for (int i = 1; i <= 20; i++)
            {
                string firstName = firstNames[i % firstNames.Length];
                string lastName = lastNames[i % lastNames.Length];
                string email = $"user{i}@example.com";
                byte[] data = new byte[] { (byte)i, (byte)(i + 1), (byte)(i + 2) };

                SiteUser user = new SiteUser
                {
                    Wealth = 50000,
                    Id = $"user{i}",
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    ContentType = "",
                    Data = data
                };

                string carModel = carModels[i % carModels.Length];
                Car car = new Car
                {
                    Uid = Guid.NewGuid().ToString(),
                    Title = $"{carModel} {i}",
                    OwnerId = user.Id
                };
                Motorcycle motorcycle = new Motorcycle
                {
                    Uid = Guid.NewGuid().ToString(),
                    Title = $"{carModel} {i}",
                    OwnerId = user.Id
                };
                builder.Entity<Motorcycle>().HasData(car);
                builder.Entity<Car>().HasData(car);
                builder.Entity<SiteUser>().HasData(user);
            }




            builder.Entity<Car>()
                .HasOne(t => t.Owner)
                .WithMany()
                .HasForeignKey(t => t.OwnerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Motorcycle>()
               .HasOne(t => t.Owner)
               .WithMany()
               .HasForeignKey(t => t.OwnerId)
               .OnDelete(DeleteBehavior.Cascade);



            base.OnModelCreating(builder);
        }


    }
}