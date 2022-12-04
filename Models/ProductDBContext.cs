using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProductCRUDAPI.Models
{
    public partial class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Producto> producto { get; set; } = null!;
        public virtual DbSet<Venta> Venta { get; set; } = null!;
        public virtual DbSet<ItemVenta> objVendidos { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
