using System.Data.Entity.ModelConfiguration;

namespace BMUKDirectoryAPI.Models
{
    public class PaymentInfoMap : EntityTypeConfiguration<PaymentInfo>
    {
        public PaymentInfoMap()
        {
            this.HasKey(t => t.Id);

            this.ToTable("MembersPaymentInfo");

            this.Property(t => t.MemberId).HasColumnName("MemberId");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.ReceiptNo).HasColumnName("ReceiptNo");
            this.Property(t => t.AmtPaid).HasColumnName("AmtPaid");

            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            this.Property(t => t.IsCheque).HasColumnName("IsCheque");
            this.Property(t => t.ChequeNo).HasColumnName("ChequeNo");

        }
    }
}