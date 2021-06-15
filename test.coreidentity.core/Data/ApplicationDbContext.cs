using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using test.coreidentity.core.Models;

#nullable disable

namespace test.coreidentity.core.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DnsUser> DnsUsers { get; set; }
        public virtual DbSet<DnsUserDocument> DnsUserDocuments { get; set; }
        public virtual DbSet<DnsVendor> DnsVendors { get; set; }
        public virtual DbSet<FkeyTable1> FkeyTable1s { get; set; }
        public virtual DbSet<FkeyTable10> FkeyTable10s { get; set; }
        public virtual DbSet<FkeyTable11> FkeyTable11s { get; set; }
        public virtual DbSet<FkeyTable12> FkeyTable12s { get; set; }
        public virtual DbSet<FkeyTable13> FkeyTable13s { get; set; }
        public virtual DbSet<FkeyTable14> FkeyTable14s { get; set; }
        public virtual DbSet<FkeyTable15> FkeyTable15s { get; set; }
        public virtual DbSet<FkeyTable16> FkeyTable16s { get; set; }
        public virtual DbSet<FkeyTable17> FkeyTable17s { get; set; }
        public virtual DbSet<FkeyTable18> FkeyTable18s { get; set; }
        public virtual DbSet<FkeyTable19> FkeyTable19s { get; set; }
        public virtual DbSet<FkeyTable2> FkeyTable2s { get; set; }
        public virtual DbSet<FkeyTable20> FkeyTable20s { get; set; }
        public virtual DbSet<FkeyTable3> FkeyTable3s { get; set; }
        public virtual DbSet<FkeyTable4> FkeyTable4s { get; set; }
        public virtual DbSet<FkeyTable5> FkeyTable5s { get; set; }
        public virtual DbSet<FkeyTable6> FkeyTable6s { get; set; }
        public virtual DbSet<FkeyTable7> FkeyTable7s { get; set; }
        public virtual DbSet<FkeyTable8> FkeyTable8s { get; set; }
        public virtual DbSet<FkeyTable9> FkeyTable9s { get; set; }
        
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "User", schema: "Identity");
                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");
            });

            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role", schema: "Identity");
            });
            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles", schema: "Identity");
            });
            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims", schema: "Identity");
            });
            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins", schema: "Identity");
            });
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims", schema: "Identity");
            });
            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens", schema: "Identity");
            });

            modelBuilder.Entity<DnsUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__DNS_User__1788CCAC7F972DE0");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.UserName).IsUnicode(false);
            });

            modelBuilder.Entity<DnsUserDocument>(entity =>
            {
                entity.HasKey(e => e.DocumentId)
                    .HasName("PK_DNS_UserDocuments_DocumentID");

                entity.Property(e => e.Abstract).IsUnicode(false);

                entity.Property(e => e.FilePath).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.UserIdCheckoutNavigation)
                    .WithMany(p => p.DnsUserDocumentUserIdCheckoutNavigations)
                    .HasForeignKey(d => d.UserIdCheckout)
                    .HasConstraintName("FK_DNS_UserDocuments_DNS_Users_Checkout");

                entity.HasOne(d => d.UserIdCreatorNavigation)
                    .WithMany(p => p.DnsUserDocumentUserIdCreatorNavigations)
                    .HasForeignKey(d => d.UserIdCreator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DNS_UserDocuments_DNS_Users_Creator");

                entity.HasOne(d => d.UserIdRevisorNavigation)
                    .WithMany(p => p.DnsUserDocumentUserIdRevisorNavigations)
                    .HasForeignKey(d => d.UserIdRevisor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DNS_UserDocuments_DNS_Users_Revisor");
            });

            modelBuilder.Entity<DnsVendor>(entity =>
            {
                entity.Property(e => e.VendorUserId).IsUnicode(false);

                entity.HasOne(d => d.ContactUser)
                    .WithMany(p => p.DnsVendors)
                    .HasForeignKey(d => d.ContactUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DNS_Vendor_DNS_Users");
            });

            modelBuilder.Entity<FkeyTable1>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FkeyTable1s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FKEY_Tabl__UserI__7E37BEF6");
            });

            modelBuilder.Entity<FkeyTable10>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FkeyTable10s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FKEY_Tabl__UserI__208CD6FA");
            });

            modelBuilder.Entity<FkeyTable11>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FkeyTable11s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FKEY_Tabl__UserI__245D67DE");
            });

            modelBuilder.Entity<FkeyTable12>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FkeyTable12s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FKEY_Tabl__UserI__282DF8C2");
            });

            modelBuilder.Entity<FkeyTable13>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FkeyTable13s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FKEY_Tabl__UserI__2BFE89A6");
            });

            modelBuilder.Entity<FkeyTable14>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FkeyTable14s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FKEY_Tabl__UserI__2FCF1A8A");
            });

            modelBuilder.Entity<FkeyTable15>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FkeyTable15s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FKEY_Tabl__UserI__339FAB6E");
            });

            modelBuilder.Entity<FkeyTable16>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FkeyTable16s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FKEY_Tabl__UserI__37703C52");
            });

            modelBuilder.Entity<FkeyTable17>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FkeyTable17s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FKEY_Tabl__UserI__3B40CD36");
            });

            modelBuilder.Entity<FkeyTable18>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FkeyTable18s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FKEY_Tabl__UserI__3F115E1A");
            });

            modelBuilder.Entity<FkeyTable19>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FkeyTable19s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FKEY_Tabl__UserI__42E1EEFE");
            });

            modelBuilder.Entity<FkeyTable2>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FkeyTable2s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FKEY_Tabl__UserI__02084FDA");
            });

            modelBuilder.Entity<FkeyTable20>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FkeyTable20s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FKEY_Tabl__UserI__46B27FE2");
            });

            modelBuilder.Entity<FkeyTable3>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FkeyTable3s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FKEY_Tabl__UserI__05D8E0BE");
            });

            modelBuilder.Entity<FkeyTable4>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FkeyTable4s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FKEY_Tabl__UserI__09A971A2");
            });

            modelBuilder.Entity<FkeyTable5>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FkeyTable5s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FKEY_Tabl__UserI__0D7A0286");
            });

            modelBuilder.Entity<FkeyTable6>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FkeyTable6s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FKEY_Tabl__UserI__114A936A");
            });

            modelBuilder.Entity<FkeyTable7>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FkeyTable7s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FKEY_Tabl__UserI__151B244E");
            });

            modelBuilder.Entity<FkeyTable8>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FkeyTable8s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FKEY_Tabl__UserI__18EBB532");
            });

            modelBuilder.Entity<FkeyTable9>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FkeyTable9s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FKEY_Tabl__UserI__1CBC4616");
            });

           
            
        }

    }
}
