using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class VeiculoDbContext : DbContext
{
    public VeiculoDbContext(DbContextOptions<VeiculoDbContext> options) : base(options)
    {
    }

    public DbSet<Veiculo> Veiculos { get; set; }
    public DbSet<Acessorio> Acessorios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Veiculo>()
            .HasMany(v => v.Acessorios)
            .WithOne(a => a.Veiculo)
            .HasForeignKey(a => a.VeiculoId);
    }
}