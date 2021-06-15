using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace test.coreidentity.core.Models
{
    [Table("DNS_Users")]
    public partial class DnsUser
    {
        public DnsUser()
        {
            DnsUserDocumentUserIdCheckoutNavigations = new HashSet<DnsUserDocument>();
            DnsUserDocumentUserIdCreatorNavigations = new HashSet<DnsUserDocument>();
            DnsUserDocumentUserIdRevisorNavigations = new HashSet<DnsUserDocument>();
            DnsVendors = new HashSet<DnsVendor>();
        }

        [Key]
        [Column("UserID")]
        public int UserId { get; set; }
        [Required]
        [StringLength(255)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string Email { get; set; }

        [InverseProperty(nameof(DnsUserDocument.UserIdCheckoutNavigation))]
        public virtual ICollection<DnsUserDocument> DnsUserDocumentUserIdCheckoutNavigations { get; set; }
        [InverseProperty(nameof(DnsUserDocument.UserIdCreatorNavigation))]
        public virtual ICollection<DnsUserDocument> DnsUserDocumentUserIdCreatorNavigations { get; set; }
        [InverseProperty(nameof(DnsUserDocument.UserIdRevisorNavigation))]
        public virtual ICollection<DnsUserDocument> DnsUserDocumentUserIdRevisorNavigations { get; set; }
        [InverseProperty(nameof(DnsVendor.ContactUser))]
        public virtual ICollection<DnsVendor> DnsVendors { get; set; }
    }
}
