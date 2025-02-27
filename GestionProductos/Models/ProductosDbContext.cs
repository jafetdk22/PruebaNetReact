using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GestionProductos.Models;

public partial class ProductosDbContext : DbContext
{
    public ProductosDbContext()
    {
    }

    public ProductosDbContext(DbContextOptions<ProductosDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.IdFactura).HasName("PK__Factura__6C08ED539760337F");

            entity.ToTable("Factura");

            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha");
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numero_factura");
            entity.Property(e => e.ProductosAdquiridos).HasColumnName("productos_adquiridos");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__Producto__FF341C0D1F5E0DF6");

            entity.ToTable("Producto");

            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codigo");
            entity.Property(e => e.Existencias).HasColumnName("existencias");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("precio");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
