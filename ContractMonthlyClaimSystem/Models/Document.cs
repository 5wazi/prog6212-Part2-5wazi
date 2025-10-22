using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace ContractMonthlyClaimSystem.Models
{
    public class Document
    {
        [Key]
        public int DocumentID { get; set; }

        [Required, ForeignKey("Claim")]
        public int ClaimID { get; set; }

        [Required]
        public string? FileName { get; set; }

        [Required]
        public DateTime UploadDate { get; set; }

        // Navigation Property
        public Claim? Claim { get; set; }
    }
}
