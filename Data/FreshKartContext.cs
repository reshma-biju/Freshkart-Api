using System;
using System.Collections.Generic;
using FreshKart.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace FreshKart.Api.Data;

public partial class FreshKartContext : DbContext
{
    public FreshKartContext(DbContextOptions<FreshKartContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Login> Login { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Login__3214EC0701C7153B");

            entity.ToTable("Login");

            entity.HasIndex(e => e.Uname, "UQ__Login__9C5CAF9ACB486A4C").IsUnique();

            entity.Property(e => e.Pword)
                .HasMaxLength(45)
                .IsUnicode(false);
            entity.Property(e => e.Uname)
                .HasMaxLength(45)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Products__3214EC07E62548C7");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Pic)
                .HasMaxLength(1200)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Was).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Weight)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
