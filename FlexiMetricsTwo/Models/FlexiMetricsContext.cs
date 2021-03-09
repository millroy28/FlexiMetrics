using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FlexiMetricsTwo.Models
{
    public partial class FlexiMetricsContext : DbContext
    {
        public FlexiMetricsContext()
        {
        }

        public FlexiMetricsContext(DbContextOptions<FlexiMetricsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChangeLog> ChangeLogs { get; set; }
        public virtual DbSet<ChangeRequest> ChangeRequests { get; set; }
        public virtual DbSet<ChangeType> ChangeTypes { get; set; }
        public virtual DbSet<SchemaLog> SchemaLogs { get; set; }
        public virtual DbSet<SchemaStatus> SchemaStatuses { get; set; }
        public virtual DbSet<UserSchema> UserSchemas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=FlexiMetrics;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ChangeLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ChangeLog");

                entity.Property(e => e.ChangeTypeId).HasColumnName("ChangeTypeID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.NewStatusId).HasColumnName("NewStatusID");

                entity.Property(e => e.NewValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OldStatusId).HasColumnName("OldStatusID");

                entity.Property(e => e.OldValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SchemaId).HasColumnName("SchemaID");

                entity.HasOne(d => d.ChangeType)
                    .WithMany()
                    .HasForeignKey(d => d.ChangeTypeId)
                    .HasConstraintName("FK__ChangeLog__Chang__7A672E12");

                entity.HasOne(d => d.Schema)
                    .WithMany()
                    .HasForeignKey(d => d.SchemaId)
                    .HasConstraintName("FK__ChangeLog__Schem__797309D9");
            });

            modelBuilder.Entity<ChangeRequest>(entity =>
            {
                entity.ToTable("ChangeRequest");

                entity.Property(e => e.ChangeRequestId).HasColumnName("ChangeRequestID");

                entity.Property(e => e.ChangeTypeId).HasColumnName("ChangeTypeID");

                entity.Property(e => e.NewValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SchemaId).HasColumnName("SchemaID");

                entity.Property(e => e.ValueType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ChangeType)
                    .WithMany(p => p.ChangeRequests)
                    .HasForeignKey(d => d.ChangeTypeId)
                    .HasConstraintName("FK__ChangeReq__Chang__778AC167");

                entity.HasOne(d => d.Schema)
                    .WithMany(p => p.ChangeRequests)
                    .HasForeignKey(d => d.SchemaId)
                    .HasConstraintName("FK__ChangeReq__Schem__76969D2E");
            });

            modelBuilder.Entity<ChangeType>(entity =>
            {
                entity.ToTable("ChangeType");

                entity.Property(e => e.ChangeTypeId).HasColumnName("ChangeTypeID");

                entity.Property(e => e.ChangeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SchemaLog>(entity =>
            {
                entity.ToTable("SchemaLog");

                entity.Property(e => e.SchemaLogId).HasColumnName("SchemaLogID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.SchemaId).HasColumnName("SchemaID");

                entity.Property(e => e.SchemaStatusId).HasColumnName("SchemaStatusID");

                entity.HasOne(d => d.Schema)
                    .WithMany(p => p.SchemaLogs)
                    .HasForeignKey(d => d.SchemaId)
                    .HasConstraintName("FK__SchemaLog__Schem__3E52440B");

                entity.HasOne(d => d.SchemaStatus)
                    .WithMany(p => p.SchemaLogs)
                    .HasForeignKey(d => d.SchemaStatusId)
                    .HasConstraintName("FK__SchemaLog__Schem__3F466844");
            });

            modelBuilder.Entity<SchemaStatus>(entity =>
            {
                entity.ToTable("SchemaStatus");

                entity.Property(e => e.SchemaStatusId).HasColumnName("SchemaStatusID");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserSchema>(entity =>
            {
                entity.HasKey(e => e.SchemaId)
                    .HasName("PK__UserSche__95006FDA81676915");

                entity.ToTable("UserSchema");

                entity.Property(e => e.SchemaId).HasColumnName("SchemaID");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ColumnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
