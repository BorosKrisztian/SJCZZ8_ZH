using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SJCZZ8_FormsApp.Models;

public partial class TanulmanyiContext : DbContext
{
    public TanulmanyiContext()
    {
    }

    public TanulmanyiContext(DbContextOptions<TanulmanyiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Beosztasok> Beosztasok { get; set; }

    public virtual DbSet<Napok> Napok { get; set; }

    public virtual DbSet<Oktatok> Oktatok { get; set; }

    public virtual DbSet<Orak> Orak { get; set; }

    public virtual DbSet<Savok> Savok { get; set; }

    public virtual DbSet<Statusok> Statusok { get; set; }

    public virtual DbSet<Tantárgyak> Tantárgyak { get; set; }

    public virtual DbSet<Termek> Termek { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=bit.uni-corvinus.hu;Initial Catalog=tanulmanyi;Persist Security Info=True;User ID=hallgato;Password=Password123;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Beosztasok>(entity =>
        {
            entity.HasKey(e => e.BeosztasId);

            entity.Property(e => e.BeosztasId)
                .ValueGeneratedNever()
                .HasColumnName("beosztas_id");
            entity.Property(e => e.Beosztasnev)
                .HasMaxLength(50)
                .HasColumnName("beosztasnev");
            entity.Property(e => e.Elvart).HasColumnName("elvart");
        });

        modelBuilder.Entity<Napok>(entity =>
        {
            entity.HasKey(e => e.NapId);

            entity.Property(e => e.NapId)
                .ValueGeneratedNever()
                .HasColumnName("nap_id");
            entity.Property(e => e.Nap)
                .HasMaxLength(50)
                .HasColumnName("nap");
        });

        modelBuilder.Entity<Oktatok>(entity =>
        {
            entity.HasKey(e => e.OktatoId);

            entity.Property(e => e.OktatoId)
                .ValueGeneratedNever()
                .HasColumnName("oktato_id");
            entity.Property(e => e.Beosztás).HasColumnName("beosztás");
            entity.Property(e => e.Nev)
                .HasMaxLength(50)
                .HasColumnName("nev");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Titulus)
                .HasMaxLength(50)
                .HasColumnName("titulus");

            entity.HasOne(d => d.BeosztásNavigation).WithMany(p => p.Oktatok)
                .HasForeignKey(d => d.Beosztás)
                .HasConstraintName("FK_Oktatok_Beosztasok");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Oktatok)
                .HasForeignKey(d => d.Status)
                .HasConstraintName("FK_Oktatok_statusok");
        });

        modelBuilder.Entity<Orak>(entity =>
        {
            entity.HasKey(e => e.OraId);

            entity.Property(e => e.OraId)
                .ValueGeneratedNever()
                .HasColumnName("ora_id");
            entity.Property(e => e.Nap).HasColumnName("nap");
            entity.Property(e => e.Tanar).HasColumnName("tanar");
            entity.Property(e => e.Targy).HasColumnName("targy");
            entity.Property(e => e.Terem).HasColumnName("terem");

            entity.HasOne(d => d.NapNavigation).WithMany(p => p.Orak)
                .HasForeignKey(d => d.Nap)
                .HasConstraintName("FK_Orak_Napok");

            entity.HasOne(d => d.SavNavigation).WithMany(p => p.Orak)
                .HasForeignKey(d => d.Sav)
                .HasConstraintName("FK_Orak_Savok");

            entity.HasOne(d => d.TanarNavigation).WithMany(p => p.Orak)
                .HasForeignKey(d => d.Tanar)
                .HasConstraintName("FK_Orak_Oktatok");

            entity.HasOne(d => d.TargyNavigation).WithMany(p => p.Orak)
                .HasForeignKey(d => d.Targy)
                .HasConstraintName("FK_Orak_Tantárgyak");

            entity.HasOne(d => d.TeremNavigation).WithMany(p => p.Orak)
                .HasForeignKey(d => d.Terem)
                .HasConstraintName("FK_Orak_Termek");
        });

        modelBuilder.Entity<Savok>(entity =>
        {
            entity.HasKey(e => e.SavId);

            entity.Property(e => e.SavId)
                .ValueGeneratedNever()
                .HasColumnName("Sav_id");
            entity.Property(e => e.Időpont).HasMaxLength(50);
            entity.Property(e => e.Sav).HasMaxLength(50);
        });

        modelBuilder.Entity<Statusok>(entity =>
        {
            entity.HasKey(e => e.Skod);

            entity.ToTable("statusok");

            entity.Property(e => e.Skod).ValueGeneratedNever();
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<Tantárgyak>(entity =>
        {
            entity.HasKey(e => e.Tkód);

            entity.Property(e => e.Tkód).ValueGeneratedNever();
            entity.Property(e => e.Tantargykod).HasMaxLength(50);
            entity.Property(e => e.Tantárgynév).HasMaxLength(50);
        });

        modelBuilder.Entity<Termek>(entity =>
        {
            entity.HasKey(e => e.Tkód);

            entity.Property(e => e.Tkód).ValueGeneratedNever();
            entity.Property(e => e.Terem).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
