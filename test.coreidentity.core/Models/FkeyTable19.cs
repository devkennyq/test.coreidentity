using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace test.coreidentity.core.Models
{
    [Table("FKEY_Table19")]
    public partial class FkeyTable19
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        public int? UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(DnsUser.FkeyTable19s))]
        public virtual DnsUser User { get; set; }
    }
}
