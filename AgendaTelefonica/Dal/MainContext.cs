using AgendaTelefonica.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AgendaTelefonica.DAL
{
    public class MainContext : DbContext
    {

        public MainContext() : base("MainContext")
        {
        }

        public DbSet<People> Peoples { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}