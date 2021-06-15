using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace test.coreidentity.core.Models
{
    [Table("DNS_Vendor")]
    [Index(nameof(VendorUserId), Name = "IX_DNS_Vendor", IsUnique = true)]
    public partial class DnsVendor
    {
        [Key]
        public int VendorId { get; set; }
        [Required]
        [StringLength(150)]
        public string VendorUserId { get; set; }
        [Required]
        [StringLength(300)]
        public string Pwd { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastAccessedDate { get; set; }
        [Required]
        [StringLength(500)]
        public string VendorToken { get; set; }
        public int VendorExpiration { get; set; }
        public bool IsEnabled { get; set; }
        public int ContactUserId { get; set; }

        [ForeignKey(nameof(ContactUserId))]
        [InverseProperty(nameof(DnsUser.DnsVendors))]
        public virtual DnsUser ContactUser { get; set; }
    }
}
