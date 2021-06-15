using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace test.coreidentity.core.Models
{
    [Table("DNS_UserDocuments")]
    public partial class DnsUserDocument
    {
        [Key]
        [Column("DocumentID")]
        public int DocumentId { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Abstract { get; set; }
        [Column("UserID_Creator")]
        public int UserIdCreator { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreationDate { get; set; }
        [Column("UserID_Revisor")]
        public int UserIdRevisor { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RevisionDate { get; set; }
        public int Version { get; set; }
        [Column("StatusID")]
        public int StatusId { get; set; }
        [Required]
        [StringLength(128)]
        public string FilePath { get; set; }
        public int FileSize { get; set; }
        [Column("MIMETypeID")]
        public int MimetypeId { get; set; }
        [Column("UserID_Checkout")]
        public int? UserIdCheckout { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CheckOutDate { get; set; }

        [ForeignKey(nameof(UserIdCheckout))]
        [InverseProperty(nameof(DnsUser.DnsUserDocumentUserIdCheckoutNavigations))]
        public virtual DnsUser UserIdCheckoutNavigation { get; set; }
        [ForeignKey(nameof(UserIdCreator))]
        [InverseProperty(nameof(DnsUser.DnsUserDocumentUserIdCreatorNavigations))]
        public virtual DnsUser UserIdCreatorNavigation { get; set; }
        [ForeignKey(nameof(UserIdRevisor))]
        [InverseProperty(nameof(DnsUser.DnsUserDocumentUserIdRevisorNavigations))]
        public virtual DnsUser UserIdRevisorNavigation { get; set; }
    }
}
