using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TredaSolutions.Domains.Models;

namespace TredaSolutions.Domains.IServices
{
    public  interface IProductoService
    {
        public Task SaveProducto(Producto producto);
        public Task<bool> ValidateSKU(Producto producto);
    }
}
