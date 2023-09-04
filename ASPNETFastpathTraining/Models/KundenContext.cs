using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ASPNETFastpathTraining.Models;

public partial class KundenContext : DbContext
{
    public KundenContext()
    {
    }

    public KundenContext(DbContextOptions<KundenContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Auftrag> Auftrags { get; set; }

    public virtual DbSet<Kunde> Kundes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Auftrag>(entity =>
        {
            entity.HasKey(e => e.AuftragId).HasName("PK__Auftrag__8686951E44952D43");

            entity.ToTable("Auftrag");

            entity.Property(e => e.Datum).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Titel)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Kunde).WithMany(p => p.Auftrags)
                .HasForeignKey(d => d.KundeId)
                .HasConstraintName("FK__Auftrag__KundeId__3C69FB99");
        });

        modelBuilder.Entity<Kunde>(entity =>
        {
            entity.HasKey(e => e.KundeId).HasName("PK__Kunde__7F871DC169FDA23B");

            entity.ToTable("Kunde");

            entity.Property(e => e.Datum).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Land)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ort)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Plz)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("PLZ");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
