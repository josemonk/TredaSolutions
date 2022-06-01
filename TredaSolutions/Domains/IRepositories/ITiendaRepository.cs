using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TredaSolutions.Domains.Models;

namespace TredaSolutions.Domains.IRepositories
{
    public  interface ITiendaRepository
    {
        public Task SaveTienda(Tienda tienda);
        public Task<bool> ValidateSKU(Tienda tienda);
    }
}
