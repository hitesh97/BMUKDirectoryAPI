using System.Data.Entity;

namespace BMUKDirectoryAPI.Models
{
    public class BMUKContext : DbContext
    {
        static BMUKContext()
        {
            Database.SetInitializer<BMUKContext>(null);
        }

        public DbSet<DirectoryData> DirectoryData { get; set; }
        public DbSet<PaymentInfo> PaymentInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DirectoryDataMap());
            modelBuilder.Configurations.Add(new PaymentInfoMap());
        }
    }
}