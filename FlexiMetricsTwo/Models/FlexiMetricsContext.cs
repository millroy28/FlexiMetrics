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
        public virtual DbSet<FrontToSqlterm> FrontToSqlterms { get; set; }
        public virtual DbSet<MasterSchema> MasterSchemas { get; set; }
        public virtual DbSet<PermissionLevel> PermissionLevels { get; set; }
        public virtual DbSet<SqltermType> SqltermTypes { get; set; }
        public virtual DbSet<Structure> Structures { get; set; }

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

                entity.Property(e => e.NewValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OldValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SchemaId).HasColumnName("SchemaID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.ChangeType)
                    .WithMany()
                    .HasForeignKey(d => d.ChangeTypeId)
                    .HasConstraintName("FK__ChangeLog__Chang__41EDCAC5");

                entity.HasOne(d => d.Schema)
                    .WithMany()
                    .HasForeignKey(d => d.SchemaId)
                    .HasConstraintName("FK__ChangeLog__Schem__40F9A68C");
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

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ValueType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ChangeType)
                    .WithMany(p => p.ChangeRequests)
                    .HasForeignKey(d => d.ChangeTypeId)
                    .HasConstraintName("FK__ChangeReq__Chang__45BE5BA9");

                entity.HasOne(d => d.Schema)
                    .WithMany(p => p.ChangeRequests)
                    .HasForeignKey(d => d.SchemaId)
                    .HasConstraintName("FK__ChangeReq__Schem__44CA3770");
            });

            modelBuilder.Entity<ChangeType>(entity =>
            {
                entity.ToTable("ChangeType");

                entity.Property(e => e.ChangeTypeId).HasColumnName("ChangeTypeID");

                entity.Property(e => e.ChangeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrontToSqlterm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FrontToSQLTerms");

                entity.Property(e => e.FrontFacingTerm)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SqlTermTypeId).HasColumnName("SqlTermTypeID");

                entity.Property(e => e.Sqlterm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SQLTerm");

                entity.HasOne(d => d.SqlTermType)
                    .WithMany()
                    .HasForeignKey(d => d.SqlTermTypeId)
                    .HasConstraintName("FK__FrontToSQ__SqlTe__18EBB532");
            });

            modelBuilder.Entity<MasterSchema>(entity =>
            {
                entity.HasKey(e => e.SchemaId)
                    .HasName("PK__MasterSc__95006FDAD9210879");

                entity.ToTable("MasterSchema");

                entity.Property(e => e.SchemaId).HasColumnName("SchemaID");

                entity.Property(e => e.FacingName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FacingType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParentSchemaId).HasColumnName("ParentSchemaID");

                entity.Property(e => e.Sqlname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SQLName");

                entity.Property(e => e.Sqltype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SQLType");
            });

            modelBuilder.Entity<PermissionLevel>(entity =>
            {
                entity.Property(e => e.PermissionLevelId).HasColumnName("PermissionLevelID");

                entity.Property(e => e.PermissionLevel1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PermissionLevel");
            });

            modelBuilder.Entity<SqltermType>(entity =>
            {
                entity.ToTable("SQLTermTypes");

                entity.Property(e => e.SqltermTypeId).HasColumnName("SQLTermTypeID");

                entity.Property(e => e.SqltermType1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SQLTermType");
            });

            modelBuilder.Entity<Structure>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Structure");

                entity.Property(e => e.TableName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
