using MCM.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MCM.DAL
{
    public class MCMContext : DbContext
    {
        public MCMContext() : base("MCMContext")
        {

        }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberBank> MemberBanks { get; set; }
        public DbSet<MemberLocation> MemberLocations { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<PostalCode> PostalCodes { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Suburb> Suburbs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
    }
}