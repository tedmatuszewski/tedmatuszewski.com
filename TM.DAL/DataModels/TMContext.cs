using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TM.DAL.DataModels
{
    public partial class TMContext : DbContext
    {
        public TMContext()
        {
        }

        public TMContext(DbContextOptions<TMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Content> Content { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(1023)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.Property(e => e.Header)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Subheader)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(1023)
                    .IsUnicode(false);
            });
        }
    }
}
