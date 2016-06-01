using System.Data.Entity.ModelConfiguration;

namespace BMUKDirectoryAPI.Models
{
    public class DirectoryDataMap : EntityTypeConfiguration<DirectoryData>
    {
        public DirectoryDataMap()
        {
            this.HasKey(t => t.Id);

            this.ToTable("NaatDirectory");

            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Surname).HasColumnName("Surname");
            this.Property(t => t.FirstName).HasColumnName("First name");
            this.Property(t => t.BirthYear).HasColumnName("Birth Year");
            this.Property(t => t.RelationToHead).HasColumnName("Relation To Head");

            this.Property(t => t.SecondndName).HasColumnName("2nd Name");
            this.Property(t => t.FathersName).HasColumnName("Fathers Name");
            this.Property(t => t.Mosal).HasColumnName("Mosal");
            this.Property(t => t.Profession).HasColumnName("Profession");

            this.Property(t => t.AddressLine1).HasColumnName("Address Line 1");
            this.Property(t => t.AddressLine2).HasColumnName("Address Line 2");
            this.Property(t => t.Town).HasColumnName("Town");
            this.Property(t => t.County).HasColumnName("County");
            this.Property(t => t.Postcode).HasColumnName("Postcode");

            this.Property(t => t.TelephoneNo).HasColumnName("Telephone No");
            this.Property(t => t.MobileNo).HasColumnName("Mobile no");

            this.Property(t => t.EmailAddress).HasColumnName("email address");
            this.Property(t => t.TelephoneNo).HasColumnName("Telephone No");

            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}