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
            FkeyTable10s = new HashSet<FkeyTable10>();
            FkeyTable11s = new HashSet<FkeyTable11>();
            FkeyTable12s = new HashSet<FkeyTable12>();
            FkeyTable13s = new HashSet<FkeyTable13>();
            FkeyTable14s = new HashSet<FkeyTable14>();
            FkeyTable15s = new HashSet<FkeyTable15>();
            FkeyTable16s = new HashSet<FkeyTable16>();
            FkeyTable17s = new HashSet<FkeyTable17>();
            FkeyTable18s = new HashSet<FkeyTable18>();
            FkeyTable19s = new HashSet<FkeyTable19>();
            FkeyTable1s = new HashSet<FkeyTable1>();
            FkeyTable20s = new HashSet<FkeyTable20>();
            FkeyTable2s = new HashSet<FkeyTable2>();
            FkeyTable3s = new HashSet<FkeyTable3>();
            FkeyTable4s = new HashSet<FkeyTable4>();
            FkeyTable5s = new HashSet<FkeyTable5>();
            FkeyTable6s = new HashSet<FkeyTable6>();
            FkeyTable7s = new HashSet<FkeyTable7>();
            FkeyTable8s = new HashSet<FkeyTable8>();
            FkeyTable9s = new HashSet<FkeyTable9>();
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
        [InverseProperty(nameof(FkeyTable10.User))]
        public virtual ICollection<FkeyTable10> FkeyTable10s { get; set; }
        [InverseProperty(nameof(FkeyTable11.User))]
        public virtual ICollection<FkeyTable11> FkeyTable11s { get; set; }
        [InverseProperty(nameof(FkeyTable12.User))]
        public virtual ICollection<FkeyTable12> FkeyTable12s { get; set; }
        [InverseProperty(nameof(FkeyTable13.User))]
        public virtual ICollection<FkeyTable13> FkeyTable13s { get; set; }
        [InverseProperty(nameof(FkeyTable14.User))]
        public virtual ICollection<FkeyTable14> FkeyTable14s { get; set; }
        [InverseProperty(nameof(FkeyTable15.User))]
        public virtual ICollection<FkeyTable15> FkeyTable15s { get; set; }
        [InverseProperty(nameof(FkeyTable16.User))]
        public virtual ICollection<FkeyTable16> FkeyTable16s { get; set; }
        [InverseProperty(nameof(FkeyTable17.User))]
        public virtual ICollection<FkeyTable17> FkeyTable17s { get; set; }
        [InverseProperty(nameof(FkeyTable18.User))]
        public virtual ICollection<FkeyTable18> FkeyTable18s { get; set; }
        [InverseProperty(nameof(FkeyTable19.User))]
        public virtual ICollection<FkeyTable19> FkeyTable19s { get; set; }
        [InverseProperty(nameof(FkeyTable1.User))]
        public virtual ICollection<FkeyTable1> FkeyTable1s { get; set; }
        [InverseProperty(nameof(FkeyTable20.User))]
        public virtual ICollection<FkeyTable20> FkeyTable20s { get; set; }
        [InverseProperty(nameof(FkeyTable2.User))]
        public virtual ICollection<FkeyTable2> FkeyTable2s { get; set; }
        [InverseProperty(nameof(FkeyTable3.User))]
        public virtual ICollection<FkeyTable3> FkeyTable3s { get; set; }
        [InverseProperty(nameof(FkeyTable4.User))]
        public virtual ICollection<FkeyTable4> FkeyTable4s { get; set; }
        [InverseProperty(nameof(FkeyTable5.User))]
        public virtual ICollection<FkeyTable5> FkeyTable5s { get; set; }
        [InverseProperty(nameof(FkeyTable6.User))]
        public virtual ICollection<FkeyTable6> FkeyTable6s { get; set; }
        [InverseProperty(nameof(FkeyTable7.User))]
        public virtual ICollection<FkeyTable7> FkeyTable7s { get; set; }
        [InverseProperty(nameof(FkeyTable8.User))]
        public virtual ICollection<FkeyTable8> FkeyTable8s { get; set; }
        [InverseProperty(nameof(FkeyTable9.User))]
        public virtual ICollection<FkeyTable9> FkeyTable9s { get; set; }
    }
}
