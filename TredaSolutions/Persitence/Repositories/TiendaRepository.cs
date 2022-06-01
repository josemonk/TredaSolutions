using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TredaSolutions.Domains.IRepositories;
using TredaSolutions.Domains.Models;
using TredaSolutions.Persitence.Context;

namespace TredaSolutions.Persitence.Repositories
{
    public class TiendaRepository : ITiendaRepository
    {
        public readonly AplicationDbContext _context;
        public TiendaRepository( AplicationDbContext context)
        {
            _context = context;
        }
        public async Task SaveTienda(Tienda tienda)
        {
            _context.tiendas.Add(tienda);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> ValidateSKU(Tienda tienda)
        {
            var validateExistence = await _context.tiendas.AnyAsync(x => x.Nombre == tienda.Nombre);
            return validateExistence;
        }
    }
}
