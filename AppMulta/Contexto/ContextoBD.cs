using AppMulta.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AppMulta.Contexto
{
    public class ContextoBD : DbContext
    {
        public ContextoBD(DbContextOptions<ContextoBD> options) : base(options)
        {
        }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Multa> Multas { get; set; }
    }
}
