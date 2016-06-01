using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMUKDirectoryAPI.Models
{
    [Table("NaatDirectory")]
    public class DirectoryData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DefaultValue(-1)]
        [Display(Name = "Head of House")]
        public int ParentId { get; set; }

        [DefaultValue("")]
        [Required]
        public string Title { get; set; }

        [DefaultValue("")]
        [Required]
        public string Surname { get; set; }

        [DefaultValue("")]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [DefaultValue("")]
        [Required]
        [Display(Name = "Birth Year")]
        [Range(1800, 9999, ErrorMessage = "Birth Year must be between 1800 - 9999")]
        [RegularExpression(@"^\(?([0-9]{4})\)?$", ErrorMessage = "Invalid Birth Year.")]
        public string BirthYear { get; set; }

        [DefaultValue("")]
        [Required]
        [Display(Name = "Relation to Head")]
        public string RelationToHead { get; set; }

        [DefaultValue("")]
        [Display(Name = "Second Name")]
        public string SecondndName { get; set; }

        [DefaultValue("")]
        //[Required]
        [Display(Name = "Father's Name")]
        public string FathersName { get; set; }

        [DefaultValue("")]
        public string Mosal { get; set; }

        [DefaultValue("")]
        public string Profession { get; set; }

        [DefaultValue("")]
        //[Required]
        public string AddressLine1 { get; set; }

        [DefaultValue("")]
        public string AddressLine2 { get; set; }

        [DefaultValue("")]
        //[Required]
        public string Town { get; set; }

        [DefaultValue("")]
        //[Required]
        public string County { get; set; }

        [DefaultValue("")]
        //[Required]
        public string Postcode { get; set; }

        [DefaultValue("")]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public string TelephoneNo { get; set; }

        [DefaultValue("")]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public string MobileNo { get; set; }

        [DefaultValue("")]
        public string EmailAddress { get; set; }

        [DefaultValue("")]
        public DateTime? DateUpdated { get; set; }

        [DefaultValue("")]
        public DateTime? DateCreated { get; set; }
    }
}