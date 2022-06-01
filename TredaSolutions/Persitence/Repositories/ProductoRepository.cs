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
    public class ProductoRepository : IProductoRepository
    {
        public readonly AplicationDbContext _context;
        public ProductoRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task SaveProducto(Producto producto)
        {
            _context.productos.Add(producto);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> ValidateSKU(Producto producto)
        {
            var validateSKU = await _context.productos.AnyAsync(x => x.SKU == producto.SKU);
            return validateSKU;
        }
    }
}
