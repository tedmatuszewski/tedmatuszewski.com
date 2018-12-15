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

        public virtual DbSet<Content> Content { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TM;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

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
