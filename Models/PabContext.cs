using Microsoft.EntityFrameworkCore;

namespace PAB4.Models;

public partial class PabContext : DbContext
{
    public PabContext()
    {
    }

    public PabContext(DbContextOptions<PabContext> options)
        : base(options)
    {
    }

    public virtual DbSet<KodyPocztowe> KodyPocztowes { get; set; }

    public virtual DbSet<Lokalizacje> Lokalizacjes { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=PAB; Integrated Security=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<KodyPocztowe>(entity =>
        {
            entity.ToTable("Kody_Pocztowe");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adres)
                .HasMaxLength(103)
                .IsUnicode(false);
            entity.Property(e => e.KodPocztowy)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Kod_Pocztowy");
            entity.Property(e => e.Miejscowosc)
                .HasMaxLength(27)
                .IsUnicode(false);
            entity.Property(e => e.Powiat)
                .HasMaxLength(48)
                .IsUnicode(false);
            entity.Property(e => e.Uwagi)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Wojewodztwo)
                .HasMaxLength(33)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Lokalizacje>(entity =>
        {
            entity.ToTable("Lokalizacje");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdKoduPocztowego).HasColumnName("ID_kodu_pocztowego");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Opis)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdKoduPocztowegoNavigation).WithMany(p => p.Lokalizacjes)
                .HasForeignKey(d => d.IdKoduPocztowego)
                .HasConstraintName("FK_Lokalizacje_Kody_Pocztowe");
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
