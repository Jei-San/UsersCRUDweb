using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using UsersCRUDweb.Shared;

#nullable disable

namespace UsersCRUDweb.Server.Data
{
    public partial class EntrevistaContext : DbContext
    {
        public EntrevistaContext()
        {
        }

        public EntrevistaContext(DbContextOptions<EntrevistaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblProfession> TblProfessions { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblUserProfession> TblUserProfessions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=Entrevista;User ID=sc; Password=z43VGYT@iu*60i;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblProfession>(entity =>
            {
                entity.HasKey(e => e.ProfessionId)
                    .HasName("PK_tblJobs");

                entity.ToTable("tblProfession");

                entity.Property(e => e.ProfessionId).HasColumnName("ProfessionID");

                entity.Property(e => e.ProfessionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("tblUser");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserProfession>(entity =>
            {
                entity.ToTable("tblUserProfession");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProfessionId).HasColumnName("ProfessionID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Profession)
                    .WithMany(p => p.TblUserProfessions)
                    .HasForeignKey(d => d.ProfessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUserProfession_tblProfession");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblUserProfessions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUserProfession_tblUserProfession");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
