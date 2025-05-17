using Microsoft.EntityFrameworkCore;
using EasyMoto.Domain.Entities;
using System.Collections.Generic;

namespace EasyMoto.Infrastructure.Context
{
    public class EasyMotoDbContext : DbContext
    {
        public EasyMotoDbContext(DbContextOptions<EasyMotoDbContext> options) : base(options) { }

        public DbSet<Filial> Filiais { get; set; }
        public DbSet<Moto> Motos { get; set; }
    }
}