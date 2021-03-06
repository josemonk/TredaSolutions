using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TredaSolutions.Domains.Models;

namespace TredaSolutions.Domains.IServices
{
    public  interface ITiendaService
    {
        public Task SaveTienda(Tienda tienda);
        public Task<bool> ValidateName(Tienda tienda);
    }
}
