using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TredaSolutions.Domains.IRepositories;
using TredaSolutions.Domains.IServices;
using TredaSolutions.Domains.Models;

namespace TredaSolutions.Services
{
    public class ProductoService : IProductoService
    {
        public readonly IProductoRepository _productoRepository;
        public ProductoService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public async Task SaveProducto(Producto producto)
        {

            await _productoRepository.SaveProducto(producto);
        }
        public async Task<bool> ValidateSKU(Producto producto)
        {
            var validateExistence = await _productoRepository.ValidateSKU(producto);
            return validateExistence;
        }
       
    }
}
