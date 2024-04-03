using AppMulta.Contexto;
using AppMulta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppMulta.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly ContextoBD _context;

        public VeiculoController(ContextoBD context)
        {
            _context = context;
        }

        public async Task<List<Veiculo>> ListaDeVeiculos()
        {
            var veiculos = await _context.Veiculos.Include(x => x.Multas).ToListAsync();
            return veiculos;
        }

        // Método para cadastrar veículos
        public async Task Add(Veiculo veiculo)
        {
            await _context.Veiculos.AddAsync(veiculo);
        }

        public async Task Salvar()
        {
            await _context.SaveChangesAsync();
        }
    }
}
