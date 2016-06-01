using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMUKDirectoryAPI.Models
{
    [Table("MembersPaymentInfo")]
    public class PaymentInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Member Id")]
        public int MemberId { get; set; }

        [Required]
        [Display(Name = "Year")]
        public int Year { get; set; }

        [Required]
        [Display(Name = "Receipt No.")]
        public string ReceiptNo { get; set; }

        [Required]
        [Display(Name = "Amt. Paid")]
        public Decimal AmtPaid { get; set; }

        public DateTime? DateUpdated { get; set; }

        public DateTime? DateCreated { get; set; }

        [Display(Name = "Paid By Cheque")]
        public bool IsCheque { get; set; }

        [Display(Name = "Cheque No.")]
        public string ChequeNo { get; set; }
    }
}