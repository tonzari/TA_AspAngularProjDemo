using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TA_AspAngularProjDemo.Models
{
    public partial class TA_UpmeetContext : DbContext
    {
        public TA_UpmeetContext()
        {
        }

        public TA_UpmeetContext(DbContextOptions<TA_UpmeetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Favorite> Favorites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=TA_Upmeet; Integrated Security=SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.Description).HasMaxLength(2048);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.StartTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(512);
            });

            modelBuilder.Entity<Favorite>(entity =>
            {
                entity.Property(e => e.FavoriteId).HasColumnName("FavoriteID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
